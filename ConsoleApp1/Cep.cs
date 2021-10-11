using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    [XmlRoot("xmlcep")]
    public class CepResponse
    {
        [XmlElement("cep")]
        public string Cep { get; set; }
        
        [XmlElement("logradouro")]
        public string Logradouro { get; set; }

        [XmlElement("complemento")]
        public string Complemento { get; set; }

        [XmlElement("bairro")]
        public string Bairro { get; set; }

        [XmlElement("localidade")]
        public string Localidade { get; set; }

        [XmlElement("uf")]
        public string Uf { get; set; }

        [XmlElement("ibge")]
        public string Ibge { get; set; }

        [XmlElement("gia")]
        public string Gia { get; set; }

        [XmlElement("ddd")]
        public string Ddd { get; set; }

        [XmlElement("siafi")]
        public string Siafi { get; set; }




    }
}
