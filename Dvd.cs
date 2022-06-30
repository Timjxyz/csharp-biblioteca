using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Dvd:Prodotto
    {
        /*
         * durata del dvd
         */
        public int durata;
        /*
         * codice identificativo dvd
         */
        public string numeroSeriale;
        public Dvd(int durata, string numeroSeriale, string titolo, int anno, string categoria, bool stato, string scaffale, string autore) : base(titolo, anno, categoria, stato, scaffale, autore)

        {
            {
                this.durata = durata;
                this.numeroSeriale = numeroSeriale;
                this.titolo = titolo;
                this.anno = anno;
                this.categoria = categoria;
                this.stato = stato;
                this.scaffale = scaffale;
                this.autore = autore;

            }
        }


        public override string ToString()
        {
            return base.ToString() + "\n" + "La durata totale del DVD è di " + this.Duratafilm() + " minuti"
                + "\n" + "IL numero seriale del DVD " + this.Generacodice()
                + "\n" + "IL titolo del DVD " + this.titolo
                + "\n" + "L'anno di uscita del DVD è" + this.anno
                + "\n" + "La categoria del DVD è " + this.categoria
                + "\n" + "Il DVD è " + this.stato
                + "\n" + "Il DVD è nello scaffale" + this.scaffale
                + "\n" + "IL regista è " + this.autore;
        }
        public int Duratafilm()
        {
            return this.durata = new Random().Next(60, 180); ;
        }
        public string Generacodice()
        {
            return this.numeroSeriale = new Random().Next(0, 999999999).ToString("D11");
        }
    }
}
