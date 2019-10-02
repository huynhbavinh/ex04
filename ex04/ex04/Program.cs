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
            Console.WriteLine("{0} is square of {1} ", Square(number), number);
            Console.WriteLine("{0} is square of {1}", Cube(number), number);
            Console.WriteLine("input 2nd number ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} is the result of math pow,{1} and {2}", pow(number, number2), number, number2);
            Console.WriteLine("{0} is the abs of {1}", abs(number), number);
            Console.WriteLine("The number u want it to be ceil and floor");
            double number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} is ceil {1} ", mathceil(number3), number3);
            Console.WriteLine("{0} is floor {1} ", mathFloor(number3), number3);
            Console.WriteLine("{0} is lucky number ", Random(number));
            Console.WriteLine("{0} is random2 ", random2());
            //long x = Convert.ToInt32(Console.ReadLine());
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
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
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
        public static int Square(int number)
        {
            return number * number;
        }
        public static int Cube(int number)
        {
            return number * number * number;
        }
        public static double pow(int number, int number2)
        {
            double result = 1;
            if (number2 > 0)
            {

                for (int i = 0; i < number2; i++)
                {
                    result = result * number;
                }
            }
            else if (number2 < 0)
            {
                double temp;
                for (int i = 0; i < Math.Abs(number2); i++)
                {
                    result = (result * number);
                }
                temp = 1 / result;
                result = temp;
            }
            return result;
        }
        public static int abs(int number)
        {
            //return Math.ABS(number);
            if (number == 0)
            {
                return 1;
            }
            if (number < 0)
            {
                return number * -1;
            }
            return number;
        }
        public static int mathceil(double number3)
        {
            if (number3 > 0 && number3 % 1 != 0)
            {
                return (int)number3 + 1;
            }
            else if (number3 < 0 && number3 % 1 != 0)
            {
                return (int)number3;
            }
            else
            {
                return (int)number3;
            }

        }
        public static int mathFloor(double number3)
        {
            if (number3 < 0)
            {
                return (int)number3 + -1;
            }

            return (int)number3;
        }
        public static int Random(int number)
        {
            Random rd = new Random();
            return number = rd.Next(0, 100000);
        }
        public static float random2()
        {
            Random rd2 = new Random();
            return rd2.Next(0, 1);
        }
        public static long factonrial(long x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
