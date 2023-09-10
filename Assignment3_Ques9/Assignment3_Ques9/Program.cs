using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Ques9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeriveClass derive = new DeriveClass();
            derive.Method2();
        }
    }
    class BaseClass
    {
        protected void Method()
        {
            Console.WriteLine("Protected method of BaseClass !");
        }
    }
    class DeriveClass : BaseClass
    {
        public void Method2()
        {
            Method();
        }
    }
}
