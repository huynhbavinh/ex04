using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4b
{
    public class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("nhap phan tu mang : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array Created : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            check1(array);
            check2(array);
            check3(array);
            Console.WriteLine(" have {0} elements is key(5) ", count1(array));
            Console.WriteLine("have {0} elements is key(5or6) ", count2(array));
            Console.WriteLine("{0} is Sum of the array", sum(array));
        }
        public static bool problem1(int[] array)
        {
            int key = 5;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return true;
                }
            }
            return false;
        }
        public static void check1(int[] array)
        {
            problem1(array);
            if (problem1(array) == true)
            {
                Console.WriteLine("have the number key");
            }
            else
            {
                Console.WriteLine("don't have the number key");
            }
        }
        public static bool problem2(int[] array)
        {
            int key1 = 5;
            int key2 = 6;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key1 || array[i] == key2)
                {
                    return true;
                }
            }
            return false;
        }

        public static void check2(int[] array)
        {
            problem2(array);
            if (problem2(array) == true)
            {
                Console.WriteLine("have the number key1 or key2");
            }
            else
            {
                Console.WriteLine("don't have the number key1 or key2");
            }
        }
        public static bool problem3(int[] array)
        {
            problem1(array);
            problem2(array);
            if (problem1(array) == true && problem2(array) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool prob2b(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 6)
                {
                    return true;
                }
            }
            return false;
        }
        public static void check3(int[] array)
        {
            problem3(array);
            if (problem3(array) == true && prob2b(array) == true)
            {
                Console.WriteLine("have the number key1 and key2");
            }
            else
            {
                Console.WriteLine("don't have the number key1 and key2");
            }
        }
        public static int count1(int[] array)
        {
            int key1 = 5;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key1)
                {
                    count++;
                }
            }
            return count;
        }
        public static int count2(int[] array)
        {
            int key1 = 5;
            int key2 = 6;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key1 || array[i] == key2)
                {
                    count++;
                }
            }
            return count;
        }
        public static int sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
