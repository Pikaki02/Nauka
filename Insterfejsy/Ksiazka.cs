using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insterfejsy
{
    internal class Ksiazka : IComparable<Ksiazka>
    {
        public string Tytul {  get; set; }
        public string Autor { get; set; }
        public int RokWydania { get; set; }
        public double Cena { get; set; }

        public Ksiazka(string tytul,string autor,int rokWydania,double cena ) 
        {
            Tytul = tytul;
            Autor = autor;
            RokWydania = rokWydania;
            Cena = cena;
        }
        public override string ToString()
        {
            return $"{Tytul}, {Autor}, {RokWydania}, {Cena} zł";
        }
        public int CompareTo([AllowNull] Ksiazka other)
        {

            if (other == null)
            {
                return 1;
            }
            return Cena.CompareTo(other.Cena);
        }
        
    }
}
