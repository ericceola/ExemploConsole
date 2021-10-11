using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleINT096
{
    class Program
    {
        public static IConfigurationRoot configuration;
        public static AppSettings appsetting;

        static void Main(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            Console.WriteLine("Hello World!");
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

        public static string ParserLine(string line)
        {
            string newLine = string.Empty;
            BaseAracFile baseAracFile = new BaseAracFile();

            #region Leitura das colunas do arquivo txt.

            baseAracFile.TP_REGISTRO = line.Substring(0, 3);
            baseAracFile.COMPANIA = line.Substring(3, 4);
            baseAracFile.PAIS = line.Substring(7, 3);
            baseAracFile.FILIAL_CONTABLE = line.Substring(10, 4);
            baseAracFile.FILIAL_NUMERICA = line.Substring(14, 4);
            baseAracFile.CODIGO_ARACS = line.Substring(18, 8);
            baseAracFile.NUMERO_ARACS = line.Substring(26, 8);
            baseAracFile.FECHA_CONTABILIZACION = line.Substring(34, 8);
            baseAracFile.FECHA_VENCIMIENTO = line.Substring(42, 8);
            baseAracFile.MONEDA = line.Substring(50, 3);
            baseAracFile.IMPORTE = line.Substring(53, 15);
            baseAracFile.TIPO_DE_CAMBIO = line.Substring(68, 11);
            baseAracFile.IMPORTE_CONVERTIDO = line.Substring(79, 15);
            baseAracFile.INDICADOR_DC = line.Substring(94, 1);
            baseAracFile.CUENTA_CONTABLE = line.Substring(95, 20);
            baseAracFile.CENTRO_DE_COSTO = line.Substring(115, 6);
            baseAracFile.TIPO_DE_SERVICIO = line.Substring(121, 10);
            baseAracFile.ORIGEN_DESTINO = line.Substring(131, 7);
            baseAracFile.AERONAVE = line.Substring(138, 11);
            baseAracFile.NUMERO_DE_DOCUMENTO = line.Substring(149, 25);
            baseAracFile.CLIENTE_PROVEEDOR = line.Substring(174, 20);
            baseAracFile.INDICADOR_PR = line.Substring(194, 1);
            baseAracFile.NUMERO_LINEA = line.Substring(195, 6);
            baseAracFile.NOME_FORNECEDOR = line.Substring(201, 30);
            baseAracFile.LEGENDA_CABECALHO = line.Substring(231, 199);

            #endregion

            #region Colunas do arquivo cs
            string result = String.Empty;
            string[] parameters = { "INV0", "CGBK" };

            int legendaCabecalho = String.IsNullOrEmpty(baseAracFile.LEGENDA_CABECALHO.Substring(3, 6)) ? Convert.ToInt32(baseAracFile.LEGENDA_CABECALHO.Substring(3, 6)) : 0;
            if (parameters.Contains(baseAracFile.CODIGO_ARACS.Trim()) && baseAracFile.INDICADOR_PR.Trim() == "R")
            {
                var fileAccountRevenue = FileAccountFactory.FileParser(FileParserType.AccountReceivable);
                result = fileAccountRevenue.Parser(baseAracFile);

            }
            

            #endregion

            return result;
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




    }
}
