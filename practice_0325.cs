using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class practice_0325
    {
        
        static void Main(string[] args) // 대소문자 변경 다른방법
        {
            string s = "Hello World!";
            StringBuilder sb = new StringBuilder();

            foreach(char ss in s)
            {
                char new_s = ss;
                if (char.IsUpper(new_s))
                {
                    new_s = char.ToLower(new_s);
                }
                else if (char.IsLower(new_s))
                {
                    new_s = char.ToUpper(new_s);
                }
                sb.Append(new_s);
            }
            Console.WriteLine(sb.ToString());

        }
        static void Main5(string[] args) // 시저암호 다른방법으로
        {
            string plain_txt = "Hello World!";
            string result = string.Empty;

            for(int i = 0; i < plain_txt.Length; i++)
            {
                char new_c = plain_txt[i];
                if (char.IsLetter(new_c))
                {
                    new_c += (char)3;
                    if (!char.IsLetter(new_c))
                    {
                        new_c -= (char)26;
                    }
                }
                result += new_c;
            }
            Console.WriteLine(result);
        }
        static void Main4(string[] args) // 대소문자 변경
        {
            string s = "Hello World!";
            string result = string.Empty;

            for(int i =0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsUpper(c))
                {
                    c = char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    c = char.ToUpper(c);
                }
                result += c;
            }
            Console.WriteLine(result);
        }

        static void Main3(string[] args) // 시저암호
        {
            string plain_text = "Hello World!";
            StringBuilder sb = new StringBuilder();
            
            foreach(char c in plain_text)
            {
                char new_c = c;
                if (char.IsLetter(c))
                {
                    new_c += (char)3;
                    if (!char.IsLetter(new_c))
                    {
                        new_c -= (char)26;
                    }
                }
                sb.Append(new_c);
            }
            //Console.WriteLine(sb);
            Console.WriteLine(sb.ToString());

        }

        static void Main2(string[] args) // char.IsUpper() 등
        {   // char.IsUpper()
            char c1 = 'A';
            bool Upper1 = char.IsUpper(c1);
            Console.WriteLine(Upper1);

            char c2 = 'a';
            bool Upper2 = char.IsUpper(c2);
            Console.WriteLine(Upper2);

            // char.IsLower()
            char c3 = 'a';
            bool Lower1 = char.IsLower(c3);
            Console.WriteLine(Lower1);

            char c4 = 'A';
            bool Lower2 = char.IsLower(c4);
            Console.WriteLine(Lower2);

            // char.IsLetter()
            char c5 = 'a';
            bool Letter1 = char.IsLetter(c5);
            Console.WriteLine(Letter1);

            char c6 = '5';
            bool Letter2 = char.IsLetter(c6);
            Console.WriteLine(Letter2);
        }

        static void Main1(string[] args) //파이썬 월 달력 - Ch09반복문22p
        {
            Console.Write("월의 날짜 수 (1-31) ? : ");
            int months = int.Parse(Console.ReadLine());

            Console.Write("월의 첫 번째 요일 (일:0 - 토:6) ? : ");
            int startDay = int.Parse(Console.ReadLine()); //4 - 목요일

            Console.WriteLine("일 월 화 수 목 금 토");

            //첫 번째 주의 1일 이전 요일 출력 (빈칸)
            for (int i = 0; i < startDay; i++)
            {
                Console.Write("   ");
            }

            int day = startDay;//ex) 4 넣음
            //1 ~ months까지의 날짜 출력
            for (int n = 1; n <= months; n++)
            {
                if (day % 7 == 0)
                {
                    day = 0;
                    Console.WriteLine();
                }
                Console.Write("{0,2} ",n);
                //Console.Write($"{n,2} ");
                day += 1;
            }

        }
    }
}
