using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToXML;

namespace ChapterTwelveLINQBeyondCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlGenerator = new XmlGenerator();
            var generatedXml = xmlGenerator.GenerateSomeXml();

            var xmlCustomReader = new XmlCustomReader();

            xmlCustomReader.ReadOutTheXml(generatedXml);

            Console.WriteLine(generatedXml);

            Console.ReadLine();
        }
    }
}
