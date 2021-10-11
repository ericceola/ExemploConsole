using System;
using System.IO;
using LinqToExcel;
using System.Linq;
using System.Text;
using System.Reflection;
using ExcelDataReader;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using ClosedXML.Excel;
using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text.Json;

namespace PArserExcelConsole
{
    class Program
    {
        private const string folderDefault = @"\Temp\analise.xlsx";

        public static IConfigurationRoot configuration;
        public static AppSettings appsetting;


        static void Main(string[] args)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            CultureInfo ci = new CultureInfo("pt-br");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

     
            Console.WriteLine("INÍCIO da Leitura do XLS!");


         //  DateTime dataFechamentoContabilidade = DateTime.Now;
//Console.WriteLine(dataFechamentoContabilidade.ToString("MM/yyyy").ToUpper());


           BuscarArquivos();

            //string testeZero = "000000000123456000009-10111213";

           // Console.WriteLine(testeZero.TrimStart('0'));

            Console.WriteLine("FIM da Leitura do XLS!");

            Console.ReadKey();
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {


            serviceCollection.AddLogging();

            // Build configuration
            configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
            .AddJsonFile("appSettings.json", false)
            .Build();


            serviceCollection.AddSingleton<IConfigurationRoot>(configuration);

            appsetting = configuration.Get<AppSettings>();

        }

        public static void BuscarArquivos()
        {

            string[] filePaths = Directory.GetFiles(@"c:\ArquivosProcessar\", "*.xlsx");

            foreach (string fileName in filePaths)
            {
                var nomeArquivo = Path.GetFileName(fileName);
                byte[] imageByteArray = File.ReadAllBytes(fileName);

                Stream stream = new MemoryStream(imageByteArray);

               var lista = XlsReader(stream);
                ParserExcelToXml(lista);

               
            }
        }


        public static void ConvertFile(byte[] input)
        {
            string outFile = string.Empty;
            string pathTemp = $"{Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)}" + folderDefault;

            Console.WriteLine(pathTemp);

            File.WriteAllBytes(pathTemp, input);

            ParserExcel(pathTemp);
        }

        public static List<SpreadSheet> XlsReader(Stream stream)
        {

            using (XLWorkbook workBook = new XLWorkbook(stream))
            {

                IXLWorksheet workSheet = workBook.Worksheet(1);
                DataTable dt = new DataTable();

                bool firstRow = true;
                foreach (IXLRow row in workSheet.Rows())
                {

                    if (firstRow)
                    {
                        foreach (IXLCell cell in row.Cells())
                        {
                            dt.Columns.Add(cell.Value.ToString());
                        }
                        firstRow = false;
                    }
                    else
                    {
                        dt.Rows.Add();
                        int i = 0;
                        foreach (IXLCell cell in row.Cells(false))
                        { 
                            dt.Rows[dt.Rows.Count - 1][i] = cell.Value;
                            i++;
                        }
                    }
                }

                
                var teste =  $"{appsetting.InvoiceParameters.NumeroControle}";

                var listSpreadSheet = (from rw in dt.AsEnumerable()
                                     select new SpreadSheet()
                                     {
                                         CodEmpresa = Convert.ToString(rw[appsetting.InvoiceParameters.CodEmpresa]),
                                         CodEstabelecimento = Convert.ToString(rw[appsetting.InvoiceParameters.CodEstabelecimento]),
                                         CnpjContribuinte = Convert.ToString(rw[appsetting.InvoiceParameters.CnpjContribuinte]),
                                         Periodo = Convert.ToString(rw[appsetting.InvoiceParameters.Periodo]),
                                         NDocumento = Convert.ToString(rw[appsetting.InvoiceParameters.NDocumento]),
                                         Serie = Convert.ToString(rw[appsetting.InvoiceParameters.Serie]),
                                         ChaveDFe = Convert.ToString(rw[appsetting.InvoiceParameters.ChaveDFe]),
                                         TipoDocumento = Convert.ToString(rw[appsetting.InvoiceParameters.TipoDocumento]),
                                         CodigoReceita = Convert.ToString(rw[appsetting.InvoiceParameters.CodigoReceita]),
                                         DescricaoReceita = Convert.ToString(rw[appsetting.InvoiceParameters.DescricaoReceita]),
                                         TipoTributo = Convert.ToString(rw[appsetting.InvoiceParameters.TipoTributo]),
                                         CnpjFavorecido = Convert.ToString(rw[appsetting.InvoiceParameters.CnpjFavorecido]),
                                         UfFavorecida = Convert.ToString(rw[appsetting.InvoiceParameters.UfFavorecida]),
                                         DetalheReceita = Convert.ToString(rw[appsetting.InvoiceParameters.DetalheReceita]),
                                         Convenio = Convert.ToString(rw[appsetting.InvoiceParameters.Convenio]),
                                         Produto = Convert.ToString(rw[appsetting.InvoiceParameters.Produto]),
                                         ValorPrincipal = Convert.ToString(rw[appsetting.InvoiceParameters.ValorPrincipal]),
                                         ValorJuros = Convert.ToString(rw[appsetting.InvoiceParameters.ValorJuros]),
                                         ValorMulta = Convert.ToString(rw[appsetting.InvoiceParameters.ValorMulta]),
                                         ValorAtualizacao = Convert.ToString(rw[appsetting.InvoiceParameters.ValorAtualizacao]),
                                         ValorOutros = Convert.ToString(rw[appsetting.InvoiceParameters.ValorOutros]),
                                         ValorTotal = Convert.ToString(rw[appsetting.InvoiceParameters.ValorTotal]),
                                         NumeroControle = Convert.ToString(rw[appsetting.InvoiceParameters.NumeroControle]),
                                         CodigoBarra = Convert.ToString(rw[appsetting.InvoiceParameters.CodigoBarra]),
                                         DataVencimento = Convert.ToString(rw[appsetting.InvoiceParameters.DataVencimento]),
                                         Pagador = Convert.ToString(rw[appsetting.InvoiceParameters.Pagador]),
                                         Status = Convert.ToString(rw[appsetting.InvoiceParameters.Status])


                                     }).ToList();


                foreach (var linha in listSpreadSheet)
                {
                    Console.WriteLine($"{linha.ToString()}");
                }

                return listSpreadSheet;
            }

        }



        public static void ParserExcel(string fileExcel)
        {
            var excel = new ExcelQueryFactory(fileExcel);

            var oldCompanies = (from c in excel.Worksheet<SpreadSheet>(0)
                                select c).ToList();
        }



        public static void ParserExcelToXml(List<SpreadSheet> listInvoice)
        {
            List<InvoiceRequest> listInvoiceRequest = new List<InvoiceRequest>();

            foreach (var invoice in listInvoice)
            {
                InvoiceRequest invoiceRequest = new InvoiceRequest();

                invoiceRequest.DocumentType = invoice.UfFavorecida;  // •	Configuração de Fornecedor
                invoiceRequest.DocumentNumber = invoice.UfFavorecida;  // •	Configuração de Fornecedor
                
                //Verificando o número do controle vir vazio o que fazer
                if (string.IsNullOrEmpty(invoice.NumeroControle))
                {
                   invoiceRequest.InvoiceNumber = $"{invoice.TipoDocumento}_{invoice.UfFavorecida}_0";
                }
                else
                {
                    invoiceRequest.InvoiceNumber = $"{invoice.TipoDocumento}_{invoice.UfFavorecida}_{invoice.NumeroControle.TrimStart('0')}";
                }

                invoiceRequest.InvoiceAmount = invoice.ValorTotal;
                invoiceRequest.InvoiceDate = DateTime.Now.ToString("yyyy-MM-dd"); 
                invoiceRequest.BusinessUnit = appsetting.InvoiceParameters.CustomInvoiceParameters.BusinessUnit;
                invoiceRequest.Description = $"{appsetting.InvoiceParameters.CustomInvoiceParameters.Description} {Convert.ToDateTime(invoice.Periodo).ToString("MMMM yyyy").ToUpper()}";
                invoiceRequest.InvoiceSource = invoice.TipoDocumento;
                invoiceRequest.PayGroup = appsetting.InvoiceParameters.CustomInvoiceParameters.PayGroup;

                invoiceRequest.InvoiceDff = new List<InvoiceDffRequest>()
                {
                    new InvoiceDffRequest()
                    {
                        __FLEX_Context = appsetting.InvoiceParameters.CustomInvoiceParameters.FlexContext,
                        __FLEX_Context_DisplayValue = appsetting.InvoiceParameters.CustomInvoiceParameters.FlexContextDisplayValue,
                        laclsBrInputMethodBcode = appsetting.InvoiceParameters.CustomInvoiceParameters.LaclsBrInputMethodBcode,
                        laclsBrBarcodeNum =  invoice.CodigoBarra
                    }
                };

                invoiceRequest.InvoiceInstallments = new List<InvoiceInstallmentRequest>()
                {
                    new InvoiceInstallmentRequest()
                    {
                        InstallmentNumber =  "1",
                        DueDate = Convert.ToDateTime(invoice.DataVencimento).ToString("yyyy-MM-dd"),
                        GrossAmount = invoice.ValorTotal
                    }
                };

                invoiceRequest.InvoiceLines = new List<InvoiceLineRequest>()
                {
                    new InvoiceLineRequest()
                    {
                        LineNumber = "1",
                        LineAmount = invoice.ValorTotal,
                        LineType = appsetting.InvoiceParameters.CustomInvoiceParameters.LineType,
                        Description = $"REF: {invoice.NumeroControle} COMP: {Convert.ToDateTime(invoice.Periodo).ToString("MM/yyyy")} CNPJ: {invoice.CnpjContribuinte}" ,
                        DistributionCombination = "01.001.0000.21401021.0.00.00000.00000"// PARAMETRO COMBINACAO CONTABIL
                    }
                };

                listInvoiceRequest.Add(invoiceRequest);
            }

             foreach(var invoiceXml in listInvoiceRequest)
            {
                string jsonString = JsonSerializer.Serialize(invoiceXml);

                Root oRoot = new Root();
                oRoot.Request = jsonString; 

                var xml = SerializeToXml(oRoot);
                Console.Write(xml);

            }

          
        }

        public static string SerializeToXml(Root input)
        {
            XmlSerializer ser = new XmlSerializer(input.GetType(), "http://schemas.yournamespace.com");
            string result = string.Empty;

            using (MemoryStream memStm = new MemoryStream())
            {
                ser.Serialize(memStm, input);

                memStm.Position = 0;
                result = new StreamReader(memStm).ReadToEnd();
            }

            return result;
        }
    }
}
