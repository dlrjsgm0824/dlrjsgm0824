using System;
using System.Collections.Generic;
using System.Text;

namespace unitty_lesson_Csharp_classinheritance
{
    // 함수 이벤트 인덱스 속성 만 멤버로 가질 수 있고 
    // 각 멤버는 기본적으로 접근 권한자가  public
    // 멤버들은 선언만 할 뿐 정의하지 않는다 (어떤 기능에 대해 이름만 명시하고 내용 구현은 안함)
    // 클래스랑 다르게 다중상속이 가능
    // 클래스의 추상화를 할때 함수들이 같은 이름이 필요한 경우 집함ㅂ으로 명시하고 따로 관리가 가능하다
    interface iTwoLeggedWalker
    {
        void TwoLeggedWalk();

    }   
}
