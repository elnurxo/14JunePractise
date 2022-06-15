using System;
using System.Collections.Generic;
using System.Text;

namespace _14JunePractiseP227.Classes
{
    public class Human
    {
        public Human(string name)
        {
            this.Name = name;
        }

        private string _name;
        public string Surname;
        public byte Age;

        public string FullName
        {
            get => Name + " " + Surname;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length>3 && OnlyLetter(value))
                {
                    value.ToLower();
                    Char.ToUpper(value[0]);
                    _name = value;
                } 
            }
        }

        public bool OnlyLetter(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
