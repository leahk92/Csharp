using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Car
    {   
        // private Member variable 멤버 변수
        // fields 필드 : 데이터 저장(이름 저장)
        private string name;    // access modifier private
        private int hp;
        private string color;
        //private int maxSpeed; 안 써도 됨, 내부적으로 생김(Auto Implemented Property)
        private int maxSpeed;

        // Read-Only & Write-Only Properties : 읽기나 쓰기만으로 속성 제한

        /*읽기 전용(Read-Only) : Setter 없음 - 일반적인 방법*/
        //public int MaxSpeed { get; } = 10;

        /*쓰기 전용(Write-Only) : Getter 없음
         - 새로운 private 멤버 변수 필요*/
        public int MaxSpeed
        {
            set
            {
                this.maxSpeed = value;
            }
        }

        // Auto Implemented Property
        //public int MaxSpeed {  get; set; }

        // the public property  (Setter, Getter 지우고)
        /*데이터를 보호하기 위해 사용함 (데이터 필드를 공개하지 않고 property 이용)
         - public 데이터 멤버처럼 사용될 수 있지만
         - 실제로는 accessor라고 불리는 메소드를 이용하는 방법*/
        public string Name  //private 멤버 변수 name을 수정
        {    
            get { return this.name; }   //get accessor
            //set { this.name = value; }  //set accessor
            set
            {
                if (value == "")
                    this.name = "Hello World Default Name";
                else
                    this.name = value;
            }
        }
        // Setter
        /*private 멤버 변수에 접근하고 싶을 때
         - 직접 변수를 바꾸는 대신 Setter를 이용 
         - 메소드는 아무것도 반환하지 않고 변수에 변화를 주는 것만 함
         - 설정하고 싶은 조건을 추가할 수 있다
        public void SetName(string name)
        {
            //this.name = name;
            if (name == "")
            {
                this.name = "DefaltName";
            }
            else
            {
                this.name = name;
            }
        }*/

        // Getter
        /*보통 반환 값이 있기 때문에 void형 안됨
         - Car 클래스 밖에서 name을 불러오고 싶을 때
        public string GetName()
        {
            return this.name;
            //return this.name + " suffix";
        }

        public int GetHp()
        {
            return this.hp;
            //return this.hp * this.hp;
        }*/


        // Constructor 생성자  |   Multiple Contructors
        /*public Car()    
        {
            Console.WriteLine("Car was created");
        }*/
        public Car()    // Default Constructor 기본 생성자
        {
            name = "Car";
            //hp = 0;
            hp = 5;
            color = "red";
            maxSpeed = 150;
            Drive(); //메소드 함수 만든거 여기서 쓸 수 있음
        }
        // Partial Specification Constructor
        public Car(string name, int hp = 0)
        {
            this.name = name;
            Console.WriteLine(name + " was created");
            this.hp = hp;
            this.color = "red"; //매개변수에 안 적고 이렇게 적는 방법 > 무효화 불가
            Drive();
        }
        // Full Specification Constructor
        public Car(string name, int hp, string color)
        {
            this.name = name;
            Console.WriteLine(this.name + " was created");
            this.hp = hp;
            this.color = color;
            Drive();
        }
        /*public Car(string name, int hp = 0, string color = "black")
        {
            this.name = name;
            Console.WriteLine(name + " was created");
            this.hp = hp;
            this.color = color;
        }*/


        // Member Method    메소드 만들기
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
            Console.WriteLine(
            "The " + color + " car " + name +
            " has " + hp + " hp");
        }
    }
}
