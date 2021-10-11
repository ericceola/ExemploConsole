using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace PArserExcelConsole
{
	
	public class Root
	{

		[XmlElement(ElementName = "request")]
		public string Request { get; set; }
		
	}
}
