using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class homme
    {   private int ID;
        public String Nom;
        public String Prenom;
        public DateTime DDN;
        public homme(int PID, String PNom, String PPrenom, DateTime Pddn)
        {
            ID = PID;
            Nom = PNom;
            DDN = Pddn;
        }
   public Boolean  EstMajeur()
    {
            if (DateTime.Today.Year - DDN.Year >=18)
            { return true;
            }
            else return false;
    }
    
  }
}