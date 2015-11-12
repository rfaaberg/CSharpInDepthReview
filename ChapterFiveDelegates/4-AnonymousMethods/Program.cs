using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_AnonymousMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> isLongerThanThreeCharacters = delegate(string input)
            {
                return input != null && input.Length > 3;
            };

            foreach (var input in new string[] {"a", "bb", "c", "dddd", "e", "ffffff"})
            {
                Console.WriteLine("{0} is longer than 3: {1}", input, isLongerThanThreeCharacters(input));
            }

            Console.ReadLine();
        }
    }
}
