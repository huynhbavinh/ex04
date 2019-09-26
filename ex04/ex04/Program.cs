using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            IsOdd(number);
            if (IsOdd(number))
            {
                Console.WriteLine("ODD");
            }
            else
            {
                Console.WriteLine("not ODD");
            }
              
        }
        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }
}
