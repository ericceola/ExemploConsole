using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleFtpDownload
{
     public class AppSettings
    {
        [JsonProperty("ftpSettings")]
        public FtpSettings FtpSettings { get; set; }
    }
}
