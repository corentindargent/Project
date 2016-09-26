using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    class ContactCar
    {
            
        public Person Person
        {
            set;
            get;
        }

        public Car Car
        {
            set;
            get;
        }

        public ContactCar (Person pers ,Car car)
        {
            Car = car;
            Person = pers;
        }


        //methode permettra d'afficher le tostring de la personne asosice à la voiture
        //
        // si obj est de type Profe... -> affichage (n p est un contact pro) 
        //
        //si obj est de type Pri...    -> affichage (n p est un contact privee) 
        //


        public void DynamicPrint(dynamic objet)
        {
            System.Console.WriteLine(objet.Print() + " voiture : " + Car.ToString());
        }

    }
}
