using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Libri:Prodotto
    {
        /*
         * numero pagine libro
         */
        public int numeroPagine;
        /*
         * codice di riferimento libro
         */
        public string isbn;

        public Libri(int numeroPagine, string isbn, string titolo, int anno, string categoria, bool stato, string scaffale, string autore) : base(titolo, anno, categoria, stato,scaffale, autore)
        
        {
            {
                this.numeroPagine = numeroPagine;
                this.isbn = isbn;
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
            return base.ToString() + "\n" + "Il libro è composto da " + this.GeneraPagine() + " pagine" +
                "\n" + "Il codice ISBN del libro è " + this.GeneraIsbn()
                + "\n" + "IL titolo del libro" + this.titolo
                + "\n" + "Anno di uscita del libro" + this.anno
                + "\n" + "Categoria DVD " + this.categoria
                + "\n" + "IL DVD è" + this.stato
                + "\n" + "IL libro è nello scaffale numero" + this.scaffale
                + "\n" + "L'autore è " + this.autore;
        }

        public int GeneraPagine()
        {
            return this.numeroPagine= new Random().Next(0, 1200); ;
        }
        public string GeneraIsbn()
        {
            return this.isbn = new Random().Next(999999, 999999999).ToString("D13");
        }


    }
}
