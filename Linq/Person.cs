using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Person
    {
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        string firstname;
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        string lastname;
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
    }
}
