using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_CapturedVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            var coolApp = new MyCoolApp();
            coolApp.DoSomeStuff();
            Console.ReadLine();
        }

        public class MyCoolApp
        {
            public void DoSomeStuff()
            {
                string myString = "some string content";
                Console.WriteLine(myString);

                MethodInvoker methodInvoker = delegate
                {
                    myString = "changing the content";
                    Console.WriteLine(myString);
                };

                methodInvoker();

                //var invokers = new List<MethodInvoker>();

                //for (int i = 0; i < 10; i++)
                //{
                //    //int k = i;

                //    invokers.Add(delegate
                //    {
                //        Console.WriteLine("value of i is {0}", i);
                //    });
                //}

                //foreach (var invoker in invokers)
                //{
                //    invoker();
                //}
            }
        }
    }
}
