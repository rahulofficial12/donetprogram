using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Ques4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derived = new DerivedClass();
            derived.ShowValue();
        }
    }
    public class BaseClass
    {
        protected int value = 100;
        protected void show()
        {
            Console.WriteLine("Base Class");
        }
    }
    class DerivedClass : BaseClass
    {
        public void ShowValue()
        {
            show();
            Console.WriteLine("The value of Base Class protected Member is : " + value);
        }
    }
}
