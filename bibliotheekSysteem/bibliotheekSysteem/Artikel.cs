using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheekSysteem
{
    abstract class Artikel
    {
        long artikelId;
        String titel, subTitel, genre;
        DateTime uitgifte;
        bool uitgeleend;

        public Artikel(long artikelId, String titel, String subTitel, String genre, DateTime uitgifte, bool uitgeleend)
        {
            this.artikelId = artikelId;
            this.titel = titel;
            this.subTitel = subTitel;
            this.genre = genre;
            this.uitgifte = uitgifte;
            this.uitgeleend = uitgeleend;
        }

        public long getArtikelId()
        {
            return artikelId;
        }

        public String getTitel()
        {
            return titel;
        }

        public String getSubTitel()
        {
            return subTitel;
        }

        public String getGenre()
        {
            return genre;
        }

        public DateTime getUitgifte()
        {
            return uitgifte;
        }

        public void setUitgifte(DateTime uitgifte)
        {
            this.uitgifte = uitgifte;
        }

    }

}
