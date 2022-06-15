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
                     _name = CapitalizeName(value);
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

        public string CapitalizeName(string name)
        {
            string capitalize = "";

            capitalize += Char.ToUpper(name[0]);
            for (int i = 1; i < name.Length; i++)
            {
                capitalize += Char.ToLower(name[i]);
            }
            return capitalize;
        }
    }
}
