using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Person
    {
        //varibale instance
        // private String name; -> pas necesaire pas valider les entrées de « value »


        private int age;


        //propriete qui nous permet d'avoir acces à notre variable instance
        
        public string Name
        {
            get;
            set;
        }


        public int Age
        {
            get{
                return age;
            }

            set{
              //verif que value soit positif
                age = (value > 0) ? value : 1; 
            }
        }



        //Constructeur affect tjs une valeure à la propriete et non à la variabel instance
        public Person(String name,int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return ""+Name+" est âgé(e) "+Age+" ans";
        }

       

    }
}
