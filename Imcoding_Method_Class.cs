using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Imcoding_Method_Class
    {

        public class Person2 //클래스 - 데이터와 메서드를 하나로 묶음
        {   
            //데이터들 필드
            public int height;
            public int weight;

            //메서드 (=함수)
            public void PrintHeight()
            {
                Console.WriteLine("키 : " + height);
            }
            public void PrintWeight()
            {
                Console.WriteLine("몸무게 : " + weight);
            }
        }

        public class Person 
        {
            public void PrintHello() //메소드
            {
                Console.WriteLine("Hello");
                Console.WriteLine("World");
            }
            public void PrintHello2(string str) //매개변수
            {
                Console.WriteLine(str);
                Console.WriteLine("Hello");
                Console.WriteLine("World\n");
            }

            public int ReturnTen() //반환
            {
               return 10; //함수를 호출한 자리에 반환값이 남는다.
            }
            public int Sum(int a, int b) //매개변수
            {
                return a + b;
            }
        }
        
        static void Main(string[] args)
        {
            // 호출
            // p 객체 변수
            Person p = new Person();

            p.PrintHello();

            p.PrintHello2("\n안녕하세요");

            int result;
            result = p.ReturnTen();
            Console.WriteLine(result + "\n");

            result = p.Sum(10, 25);
            Console.WriteLine(result + "\n");

        }
    }
}
