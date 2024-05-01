using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Class2_calendar
    {
        static bool is_yoon(int y) // 윤년 체크
        {
            return ( y%4 ==0 && y%10 != 0) || y%400 ==0;
        }
        static int day_1_1(int y) // 해당 년도의 1월1일이 무슨 요일에서 시작하는지
        {
            int wd = 1 + (y - 1900);
            for(int i = 1904; i<y; i += 4)
            {
                if (is_yoon(i)) wd++;
            }
            return wd % 7;
        }
        
        static int[] m_number = { // 월별 일수 - 해당 월의 앞 월까지 일수 더해서 계산하려고
            0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
        };
        static int day_m_1(int m) // 해당 월의 첫째 날이 무슨 요일에 시작하는지
        {
            int wd = 0;
            for(int i=1; i<m; i++)
            {
                wd += m_number[i];
            }
            return wd % 7;
        }

        static void calendar(int y, int m) // 달력 만들기
        {
            bool yoon = is_yoon(y);
            int wd = day_1_1(y) + day_m_1(m);

            if (m > 2 && yoon) wd++;
            wd %= 7;

            int w = 0;
            int days = m_number[m];
            if(m == 2 && yoon) days++;

            string[,] cal = new string[6, 7];
            for(int i = 1; i <= days; i++)
            {
                cal[w, wd] = i.ToString();
                if(++wd > 6)
                {
                    wd = 0;
                    w++;
                }
            }

            Console.WriteLine(" 일 월 화 수 목 금 토");
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    Console.Write($"cal[i,j],3");
                }
                Console.WriteLine();
            }
        }
    }
}
