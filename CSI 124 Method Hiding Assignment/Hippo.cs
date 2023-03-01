using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI_124_Method_Hiding_Assignment
{
    internal class Hippo : Animal
    {
        //What symbol do we use to inherit - Colon;
        //Which class is parent and which class is child
        //Baby Hippo is a child that is a driven and Hippo is parent that is base
        //Access modifers are all about giving Permision to other programmer.
        //Override gives us to change the vertual method, Sound from the base

        //Keyword New Prevents others from overriding in drived class
        public virtual string Sound()
        {
            return "Snoring Roar";
        }
    }
}
