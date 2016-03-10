using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToSQL;
using LinqToXML;

namespace ChapterTwelveLINQBeyondCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var myNeatRepo = new MyNeatRepo();
            var someList = myNeatRepo.DoSomeQuerying();

            var xmlGenerator = new XmlGenerator();
            var generatedXml = xmlGenerator.GenerateSomeXml();

            var xmlCustomReader = new XmlCustomReader();

            xmlCustomReader.ReadOutTheXml(generatedXml);

            Console.WriteLine(generatedXml);

            Console.ReadLine();
        }
    }
}
