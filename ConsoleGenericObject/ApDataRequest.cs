using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleGenericObject
{
    public class ApDataRequest
    {
        [JsonProperty("userName")]
        public string userName { get; set; }

        [JsonProperty("pass")]
        public string pass { get; set; }

        [JsonProperty("queryId")]
        public int queryId { get; set; }

        [JsonProperty("languageId")]
        public int languageId { get; set; }

        [JsonProperty("items")]
        public List<Item> items { get; set; }
    }

    public class Item
    {
        [JsonProperty("paramName")]
        public string paramName { get; set; }

        [JsonProperty("value")]
        public string value { get; set; }
    }

}
