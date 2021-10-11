using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static readonly HttpClient _Client = new HttpClient { BaseAddress = new Uri("https://viacep.com.br/ws/") };

        static void Main(string[] args)
        {

            var cities = new Dictionary<string, string>(){
    {"UK", "London, Manchester, Birmingham"},
    {"USA", "Chicago, New York, Washington"},
    {"India", "Mumbai, New Delhi, Pune"}
};

       
            CepRequest cepRequest = new CepRequest();

            cepRequest.Cep = "09310520";
            cepRequest.Tipo = TipoRetorno.xml;

            Console.WriteLine("Entre com o Cep sem o '-'. E pressione /enter");
            Console.WriteLine();
            cepRequest.Cep = Console.ReadLine();

         
            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
            ObterEnderecoPorCepAsync(cepRequest);



            // Console.WriteLine("Hello World!");
        }

         static void ObterEnderecoPorCepAsync(CepRequest cepRequest)
        {
            ConsultaResponse oCep = new ConsultaResponse();
            oCep.ConsultaCep = new CepResponse();
            try
            {
                string _uri = string.Format("{0}/{1}", cepRequest.Cep, cepRequest.Tipo);
                var response =   _Client.GetAsync(_uri).Result;

                var teste = response.Content;

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(teste.ReadAsStringAsync().Result);
                
                var teste1 =  doc.GetElementsByTagName("xmlcep");

                var xmlTeste = teste1[0].OuterXml;

                //using (TextReader sr = new StringReader(teste1[0].OuterXml))
                //{
                //    var serializer = new System.Xml.Serialization.XmlSerializer(typeof(CepResponse));
                //    CepResponse response1 = (CepResponse)serializer.Deserialize(sr);
                //    Console.WriteLine(response1.Cep);
                //    Console.ReadKey();
                //}

                XmlSerializer serializer = new XmlSerializer(oCep.ConsultaCep.GetType());
                TextReader sr = new StringReader(xmlTeste);
                oCep.ConsultaCep = (CepResponse)serializer.Deserialize(sr);
                sr.Close();

                Console.WriteLine("Consulta ViaCep retorno XML");
                Console.WriteLine();
                Console.WriteLine("CEP: " + oCep.ConsultaCep.Cep);
                Console.WriteLine("Rua: " + oCep.ConsultaCep.Logradouro);
                Console.WriteLine("Bairro: " + oCep.ConsultaCep.Bairro);
                Console.WriteLine("Cidade: " + oCep.ConsultaCep.Localidade);
                Console.WriteLine("Estado: "+ oCep.ConsultaCep.Uf);

                Console.ReadKey();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

          
        }
    }
}
