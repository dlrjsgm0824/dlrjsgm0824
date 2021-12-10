//키워드 : using
//무언가를 사용하겠다 라고 선언하는 키워드

//using 을 언제쓰나?
//특징 네임스페이스를 가져다 쓸때

// 1 만약 어떰 사람이 이 프로글매에 잇는 내용을 가져다 쓸때 스크립트 최상단에 프로그램이름을 선언
// 2 우선수위가 차순위인 함수 호출

// unity engine.physics에 raycast() 라는 함수가있음.
//unity physics에도 raycast() 라는 함수가 있다
//unity engine.physics 가 우선순위이기 때문에

//using unity engine.physics;
//unity unity.physisc;
//이렇게 둘다 선언을 횃을때 
//raycast() 라는 함수를호출햇을때
//unityengime.physiscs.raycast()가 호출됨 
//근데 만약 일반적으로 raycasst() 를 호출햇는데 unity.phisics.raycast를 호출하고 싶으면
//using Ratycast = unityLesson-shop-program

//객체화를 한 후에 메모리에 할당을 하면 그 객체를 인스턴스라고하고 그 과정을 인스턴스화라한다


using System;

//키워드 : namespace
//  클레스 간에 멤버이름 충돌을 방지함. 

namespace unity_lesson_cshop_program
{
    //c# 에서만 특별하게 main 함수가 class program 에 있음
    class Program
    {
        //main함수
        //모든실행파일 (exe) 을 실행하면
        //하드디스크에있던 프로젝트를 램으로 복제후 실행되는 함수
        
        // static : 메모리할당 불가
        // daynamic: 메모리 할당 가능
        // static(정적) 반대로 daynamic(동적)

        //static class: 해당 클래스로 객체를 생성하고 메모리에 할당하는것이 금지된다
        //ststic main : 이 멤버함수를 포함한 클래스가 여 러개 객체화 되어 있고 메모리에 할당되도록 

        // void : 공허 
        // 뜻 반환값이 없다. 라는 자료형
        //함수의 기본 형태  : 입력기능 수행, 출력 
        //void : 출력이없다

        //main : 함수의이름
        // args : arguments 의 줄임말
        //함수의 이름뒤에 괄호열고 '자료형' , '이름' 괄호닫고
        // 이함수의 입력 인자를 arguments 라고함

        // console 
        // 스크립트 최상단의 using 으로 선언한 system 이라는 namespace 에 포함된 클래스다
      
        // WriteLine() 
        //콘솔창에 괄호안의내용을 써주는 함수

        //.연산자
        //namespace 에서 안에잇는 함수에 접근할때 namespace.class
        //class 안의 함수 (function)에 접근할때 class.function

        //wiriteline 함수 괄호 안의 내용 : writeline함수의 입력 변수
        //paramenter라고함

       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 현재 writeline 함수는 입력으로 string 형태를 받고있고
            //string 은 문자연을 뜻ㅎ마 그리고 문자열은 ""형태로 표기.
        }
    }
}
