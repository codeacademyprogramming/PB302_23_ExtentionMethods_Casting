using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal partial class Human
    {
        public Human()
        {

        }

        public Human(string name)
        {
            Name = name;
        }

        public Human(string name, string surname) : this(name)
        {
            Surname = surname;
        }

        public Human(string name, string surname, byte age) : this(name, surname)
        {
            Age = age;
        }
    }
    internal partial class Human
    {
       
        private string _name;
        private string _surname;
        private byte _age;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }
        public byte Age
        {
            get => _age;
            set => _age = value;
        }

       
    }
    internal partial class Human 
    {
        public static bool CheckName()
        {
            return true;
        }

        public static bool CheckSurname()
        {
            return true;
        }

        public string GetFullname()
        {
            return _name + " " + _surname;
        }
    }

}
