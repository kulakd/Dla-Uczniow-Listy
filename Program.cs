namespace ListyiFE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // porównanie Tabli i List
            Tablica();
            Console.WriteLine();
            Listy();

            // Tworzenie listy piłkarzy
            List<Pilkarz> pilkarze = new List<Pilkarz>();
            Pilkarz P1 = new Pilkarz("Robert", " Lewandowski", "Napastnik", 9);
            Pilkarz P2 = new Pilkarz("Wojciech", " Szczęsny", "Bramkarz", 1);
            Pilkarz P3 = new Pilkarz("Kamil", "Glik", "Obrońca", 15);

            // Dodanie Piłkarzy do listy
            pilkarze.Add(P1);
            pilkarze.Add(P2);
            pilkarze.Add(P3);


            // Iteracja po piłkarzach za pomocą foreach
            // foreach ( TYP ZMIENNA in LISTA), czytamy "dla każdego p klasy Piłkarz w liscie pilkarze"
            foreach (Pilkarz p in pilkarze)
            {
                p.Opis(); // Wywołanie metody Opis
                if (p.CzyJestBramkarzem()) // Sprawdzanie, czy piłkarz jest bramkarzem
                {
                    Console.WriteLine($"{p.Imie} jest bramkarzem.");
                }
                else
                {
                    Console.WriteLine($"{p.Imie} nie jest bramkarzem.");
                }
                Console.WriteLine();
            }

        }
        // Porównujemy działanie tablic i list
        #region Tablica
        public static void Tablica()
        {
            int[] liczby = new int[5];
            double suma = 0;
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.WriteLine("Podaj nową liczbę: ");
                int liczba = int.Parse(Console.ReadLine());
                liczby[i] = liczba;
                suma += liczba;

                string tekst = ZamienNaTekst(liczby);
                int liczbaElementow = i + 1;
                double srednia = suma / liczbaElementow;
                Console.WriteLine($"Aktualna tablica: {tekst}");
                Console.WriteLine($"Jest {liczbaElementow} liczb, średnia to {srednia}");
            }
            Console.ReadKey();
        }
        public static string ZamienNaTekst(int[] tablica)
        {
            string wynik = "[";
            for (int i = 0; i < tablica.Length; i++)
                wynik += $"{tablica[i]}";
            wynik += "]";
            return wynik;
        }
        #endregion

        #region Listy
        public static void Listy()
        {
            List<int> list = new List<int>();
            double suma = 0;
            while (true)
            {
                Console.WriteLine("Podaj nową liczbę: ");
                int liczba = int.Parse(Console.ReadLine());
                list.Add(liczba);
                suma += liczba;
                string tekst = ZamienNaTekst(list);
                int liczbaElementow = list.Count;
                double srednia = suma / list.Count;
                Console.WriteLine($"Aktualna lista: {tekst}");
                Console.WriteLine($"Jest {liczbaElementow} liczb, średnia to {srednia}");
            }
        }
        public static string ZamienNaTekst(List<int> lista)
        {
            string wynik = "[";
            for (int i = 0; i < lista.Count; i++)
                wynik += $"{lista[i]}";
            wynik += "]";
            return wynik;
        }

        #endregion
    }
}