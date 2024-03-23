using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_0323_Method
{   //클래스
    class Calc 
    {
        public static int Plus(int a, int b) //메소드 선언
        {
            Console.WriteLine(a + " " + b);
            int res = a + b;
            return res;
        }
    }

    internal class Program
    {
        static void PrintProfile(string name, string phone) //메소드 선언
        {
            if (name == "" || name == null)
                return;
            Console.WriteLine(name + " " + phone);
        }
        static int Minus(int a, int b) //메소드 선언
        {
            return a - b;
        }

        // **메인함수**
        static void Main(string[] args)
        {
            //메소드 호출
            int s = Calc.Plus(1, 2);
            Console.WriteLine(s);

            //한 번에 적기
            Console.WriteLine(Calc.Plus(1, 2));

            Console.WriteLine(Minus(3, 4));

            //
            string n = null;
            PrintProfile("홍길동", "010-1234-5678");
            PrintProfile("", "010-1234-5678");
            PrintProfile(n, "010-1234-5678");
        }
    }
}
