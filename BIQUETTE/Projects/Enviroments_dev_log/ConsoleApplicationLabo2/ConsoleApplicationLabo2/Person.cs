using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    public abstract class Person
    {
        public String Name
        {
            get;
            set;
        }

        public String LastName
        {
            get;
            set;
        }

        public Person(string lastname,string name)
        {
            LastName = lastname;
            Name = name;
        }

        public override string ToString()
        {
            return LastName+" "+Name;
        }

        public abstract bool HasHisBirthday();

    }
}
