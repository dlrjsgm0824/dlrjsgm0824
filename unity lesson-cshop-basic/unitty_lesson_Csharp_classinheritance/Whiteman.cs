using System;
using System.Collections.Generic;
using System.Text;

namespace unitty_lesson_Csharp_classinheritance
{
    class Whiteman : Human 
    {
        public override void breath()
        {
            lifetime++;
            weight += 0.00003f;
            height += 0.00005f;
        }
    }
}
