using System;
using System.Windows.Forms;

namespace _3_CovarianceAndContravariance
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.AutoSize = true;
            
            Button button = new Button();
            button.Text = "Click this button!";

            form.Controls.Add(button);

            // Contravariance

            button.Click += MyCustomEventHandler;
            button.KeyPress += MyCustomEventHandler;
            button.MouseClick += MyCustomEventHandler;

            // covariance
            AnimalGenerator ag = GetHippo;

            Animal myAnimal = ag("Phil");

            Application.Run(form);
        }

        private static void MyCustomEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Calling my custom event handler, triggered by {0}", sender);
        }

        public delegate Animal AnimalGenerator(string name);

        public static Hippo GetHippo(string name)
        {
            return new Hippo(name);
        }

        public class Animal
        {
            private readonly string _name;
            public string Name { get { return _name; } }

            public Animal(string name)
            {
                _name = name;
            }
        }

        public class Hippo : Animal
        {
            public Hippo(string name) : base(name)
            {
                
            }
        }
    }
}
