using System;
// enum? (enumerated type) 열거형.
//eunm은 겹치지 않는것이 전제이다
enum e_PlayerState
{
     IDlE, //...00000000
     ATTACK, //...00000001
     JUMP, // ...00000010
     WALK, // ...000000101
     RUN, // ...000000100
     DASH, // ...000000101
     HOME // ...00000110
}
[Flags]
enum e_platerStateFlags
{
    IDLE = 0,      //...00000000
    ATTACK = 1<< 0,//...00000001
    JUMP = 1 << 1, //...00000010
    WALK = 1 << 2, //...00000101
    RUN = 1 <<  3, //...00000100
    DASH = 1 << 4, //...00000101
    HOME = 1 << 5, //...00000110
    ATTACK_JUMP = ATTACK|JUMP // //  ... 00000011
}



namespace unitty_lesson_Csharp_Enum
{
    class Program
    {
        static public bool doAttack;
        static public bool doJump;
        static public bool doWalk;
        static public bool doRun;
        static public bool doDash;
        static public bool doHome;

        static public e_PlayerState createMotion = e_PlayerState.JUMP;

        static void Main(string[] args)
        {
            e_platerStateFlags state = e_platerStateFlags.IDLE;

            //  if (state == e_platerStateFlags.IDLE)
            //      {
            //      //Switch - Case 분기문 (조건 (참 / 거짓이 아닌 다양한 타입에 사용 가능))
            //      switch (switch_on)
            //      {
            //   case 조건1;
            //     brake;
            //   case 조건 2
            //     brake;
            //   case 조건 3
            //     brake;
            //     default:
            // 어느 경우에도 해당되지 않는 경우

            Console.WriteLine("검색할 캐릭터의 이름을 입력하십시오");
            string name = Console.ReadLine();
            switch (name)
            {
                case "철수":
                 Console.WriteLine("내이른은 철수 NPC 플레이어 입니다");
                    break;
                case "영희":
                    Console.WriteLine("내이름은 영희 NPC 플레이어 입니다");
                    break;
                default:
                    Console.WriteLine($"내이름은 {name},플레이어입니다");
                    break;
            }

            Console.WriteLine($"전사를생성합니다. 캐릭터 이름을 입력해주세요");
            Warrior warrior1 = new Warrior();
            warrior1.name = Console.ReadLine();

            if (doAttack)
            {
                warrior1.Attack();
            }
            else if (doJump)
            {
                warrior1.Jump();
            }
            else if (doWalk)
            {
                warrior1.Walk();
            }
            else if (doDash)
            {
                warrior1.Dash();
            }
            else if (doHome)
            {
            }

            // switch-case         
            switch (createMotion)
            {
                case e_PlayerState.IDlE:
                    // do noting
                    break;
                case e_PlayerState.ATTACK:
                    warrior1.Attack();
                    break;
                case e_PlayerState.JUMP:
                    warrior1.Jump();
                    break;
                case e_PlayerState.WALK:
                    warrior1.Walk();
                    break;
                case e_PlayerState.RUN:
                    warrior1.Run();
                    break;
                case e_PlayerState.DASH:
                    warrior1.Dash();
                    break;
                case e_PlayerState.HOME:
                    warrior1.Home();
                    break;
                default:
                    break;
            }

            // 동작 명령
            string motioninput = Console.ReadLine();
            e_PlayerState motion = (e_PlayerState)Enum.Parse(typeof(e_PlayerState), motioninput);
            switch (motion)
            {
                case e_PlayerState.IDlE:
                    // do nothing
                    break;
                case e_PlayerState.ATTACK:
                    warrior1.Attack();
                    break;
                case e_PlayerState.JUMP:
                    warrior1.Jump();
                    break;
                case e_PlayerState.WALK:
                    warrior1.Walk();
                    break;
                case e_PlayerState.RUN:
                    warrior1.Run();
                    break;
                case e_PlayerState.DASH:
                    warrior1.Dash();
                    break;
                case e_PlayerState.HOME:
                    warrior1.Home();
                    break;
                default:
                    break;
            }

        }
    }

    class Warrior
    {
        public string name;

        // 상태 제크용 변수

        public void Walk()
        {
            Console.WriteLine($"{name} (이)가 걸음");
        }

        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프함");
        }

        public void Run()
        {
            Console.WriteLine($"{name} (이)가 달림");
        }

        public void Attack()
        {
            Console.WriteLine($"{name} (이)가 공격함");
        }

        public void Dash()
        {
            Console.WriteLine($"{name} (이)가 대시함");
        }

        public void Home()
        {
            Console.WriteLine($"{name} (이)가 귀환함");
        }


    }
} 

