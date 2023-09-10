using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Ques6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derived = new DerivedClass();
            derived.SetProperty();
            derived.GetProperty();
        }
    }
    public class BaseClass
    {
        public int Value { get; set; }
    }
    class DerivedClass : BaseClass
    {
        public void SetProperty()
        {
            Value = 10;
        }
        public void GetProperty()
        {
            Console.WriteLine("Value : " + Value);
        }

    }
}
