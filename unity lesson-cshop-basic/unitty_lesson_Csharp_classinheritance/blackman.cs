using System;
using System.Collections.Generic;
using System.Text;

namespace unitty_lesson_Csharp_classinheritance
{
    class blackman : Human
    {
        public override void breath()
        {
            lifetime++;
            weight += 0.00004f;
            height += 0.00006f;
        }
    }
}
