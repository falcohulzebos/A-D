using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotheekSysteem
{
    abstract class Boek
    {
        int bladzijdes;
        String type, isbn, taal, auteur;

        public Boek(long artikelId, String titel, String subTitel, String genre, DateTime uitgifte, bool uitgeleend, int bladzijdes, String type, String isbn, String taal, String auteur)
        {
            this.bladzijdes = bladzijdes;
            this.type = type;
            this.isbn = isbn;
            this.taal = taal;
            this.auteur = auteur; 
        }

        public int getBladzijdes()
        {
            return bladzijdes;
        }

        public String getType()
        {
            return type;
        }
        public String getIsbn()
        {
            return isbn;
        }
        public String getTaal()
        {
            return taal;
        }
        public String getAuteur()
        {
            return auteur;
        }
    }
}
