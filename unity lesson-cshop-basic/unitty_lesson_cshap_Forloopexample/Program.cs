using System;
//Orc 객체를 10명 만들고 Orc 들의 인스턴스는 Orc 타입 배열에 넣어준다
//각 Orc 의 이름은 오크 1 오크2...오크9
//각 오크가 램덤한 isResting 값을 설정해준다 ( true or flase)
// 각 오크가 쉬고있으면 점프시키고 쉬고있지않으면 아무것도 안시킨다
namespace unitty_lesson_cshap_Forloopexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc[] arr_Orc = new Orc[10];
            int lenght = arr_Orc.Length;
            for (int i = 0; i < lenght; i++)
            {
                arr_Orc[i] = new Orc();
                arr_Orc[i].name = $"오크{i}";
            }

        }
    }

    class Orc
    {

        public int age; // 오크의 나이
        public float height; // 오크의 몸무게
        public char genderChar; // 오크의 성별
        public string name; // 오크의 이름
        public bool isResting; //오크가 현재 쉬고 있는가?
        public bool isJump; // 오크가 점프를 했는가?
        public float weight; // 오크의 몸무게


        public void SayAge()
        {
            Console.WriteLine($"나이 : {age}");
        }

        public void Sayheight()
        {
            Console.WriteLine($"키 : {height}");
        }

        public void SayisFemale()
        {
            Console.WriteLine($"성별이무엇? : {genderChar}");
        }

        public void sayisname()
        {
            Console.WriteLine($"오크의 이름 : {name}");
        }
        public void Smash()
        {
            Console.WriteLine($"{name} (이)가 휘둘렀다!");
        }
        public void jump()
        {
            Console.WriteLine($"{name} (이)가 점프했다!");
        }


    }
}
