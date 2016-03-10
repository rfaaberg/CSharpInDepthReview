using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXML
{
    public class XmlGenerator
    {
        public string GenerateSomeXml()
        {
            var things = new[] {new {Property = 1}, new { Property = 2}};

            var thing = new XElement("items", things.Select(t => new XElement("item", new XAttribute("prop1", t.Property))), new XElement("aWhatever", "hey there"));

            return thing.ToString();
        }
    }
}
