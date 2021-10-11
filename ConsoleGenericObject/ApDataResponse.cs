using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleGenericObject
{
    public class ApDataResponse
    {
        public bool result { get; set; }
        public Message message { get; set; }
    }

    public class Field
    {
        public string fieldName { get; set; }
        public int fieldType { get; set; }
        public string fieldMask { get; set; }
        public int fieldLength { get; set; }
        public int fieldDecimals { get; set; }
    }

    public class Record
    {
        public string value { get; set; }
    }

    public class Value
    {
        public int recNo { get; set; }
        public List<Record> record { get; set; }
    }

    public class Message
    {
        public List<Field> fields { get; set; }
        public List<Value> values { get; set; }
    }

}
