using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheekSysteem
{
    class Reservering
    {
        Artikel artikel;
        double boete;
        Boolean boeteBetaald;
        DateTime leenDatum;
        DateTime inleverDatum;

        public Reservering(Artikel artikel): this(artikel, DateTime.Today)
        {

        }

        public Reservering(Artikel artikel, DateTime leenDatum)
        {
            this.artikel = artikel;
            this.leenDatum = leenDatum;
            
        }

        public Artikel getArtikel()
        {
            return artikel;
        }

        public double getBoete()
        {
            return boete;
        }

        public DateTime getLeenDatum()
        {
            return leenDatum;
        }

        public DateTime getInleverDatum()
        {
            return inleverDatum;
        }

        public Boolean getBoeteBetaald()
        {
            return boeteBetaald;
        }

        public void setBoeteBetaald()
        {
            boeteBetaald = true;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public double sluitReservering()
        {
            return 0.3;
        }

        public double sluitReservering(DateTime inleverDatum)
        {
            this.inleverDatum = inleverDatum;
            return 0.3;
        }

        public double berekenBoete()
        {
            double boete = 0.0;
            if (artikel is Romanboek)
            {
                if(leenDatum.AddDays(21) < DateTime.Today)
                {
                    boete += 0;
                }
                else
                {
                    int aantalDagen = DateTime.Today.Day - leenDatum.AddDays(21).Day;
                    boete += aantalDagen * 0.25; 
                }
            }
            if (artikel is Studieboek)
            {
                if (leenDatum.AddDays(30) < DateTime.Today)
                {
                    boete += 0;
                }
                else
                {
                    int aantalDagen = DateTime.Today.Day - leenDatum.AddDays(30).Day;
                    boete += aantalDagen * 1;
                }
            }
            if (artikel is PopulaireCD)
            {
                if (leenDatum.AddDays(10) < DateTime.Today)
                {
                    boete += 1.00;
                }
                else
                {
                    int aantalWeken = (DateTime.Today.Day - leenDatum.AddDays(21).Day) / 7;
                    boete += (aantalWeken * 2.00) +2;
                }
            }
            if (artikel is KlassiekeCD)
            {
                if (leenDatum.AddDays(10) < DateTime.Today)
                {
                    boete += 2.00;
                }
                else
                {
                    int aantalWeken = (DateTime.Today.Day - leenDatum.AddDays(21).Day) / 7;
                    
                    if(artikel.getLeeftijd() <= 1)
                        boete += (aantalWeken * 1.5)+2;
                    if (artikel.getLeeftijd() > 1 && artikel.getLeeftijd() <= 5)
                        boete += ((aantalWeken * 1.5) * 0.9)+2;
                    if(artikel.getLeeftijd() > 5)
                        boete += ((aantalWeken * 1.5) * 0.5)+2;
                }
            }
            if (artikel is AFilm)
            {
                int aantalDagen = DateTime.Today.Day - leenDatum.Day;
                boete += aantalDagen * 2;
            }
            if (artikel is BFilm)
            {
                if (leenDatum.AddDays(3) < DateTime.Today)
                {
                    boete += 2;
                }
                else
                {
                    int aantalDagen = DateTime.Today.Day - leenDatum.AddDays(21).Day;
                    boete += aantalDagen + 2;
                }
            }

            return boete;
        }
    }
}
