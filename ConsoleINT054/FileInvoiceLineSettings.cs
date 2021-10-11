using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleINT054
{
    public class FileInvoiceLineSettings
    {
        [JsonProperty("lineType")]
        public string LineType { get; set; }

        [JsonProperty("shiptoLocation")]
        public string ShiptoLocation { get; set; }
    }
}
