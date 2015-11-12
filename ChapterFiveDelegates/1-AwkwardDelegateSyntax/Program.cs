using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_AwkwardDelegateSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.Text = "Click me";

            button.Click += new EventHandler(LogPlainEvent);
            button.KeyPress += new KeyPressEventHandler(LogKeyEvent);
            button.MouseClick += new MouseEventHandler(LogMouseEvent);


            Form form = new Form();
            form.AutoSize = true;
            form.Controls.Add(button);
            Application.Run(form);
        }

        static void LogPlainEvent(object sender, EventArgs e)
        {
            Console.WriteLine("LogPlain");
        }

        static void LogKeyEvent(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("This key was pressed: {0}", e.KeyChar);
        }

        static void LogMouseEvent(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse was clicked at : ({0}, {1})", e.X, e.Y);
        }
    }
}
