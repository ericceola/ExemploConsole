using System;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Http.Internal;

namespace ConsoleFtpUpload
{
  
    class Program
    {
        public static IConfigurationRoot configuration;
        public static AppSettings appsetting;
        static  void Main(string[] args)
        {


            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

             BuscarArquivos();

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

        public  static void UploadFile(IFormFile file)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"ftp://{appsetting.FtpSettings.Host}/" + string.Format("{0}",file.FileName));
                request.Credentials = new NetworkCredential(appsetting.FtpSettings.Username, appsetting.FtpSettings.Password);
                request.Method = WebRequestMethods.Ftp.UploadFile;
              
                //using (var client = new WebClient())
                //{
                //    client.Credentials = new NetworkCredential(appsetting.FtpSettings.Username, appsetting.FtpSettings.Password);
                //    client.UploadFile($"ftp://{appsetting.FtpSettings.Host}/" + string.Format("{0}", file.FileName), WebRequestMethods.Ftp.UploadFile, );
                //}

                using (Stream ftpStream = request.GetRequestStream())
                {
                  


                    file.CopyToAsync(ftpStream);


                }
            }
            catch (Exception ex)
            {
                

                Console.WriteLine(ex.Message) ;
            }
            
        }

        public static void BuscarArquivos()
        {

            string[] filePaths = Directory.GetFiles(@"c:\ArquivosProcessar\", "*.txt");

            foreach (string fileName in filePaths)
            {
               var nomeArquivo = Path.GetFileName(fileName);
                byte[] imageByteArray = File.ReadAllBytes(fileName);

                var stream = new MemoryStream(imageByteArray);
              //  UploadFile(stream);
                IFormFile  file =  new FormFile(stream, 0, stream.Length, fileName, nomeArquivo);

                UploadFile(file);
            }
           

 
        }

       
    }
}
