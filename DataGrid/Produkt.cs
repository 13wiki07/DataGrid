using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid
{
    internal class Produkt
    {
        public String Nazwa {  get; set; }
        public bool Dostepnosc {  get; set; }
        public double Cena {  get; set; }
        public String Kategoria {  get; set; }

        public Produkt(string nazwa, bool dostepnosc, double cena, string kategoria)
        {
            this.Nazwa = nazwa;
            this.Dostepnosc = dostepnosc;
            this.Cena = cena;
            this.Kategoria = kategoria;
        }
    
    }
}
