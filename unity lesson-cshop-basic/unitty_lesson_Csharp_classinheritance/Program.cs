using System;
using System.Collections.Generic;

namespace unitty_lesson_Csharp_classinheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            creatrue creatrue = new creatrue();
            creatrue.breath();

            Human human = new Human();
            human.breath();

            Dog dog = new Dog();
            dog.breath();

       
        // 황인 흑인 백인 두발로 걷게하고 싶다
        //==============================================

        // 그냥 객채 멤버 함수 호출
            yelloman yelloman1 = new yelloman();
            blackman blackman1 = new blackman();
            Whiteman whiteman1 = new Whiteman();

            yelloman1.TwoLeggedWalk();
            blackman1.TwoLeggedWalk();
            whiteman1.TwoLeggedWalk();

            // 인터페이스 활용 
            iTwoLeggedWalker yeiioman_iTwoLeggedWalker = yelloman1;
            iTwoLeggedWalker blackman_iTwoLeggedWalker = blackman1;
            iTwoLeggedWalker whiteman_iTwoLeggedWalker = whiteman1;

            List<iTwoLeggedWalker> list_TwoLeggedWalker = new List<iTwoLeggedWalker>();
            list_TwoLeggedWalker.Add(yeiioman_iTwoLeggedWalker);
            list_TwoLeggedWalker.Add(blackman_iTwoLeggedWalker);
            list_TwoLeggedWalker.Add(whiteman_iTwoLeggedWalker);

            foreach (iTwoLeggedWalker twoLeggedWalker in list_TwoLeggedWalker)
            {
                twoLeggedWalker.TwoLeggedWalk();
            }
            


                                              //solid 원칙 

                        // 객체지향 프로그래밍을 할때 반드시 지켜주어야할 5가지 원칙


            // 1. SRP(single Responblity Principle  단일 책임 원칙 ) : 한 클래스는  하나의 책임만 가져야 함. 
            // 여러가지 개념이나 가능을 한 클래스에 다넣으면 수정이 불편하고 각 클래스에 대한 확장성, 가독서이 떨어진다

            // 2. OCP( Open Close principle 개방 폐쇄의 원칙)
            // 제사용 가능하고 고나리하기 편한 코드를 만들기 위한 원칙.
            //컴포넌트, 클래스, 모듈, 함수의 확장에는 열려있고 변경에는 닫혀있어야 한다.
            // -> 레고 블록을 처음에 다양하게 설께해서, 레고끼리 조립 호환성을 높게 설정해야 한다
            // 조립 도중 레고블록이 안맞는다 헤서 자르거나 녹이는 드의 행동은 안된다

            // 3. LSP (The LIskov subsititution principle , 리스코프 치환법칙)
            // 히위타입은 기반타입으로 언제든지 변경이 가능해야 한다
            // 기반인 부모클래스로부터 상속받은 하위인 자식클래스가 함수를 오버라이드 해서 사용할 경우, 언제든지 오버라이드로 된 함수를
            // 지워서 기반인 부모의 함수로 교채되어 사용할 수 있어야 한다(교체 후에도 코드가 문제없이 동작이 가능해야 한다는 뜻)
            // 리스코프 치환법칙을 지키기 위해서는 특히 다음 4가지를 기키면 된다
              // 1 두객체가 똑같은일을 수행한다면 -> 클래스는 하나로 만들고 구분지을 수 있는 변수를 만들어야 한다
              // 2 이름이 같고 동작은 비슷하나 약간의 차이가 있다면 -> 인터페이스를 구분해서 공통으로 상속한다
              // 3 같은 기능이 없다면 각각 별개로 클래스 구현
              // 4 추가적인 기능을 부여하려면 상속을 이용해야한다

            //4. ISP(interface Sergregration principle., 인터페이스 분리 원칙)
            // 사용 하지 않을 인터패이스는 구현하면 안되고
            // 하나의 일반적인 인터페이스보다 여러개의 구체적인 인터페이스를 추구
            // ipointerEvent 라는 인터페이스 보다 ipointerDownEvent ,ipointerupEvent
            //ipoiterclickEvent 등으로 세분화 

            // 5. DIP (Dependency Inversion principle, 의존성 역전의 법칙)
            // "자신보다 변하기 쉬운것에 의존하지 마라"

        }
    }
}
