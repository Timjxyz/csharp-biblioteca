using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Prodotto
    {
        /*
         * titolo
         */
        public string titolo;
        /*
         * anno di uscita
         */
        public int anno;
        /*
         * categoria appartenente
         */
        public string categoria;
        /*
         * stato se è disponibile o meno
         */
        public bool stato;
        /*
         * posizione nello scaffale
         */
        public string scaffale;
        /*
         * nome o cognome dell'autore/regista
         */
        public string autore;
        public Prodotto(string titolo, int anno, string categoria, bool stato, string scaffale, string autore)
        {
            this.titolo = titolo;
            this.anno = anno;
            this.categoria = categoria;
            this.stato = stato;
            this.scaffale = scaffale;
            this.autore = autore;
        }
    }
}
