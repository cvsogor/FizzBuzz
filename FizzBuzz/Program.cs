using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        const int max = 100;
        //first solution
        static void Mod()
        {
            int mod3;
            int mod5;
            for (int i = 1; i < max; i++) //int.MaxValue
            {
                mod3 = i % 3;
                mod5 = i % 5;
                if (mod3 == 0)
                {
                    Console.Write(" Fizz");
                }
                if (mod5 == 0)
                {
                    Console.Write(" Buzz");
                }
                if ((mod3 != 0) && (mod5 != 0))
                {
                    Console.Write(string.Format(" {0}", i));
                }
                Console.Write(",");
            }
        }
        //optimization
        static void Inc()
        {
            int mod3 = 0;
            int mod5 = 0;
            for (int i = 1; i < max; i++) //int.MaxValue
            {
                mod3++;
                mod5++;
                if ((mod3 != 3) && (mod5 != 5))
                {
                    Console.Write(string.Format(" {0}", i));
                }
                if (mod3 == 3)
                {
                    mod3 = 0;
                    Console.Write(" Fizz");
                }
                if (mod5 == 5)
                {
                    mod5 = 0;
                    Console.Write(" Buzz");
                }
                Console.Write(",");
            }
        }
        static void Main(string[] args)
        {
            Mod();
            Console.WriteLine();
            Console.WriteLine();
            Inc();
            Console.ReadKey();
        }
    }
}
