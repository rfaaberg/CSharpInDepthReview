using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_InsideOutCapturing
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodInvoker[] delegates = new MethodInvoker[2];

            int outside = 0;

            for (int i = 0; i < 2; i++)
            {
                int inside = 0;

                delegates[i] = delegate
                {
                    Console.WriteLine("({0}, {1})", outside, inside);
                    outside++;
                    inside++;
                };
            }

            MethodInvoker first = delegates[0];
            MethodInvoker second = delegates[1];

            first();
            first();
            first();

            second();
            second();

            Console.ReadLine();
        }
    }
}
