using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using Throttling;

namespace ThrottleConsoleApp
{
    class Program
    {
        private static HttpClient httpClient = new HttpClient();
        const int MAX_DOWNLOADS = 3;

        static readonly string[] s_urlList = new string[]
        {
            "https://docs.microsoft.com",
            "https://docs.microsoft.com/aspnet/core",
            "https://docs.microsoft.com/azure",
            "https://docs.microsoft.com/azure/devops",
            "https://docs.microsoft.com/dotnet",
            "https://docs.microsoft.com/dynamics365",
            "https://docs.microsoft.com/education",
            "https://docs.microsoft.com/enterprise-mobility-security",
            "https://docs.microsoft.com/gaming",
            "https://docs.microsoft.com/graph",
            "https://docs.microsoft.com/microsoft-365",
            "https://docs.microsoft.com/office",
            "https://docs.microsoft.com/powershell",
            "https://docs.microsoft.com/sql",
            "https://docs.microsoft.com/surface",
            "https://docs.microsoft.com/system-center",
            "https://docs.microsoft.com/visualstudio",
            "https://docs.microsoft.com/windows",
            "https://docs.microsoft.com/xamarin"
        };

        static async Task DownloadAsync(string[] urls)
        {
            using (var semaphore = new SemaphoreSlim(MAX_DOWNLOADS))
            {
                using (var httpClient = new HttpClient())
                {
                    var tasks = urls.Select(async url =>
                    {
                        await semaphore.WaitAsync();
                        try
                        {
                            var data = await httpClient.GetStringAsync(url);
                            Console.WriteLine(data);
                        }
                        finally
                        {
                            semaphore.Release();
                        }
                    });

                    await Task.WhenAll(tasks);
                }
            }
        }

        static async Task Main(string[] args)
        {


            var client = new RestClient("https://oicazultst-idlwl4w62p2k-ia.integration.ocp.oraclecloud.com:443/ic/api/integration/v1/flows/rest/INT061_CRIANF_CONTAS_PAGAR/1.0/INT061_Criar");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic T0lDX0RFVl9TRVJWSUNFX1VTRVJfQkFTSUNBVVRIOjA1MzE3NmZhLTAzOWEtNDNjZC1iMjZmLTYxNDZhNjFiMmE4OQ==");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{​​​​​\r\n \"DocumentType\": \"ORA_BR_CNPJ\",\r\n \"DocumentNumber\": \"03746938000143\",\r\n \"InvoiceNumber\": \"25020962\",\r\n \"InvoiceAmount\": 156.88,\r\n \"InvoiceDate\": \"2021-02-25\",\r\n \"BusinessUnit\": \"AZUL LINHAS AEREAS\",\r\n \"Description\": \"GERAR GUIA GRU\",\r\n \"InvoiceSource\": \"GRU\",\r\n \"PayGroup\": \"BOLETO\",\r\n \"invoiceDff\": [\r\n {​​​​​\r\n \"__FLEX_Context\": \"LACLS_BR_TAX_PAY_BARCODE\",\r\n \"__FLEX_Context_DisplayValue\": \"LACLS Impostos do Brasil com CÃ³digo de Barras\",\r\n \"laclsBrInputMethodBcode\": \"MANUAL\",\r\n \"laclsBrBarcodeNum\": \"899200000012568800010109955231622087012599214280\"\r\n }​​​​​\r\n ],\r\n \"invoiceInstallments\": [\r\n {​​​​​\r\n \"InstallmentNumber\": 1,\r\n \"DueDate\": \"2021-02-25\",\r\n \"GrossAmount\": 156.88\r\n }​​​​​\r\n ],\r\n \"invoiceLines\": [\r\n {​​​​​\r\n \"LineNumber\": 1,\r\n \"LineAmount\": 156.88,\r\n \"LineType\": \"Item\",\r\n \"Description\": \"GERAR GUIA GRU\",\r\n \"DistributionCombination\": \"01.000.1105.52103008.0.00.00000.00000\"\r\n }​​​​​\r\n ]\r\n}​​​​​", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            //using (var semaphore = new SemaphoreSlim(MAX_DOWNLOADS))
            //using (var httpClient = new HttpClient())
            //{
            //    var tasks = s_urlList.Select(async url =>
            //    {
            //        await semaphore.WaitAsync();
            //        try
            //        {
            //            var data = await httpClient.GetStringAsync(url);
            //            Console.WriteLine(data);
            //        }
            //        finally
            //        {
            //            semaphore.Release();
            //        }
            //    });

            //    await Task.WhenAll(tasks);
            //}

            //var taskLimit = 3;
            //var limitingPeriodInMilliseconds = 30000;
            //Throttled throttled = new Throttled(taskLimit, limitingPeriodInMilliseconds);
            //await throttled.Run(async () => {
            //    for (var i = 0; i < 30; i++)
            //    {
            //        var result = await ExecuteRequest();
            //        Console.WriteLine(i.ToString());
            //        Console.WriteLine(result.Content.ReadAsStringAsync().Result);

            //    }


            //    return Task.CompletedTask;
            //});
        }

        private static async void teste()
        {
            var tasks = new List<Task>();

            // here we set the max allowed concurrent requests, in our case it is 50
            // definimos o máximo de solicitações simultâneas permitidas, no nosso caso é 50
            var throttler = new SemaphoreSlim(3);

            List<int> list = new List<int>();


            // Let's say that we have 12 requests in total that we want to send
            for (var i = 0; i < 10; i++)
            {
                // let's wait here until we can pass from the Semaphore
                await throttler.WaitAsync();

                // add our task logig here
                tasks.Add(Task.Run(async () =>
                {
                    try
                    {
                        //Método de envio 
                        var result = await ExecuteRequest();

                        if (i == 3)
                        {
                            Console.WriteLine("Passou aqui!");
                        }

                        Console.WriteLine(i.ToString());
                        Console.WriteLine($"{i.ToString()} {result.Content.ReadAsStringAsync().Result}");

                        // let's wait here for 1 second to honor the API's rate limit                         
                        await Task.Delay(100000);
                    }
                    finally
                    {
                        // here we release the throttler immediately
                        throttler.Release();
                    }
                }));
            }

            // await for all the tasks to complete
            await Task.WhenAll(tasks.ToArray());
        }

        private static async Task<HttpResponseMessage> ExecuteRequest()
        {
            try
            {
                //var result = await httpClient.GetAsync("https://viacep.com.br/ws/09310520/json/");
                var result = await httpClient.GetAsync("https://localhost:5001/api/cep");
                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        private static async void teste2()
        {
            try
            {
               
            }
            catch (Exception ex)
            {

                throw;
            }
          
        }

    }
}