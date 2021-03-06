﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Pupil:Person
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set { grade = (value>0)?value : 1; }
        }

        private List<Activity> lstActivity;
        private char[] tabEval;

        internal List<Activity> LstActivity
        {
            get { return lstActivity; }
            set { lstActivity = value; }
        }

        public char[] TabEval
        { 
            get{return tabEval;}
            set {tabEval = value;} 
        }


        // signifie fait appel cons classe mere
        public Pupil(String name,int age,int grade) : base(name, age)
        {
            Grade = grade;
            LstActivity = new List<Activity>();
            TabEval = new char[10];
        }

        //cons pour eleve 1er sans activite
        public Pupil(String name, int age) : this(name, age, 1) { }

                //le mot this reference le cons decrit au dessus

        public void AddActivity(Activity activity)
        {
            LstActivity.Add(activity);
        }

        public override string ToString()
        {
            string ch = base.ToString();
            int cptActivities = LstActivity.Count();

            if(cptActivities == 0)
            {
                ch+=" n'a pas encore choisi d'activité";
            }
            else
            {
                ch += " a choisi les activités suivantes";
                foreach(Activity activity in LstActivity)
                {
                    ch += activity + ", ";
                }
            }

            return ch;
        }

        //Les affectation ici sont des valeurs par defaut
        public void AddEvaluation(String title = null,char evaluation = 'S')
        {    
            if(title != null)
            {

                int i;
                for (i = 0; LstActivity[i].Title != title && i < 10; i++)
                { }

                if(i<10)
                {
                    tabEval.SetValue(evaluation, i);
                }
            }            
        }

        public delegate string DelegatePrintActivityCompulsory(Activity activity);

        public string PrintPupilActivityCompulsory(DelegatePrintActivityCompulsory MyPrintActivity)
        {
            int numAct = 0;
            string ch = base.ToString() + " a choisi les activités obligatoires : \n";
            foreach (Activity activity in LstActivity)
                if (activity.Compulsory)
                    ch += (++numAct) + " " + MyPrintActivity(activity);
            return ch;
        }
        //MyPrintActivity -> methode d'impression chois par le programmeur

    }
}
