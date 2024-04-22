using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args) // Memebers 클래스
        {
            Members member1 = new Members();
            member1.Introducing(true);
            Console.ReadKey();
        }


        static void Main1(string[] args)
        {
            /* the public property */
            Car myCar = new Car();
            //Console.WriteLine(myCar.Name);
            myCar.Name = "MyAudiA3";
            myCar.Details();

            /* Auto Implemented Property */
            //myCar.MaxSpeed = 180;
            //Console.WriteLine("Maxspeed is " + myCar.MaxSpeed);

            /* Read-Only Property */
            Console.WriteLine("Maxspeed is " + myCar.MaxSpeed);

            /* Write-Only Property */
            //myCar.MaxSpeed = 10;
            //Console.WriteLine("Maxspeed is ");
        }


        static void Main0(string[] args)
        {
            // 섹션 6: Object Oriented Programming (OOP)

            /*생성자를 호출하여 개체를 초기화하고 레퍼런스를 객체에 반환, (변수)audi에 저장됨
             - audi : Car 클래스를 참조하는 저장소
             - new : 객체를 위해 메모리를 힙에 할당
             - 괄호() : 생성자를 부르는 역할   */
            //Car audi = new Car();
            Car audi = new Car("Audi A4", 250, "blue");
            Car bmw = new Car("BMW M5", 350);

            Car myCar = new Car();  // Default Constructor 만든 후
            myCar.Details();

            /*
            myCar.SetName("Default Red Car with special name"); // Setter
            myCar.Details();
            myCar.SetName("");
            myCar.Details();

            Console.WriteLine(myCar.GetName()); // Getter
            myCar.SetName("my best car");
            Console.WriteLine("My car name is: " + myCar.GetName());

            Console.WriteLine(myCar.GetHp());
            */

            /* 함수 호출 방법 : 변수명.메소드(); */
            audi.Drive(); 
            audi.Details();
            
            bmw.Drive();
            bmw.Details();

            Console.WriteLine("press 1 to stop to car!");
            //int input = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            if (input == "1")
            {
                audi.Stop();
            }
            else
                Console.WriteLine("Car drive indefinitely");
        }
    }
}
