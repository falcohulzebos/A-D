using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheekSysteem
{
    abstract class Cd
    {
        double duur, leengeld;

        public Cd(long artikelId, String titel, String subTitel, String genre, DateTime uitgifte, bool uitgeleend, double duur, double leengeld) 
        {
            this.duur = duur;
            this.leengeld = leengeld;
        }

        public double getDuur()
        {
            return duur;
        }

        public double getLeengeld()
        {
            return leengeld;
        }
    }
}
