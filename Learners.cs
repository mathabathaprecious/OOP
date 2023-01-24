using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Learners
    {
        public string firstname;
        public string lastname;
        public char initial;
        public string gender;
        public int age;
        public Learners(string Firstname, string Lastname, char Initial,string Gender, int Age)
        {
            firstname = Firstname;
            lastname = Lastname;
            initial = Initial;
            gender = Gender;
            age = Age;
        }
    }
}
