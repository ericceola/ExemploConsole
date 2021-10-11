using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleParserZip
{
    public class AppSettings
    {
        [JsonProperty("ftpSettings")]
        public FtpSettings FtpSettings { get; set; }

    }
}
