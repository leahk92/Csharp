using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Loop_0327
    {
        static void Main5(string[] args) //5번
        {
            for(int i = 1; i <=8; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            int m, k;
            k = 6;

            for(int j=1; j<=6; j++)
            {
                Console.Write("*");
                for(m=k; m>=1; m--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }

            for (int i = 1; i <= 8; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        static void Main4(string[] args) //4번
        {
            for(int i=1; i <= 6; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        static void Main3(string[] args) //3번
        {
            for(int i = 6; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i}");
                    //Console.Write("{0}",i);
                }
                Console.WriteLine();
            }
        }
        static void Main2(string[] args) //2번
        {//1번을 while문으로

        }
        static void Main1(string[] args) //1번
        {/*
            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }*/

            // 파이썬에서 print("* "*10) 기능
            for (int i = 1; i <= 5; i++)
            {
                //한 문자씩
                Console.WriteLine(new string('*', 10));

                //문자열 (띄어쓰기 포함)
                // new string[11]??
                //Console.WriteLine(string.Join("* ", new string[11]));

            }



        }
    }
}
