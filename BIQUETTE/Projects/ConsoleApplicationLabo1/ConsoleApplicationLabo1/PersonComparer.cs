using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class PersonComparer : IEqualityComparer <Person>
    {       

        bool IEqualityComparer<Person>.Equals(Person x, Person y)
        {
            throw new NotImplementedException();
            if (x.Name == y.Name && x.Age == y.Age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        int IEqualityComparer<Person>.GetHashCode(Person obj)
        {
            throw new NotImplementedException();
            return base.GetHashCode();
        }
    }
}
