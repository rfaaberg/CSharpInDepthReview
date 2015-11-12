using System;
using System.Threading;
using System.Windows.Forms;

namespace _2_MethodGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            EventHandler eh = MyGreatMethod;
            ThreadStart ts = MyGreatMethod;

            Form form = new Form();

            //form.Invoke(MyGreatMethod);

            //Delegate del = MyGreatMethod;
            //Delegate del1 = (ThreadStart) MyGreatMethod; // Casting
            //Delegate del2 = (EventHandler)MyGreatMethod; // Casting
            //InvokeIt(MyGreatMethod, null, new EventArgs()); // Helper method
            //ThreadStart ts2 = MyGreatMethod;
            //form.Invoke(ts2);
        }

        public static void InvokeIt(EventHandler eventHandler, object sender, EventArgs e)
        {
            eventHandler(sender, e);
        }

        public static void MyGreatMethod(object sender, EventArgs e)
        {
            Console.WriteLine("MyGreatMethod with sender and e");
        }

        public static void MyGreatMethod()
        {
            Console.WriteLine("MyGreatMethod with no args");
        }
    }
}
