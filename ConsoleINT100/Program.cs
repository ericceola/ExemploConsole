using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleINT100
{
    class Program
    {
        public static IConfigurationRoot configuration;
        public static AppSettings appsetting;
        static void Main(string[] args)
        {

            //  ServiceCollection serviceCollection = new ServiceCollection();
            // ConfigureServices(serviceCollection);

              var lista = ParserList();
            //DateTime dataFechamentoContabilidade = DateTime.ParseExact("20210201", "yyyyMMdd", CultureInfo.InvariantCulture);
           // Console.WriteLine(dataFechamentoContabilidade.ToString("yyyy-MM-dd"));

           // var teste = Convert.ToDateTime("20210201").ToString("YYYY-MM-DD");

           // Console.WriteLine(teste);


            Console.WriteLine("Hello World!");
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


        public static List<BaseAracFile> ParserList()
        {
            List<BaseAracFile> listReceiptRequest = new List<BaseAracFile>();
            var csv = new StringBuilder();
            int i = 0;
            string[] filePaths = Directory.GetFiles(@"c:\ArquivosProcessarReceipt\", "*.txt");

            foreach (string fileName in filePaths)
            {
                var nomeArquivo = Path.GetFileName(fileName);
                byte[] imageByteArray = File.ReadAllBytes(fileName);

                using (MemoryStream ms = new MemoryStream(imageByteArray))
                {

                    using (StreamReader reader = new StreamReader(ms))
                    {
                        string line;
                        using (MemoryStream newMs = new MemoryStream())
                        {

                            using (var writer = new StreamWriter(newMs))
                            {

                                reader.ReadLine();

                                do
                                {
                                    line = reader.ReadLine();

                                    //Until we read the last line, write out the
                                    //current line - note that blank lines count
                                    if (!reader.EndOfStream)
                                    {
                                        var ReceiptRequest = ParserLine(line);
                                        listReceiptRequest.Add(ReceiptRequest);

                                    }
                                } while (line != null);
                                                       
                                writer.Flush();
                                byte[] bytes = newMs.ToArray();
                            }
                        }
                    }

                }
            }

            return listReceiptRequest;
        }
        public static BaseAracFile ParserLine(string line)
        {
            string newLine = string.Empty;
            FileSource fileSource = new FileSource();

            #region Leitura das colunas do arquivo txt.

            fileSource.REGISTRO = line.Substring(0, 3);
            fileSource.COMPANIA = line.Substring(3, 4);
            fileSource.PAIS = line.Substring(7, 3);
            fileSource.FILIAL_CONTABLE = line.Substring(10, 4);
            fileSource.FILIAL_NUMERICA = line.Substring(14, 4);
            fileSource.CODIGO_ARACS = line.Substring(18, 8);
            fileSource.NUMERO_ARACS = line.Substring(26, 8);
            fileSource.FECHA_CONTABILIZACION = line.Substring(34, 8);
            fileSource.FECHA_VENCIMIENTO = line.Substring(42, 8);
            fileSource.MONEDA = line.Substring(50, 3);
            fileSource.IMPORTE = line.Substring(53, 15);
            fileSource.TIPO_DE_CAMBIO = line.Substring(68, 11);
            fileSource.IMPORTE_CONVERTIDO = line.Substring(79, 15);
            fileSource.INDICADOR_DC = line.Substring(94, 1);
            fileSource.CUENTA_CONTABLE = line.Substring(95, 20);
            fileSource.CENTRO_DE_COSTO = line.Substring(115, 6);
            fileSource.TIPO_DE_SERVICIO = line.Substring(121, 10);
            fileSource.ORIGEN_DESTINO = line.Substring(131, 7);
            fileSource.AERONAVE = line.Substring(138, 11);
            fileSource.NUMERO_DE_DOCUMENTO = line.Substring(149, 25);
            fileSource.CLIENTE_PROVEEDOR = line.Substring(174, 20);
            fileSource.INDICADOR_PR = line.Substring(194, 1);
            fileSource.NUMERO_LINEA = line.Substring(195, 6);
            fileSource.NOME_FORNECEDOR = line.Substring(201, 30);
            fileSource.LEGENDA_CABECALHO = line.Substring(231, 20);

            #endregion

            #region Colunas do arquivo cs
            BaseAracFile result =new BaseAracFile();
        
            string[] cuentaContablelist = { "11299004", "11299006", "11299008", "11299009", "77777777", "66666666", "88888888", "99999999" };
            int legendaCabecalho = String.IsNullOrEmpty(fileSource.LEGENDA_CABECALHO.Substring(3, 6)) ? Convert.ToInt32(fileSource.LEGENDA_CABECALHO.Substring(3, 6)) : 0;

            if (fileSource.CODIGO_ARACS.Trim() == "TCCR" && !cuentaContablelist.Contains(fileSource.CUENTA_CONTABLE.Trim()))
            {
                var fileAccountReceipt = FileAccountFactory.FileParser(FileParserType.FileAccountReceipt);
                result = fileAccountReceipt.Parser(fileSource);
            }

            #endregion

            return result;
        }

        public static void BuscarArquivos()
        {

            string[] filePaths = Directory.GetFiles(@"c:\ArquivosProcessar\", "*.txt");

            foreach (string fileName in filePaths)
            {
                var nomeArquivo = Path.GetFileName(fileName);
                byte[] imageByteArray = File.ReadAllBytes(fileName);

                var stream = new MemoryStream(imageByteArray);
               

            }



        }
    }
}
