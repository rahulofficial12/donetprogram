using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nQues 1");
            Ques1 ques1 = new Ques1();
            ques1.method1();
            Console.WriteLine("\n\nQues 2"); 
            Ques2 ques2 = new Ques2();
            ques2.method2();
            Console.WriteLine("\n\nQues 3"); 
            Ques3 ques3 = new Ques3();
            ques3.method3();
            Console.WriteLine("\n\nQues 4"); 
            Ques4 ques4 = new Ques4();
            ques4.method4();
            Console.WriteLine("\n\nQues 5"); 
            Ques5 ques5 = new Ques5();
            ques5.method5();
            Console.WriteLine("\n\nQues 6"); 
            Ques6 ques6 = new Ques6();
            ques6.method6();
            Console.WriteLine("\n\nQues 7"); 
            Ques7 ques7 = new Ques7();  
            ques7.method7();
            Console.WriteLine("\n\nQues 8"); 
            Ques8 ques8 = new Ques8();
            ques8.method8();
            Console.WriteLine("\n\nQues 9"); 
            Ques9 ques9 = new Ques9();
            ques9.method9();
            Console.WriteLine("\n\n\nQues 10"); 
            Ques10 ques10 = new Ques10();   
            ques10.method10();
            Console.Read();
        }
    }
}
