using System;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Http.Internal;
using System.Text;
using System.Collections.Generic;
using System.IO.Compression;
using CsvHelper;

namespace ConsoleFtpDownload
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

            DownloadFtpDirectory();
            //  CompactarArquivos();

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



                    //  UploadFile(file);



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
                        // CompactarArquivos1(b);


                        // listaArquivos.Add(b, name); 
                        Console.WriteLine(name);
                        string teste12 = System.IO.Path.GetFileNameWithoutExtension(name);
                        Console.WriteLine(teste12);


                        IFormFile file = new FormFile(ms, 0, ms.Length, teste12, name);

                        using (var ms1 = new MemoryStream())
                        {
                            file.CopyTo(ms1);
                            var fileBytes = ms.ToArray();

                            listaArquvos.Add(fileBytes);
                        }


                        // /  listFormFile.Add(newFile);
                        //  UploadFile(newFile);
                        // GetZipArchive1(listFormFile);

                    }
                      //var listFiles = ParserCsv(file);
                   

                }
                var listFiles = ParserCsv1(listaArquvos);
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

                                //  csv.AppendLine(line);
                            }
                        }
                    }
                }

                //  GetZipArchive(listaArquivos);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static void UploadFile(IFormFile file)
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

        public static void UploadZipFile(Dictionary<byte[], string> files)
        {
            try
            {
                foreach(var oFile in files)
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{appsetting.FtpSettings.Host}/Processado/" + string.Format("{0}", oFile.Value)) ;
                request.Credentials = new NetworkCredential(appsetting.FtpSettings.Username, appsetting.FtpSettings.Password);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                    using (Stream stream = new MemoryStream(oFile.Key))
                    {
                        using (Stream ftpStream = request.GetRequestStream())
                        {
                            stream.CopyToAsync(ftpStream);
                        }
                    }
                }
            }
            catch (Exception ex)
            {


                Console.WriteLine(ex.Message);
            }
        }


        public static void CompactarArquivos()
        {
            try
            {

                using (FileStream zipToOpen = new FileStream($"ftp://{appsetting.FtpSettings.Host}/Processado/release.zip", FileMode.CreateNew))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Create))
                    {
                        ZipArchiveEntry readmeEntry = archive.CreateEntry("Readme.txt");
                        using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                        {
                            writer.WriteLine("Information about this package.");
                            writer.WriteLine("========================");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public static void CompactarArquivos1(List<byte[]> arquivos)
        {
            var compressedFileStream = new MemoryStream();

            using (compressedFileStream)
            {
                //compressedFileStream.Seek(0, SeekOrigin.Begin);
                using (var zipArchive = new ZipArchive(compressedFileStream, ZipArchiveMode.Create, false))
                {

                    //Create a zip entry for each attachment
                    var zipEntry = zipArchive.CreateEntry("teste");



                    using (var zipEntryStream = zipEntry.Open())
                    {
                        foreach (var arquivo in arquivos)
                        {
                            using (var originalFileStream = new MemoryStream(arquivo))


                                //Get the stream of the attachment


                                //Copy the attachment stream to the zip entry stream
                                originalFileStream.CopyTo(zipEntryStream);


                        }
                        IFormFile file = new FormFile(compressedFileStream, 0, compressedFileStream.Length, "teste", "Teste.zip");
                        UploadFile(file);
                    }

                }
            }

            // var teste = compressedFileStream.ToArray();
        }

        public static void ZipFiles(Dictionary<byte[], string> files)
        {
            Dictionary<byte[], string> zipFile = new Dictionary<byte[], string>();
            byte[] archiveFile;
            int i = 0;
            using (var archiveStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(archiveStream, ZipArchiveMode.Create, true))
                {
                    foreach (var oFile in files)
                    {
                        var zipArchiveEntry = archive.CreateEntry(oFile.Value, CompressionLevel.Fastest);

                        using var zipStream = zipArchiveEntry.Open();
                        zipStream.Write(oFile.Key, 0, oFile.Key.Length);
                    }
                }

                archiveFile = archiveStream.ToArray();
                zipFile.Add(archiveFile, "Lote1.zip");
               // IFormFile file = new FormFile(archiveStream, 0, archiveStream.Length, "teste1", "Teste.zip");
                UploadZipFile(zipFile);
            }

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
                UploadFile(file);
            }

        }

        public static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[32768];
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, read);
            }
        }

        public static void GetZipArchive1(List<IFormFile> files)
        {
            try
            {

                byte[] archiveFile;
                int i = 0;
                using (var archiveStream = new MemoryStream())
                {
                    using (var archive = new ZipArchive(archiveStream, ZipArchiveMode.Create, true))
                    {
                        foreach (var oFile in files)
                        {

                            using (Stream sourceStream = oFile.OpenReadStream())
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    var zipArchiveEntry = archive.CreateEntry(oFile.Name, CompressionLevel.Fastest);
                                    sourceStream.CopyTo(ms);
                                    var fileByte = ms.ToArray();
                                    using var zipStream = zipArchiveEntry.Open();
                                    zipStream.Write(fileByte, 0, fileByte.Length);
                                }
                            }
                        }
                    }

                    archiveFile = archiveStream.ToArray();
                    IFormFile file = new FormFile(archiveStream, 0, archiveStream.Length, "teste1", "Teste.zip");
                    UploadFile(file);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        public static void GetZipArchive2(List<Stream> files)
        {
            try
            {

                byte[] archiveFile;
                int i = 0;
                using (var archiveStream = new MemoryStream())
                {
                    using (var archive = new ZipArchive(archiveStream, ZipArchiveMode.Create, true))
                    {
                        foreach (var oFileStream in files)
                        {


                            using (MemoryStream ms = new MemoryStream())
                            {
                                var zipArchiveEntry = archive.CreateEntry("teste.csv", CompressionLevel.Fastest);
                                oFileStream.CopyTo(ms);
                                var fileByte = ms.ToArray();
                                using var zipStream = zipArchiveEntry.Open();
                                zipStream.Write(fileByte, 0, fileByte.Length);
                            }

                        }
                    }

                    archiveFile = archiveStream.ToArray();
                    IFormFile file = new FormFile(archiveStream, 0, archiveStream.Length, "teste1", "Teste.zip");
                    UploadFile(file);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        public static ZipArchive GetZipDataFromBinary(byte[] data)
        {
            Stream stream = new MemoryStream(data);
            ZipArchive archive = new ZipArchive(stream);
            return archive;
        }


        public static IFormFile TesteAzul(IFormFile oFile)
        {
            IFormFile _file;
            var csv = new StringBuilder();
            MemoryStream testeNewFile = new MemoryStream();

            using (Stream sourceStream = oFile.OpenReadStream())



            using (StreamReader reader = new StreamReader(sourceStream))
            {

                string line;
                using (var fileStream = new FileStream("contasExportadas.csv", FileMode.Create))
                {
                    using (var output = new StreamWriter(fileStream))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);

                            csv.AppendLine(line);
                        }
                        output.WriteLine(csv);



                    }

                    fileStream.CopyTo(testeNewFile);

                    _file = new FormFile(testeNewFile, 0, testeNewFile.Length, oFile.Name, string.Format("{0}.csv", oFile.Name));


                }

            }



            return _file;


        }


        public static IFormFile TesteAzul2(IFormFile oFile)
        {
            IFormFile _file;
            var csv = new StringBuilder();


            using (Stream sourceStream = oFile.OpenReadStream())
            {


                using (StreamReader reader = new StreamReader(sourceStream))
                {

                    string line;
                    using (var output = new StreamWriter(string.Format(@"C:\TesteAzul\{0}.csv", oFile.Name)))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);

                            csv.AppendLine(line);
                        }
                        output.Write(csv);



                        _file = new FormFile(output.BaseStream, 0, output.BaseStream.Length, oFile.Name, string.Format("{0}.csv", oFile.Name));
                        output.Close();
                    }
                    reader.Close();
                }
                sourceStream.Close();
                //sourceStream.Flush();


            }

            return _file;
        }

        public static IFormFile TesteAzul3(IFormFile oFile)
        {
            IFormFile _file;
            var csv = new StringBuilder();

            MemoryStream mStream = new MemoryStream();
            using (Stream sourceStream = oFile.OpenReadStream())


            using (StreamReader reader = new StreamReader(sourceStream))
            {


                string line;
                using (var output = new StreamWriter(mStream))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);

                        csv.AppendLine(line);
                    }


                    output.Write(csv);
                    output.Flush();
                    byte[] bytes = mStream.ToArray();

                    var teste = output.BaseStream;




                }

                // CompactarArquivos1(b);



            }



            return null;


        }


        public static Dictionary<byte[], string>  ParserCsv(IFormFile oFile)
        {
            Dictionary<byte[], string> listfiles = new Dictionary<byte[], string>();
            var csv = new StringBuilder();

            using (MemoryStream ms = new MemoryStream())
            {
                using (Stream sourceStream = oFile.OpenReadStream())
                {
                    using (StreamReader reader = new StreamReader(sourceStream))
                    {
                        string line;
                        using (var writer = new StreamWriter(ms))
                        {
                            while ((line = reader.ReadLine()) != null)
                            {
                                writer.WriteLineAsync(line);

                                // csv.AppendLine(line);
                            }
                            //  output.Write(csv);
                            writer.Flush();
                            byte[] bytes = ms.ToArray();

                            listfiles.Add(bytes, oFile.Name);
                        }
                    }
                }
            }

            return listfiles; 
        }


      


        // CompactarArquivos1(b);


        public static Dictionary<byte[], string> ParserCsv1(List<byte[]> listFile)
        {
            Dictionary<byte[], string> listfiles = new Dictionary<byte[], string>();
            var csv = new StringBuilder();
            int i = 0;
            foreach(var oFile in listFile)
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
                                while ((line = reader.ReadLine()) != null)
                                {
                                    writer.WriteLineAsync(line);

                                    // csv.AppendLine(line);
                                }
                                //  output.Write(csv);
                                writer.Flush();
                                byte[] bytes = newMs.ToArray();

                                listfiles.Add(bytes, string.Format("Teste{0}", i++));
                            }
                        }
                        }
                    
                }
            }

            return listfiles;
        }






        public static byte[] azulCsv()
        {
            IFormFile _file;
            byte[] arquivo;
            using (MemoryStream ms = new MemoryStream())
            {
           
                StreamWriter writer = new StreamWriter(ms);
                {

                    writer.WriteLineAsync("asdasdasasdfasdasd");
                    writer.Flush();
                }
                //You have to rewind the MemoryStream before copying
                byte[] bytes = ms.ToArray();

                //using (FileStream fs = new FileStream("output.txt", FileMode.Create, System.IO.FileAccess.Write))
                //{
                   
                //    ms.CopyToAsync(fs);

                   

                //   // _file = new FormFile(fs, 0, fs.Length, "output", "output.txt");
                //}
                 

                return bytes;
            }
        }


    }
}



