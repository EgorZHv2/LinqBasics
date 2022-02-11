using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    internal class Person
    {
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        private string firstname;
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        private string lastname;
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
    }
}
