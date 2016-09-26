using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    class PrivateContact : Person
    {
        public int NumeroTelephone
        {
            set;
            get;
        }
        public string AdresseMail
        {
            set;
            get;
        }

        public DateTime DateNaissance
        {
            get;
            set;
        }

        public PrivateContact(String name,String lastname,
            int numTel,string adrMail,int jour,int mois,int an):base(lastname,name)
        {
            NumeroTelephone = numTel;
            AdresseMail = adrMail;
            DateNaissance = new DateTime(an,mois,jour);            
        }

        public PrivateContact(String name, String lastname,
            int numTel, string adrMail) : base(lastname, name)
        {
            NumeroTelephone = numTel;
            AdresseMail = adrMail;
            DateNaissance = new DateTime();
        }

        public override string ToString()
        {
            return base.ToString()+" a contacter via l'adresse "+AdresseMail
                +" ou avec le numéro "+NumeroTelephone;
        }

        public override bool HasHisBirthday()
        {
            return (DateTime.Today.Day == DateNaissance.Day && DateTime.Today.Month == DateNaissance.Month);
        }

        public string Print()
        {
            return Name + LastName + " est un contact privée";
        }

    }
}
