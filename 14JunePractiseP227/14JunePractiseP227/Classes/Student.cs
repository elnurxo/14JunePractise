using System;
using System.Collections.Generic;
using System.Text;

namespace _14JunePractiseP227.Classes
{
    public class Student:Human
    {
        public Student(string name,byte grade):base(name)
        {
            this.Grade = grade;
        }

        public byte Grade;

    }
}
