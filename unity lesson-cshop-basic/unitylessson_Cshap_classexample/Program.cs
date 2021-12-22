using System;

namespace unitylessson_Cshap_classexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orc1 = new Orc();

            orc1.name = "상급오크";
            orc1.age = 140;
            orc1.height = 240.2f;
            orc1.weight = 200;
            orc1.isResting = false;
            orc1.genderChar = '남';
            
           
            

            Orc orc2 = new Orc();

            orc2.name = "하급오크";
            orc2.age = 60;
            orc2.height = 140.4f;
            orc2.weight = 120;
            orc2.genderChar = '여';
            orc2.isResting = true;

            orc1.jump();
            orc2.Smash();
            orc1.jump();
            orc2.Smash();

            if (orc1.isResting) 
            {
                orc1.jump();
                orc1.Smash();
            }
            else
            {
                Console.WriteLine($"{orc1.name} (이)가 바쁘다");
            }

            if (orc2.isResting) 
            {
                orc2.jump();
                orc2.Smash();
            }
            else
            {
                Console.WriteLine($"{orc2.name} (이)가 바쁘다");
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
