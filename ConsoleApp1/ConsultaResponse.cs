using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    public class ConsultaResponse
    {
        [XmlElement("xmlcep")]
        public CepResponse ConsultaCep { get; set; }
    }
}
