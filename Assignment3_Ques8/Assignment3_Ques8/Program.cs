using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Ques8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoClass demo = new DemoClass();
            demo.ShowPrivate();
        }
    }
    class DemoClass
    {
        private void Show()
        {
            Console.WriteLine("Private method");
        }
        public void ShowPrivate()
        {
            Show();
        }
    }
}
