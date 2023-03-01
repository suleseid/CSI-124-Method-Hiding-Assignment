using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI_124_Method_Hiding_Assignment.Aggregate_Container
{
    internal class Course
    {
        string _courseName;
        string _location;
        Teacher _teacher;

        //If an access modifiers are not explicted, what is the
        //default  assess modifier? Protected


        //what are the main four modifiers?
        //public, privet, internal, and protected.

        //A Contains means an object that neccessary to work
        List<Student> _classRoster = new List<Student>();

        //Aggregate
        //Has-A indicate that an object used in a class
        //but can exist outside the class

        //null indicates it does not exist inthe memory

        public Course(string courseName, string location)
        {
            _courseName = courseName;
            _location = location;
        }

        public Course(string courseName, string location, Teacher teacher)
        {
            CourseName = courseName;
            Location = location;
            Teacher = teacher;
        }
        /*public Course(string courseName, string location, Teacher teacher, List<Student> classRoster)
        {
            _courseName = courseName;
            _location = location;
            _teacher = teacher;
            _classRoster = classRoster;
        }*/
        public string CourseName { get => _courseName; set => _courseName = value; }
        public string Location { get => _location; set => _location = value; }
        internal Teacher Teacher 
        {
            get
            {
                if (_teacher == null)
                {
                    return new Teacher("", "", 0);
                }
                return _teacher;
            }
            set => _teacher = value;
        }
        //Retricting users from setting the class Roster the students.

        //The Proteected access modifier allows the class and
        //it's drived children to access the members.

        public List<Student> ClassRoster 
        { 
            get => _classRoster;
            protected set => _classRoster = value;
        }

        //Creating a method to Add the to the list.
        //but users are unable to directly access that list.

        public void AddStudent(Student student)
        {
            _classRoster.Add(student);
        }
    }
}
