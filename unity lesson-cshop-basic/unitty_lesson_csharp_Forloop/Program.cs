using System;

namespace unitty_lesson_csharp_Forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            // for 
            //형태
            // 인덱스용 변수 선언 , 초기화. for 문이 반복될 조건 , for문 내용이 끝난 후 마지막에 실행할 구문
            //{
            // for 문이 참일때 반복될 실행될 조건
            //
            string[] arr_PersonName = new string[6];
            arr_PersonName[0] = "김아무개";
            arr_PersonName[1] = "이아무개";
            arr_PersonName[2] = "김아무개";
            arr_PersonName[3] = "최아무개";
            arr_PersonName[4] = "이아무개";
            arr_PersonName[5] = "김아무개";

            int length = arr_PersonName.Length;
            // for 문을 배열길이만큼 돌리면서 if 문으로 확인후 출력
            for (int i = 0; i < length; i++)
            {
                if (arr_PersonName[i] == "김아무개")
                {
                    Console.WriteLine(arr_PersonName[i]);
                }
            }

            // 김아무개씨가 2n(n은 양의정수)마다 있는 규칙을이용해서
            // for 문의 인덱스를 2씩 증가시키는 예시
            for (int i = 0; i < length; i+=2)
            {
                Console.WriteLine(arr_PersonName[i]);
            }

        }
    }
}
