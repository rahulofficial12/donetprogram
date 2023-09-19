using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass4_Ques5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Collection = new CustomList<String>();
            Collection[0] =" Sachin Varshney";
            Collection[1] = "Sneha Sharma";
            Collection[2] = "Amit Saraswat";
            Collection[3] = "Lal Upadhyay";
            Collection[4] = "Puspendra Singh Yadav";
            Console.WriteLine("Rahul's Friendlist : ");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(Collection[i]);
        }
    }
    class CustomList<T>
    {
        private T[] list = new T[5];
        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
    }
}