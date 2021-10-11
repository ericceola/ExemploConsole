using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ThrottlingConsole
{
    class Program
    {
        const int MAX_DOWNLOADS = 1;
        const int MAX_PROCESSORS = 1;
        static  string[] lisCep = new string[]
       {
           "09030000",
           "09310520",
           "09020000",
           "09030000",
           "09310520",
           "09020000",
           "09030000",
           "09310520",
           "09020000",
           "09030000",
           "09310520",
           "09020000",
           "09030000",
           "09310520",
           "09020000"
       };

        // process data
        class Processing
        {
            SemaphoreSlim _semaphore = new SemaphoreSlim(MAX_PROCESSORS);
            HashSet<Task> _pending = new HashSet<Task>();
            object _lock = new Object();

            async Task ProcessAsync(string data)
            {
                int i = 0;
                await _semaphore.WaitAsync();
                try
                {
                    await Task.Run(() =>
                    {
                        // simuate work
                      //  Thread.Sleep(5000);
                       // Console.WriteLine($"{++i} {data}");
                    });
                }
                finally
                {
                    _semaphore.Release();
                }
            }

            public async void QueueItemAsync(string data)
            {
                var task = ProcessAsync(data);
                lock (_lock)
                    _pending.Add(task);
                try
                {
                    await task;
                }
                catch
                {
                    if (!task.IsCanceled && !task.IsFaulted)
                        throw; // not the task's exception, rethrow
                               // don't remove faulted/cancelled tasks from the list
                    return;
                }
                // remove successfully completed tasks from the list 
                lock (_lock)
                    _pending.Remove(task);
            }

            public async Task WaitForCompleteAsync()
            {
                Task[] tasks;
                lock (_lock)
                    tasks = _pending.ToArray();
                await Task.WhenAll(tasks);
            }
        }

        // download data
        static async Task DownloadAsync(string[] ceps)
        {
            var processing = new Processing();

            using (var semaphore = new SemaphoreSlim(MAX_DOWNLOADS))
            using (var httpClient = new HttpClient())
            {
                int i = 0;
                var tasks = ceps.Select(async (cep) =>
                {
                    await semaphore.WaitAsync();
                    try
                    {
                        string urlComplete = string.Format("https://viacep.com.br/ws/{0}/json/", cep); 
                        var data = await httpClient.GetStringAsync(urlComplete);
                        // put the result on the processing pipeline
                         processing.QueueItemAsync(data);
                       // Console.WriteLine($"{++i} {data}"); ;
                    }
                    finally
                    {
                        semaphore.Release();
                    }
                });

                await Task.WhenAll(tasks.ToArray());
                await processing.WaitForCompleteAsync();
            }
        }


        public class Log
        {
            public string Label { get; set; }

            public string TotalErro { get; set; }

            public string TotalSucesso { get; set; }

            public List<Item> Items { get; set; }


        }

        public class Item
        {
            public string NF { get; set; }

            public string Valor { get; set; }

            public string Status { get; set; }
        }

        static async Task Main(string[] args)
        {
           await DownloadAsync(lisCep);

            Log log = new Log()
            {

                Label = "*** RESUMO DE PROCESSAMENTO  DE GUIAS  DIVERSOS *****",
                TotalErro = "18",
                TotalSucesso = "10",

                Items = new List<Item>()
                {
                    new Item()
                    {
                         NF = "576760",
                         Valor = "3500,00",
                         Status = "PROCESSADO"
                    },
                    new Item()
                    {
                         NF = "576761",
                         Valor = "2500,00",
                         Status = "PROCESSADO"
                    },

                }
               
                

            };

          

            string path = @"c:\temp\teste.txt";
          
            if (!File.Exists(path))
            {
              
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine($"{log.Label}");
                    sw.WriteLine();
                    sw.WriteLine();
                    sw.WriteLine($"Total de processados com sucesso: {log.TotalSucesso}");
                    sw.WriteLine($"Total de processados com erro: {log.TotalSucesso}");
                    sw.WriteLine();
                    sw.WriteLine();
                    sw.WriteLine("Registros.....");
                    sw.WriteLine();

                    sw.WriteLine("NF         Valor         status");
                    foreach (var oItem in log.Items)
                    {
                        sw.WriteLine($"{oItem.NF}{oItem.Valor}{oItem.Status}");
                    }
                   
                }
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
