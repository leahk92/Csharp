using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Car
    {   // Member variable 멤버 변수
        // 필드 : 데이터 저장(이름 저장)
        private string name;
        private int hp;
        private string color;

        // Constructor 생성자 | Multiple Contructors
        /*public Car()    
        {
            Console.WriteLine("Car was created");
        }*/
        public Car()    // Default Constructor 기본 생성자
        {
            this.name = "Car";
            this.hp = 0;
            this.color = "red";
        }

        // Partial Specification Constructor
        public Car(string name, int hp = 0)
        {
            this.name = name;
            Console.WriteLine(name + " was created");
            this.hp = hp;
            this.color = "red"; //매개변수에 안 적고 이렇게 적는 방법 - 무효화 불가
        }

        /*public Car(string name, int hp = 0, string color = "black")
        {
            this.name = name;
            Console.WriteLine(name + " was created");
            this.hp = hp;
            this.color = color;
        }*/
        // Full Specification Constructor
        public Car(string name, int hp, string color)
        {
            this.name = name;
            Console.WriteLine(name + " was created");
            this.hp = hp;
            this.color = color;
        }

        // Member Method
        // 메소드 만들기
        /*
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }*/
        public void Drive()
        {
            Console.WriteLine(name + " is driving");
        }
        public void Stop()
        {
            Console.WriteLine(name + " stopped!");
        }
        public void Details()
        {
            Console.WriteLine("The " + color + " car " + name + " has " + hp + " hp");
        }
    }
}
