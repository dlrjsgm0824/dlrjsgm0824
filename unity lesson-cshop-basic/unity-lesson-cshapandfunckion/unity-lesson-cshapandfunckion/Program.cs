using System;

namespace unity_lesson_cshapandfunckion
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        // CamelCase
        // 클레스이름 , function namespace 등은 대문자로 시작한다
        // 변수는 소문자로 시작핝다
        //단어가 바뀔경우 첫 문자는 대문자로 한다
        //SayAge() SA() SH() xxxxx
        // 이름을 보았을떄 어떤 기능 목적인지 알 수잇도록 한다
        // 애매한부분은 주석을 달도록 한다


        class person
        {
           int age; // 나이
           float height; // 키
           bool isfemail; // 여자인가?
           char genderChar; // 성별 문자
           string name; // 이름
            void sayAllinfo()
            {
                //consol.Writeline($"나이 : 
            }
            void SayAge()
            {
                Console.WriteLine( $"나이 : {age}");
            }
            void sayHeight()
            {
                Console.WriteLine($"키 : {height}");
            }

            void Sayisfemail()
            {
                Console.WriteLine($"여자인가? : {isfemail}");
            }

            void SaygenderChar()
            {
                Console.WriteLine($"성별이 무엇인가? : {genderChar}");
            }


        }


    }
}
