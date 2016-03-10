using System;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace ObservableFormClicking
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();

            var mouseClick = Observable.FromEventPattern(form, "Click");
            mouseClick.Subscribe(pattern =>
            {
               Console.WriteLine("click");
            });

            Application.Run(form);
        }
    }
}
