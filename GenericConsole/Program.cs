using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using RestSharp;

namespace GenericConsole
{
    class  Program
    {
        static async Task Main(string[] args)
        {

            var formato = "dd/MM/yyyy HH:mm:ss";
            string testeData = "01/31/2021";

            DateTime dataNova;
            var teste = DateTime.TryParse(testeData, out dataNova);
          
            Console.WriteLine(CultureInfo.CurrentCulture);


            testeData.Replace("00:00:00", "").Trim();
         // DateTime dataConvert = DateTime.Parse(testeData);


       //  var parsed = DateTime.ParseExact(string.Format("{0:MM/dd/yyyy}", testeData), "dd/MM/yyyy", CultureInfo.CurrentCulture);
        //    var formatted = parsed.ToString("MMMM yyyy");



          //  Console.WriteLine(formatted);
            Console.ReadKey();
        }


        public static async Task parameters()
        {
            string Parameters = "{\"parameters\": [ {\"name\": \"company\", \"value\": \"AZUL VIAGENS\"},"
               + "{\"name\": \"segment\", \"value\": \"54\"},{ \"name\": \"ledgerId\",\"value\": \"1001\"}]}";

            string Companies = "{\"settingsCompany\":[{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295008063\",\"uf\":\"AC\",\"nameState\":\"Secretaria de Estado da Fazenda do Acre\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295002960\",\"uf\":\"AL\",\"nameState\":\"Secretaria da Fazenda do Estado de Alagoas\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295002456\",\"uf\":\"AM\",\"nameState\":\"Secretaria da Fazenda do Estado do Amazonas\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295010475\",\"uf\":\"AP\",\"nameState\":\"Secretaria da Fazenda do Estado do Amapá\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295000755\",\"uf\":\"BA\",\"nameState\":\"Secretaria da Fazenda do Estado da Bahia\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295001808\",\"uf\":\"CE\",\"nameState\":\"Secretaria da Fazenda do Estado do Ceará\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295001484\",\"uf\":\"DF\",\"nameState\":\"Secretaria de Estado de Fazenda do Distrito Federal\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295001131\",\"uf\":\"ES\",\"nameState\":\"Secretaria da Fazenda do Estado do Espírito Santo\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295001050\",\"uf\":\"GO\",\"nameState\":\"Secretaria da Fazenda do Estado de Goiás\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295004580\",\"uf\":\"MA\",\"nameState\":\"Secretaria de Estado da Fazenda do Maranhão\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295001301\",\"uf\":\"MG\",\"nameState\":\"Secretaria da Fazenda do Estado de Minas Gerais\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295001727\",\"uf\":\"MS\",\"nameState\":\"Secretaria de Estado de Fazenda do Mato Grosso do Sul\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295002707\",\"uf\":\"MT\",\"nameState\":\"Secretaria da Fazenda do Estado do Mato Grosso\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295003509\",\"uf\":\"PA\",\"nameState\":\"Secretaria da Fazenda do Estado do Pará\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295004157\",\"uf\":\"PB\",\"nameState\":\"Secretaria de Estado da Receita do Estado da Paraíba\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295001212\",\"uf\":\"PE\",\"nameState\":\"Secretaria da Fazenda do Estado de Pernambuco\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295004408\",\"uf\":\"PI\",\"nameState\":\"Secretaria da Fazenda do Estado do Piauí\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295000402\",\"uf\":\"PR\",\"nameState\":\"Secretaria da Fazenda do Estado do Paraná\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295000321\",\"uf\":\"RJ\",\"nameState\":\"Secretaria de Fazenda do Estado do Rio de Janeiro\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295003002\",\"uf\":\"RN\",\"nameState\":\"Secretaria da Tributação do Estado do Rio Grande do Norte\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295009388\",\"uf\":\"RR\",\"nameState\":\"Secretaria da Fazenda do Estado de Roraima\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295000593\",\"uf\":\"RS\",\"nameState\":\"Secretaria da Fazenda do Estado do Rio Grande do Sul\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295001646\",\"uf\":\"SC\",\"nameState\":\"Secretaria da Fazenda do Estado de Santa Catarina\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295001565\",\"uf\":\"SE\",\"nameState\":\"Secretaria da Fazenda do Estado de Sergipe\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295000160\",\"uf\":\"SP\",\"nameState\":\"Secretaria da Fazenda do Estado de São Paulo\"},{\"typeDocument\":\"ORA_BR_CNPJ\",\"numberDoc\":\"09296295004904\",\"uf\":\"TO\",\"nameState\":\"Secretaria da Fazenda do Estado de Tocantins\"}]}";

            string CompaniesStep = Companies.Replace(@"\", " ");
            Console.Write(CompaniesStep);

            var filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\PastaTeste\\ArquivoTeste.txt";
            //parser();
            string test = "{\"DocumentType\":\"ORA_BR_CNPJ\",\"DocumentNumber\":\"03746938000143\",\"InvoiceNumber\":\"25020956\",\"InvoiceAmount\":156.88,\"InvoiceDate\":\"2021-02-25\",\"BusinessUnit\":\"AZUL LINHAS AEREAS\",\"Description\":\"GERAR GUIA GRU\",\"InvoiceSource\":\"GRU\",\"PayGroup\":\"BOLETO\",\"invoiceDff\":[{\"__FLEX_Context\":\"LACLS_BR_TAX_PAY_BARCODE\",\"__FLEX_Context_DisplayValue\":\"LACLS Impostos do Brasil com Codigo de Barras\",\"laclsBrInputMethodBcode\":\"MANUAL\",\"laclsBrBarcodeNum\":\"899200000012568800010109955231622087012599214280\"}],\"invoiceInstallments\":[{\"InstallmentNumber\":1,\"DueDate\":\"2021-02-25\",\"GrossAmount\":156.88}],\"invoiceLines\":[{\"LineNumber\":1,\"LineAmount\":156.88,\"LineType\":\"Item\",\"Description\":\"GERAR GUIA GRU\",\"DistributionCombination\":\"01.000.1105.52103008.0.00.00000.00000\"}]}";


            var client = new RestClient("https://oicazultst-idlwl4w62p2k-ia.integration.ocp.oraclecloud.com:443/ic/api/integration/v1/flows/rest/INT061_CRIANF_CONTAS_PAGAR/1.0/INT061_Criar");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic T0lDX0RFVl9TRVJWSUNFX1VTRVJfQkFTSUNBVVRIOjA1MzE3NmZhLTAzOWEtNDNjZC1iMjZmLTYxNDZhNjFiMmE4OQ==");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", test, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        public static void parser()
        {
            var client = new RestClient("http://localhost:5000/api/ParserProcess");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddFile("processFiles", @"C:/ArquivosProcessar/CTB_AD_9999995_AX_TCPR_2021020220322647 - JULIANA.txt");
            request.AddParameter(@"Parameters", "{\"parameters\": [ { \"name\": \"Legder\","
             + "\"value\": { \"company\": \"AZUL VIAGENS\",\"segment\": \"54\",\"ledgerId\": \"1001\"}}]}");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            Console.ReadKey();
        }

    }
}
