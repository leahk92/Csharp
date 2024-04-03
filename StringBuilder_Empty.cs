using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder
            Console.Write("문자 입력: ");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            foreach (char c in str)
            {
                char c2 = c;
                if (char.IsUpper(c))
                {
                    c2 = char.ToLower(c);
                }
                else if (char.IsLower(c))
                {
                    c2 = char.ToUpper(c);
                }
                sb.Append(c2);
            }
            Console.WriteLine(sb);


            // string.Empty
            Console.Write("문자 입력: ");
            string str2 = Console.ReadLine();
            string result = string.Empty;
            
            for (int i = 0; i < str2.Length; i++)
            {
                char cc = str2[i];
                if (char.IsUpper(cc))
                {
                    cc = char.ToLower(cc);
                }
                else if (char.IsLower(cc))
                {
                    cc = char.ToUpper(cc);
                }
                result += cc; //문자열 뒤에 문자를 붙임
            }
            Console.WriteLine(result);
          
        }
    }
}
