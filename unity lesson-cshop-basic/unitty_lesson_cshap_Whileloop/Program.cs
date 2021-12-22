using System;

namespace unitty_lesson_cshap_Whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //형태
            //조건이 참이면 반복할 내용
            //무한루프
            // While 루프는 조건이 참이면 무한으로 반복되기때문에 조건이 거짓으로 바뀌는 즉. 루프를 
            //탈출할수 있는 조건이 필요하다
            // () 안의 조건이거짓이되거나 while 루프중간에 break 라는 키워드로 끊어준다
            string[] arr_PersonName = new string[3];
            arr_PersonName[0] = "김아무개";
            arr_PersonName[0] = "이아무개";
            arr_PersonName[0] = "박아무개";

            int count = 0; // 반복문의 반복횟수를 세는 변수
            int lenght = arr_PersonName.Length;

            // () 안의 조건을 거짓을 만드는 예시
            // 되도록 이런 형태 활용
            // while 문의 조건은 항상 거짓이되는 경우가 있는 조건을 사용해야한다.

            while (count <lenght)
            {
                Console.WriteLine(arr_PersonName[count]);
                count++;
            }

            count = 0;
            // 중간에 break 로 귾는 예시 (실제로는 이렇게 쓰면 안됨)
            while (true)
            {
                if (count <lenght)
                {
                    Console.WriteLine(arr_PersonName[count]);
                }

                else
                {
                    break;
                }
                count++;
            }

        }
    }
}
