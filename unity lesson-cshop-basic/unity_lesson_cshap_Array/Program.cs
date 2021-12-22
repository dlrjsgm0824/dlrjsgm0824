using System;

namespace unity_lesson_cshap_Array
{
    class Program
    {
        static int[] arr_TestInt = new int[5];
        static float[] arr_TestFloat = new float[3];
        static float[] arr_TestFloat2 = { 1.0f, 2.0f, 3.0f, 4.0f };
        static string[] arr_TestSting = new string[3];



        static void Main(string[] args)
        {
            // array
            // 형태 : 자료형[]
            // 자료형이 정적으로 나열되어있는 형태. 한번 데이터 크기를 정하면 바굴 수 없다.
            arr_TestInt[0] = 5;
            arr_TestInt[1] = 4;
            arr_TestInt[2] = 3;
            arr_TestInt[3] = 2;
            arr_TestInt[4] = 1;

            Console.WriteLine(arr_TestInt[0]);
            Console.WriteLine(arr_TestInt[1]);
            Console.WriteLine(arr_TestInt[2]);
            Console.WriteLine(arr_TestInt[3]);
            Console.WriteLine(arr_TestInt[4]);

            arr_TestFloat[0] = 2.0f;
            arr_TestFloat[1] = 4.0f;
            arr_TestFloat[2] = 6.0f;

            Console.WriteLine(arr_TestFloat[0]);
            Console.WriteLine(arr_TestFloat[1]);
            Console.WriteLine(arr_TestFloat[2]);

            arr_TestSting[0] =
            arr_TestSting[1] =
            arr_TestSting[2] =

           








        }
    }
}
