using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    class Entreprise
    {
        public string Name
        {
            get;
            set;
        }

        public string Localite
        {
            get;
            set;
        }

        public Entreprise (string name,string localite)
        {
            Name = name;
            Localite = localite;
        }

        public override string ToString()
        {
            return "L'entreprise "+Name+" se situe à "+ Localite;
        }

    }
}
