using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyiFE
{
    public class Pilkarz
    {
        // Pola
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pozycja { get; set; }
        public int Numer { get; set; }

        // Konstruktor
        public Pilkarz(string imie,string nazwisko, string pozycja, int numer)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Pozycja = pozycja;
            Numer = numer;
        }

        // Opis piłkarza
        public void Opis()
        {
            Console.WriteLine($"Piłkarz: {Imie} {Nazwisko}, Pozycja: {Pozycja}, Numer: {Numer}");
        }

        //Sprawdzenie, czy piłkarz gra na bramce, ToLower() zamienia wszytskie litery na małe
        public bool CzyJestBramkarzem()
        {
            return Pozycja.ToLower() == "bramkarz";
        }
    }

}
