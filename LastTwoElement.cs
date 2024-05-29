using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*프로그래머스 문제 Day6 조건문, 반복문 - 마지막 두 원소
             * 마지막 원소가 그전 원소보다 크면
             * 마지막 원소에서 그전 원소를 뺀 값을,
             * 
             * 마지막 원소가 그전 원소보다 크지 않다면
             * 마지막 원소를 두 배한 값을 추가*/
           
            //수정
            int[] num_list = new int[] { 5, 2, 1, 7, 5 }; 

            int[] answer = new int[num_list.Length + 1];

            for (int i = 0; i < num_list.Length; i++)
                answer[i] = num_list[i];

            if (answer[num_list.Length - 1] > answer[num_list.Length - 2])
                answer[num_list.Length] = (answer[num_list.Length - 1] - answer[num_list.Length - 2]);
            else answer[num_list.Length] = (answer[num_list.Length - 1] * 2);

            foreach (int i in answer) { Console.WriteLine(i); }

            /*
            int pre = 0;
            int n = 0;
            
            for (int i = 1; i < num_list.Length; i++)
            {
                pre = num_list[i-1];
                n = num_list[i];
            }

            int newElement;
            if (n > pre) newElement = (n - pre);
            else newElement = (n * 2);

            int[] answer = new int[num_list.Length + 1];
            

            for(int i = 0; i < num_list.Length; i++)
            {
                answer[i] = num_list[i];
            }
            answer[answer.Length - 1] = newElement;
            foreach (int i in answer) { Console.WriteLine(i); }
            */

        }
    }
}
