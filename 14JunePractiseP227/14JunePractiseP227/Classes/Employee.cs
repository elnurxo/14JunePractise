using System;
using System.Collections.Generic;
using System.Text;

namespace _14JunePractiseP227.Classes
{
    public class Employee:Human
    {
        public Employee(string name,string position):base(name)
        {
            this.Position = position;
        }

        public string Position;
    }
}
