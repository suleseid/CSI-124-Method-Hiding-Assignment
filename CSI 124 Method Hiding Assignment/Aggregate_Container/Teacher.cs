using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI_124_Method_Hiding_Assignment.Aggregate_Container
{
    internal class Teacher
    {
        string _fristName;
        string _lastName;
        int _yearsWorked;

        public Teacher(string fristName, string lastName, int yearsWorked)
        {
            FristName = fristName;
            LastName = lastName;
            YearsWorked = yearsWorked;
        }

        public string FristName
        {
            get => _fristName;
            set
            {
                if (value != value)
                {
                    _fristName = value;
                }
                else
                {
                    _fristName = "Invalid Name";
                }
            }
        }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int YearsWorked { get => _yearsWorked; set => _yearsWorked = value; }

        public override string ToString()
        {
            return $"{_fristName}{_lastName}, Years Worked : {_yearsWorked}";
        }
    }
}
