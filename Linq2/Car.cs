using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    internal class Car
    {
        public Car(string name,int power, Person person)
        {
            Name = name;
            Power = power;
            Owner = person;
        }
        public Car(string name,int power,string firstname,string lastname)
        {
            Name = name;
            Power = power;
            Owner.Firstname = firstname;
            Owner.Lastname = lastname;
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int power;
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        private Person owner;
        public Person Owner
        {
            get { return owner; }
            set { owner = value; }
        }

    }
}
