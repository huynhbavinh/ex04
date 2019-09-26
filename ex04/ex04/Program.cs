using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            PrintOdd(number);
            PrintEven(number);
            PrintPrime(number);
        }
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
        static void PrintOdd(int number)
        {
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
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        static void PrintEven(int number)
        {
            IsEven(number);
            if (IsEven(number))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("not Even");
            }
        }
        public static bool IsPrime(int number)
        {
            bool result = true;
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i <= number; i++)
            {
                int flag = 1;
                if (number % i == 0)
                {
                    flag++;
                }
                if (flag == 2)
                {
                    return result;
                }
            }
            return result;
        }
        static void PrintPrime(int number)
        {
            if (IsPrime(number))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("not Prime");
            }
        }
    }
}
