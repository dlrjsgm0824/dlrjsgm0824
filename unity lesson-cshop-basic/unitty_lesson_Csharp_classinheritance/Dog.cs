using System;
using System.Collections.Generic;
using System.Text;

namespace unitty_lesson_Csharp_classinheritance
{
    class Dog : creatrue , iFourLeggedWalker
    {
        public float tailLength;

        public void FourLeggedWalk()
        {
            Console.WriteLine("네발로 걷는다");
        }
    }
}
