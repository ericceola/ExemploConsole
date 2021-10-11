using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleINT054
{
    public class AppSettings
    {
        [JsonProperty("ftpSettings")]
        public FtpSettings FtpSettings { get; set; }

        [JsonProperty("fileInvoiceSettings")]
        public FileInvoiceSettings FileInvoiceSettings { get; set; }

        [JsonProperty("fileInvoiceLineSettings")]
        public FileInvoiceLineSettings FileInvoiceLineSettings { get; set; }

    }
}
