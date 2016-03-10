using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXML
{
    public class XmlCustomReader
    {
        public void ReadOutTheXml(string xml)
        {
            var element = XElement.Parse(xml);
            var things = element.Elements().Select(item => new
            {
                Prop = item.Attribute("prop1")
            });
        }
    }
}
