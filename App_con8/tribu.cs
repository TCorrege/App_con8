using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace ConsoleApplication1
{
    public class tribu
    {
        private Collection<homme> LesMembres = new Collection<homme>();

        public tribu()
        {
         
    }

        public void AjouterMembre(homme h)
    {
            LesMembres.Add(h);

    }
        public int NBFemmes()
        { int nb = 0;
            foreach (homme UnIndividu in LesMembres)
            {
                if (UnIndividu.GetType() == typeof(femme))  nb += 1;

            }
            return nb;

        }
}
}