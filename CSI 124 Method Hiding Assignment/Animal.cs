using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI_124_Method_Hiding_Assignment
{
    internal class Animal
    {
        internal string _name;

        //The Three key words of controlling Method inheritance are
        // Virtual, Overide, and New
        //What word do we use to give permision to change a method in a child?
        //Virtual
        public virtual string Sound()
        {
            return "Animal Call";
        } 
    }
}
