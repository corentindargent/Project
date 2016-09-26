using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    class Car
    {
        public int NumPlaque
        {
            get;
            set;
        }

        public Car(int numPlaque)
        {
            NumPlaque = numPlaque;
        }

        public override string ToString()
        {
            return "Plaque mineralogique "+NumPlaque;
        }
    }
}
