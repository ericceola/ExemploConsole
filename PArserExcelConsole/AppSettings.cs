using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace PArserExcelConsole
{
   
    public class AppSettings
    {
        
        [JsonProperty("invoiceParameters")]
        public InvoiceSettings InvoiceParameters { get; set; }
    }
}
