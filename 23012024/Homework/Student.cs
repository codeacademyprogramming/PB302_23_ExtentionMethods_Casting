using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Student
    {
        string _fullname;
        string _groupNo;
        public byte Age;

        public Student(string fullname, string groupNo, byte age)
        {
            Fullname = fullname;
            Age = age;
            GroupNo = groupNo;
        }

        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }

        public string Fullname
        {
            get=> _fullname;
            set
            {
                if (CheckFullname(value))
                    _fullname = value;
                else throw new Exception("Fullname format exception");
            }
        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (string.IsNullOrWhiteSpace(groupNo) || groupNo.Length != 4) return false;

            if (!char.IsUpper(groupNo[0])) return false;

            for (int i = 1; i < 4; i++) 
                if (!char.IsDigit(groupNo[i])) return false;
            
            return true;
        }

        public static bool CheckFullname(string fullname)
        {
            var words = fullname.Split(' ');
            if(words.Length != 2) return false;

            if (words[0].Length>2 && words[0].Length<11 && words[1].Length > 2 && words[1].Length < 11)
            {
                if (CheckIsNameCapitalized(words[0]) && CheckIsNameCapitalized(words[1]))
                    return true;
            }

            return false;
        }

        static bool CheckIsNameCapitalized(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return false;

            if (!char.IsUpper(str[0])) return false;

            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsLower(str[i])) return false;
            }

            return true;
        }
    }
}
