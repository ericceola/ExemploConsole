using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleINT054
{
    public class FileInvoiceSettings
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("invoiceType")]
        public string InvoiceType { get; set; }
    }
}
