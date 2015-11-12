using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_IgnoringExistingParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.AutoSize = true;

            Button button = new Button();
            button.Text = "Click me";
            button.Click += delegate { Console.WriteLine("I've been clicked!"); };

            form.Controls.Add(button);

            Application.Run(form);
        }
    }
}
