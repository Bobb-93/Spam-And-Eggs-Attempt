using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spam_and_Eggs
{
    class Program
    {
        static void prepare_meal(int number)
        {
            List<int> myList=new List<int>();
            bool noSpan = true;
            for(int i=0;i<Int32.MaxValue;i++)
            {
                myList.Add(i);
                //int n = i;
                if(number%Math.Pow(3,i)==0)
                {
                    Console.Write("span ");
                    noSpan = false;
                }
            }

            if(number%5==0 && noSpan==false)
            {
                Console.WriteLine("and eggs");
            }
            else if(number%5==0 && noSpan==true)
            {
                Console.WriteLine("eggs");
            }
            else
            {
                Console.WriteLine(' ');
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter m: ");
            int m = int.Parse(Console.ReadLine());
            prepare_meal(m);
        }
    }
}
