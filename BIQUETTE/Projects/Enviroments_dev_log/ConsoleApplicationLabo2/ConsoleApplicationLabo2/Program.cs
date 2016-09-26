using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateContact p1 = new PrivateContact("Williams", "Serena", 0475123678, "SeranaWillliams@hotmail.com", 26, 09, 1981);
            PrivateContact p2 = new PrivateContact("Drake", "Francis", 0, "Uncharted1@gmail.com");

            ProfessionalContact prf1 = new ProfessionalContact("Stephan", "Streiker", 051454854, "StefStreiker@hotmail.com","consultant");
            ProfessionalContact prf2 = new ProfessionalContact("Bemjamin", "Prejent", 05489899, "BenjaPrejent@hotmail.com", "consultant");
            ProfessionalContact prf3 = new ProfessionalContact("Bob", "Bricoleur", 1111111, "LEBricoleur@hotmail.com", "independant");

            Entreprise e1 = new Entreprise("JouetClub", "Namur");
            Entreprise e2 = new Entreprise("SkySport", "Londres");


            //Creation liste regroupant tous les contact professionel
            List<ProfessionalContact> lstPro = new List<ProfessionalContact>();
            lstPro.Add(prf1);
            lstPro.Add(prf2);
            lstPro.Add(prf3);

            //Ajout entreprise au professionel
            prf1.AddEntreprise(e1);
            prf1.AddEntreprise(e2);
            prf2.AddEntreprise(e2);

            //Creation liste regroupant les independants
            // ProIndepandant ets une variable anonyme -> c à la commpil prendra le type donne à l'init

            var ProIndependant = from professionalContact in lstPro
                                 where professionalContact.Profession == "independant"
                                 select professionalContact;


            //Creation liste via une expression lambda
        
            List<ProfessionalContact> nbEmploy = lstPro.Where(p =>p.Profession == "consultant" && p.LstEntreprise.Where((e,s) => e.Name.Equals(s)));
            
            //Affiche le nombre d'independant
            System.Console.Write("Il y a "+ProIndependant.Count()+" independant \n");

            

            System.Console.Write(p1.ToString() + ((p1.HasHisBirthday()) ? " \n Bon anniversaire \n" : "\n"));
            


            //Partie 2 dynamique
                        
            Car c1 = new ConsoleApplicationLabo2.Car(03135615);
            ContactCar cc1 = new ContactCar(p1, c1);
            cc1.DynamicPrint(cc1.Person);

            Car c2 = new ConsoleApplicationLabo2.Car(666666);
            ContactCar cc2 = new ContactCar(prf1, c1);


            System.Console.Read();
        }
    }
}
