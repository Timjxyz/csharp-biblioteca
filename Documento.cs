using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documento
    {
        List<Prodotto> prodotti;
        public Documento()
        {
            prodotti = new List<Prodotto>();
        }
        public void GestisciProdotto(Prodotto prodotto)
        {
            this.prodotti.Add(prodotto);
        }

        internal void StampaProdotti()
        {
            Console.WriteLine("Lista prodotti");
            foreach (Prodotto prodotti in this.prodotti)
            {
                Console.WriteLine(prodotti.GetType);
                Console.WriteLine(prodotti.ToString);
                Console.WriteLine();
            }

        }
    }
}
