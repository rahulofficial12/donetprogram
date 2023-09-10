using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass3_Ques2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            class2.ShowValue();
        }
    }
    public class Class1
    {
        private string f = "Rahul Tomar";
        public string show()
        {
            return f;
        }
    }
    public class Class2
    {
        public void ShowValue()
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Name = " + class1.show());
        }
    }
}