using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Composition_Lab
{
    public class Author
    {
        private string name;
        private char gender;
        private string email;
        public Author(string name, char gender, string email)
        {
            this.name = name;
            this.gender = gender;
            this.email = email;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetGender(char gender)
        {
            this.gender = gender;
        }
        public char GetGender()
        {
            return gender;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public override string ToString()
        {
            return "The author name is = " + name + ", The author gender is = " + gender + ", The author email is = " + email;
        }
    }
}