using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class femme : homme
    {
        public femme(int PID, String PNom, String PPrenom, DateTime Pddn,  int PLe6emeSens)
            : base(  PID,  PNom,  PPrenom,  Pddn)
        {// on appelle de facon implicite le constructeur de la classe mère

            Le6emeSens = PLe6emeSens;
        }

        public int Le6emeSens;
       
       
    }
}