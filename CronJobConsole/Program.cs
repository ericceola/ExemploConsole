using System;
using System.Threading;

namespace CronJobConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           

            while (true)
            {
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()} - Processado ");
                Thread.Sleep(10000);
            }
        }
    }
}
