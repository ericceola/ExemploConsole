using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleINT096
{
    public class AppSettings
    {
        [JsonProperty("ftpSettings")]
        public FtpSettings FtpSettings { get; set; }

        [JsonProperty("fileAccountReceivableSettings")]
        public FileAccountReceivableSettings FileAccountReceivableSettings { get; set; }
    }
}
