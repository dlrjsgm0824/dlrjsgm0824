using System;
using System.Collections.Generic;
using System.Text;

namespace unitty_lesson_Csharp_classinheritance
{
    class creatrue
    {
        public string DNA;
        public int lifetime;
        public float weight;
        // 함수 오버라이드 (OVERRIDE)
        // 함수를 재정의 하는 기능
        // VIRTUAL 키워드: 해당함수를 오버라이딩 가능하도록 해준다.
        // 부모 클래스의 함수라고 virtual 을 전부붙이는게 아니라 
        // 자식클래스의 함수를 재정의할때만 virtual 키워드를 붙여준다.

        virtual public void breath()
        {
            lifetime++;
        }
            

    }
}
