using System;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Http.Internal;
using System.Collections.Generic;
using System.Text;
using System.IO.Compression;
using System.Linq;
using System.Globalization;

namespace ConsoleParserZip
{
    class Program
    {

        public static IConfigurationRoot configuration;
        public static AppSettings appsetting;
        static void Main(string[] args)
        {


            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            string resultado = Convert.ToString((Convert.ToDouble(200) / 100));
            string dataTeste = "02/02/2021";
            string dataTeste1 = "20201010";
            string data =  DateTime.Now.ToString("MMM-yy");

            string testeZero = "000000000123456000009-10111213";

            Console.WriteLine(testeZero.TrimStart('0'));

            //DateTime dataFechamentoContabilidade = DateTime.ParseExact(dataTeste1, "yyyyMMdd", CultureInfo.InvariantCulture);
           // Console.WriteLine(dataFechamentoContabilidade.ToString("MMM-yy"));


           // DownloadFtpDirectory();

            Console.WriteLine("Envio do arquivo zip finalizado com sucesso!");
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {


            serviceCollection.AddLogging();

            // Build configuration
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();


            serviceCollection.AddSingleton<IConfigurationRoot>(configuration);

            appsetting = configuration.Get<AppSettings>();





        }


        static void DownloadFtpDirectory()
        {
            try
            {
                List<IFormFile> listFormFile = new List<IFormFile>();
                var listaArquivos = new Dictionary<byte[], string>();
                FtpWebRequest listRequest = (FtpWebRequest)WebRequest.Create($"ftp://{appsetting.FtpSettings.Host}/Processar/");
                listRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                NetworkCredential credentials = new NetworkCredential(appsetting.FtpSettings.Username, appsetting.FtpSettings.Password);
                listRequest.Credentials = credentials;

                List<string> lines = new List<string>();

                using (FtpWebResponse listResponse = (FtpWebResponse)listRequest.GetResponse())
                using (Stream listStream = listResponse.GetResponseStream())


                using (StreamReader listReader = new StreamReader(listStream))
                {
                    while (!listReader.EndOfStream)
                    {
                        lines.Add(listReader.ReadLine());
                    }
                }
                List<byte[]> listaArquvos = new List<byte[]>();
            
                foreach (string line in lines)
                {
                    string[] tokens =
                        line.Split(new[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[8];
                    string permissions = tokens[0];
                    if (name != ".")
                        if (name != "..")
                        {

                            string fileUrl = $"ftp://{appsetting.FtpSettings.Host}/Processar/" + name;


                            FtpWebRequest downloadRequest = (FtpWebRequest)WebRequest.Create(fileUrl);
                            downloadRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                           
                            downloadRequest.Credentials = credentials;
                            byte[] b = null;
                            using (FtpWebResponse downloadResponse =
                                      (FtpWebResponse)downloadRequest.GetResponse())

                            using (Stream sourceStream = downloadResponse.GetResponseStream())
                            using (MemoryStream ms = new MemoryStream())
                            {
                                sourceStream.CopyTo(ms);
                                b = ms.ToArray();

                                string NomeSemExtensao = System.IO.Path.GetFileNameWithoutExtension(name);

                                ////Este importa //////
                                IFormFile file = new FormFile(ms, 0, ms.Length, NomeSemExtensao, name);

                                using (var ms1 = new MemoryStream())
                                {
                                    file.CopyTo(ms1);
                                    var fileBytes = ms.ToArray();

                                    listaArquvos.Add(fileBytes);
                                }
                                ////////
                            }
                        }
                }
                var listFiles = ParserCsv(listaArquvos);
                GetZipArchive(listFiles);
                // var newFile = azulCsv();
                string line1;

                foreach (var oFile in listFiles)
                {

                    using (MemoryStream memory = new MemoryStream(oFile.Key))
                    {
                        using (var reader = new StreamReader(memory))
                        {
                            while ((line1 = reader.ReadLine()) != null)
                            {
                                Console.WriteLine(line1);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static Dictionary<byte[], string> ParserCsv(List<byte[]> listFile)
        {
            Dictionary<byte[], string> listfiles = new Dictionary<byte[], string>();
            var csv = new StringBuilder();
            int i = 0;
            foreach (var oFile in listFile)
            {
                using (MemoryStream ms = new MemoryStream(oFile))
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
                                        string newLine = ParserLine(line);
                                        writer.WriteLineAsync(newLine);
                                       
                                    }
                                } while (line != null);
                                //while ((line = reader.ReadLine()) != null)
                                //{
                                  
                                //    writer.WriteLineAsync(line);
                                //   // ParserLine(line);

                                //    // csv.AppendLine(line.Trim().Substring(1, 3));
                                //}                              
                                writer.Flush();
                                byte[] bytes = newMs.ToArray();

                                listfiles.Add(bytes, string.Format("Teste_{0}", i++));
                            }
                        }
                    }

                }
            }

            return listfiles;
        }

        public static void GetZipArchive(Dictionary<byte[], string> files)
        {

            byte[] archiveFile;
            int i = 0;
            using (var archiveStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(archiveStream, ZipArchiveMode.Create, true))
                {
                    foreach (var oFile in files)
                    {
                        var zipArchiveEntry = archive.CreateEntry(string.Format("{0}.csv", oFile.Value), CompressionLevel.Fastest);

                        using var zipStream = zipArchiveEntry.Open();
                        zipStream.Write(oFile.Key, 0, oFile.Key.Length);
                    }
                }

                archiveFile = archiveStream.ToArray();

                IFormFile file = new FormFile(archiveStream, 0, archiveStream.Length, "Lote", "Lote.zip");
                UploadFileZip(file);
            }

        }

        public static void UploadFileZip(IFormFile file)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{appsetting.FtpSettings.Host}/Processado/" + string.Format("{0}", file.FileName));
                request.Credentials = new NetworkCredential(appsetting.FtpSettings.Username, appsetting.FtpSettings.Password);
                request.Method = WebRequestMethods.Ftp.UploadFile;


                using (Stream ftpStream = request.GetRequestStream())
                {
                    file.CopyToAsync(ftpStream);
                }
            }
            catch (Exception ex)
            {


                Console.WriteLine(ex.Message);
            }
        }


        public static string ParserLine(string line)
        {
            string newLine = string.Empty;
            FileSource fileSource = new FileSource();

            #region Leitura das colunas do arquivo txt.

            fileSource.TP_REGISTRO = line.Substring(1, 3);
            fileSource.COMPANIA = line.Substring(4, 4);
            fileSource.PAIS = line.Substring(8, 3);
            fileSource.FILIAL_CONTABLE = line.Substring(11, 4);
            fileSource.FILIAL_NUMERICA = line.Substring(15, 4);
            fileSource.CODIGO_ARACS = line.Substring(19, 8);
            fileSource.NUMERO_ARACS = line.Substring(27, 8);
            fileSource.FECHA_CONTABILIZACION = line.Substring(35, 8);
            fileSource.FECHA_VENCIMIENTO = line.Substring(43, 8);
            fileSource.MONEDA = line.Substring(51, 3);
            fileSource.IMPORTE = line.Substring(54, 15);
            fileSource.TIPO_DE_CAMBIO = line.Substring(69, 11);
            fileSource.IMPORTE_CONVERTIDO = line.Substring(80, 15);
            fileSource.INDICADOR_DC = line.Substring(95, 1);
            fileSource.CUENTA_CONTABLE = line.Substring(96, 20);
            fileSource.CENTRO_DE_COSTO = line.Substring(116, 6);
            fileSource.TIPO_DE_SERVICIO = line.Substring(122, 10);
            fileSource.ORIGEN_DESTINO = line.Substring(132, 7);
            fileSource.AERONAVE = line.Substring(139, 11);
            fileSource.NUMERO_DE_DOCUMENTO = line.Substring(150, 25);
            fileSource.CLIENTE_PROVEEDOR = line.Substring(175, 20);
            fileSource.INDICADOR_PR = line.Substring(195, 1);
            fileSource.NUMERO_LINEA = line.Substring(196, 6);
            fileSource.NOME_FORNECEDOR = line.Substring(202, 30);
            fileSource.LEGENDA_CABECALHO = line.Substring(232, 199);

            #endregion

            #region Colunas do arquivo cs
             string result = String.Empty;
            string[] parameters = { "REVE", "ARAC", "EXPD", "EXCS" };
          
            int legendaCabecalho = String.IsNullOrEmpty(fileSource.LEGENDA_CABECALHO.Substring(3, 6)) ? Convert.ToInt32(fileSource.LEGENDA_CABECALHO.Substring(3, 6)) : 0;
            if (parameters.Contains(fileSource.CODIGO_ARACS))
            {
               var fileAccountRevenue =  FileAccountFactory.FileParser(FileParserType.FileAccountRevenue);
                result = fileAccountRevenue.Parser(fileSource);
                
            }
            else if(fileSource.CODIGO_ARACS == "TCPR" && ((legendaCabecalho >= 201011) || (legendaCabecalho < 201011 && fileSource.AERONAVE != "DESA")))
            {

                var fileAccountSales = FileAccountFactory.FileParser(FileParserType.FileAccountSales);
                result = fileAccountSales.Parser(fileSource);
            }

            #endregion

            return result;
        }
    }


}
