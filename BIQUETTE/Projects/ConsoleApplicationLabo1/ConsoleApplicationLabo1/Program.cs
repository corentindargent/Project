using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new Pupil("Roland", 6, 1);
            Pupil p2 = new Pupil("Lily", 6, 1);          

            Pupil p3 = new Pupil("Brick", 10, 3);
            Pupil p4 = new Pupil("Modecai", 8, 2);

            Activity a1 = new Activity("Racket", true);
            Activity a2 = new Activity("Basket", false);
            Activity a3 = new Activity("Football", true);
            Activity a4 = new Activity("Danse", false);

            p1.AddActivity(a1);
            p1.AddActivity(a2);
            p1.AddActivity(a3);
            p2.AddActivity(a3);
            p2.AddActivity(a2);
            p3.AddActivity(a1);
            p3.AddActivity(a2);


            //Liste eleve
            List <Pupil> lPupil = new  List<Pupil>();
            lPupil.Add(p1);
            lPupil.Add(p2);
            lPupil.Add(p3);
            lPupil.Add(p4);


            //Covariance 
            /*
               List<Pupil> listPupils = new List<Pupil>()
                {
                    new Pupil("AAAA", 10,4),
                    new Pupil("BB", 10,4),
                    new Pupil("Cc", 10,4)
               };

               List<Person> listPerson = new List<Person>()
                {
                    new Person("Alferd",100),
                    new Person("Batamn", 34),
                    new Person("Cartman", 14)
               };

               var listFusion = listPerson.Union(listPupils);
               string TbMassage = Environment.NewLine;

               foreach (var person in listFusion)
               {
                   System.Console.Write(person.Name);

                   System.Console.Write(TbMassage);
                   System.Console.Read();

               }
               */

            List<Pupil> listPupilsDuplicated = new List<Pupil>()
             {
                 new Pupil("Arvey", 10,4),
                 new Pupil("Arvey", 10,3),
                 new Pupil("BB", 17,6),
                 new Pupil("Co", 10,8),
                 new Pupil("Co", 10,4),
            };
        



            //varibale anonymes
            /* var pupilGrad1Plus6 = from pupil in lPupil
                                   where pupil.Age == 6 && pupil.Grade == 1
                                   select pupil;
            
            //Garnissage var anonyme via fct anonyme
              //var pupilGrad1Plus6 = lPupil.TakeWhile(lPupil)

            if (pupilGrad1Plus6 != null)
            {
                foreach(var pupil in pupilGrad1Plus6)
                {
                    System.Console.Write(pupil);
                    string TbMassage = Environment.NewLine;
                    System.Console.Write(TbMassage);

                }
            }
            System.Console.Read();
            */



            /*            
               p1.AddEvaluation(evaluation: 'O', title: "Racket");            
                System.Console.Write(p1);
                string TbMassage = Environment.NewLine;
                System.Console.Write(TbMassage);
                System.Console.Write(p1.TabEval.First());
                System.Console.Read();
            */

        }
    }
}
