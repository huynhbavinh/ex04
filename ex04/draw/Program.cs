using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace draw
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = Convert.ToInt32(Console.ReadLine());
            draw1(4, 'o');
            Console.WriteLine();
            draw2(4, 'u');
            Console.WriteLine();
            draw3(4, 'v');
            Console.WriteLine();
            draw4(4, 'x');
            Console.WriteLine();
            draw5(4, '+');
            Console.WriteLine();
            draw6(4, 'v');
            Console.WriteLine();
            draw7(4, 'V');
            Console.WriteLine();
            draw8(4, '^');
            Console.WriteLine();
            draw9(4, 'A');

        }
        public static void line(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(c);
            }
        }
        public static void square(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < number; j++)
                {
                    Console.Write(c);
                }
            }
        }
        public static void Hori(int number, char c)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(c);
            }
        }
        public static void draw1(int number, char c)
        {
            int space;
            //line1
            Hori(number, c); Console.WriteLine();
            //line i
            if (number % 2 == 0)
            {
                space = number / 2;
            }
            else
            {
                space = number / 2 + 1;
            }
            for (int i = 0; i < number - 2; i++)
            {
                Hori(1, c); Hori(space, ' '); Hori(1, c); Console.WriteLine();
            }
            //last line;
            Hori(number, c); Console.WriteLine();
        }
        public static void draw2(int number, char c)
        {
            //i-line
            int space;
            if (number % 2 == 0)
            {
                space = number / 2;
            }
            else
            {
                space = number / 2 + 1;
            }
            for (int i = 0; i < number - 1; i++)
            {
                Hori(1, c); Hori(space, ' '); Hori(1, c); Console.WriteLine();
            }
            //last-line
            Hori(number, c); Console.WriteLine();
        }
        public static void draw3(int number, char c)
        {
            //draw W
            //1-line
            int space1 = number + 1;
            Hori(1, c); Hori(space1, ' '); Hori(1, c); Hori(space1, ' '); Hori(1, c); Console.WriteLine();
            //i-line
            int space2 = number + 1;
            int space3 = 1;
            for (int i = 1; i <= number / 2; i++)
            {
                space2 = space2 - 2;
                Hori(i, ' '); Hori(1, c); Hori(space2, ' '); Hori(1, c); Hori(space3, ' ');
                Hori(1, c); Hori(space2, ' '); Hori(1, c); Console.WriteLine();
                space3 = space3 + 2;
            }
            //last-line
            Hori(number - 1, ' '); Hori(1, c); Hori(number + 1, ' '); Hori(1, c);

        }
        public static void draw4(int number, char c)
        {
            int topspace2 = number - 1;
            int topspace1 = 0;
            //draw X
            //top mid line
            for (int i = 0; i < number / 2; i++)
            {

                Hori(topspace1, ' '); Hori(1, c); Hori(topspace2, ' '); Hori(1, c); Console.WriteLine();
                topspace1 = topspace1 + 1;
                topspace2 = topspace2 - 2;
            }

            //mid-line
            Hori(number / 2, ' '); Hori(1, c); Console.WriteLine();
            //bot mid line
            int botspace1 = number / 2 - 1;
            int botspace2 = 1;
            for (int i = 0; i < number / 2; i++)
            {

                Hori(botspace1, ' '); Hori(1, c); Hori(botspace2, ' '); Hori(1, c); Console.WriteLine();
                botspace1 = botspace1 - 2;
                botspace2 = botspace2 + 2;
            }
        }
        public static void draw5(int number, char c)
        {
            //top-mid
            for (int i = 0; i < number / 2; i++)
            {
                Hori(number / 2, ' '); Hori(1, c); Console.WriteLine();
            }
            //middle
            Hori(number + 1, c); Console.WriteLine();
            //bot-mid
            for (int i = 0; i < number / 2; i++)
            {
                Hori(number / 2, ' '); Hori(1, c); Console.WriteLine();
            }
        }
        public static void draw6(int number, char c)
        {
            //i-th line
            //idea : mid-space decrease 2 element any single line 
            //at : line 2 : mid-space  got 12 ( at number=8)
            // line 3 got : got 10
            // so : we got Space = number(8) + (8)/2 + 1 at first loop
            // mid-space of line2 = Space - 2 because its decrease 2 element any single line 
            int space = number + 1;
            for (int i = number - 1; i > 1; i--)
            {
                Hori(number - i, ' '); Hori(1, c);
                space = space - 2;
                Hori(space, ' '); Hori(1, c); Console.WriteLine();
            }
            //last line
            Hori(number - 1, ' '); Hori(1, c); Console.WriteLine();
        }
        static void draw7(int number, char c)
        {
            Hori(number * 2 - 1, c); Console.WriteLine();
            //i-th line
            //idea : mid-space decrease 2 element any single line 
            //at : line 2 : mid-space  got 12 ( at number=8)
            // line 3 got : got 10
            // so : we got Space = number(8) + (8)/2 + 1 at first loop
            // mid-space of line2 = Space - 2 because its decrease 2 element any single line 
            int space = number + 1;
            for (int i = number - 1; i > 1; i--)
            {
                Hori(number - i, ' '); Hori(1, c);
                space = space - 2;
                Hori(space, ' '); Hori(1, c); Console.WriteLine();
            }
            //last line
            Hori(number - 1, ' '); Hori(1, c); Console.WriteLine();
        }
        static void draw8(int number, char c)
        {
            // line 1 : n-1 space / 1 star
            // line 2 : n-2 space/ 1 star, 1 space/1 star
            // line 3 : n-3 space/ 1 star, 3 space/1 star
            // last line 2n-1 star 
            {
                //first line
                Hori(number - 1, ' '); Hori(1, c); Console.WriteLine();
                // i-th line           
                int line = 1, space = number + 1;
                for (int i = 1; i < number; i++)
                {
                    line = line + 1;
                    Hori(number - line, ' '); Hori(1, c);
                    // we got space = number+1 - 2, because Value (number - space) must grow 2 time/ 1 it's only a oDD 
                    space = space - 2;
                    Hori(number - space, ' '); Hori(1, c); Console.WriteLine();
                }
                // last line
                Hori(number * 2 - 1, c);
            }
        }
        static void draw9(int number, char c)
        {
            // line 1 : n-1 space / 1 star
            // line 2 : n-2 space/ 1 star, 1 space/1 star
            // line 3 : n-3 space/ 1 star, 3 space/1 star
            // last line 2n-1 star 
            {
                //first line
                Hori(number - 1, ' '); Hori(1, c); Console.WriteLine();
                // i-th line           
                int line = 1, space = number + 1;
                for (int i = 1; i < number / 2; i++)
                {
                    line = line + 1;
                    Hori(number - line, ' '); Hori(1, c);
                    // we got space = number+1 - 2, because Value (number - space) must grow 2 time/ 1 it's only a oDD 
                    space = space - 2;
                    Hori(number - space, ' '); Hori(1, c); Console.WriteLine();
                }
                for (int i = 1; i < number/2; i++)
                {
                    int temp = number / 2;
                    if (i == 1)
                    {
                        Hori(temp - i, ' '); Hori(number + 1, 'A'); Console.WriteLine();
                    }
                    Hori(1, c); Hori(number + 1, ' '); Hori(1, c); ; Console.WriteLine();
                }
               
            }
        }
    }
}
