using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheekSysteem
{
    class Lid
    {
        List<Reservering> reserveringen;
        int lidID;
        string naam;

        public Lid(int lidID, string naam)
        {
            this.lidID = lidID;
            this.naam = naam;
        }

        public List<Reservering> getReserveringen()
        {
            return reserveringen;
        }

        public void addReservering(Reservering reservering)
        {
            reserveringen.Add(reservering);
        }

        public double totaalBoetes()
        {
            // itterate door reserveringen en return boetes totaal
        }

        public double openstaandeBoetes()
        {
            // itterate door reserveringen en return openstaande boetes totaal
        }

        public int aantalReserveringen()
        {
            return reserveringen.Count;
        }

        public int aantalHuidigeReserveringen()
        {
            
        }
    }
}
