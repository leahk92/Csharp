using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_0330
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Method_star_splitnumber
    {

        static void splitNumber(int n)
        {
            char[] digit = new char[16];
            int i = digit.Length - 1; // i에 15 대입

            if (n != 0)
            {   //(1)i= 15    (2)i= 14   (3)i = 13  (4)i= 12 (5)i= 11 (6)i= 10
                //(1)n= 12350 (2)n= 1235 (3)n = 123 (4)n= 12 (5)n= 1  (6)n= 0  -->끝
                for (; n != 0; n /= 10, i--)
                {
                    int k = n % 10;
                    //(1)k= 0 (2)k= 5 (3)k= 3 (4)k= 2 (5)k= 1

                    digit[i] = (char)(k + '0');
                    //(1)digit[15] = 0, (2)digit[14] = 5, (3)digit[13] = 3, (4)digit[12] = 2, (5)digit[11] = 1
                }
                i++; //i 값은 11
            }
            for (int k = i; k < digit.Length; k++)
            { // k = 11 > 12 > 13 > 14 > 15 
                Console.WriteLine(digit[k]);
                //digit[11] > digit[12] > digit[13] > digit[14] > digit[16]
            }
        }
        static void splitNumber2(int n)
        {
            char[] digit = new char[16];
            int i = digit.Length - 1;

            if (n != 0)
            {
                for (; n != 0; n /= 10, i--)
                {
                    int k = n % 10;

                    digit[i] = (char)(k + '0');
                }
                i++;
                for (int k = i; k < digit.Length; k++)
                {
                    Console.WriteLine(digit[k]);
                }

            }
        }

        static void DrawLine03(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Star_b(n - i, '-', false);
                Star_b(i);
            }
        }
        static void Star_b(int n, char c = '*', bool new_line = true)
        {
            //for (int i = 1; i <= n; i++)
            for (int i = 0; i < n; i++)
            {
                Console.Write(c);
            }
            if (new_line)
                Console.WriteLine();
        }

        static void DrawLine02(int n)
        {
            for (int i = n; i > 0; i--)
            {
                Sharp(i);
            }
        }
        static void Sharp(int n)
        {
            for (int i = n; i > 0; i--)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        static void DrawLine01(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Star(i);
            }

            //for(int i=1; i <= n; i++)
            //{
            //    Star(i);
            //}
        }
        static void Star(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            //for (int i=0; i < n; i++)
            //{
            //    Console.Write("*");
            //}
            //Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //DrawLine01(5);
            //DrawLine02(5);
            //DrawLine03(10);
            splitNumber2(12345);

            /*
            char x = '9';
            int b = x - '0';
            Console.WriteLine(b); //57 - 48 = 9

            Console.WriteLine();

            int n = 3;
            char c = (char)(n + '0');
            Console.WriteLine(c); //3
            */
        }
    }
}
