using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo2
{
    class ProfessionalContact : Person
    {
        public string AdresseMailPro
        {
            set;
            get;
        }
        public string Profession
        {
            set;
            get;
        }

        public int NumeroTelephonePro
        {
            set;
            get;
        }

        private List<Entreprise> lstEntreprise;

        public List<Entreprise>LstEntreprise
        {
            get { return lstEntreprise; }
            set { lstEntreprise = value; }
        }

        public ProfessionalContact (string name,string lastname, int numTel,
            string adrMail,string profession) : base(lastname, name)
        {
            AdresseMailPro = adrMail;
            Profession = profession;
            NumeroTelephonePro = numTel;
            LstEntreprise = new List<Entreprise>();
        }

        public override string ToString()
        {
            return Name+"\t"+LastName+"("+NumeroTelephonePro+")"+"\n"
                + "\t" + Profession + "\n" 
                + "\t" +AdresseMailPro + "\n" 
                + "\t" + AdresseMailPro+ "\n" ;
        }

        public override bool HasHisBirthday()
        {
            return false; ;
        }

        public void AddEntreprise(Entreprise entreprise)
        {
            LstEntreprise.Add(entreprise);
        }

        public String Print()
        {
            return Name + LastName + " est un contact professionel"; 
        }


    }
}
