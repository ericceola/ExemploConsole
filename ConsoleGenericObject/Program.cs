using System;
using System.Collections.Generic;
using RestSharp;
using System.Text.Json;
using System.Text;
using System.Threading;
using JetBrains.Annotations;
using Azure.Messaging.ServiceBus;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ConsoleGenericObject
{
    class Program
    {
      
        static void Main()
        {
            Console.WriteLine("AppData Query inizialida.");
            Console.WriteLine();
             Menu();

        }

        static void Menu()
        {
           
            Console.WriteLine("********************************************************");
            Console.WriteLine();
            Console.WriteLine("Escolha a opção:");
            Console.WriteLine();
            Console.WriteLine("1 - Departament");
            Console.WriteLine("2 - Job");
            Console.WriteLine("3 - Location");
            Console.WriteLine();
            Console.WriteLine("********************************************************");
            Console.WriteLine();
            Console.Write("Digite uma opção:");

            var selectOpton = Console.ReadLine();
            int queryId = 0;
            switch (selectOpton)
            {
                case "1":
                    queryId = 17749;
                    SubMenu(queryId, "departament");
                    break;
                case "2":
                    queryId = 17750;
                    SubMenu(queryId, "job");
                    break;
                case "3":
                    queryId = 17751;
                    SubMenu(queryId, "location");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Escolha a opção válida");
                    Menu();
                    break;
            }

        }


        static void SubMenu(int queryId, string topicName)
        {
            Console.Clear();
            Console.WriteLine("********************************************************");
            Console.WriteLine();
            Console.WriteLine("Escolha a opção de visualização:");
            Console.WriteLine();
            Console.WriteLine("1 - Text");
            Console.WriteLine("2 - Json");
            Console.WriteLine();
            Console.WriteLine("********************************************************");
            Console.WriteLine();
            Console.Write("Digite uma opção:");
            Console.WriteLine();
            var selectOpton = Console.ReadLine();
            int option = 0;

            switch (selectOpton)
            {
                case "1":
                    option = 1;
                    Display(queryId, option, topicName);
                    break;
                case "2":
                    option = 2;
                    Display(queryId, option, topicName);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Escolha a opção válida");
                    SubMenu(queryId, topicName);
                    break;
            }
        }
        static void ShowSpinner()
        {
            var counter = 0;
            Console.Write("Carregando: ");
            for (int i = 0; i < 50; i++)
            {
                switch (counter % 4)
                {
                    case 0: Console.Write("*"); break;
                    case 1: Console.Write("**"); break;
                    case 2: Console.Write("***"); break;
                    case 3: Console.Write("****"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                counter++;
                Thread.Sleep(100);
            }
        }
        static ApDataResponse ApDataApi(int queryId)
        {
            ApDataResponse apDataResponse = new ApDataResponse();

            try
            {
                var client = new RestClient("http://10.0.10.178:7082/REST/API.APDATA.V1/QUERYS");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");

                ApDataRequest apDataRequest = new ApDataRequest();
                apDataRequest.userName = "APDXHCM";
                apDataRequest.pass = "APDXHCM";
                apDataRequest.queryId = queryId;
                apDataRequest.languageId = 0;
                apDataRequest.items = new List<Item>(){new Item()
            {
                paramName = "pagina",
                value = "0"
            } };


                var body = JsonSerializer.Serialize(apDataRequest);
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                var response = client.Execute(request);

                apDataResponse = JsonSerializer.Deserialize<ApDataResponse>(response.Content);
              
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("********************************************************");
                Console.WriteLine();
                Console.WriteLine("SEM CONEXÃO COM OIC - VERIFIQUE A INTERNET OU VPN ONLINE DC.");
                Console.WriteLine();
                Console.WriteLine("********************************************************");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para sair.");
                Console.ReadKey();
                System.Environment.Exit(500);
            }

            return apDataResponse;
           

        }
        static void Display(int queryId, int displayOption, string topicName)
        {
            Console.Clear();
            ShowSpinner();
            var response = ApDataApi(queryId);

            switch (displayOption)
            {
                case 1:
                    DisplayText(response);
                    break;
                case 2:
                    DisplayJson(response, topicName);
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Pressione R para Reiniciar ou qualquer outra tecla para sair:");

            string restart = Console.ReadLine();
            if (restart.ToUpper() == "R")
            {
                Console.Clear();
                Main();
            }
        }
        static void DisplayText(ApDataResponse apDataResponse)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("********************************************************");
            Console.WriteLine();
            if (apDataResponse.message.values.Count > 0)
            {
                foreach (var value in apDataResponse.message.values)
                {
                    int index = 0;
                    Console.WriteLine($"Register Number: {value.recNo}");
                    Console.WriteLine();
                    foreach (var record in value.record)
                    {
                        string linha = $"{apDataResponse.message.fields[index].fieldName}: {record.value}";
                        Console.WriteLine(linha);
                        index++;
                    }
                    Console.WriteLine();
                    Console.WriteLine("********************************************************");
                }
            }
        }
        static void DisplayJson(ApDataResponse apDataResponse, string topicName)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("********************************************************");
            Console.WriteLine();
            if (apDataResponse.message.values.Count > 0)
            {
                foreach (var value in apDataResponse.message.values)
                {
                    int index = 0;
                    Console.WriteLine($"Register Number: {value.recNo}");
                    Console.WriteLine();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("{");
                    foreach (var record in value.record)
                    {
                        string linha = string.Empty;
                        if (index + 1 != value.record.Count)
                        {
                           linha = $"\"{apDataResponse.message.fields[index].fieldName.FirstCharToLowerCase()}\": \"{record.value}\",";
                        }
                        else
                        {
                            linha = $"\"{apDataResponse.message.fields[index].fieldName}\": \"{record.value}\"";
                        }
                        sb.Append(linha);
                        index++;
                    }
                    sb.Append("}");
                    sb.AppendLine();
                    JObject jsonTopicMessage = JObject.Parse(sb.ToString());
                     SendMessageToTopicAsync(jsonTopicMessage, topicName);
                    Console.WriteLine(jsonTopicMessage.ToString());
                    Console.WriteLine();
                    Console.WriteLine("********************************************************");

                }
            }
        }

        static async Task SendMessageToTopicAsync(JObject jsonTopicMessage, string topicName)
        {
            string connectionString = string.Empty;
             string topic =string.Empty;

            switch(topicName)
            {
                case "departament":
                     connectionString = "Endpoint=sb://isabko.servicebus.windows.net/;SharedAccessKeyName=bko.humanresources.department.skn;SharedAccessKey=llHM0aQsnVAeUdkRimumqpNBy00IDlux8EZyemGpMHI=;EntityPath=bko.humanresources.department";
                     topic = "bko.humanresources.department";
                    break;
                case "job":
                    connectionString = "Endpoint=sb://isabko.servicebus.windows.net/;SharedAccessKeyName=bko.humanresources.job.skn;SharedAccessKey=1WqRKnZgGy/YCYoChuGjSJm6+l5iaHr9ptx6NkbSZCE=;EntityPath=bko.humanresources.job";
                    topic = "bko.humanresources.job";
                    break;
                case "location":
                    connectionString = "Endpoint=sb://isabko.servicebus.windows.net/;SharedAccessKeyName=bko.humanresources.location.skn;SharedAccessKey=zFKbgZV2vzps8/eEvB0OF25/b2wfNwcXaDXod2c01QA=;EntityPath=bko.humanresources.location";
                    topic = "bko.humanresources.location";
                    break;

            }
            // create a Service Bus client 
            try
            {
                await using (ServiceBusClient client = new ServiceBusClient(connectionString))
                {
                    // create a sender for the topic
                    ServiceBusSender sender = client.CreateSender(topic);
                    await sender.SendMessageAsync(new ServiceBusMessage(jsonTopicMessage.ToString()));
                   // Console.WriteLine($"Sent a single message to the topic: {topic}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Mensagem de rro: {ex.Message}");
                Console.ReadKey();
            }
        }
    }

    public static class StringExtensions
    {
        [CanBeNull]
        public static string FirstCharToLowerCase([CanBeNull] this string str)
        {
            if (string.IsNullOrEmpty(str) || char.IsLower(str[0]))
                return str;

            return char.ToLower(str[0]) + str.Substring(1);
        }
    }


}
