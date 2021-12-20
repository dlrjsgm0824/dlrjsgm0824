using System;

namespace unityclass_cshap_Variable_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            // 점연산자 
            // 클래스의 맴버에 접근할때 사용
            //객체의 멤버의 접글한때도 사용

            person1.name = "김아무개";
            person1.age = 123;
            person1.height = 224.31f;
            person1.isFemale = false;
    }

    class Person
    {
        // 접근제한자 : 자료혈 앞에 붙혀준다
        // public private protected
        // public 다른 클래스에서 접속 가능
        // private 다른 클래스는 접속 불가
        // protected 상속자만 접속 가능

        public int age;
        public float height;
        public bool isfemale; // 여자인가?
        public char genderChar; // 성별 문자
        public string name; // 이름
        public void sayAllinfo()
        {
            //consol.Writeline($"나이 : 
        }
        public void SayAge()
        {
            Console.WriteLine($"나이 : {age}");
        }
        public void sayHeight()
        {
            Console.WriteLine($"키 : {height}");
        }

        public void SayisFemaile()
        {
            Console.WriteLine($"여자인가? : {isfemale}");
        }

        public void SaygenderChar()
        {
            Console.WriteLine($"성별이 무엇인가? : {genderChar}");
        }






    }
}



