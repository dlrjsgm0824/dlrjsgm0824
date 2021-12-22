using System;

namespace Unity_lesson_Cshap_operator
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 14;
            int b = 5;
            int c;

            // 산술연산
            // 덧샘 뺼셈 나눗셈 곱셈 나머지셈
            //=================================================
            c = a + b;
            c = FunctionsForOperators.Sum(a, b);
            Console.WriteLine(c);

            // 뺼셈
            c = a - b;
            Console.WriteLine(c);

            // 니눗셈
            c = a / b;
            Console.WriteLine(c);
            // 곱셈
            c = a * b;
            Console.WriteLine(c);
            // 나머지셈
            c = a % b;
            Console.WriteLine(c);

            Console.WriteLine($"Last C Value : {c}");
            // 증가연산자 : 1일 증가시키는 연산자
            c++; // c = c+1
            // 감소연산자 : 1을 감소시키는 연산자
            c--; // c = c - 1;

            // 관계연산 
            // 결과값은 논리형
            //=================================================
            Console.WriteLine(a == b);
            // 같음비교 

            //다름비교
            Console.WriteLine(a != b);
            //큼
            Console.WriteLine(a > b);
            // 크거나 같음
            Console.WriteLine(a >= b);
            // 작음 
            Console.WriteLine(a < b);



            // 대입연산
            // 오름쪽 변수의 값을왼쪽 변수에 ( 그냥, 더해서 , 곱해서, 나누어서, 나머지를 ) 대입한다
            // 일반적인 대입연산
            Console.WriteLine($"Last C Value : {c}");
            c = a; //  c = c + a;
            // 더해서 대입
            c += a; // c = + a;
            // 뺴서 대입
            c -= a; // c = a - a;
            // 나누어서 대입
            c /= a; // c = c / a;
                    // 곱해서 대입


            // 논리연산
            // 피연산자(들) 을 비교해서 연산 수행.
            // ==================================================
            // OR
            bool A = true;
            bool B = false;
            // A 와 B 둘중에 하나라도
            Console.WriteLine(A | B);
            // AND
            // A 와 B 모두 True 이면 Ture 반환 , 나머지 경우에는 False 반환 
            Console.WriteLine(A & B);
            //  NOT
            // A 의 값을 반전 . Ture 이면 Flase 로 반전시킴
            Console.WriteLine(!A);
            // XOR 
            // A 와 B 둘중에 하나만 True 일떄 Ture 반환 , 나머짖 경우에는 Flase 로 반환 
            Console.WriteLine(A ^ B);

            // 조건부 논리연산 
            // 연산의 필요성에 대해서 판단을 한 후에 연산이 필요없으면 정해진 결과를 반환함.
            // 연산이 필요하면 연산후의 결과를 반환함.
            // 조건부 OR 연산 
            // 연산이 필요할때만 연산을 하기 떄문에 연산속도가 조금이나마 빠르다.

            // 조건부 AND 연산
            Console.WriteLine(A && B);
            // Ex
            // IF 문의 조건을 제시하는데 시간이 걸림
            // IF  문이 수백개다 -> 연산하는데 시간이 많이걸려서 랙이 걸림

            // 비트 연산 
            // 비트 연산을 하는 이유 : 데이터를 효율적으로 관리하기 위함.
            // or 
            Console.WriteLine(a | b);
            // and
            Console.WriteLine(a & b);
            //XOR
            Console.WriteLine(a ^ b);
            // not
            Console.WriteLine(~a);
            int howManyBitsYouWantToShift = 3;
            // shift - left
            Console.WriteLine(a << howManyBitsYouWantToShift);
            //shift - right
            Console.WriteLine(a >> howManyBitsYouWantToShift);

            //FSM ( Finite State Machine , 유한 상태 머신 )
            // 클래스의 상태에 따라 다른동작이나 조건을 특정해주기 위해 사용함.
            // ex ) 플레이어의 상태를 FSM 에 따라 나누고 , 귀환이 가능한 조건을 FSM 의 특정상태
            // ( 피격중 , 공격중 )등등 에 구분해놓는다.
            // 그래서 사용자가 귀환을 눌렀는데 저런 특정상태이면 
            // 귀환이 불가능하도록 코딩을 해놓는다

            
        }

    }
        [Flags] // Bit- Shift 연산자의 예시
        public enum e_FSM
        { 아무것도안하는상태 = 0,
          피격당하는상태 = 1 <<0,
          공격중인상태 = 1 <<1,
          점프중인상태 = 1<< 2,
          달리기중인상태 = 1<< 3,
        }


}
