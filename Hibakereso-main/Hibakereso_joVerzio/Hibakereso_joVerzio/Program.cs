using System;

namespace SzamKitalalo
{
    class Program
    {
        static void Main(string[] args)
        {
            kiiras();
            Console.WriteLine("Kérlek add meg, hogy mettől meddig generáljon számot:");
            int mettol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérlek add meg, hogy mettől meddig generáljon számot:");
            int meddig = Convert.ToInt32(Console.ReadLine());


            int randSzam = szamGondolas(mettol, meddig);
            int szamlalo = 0;
            int szam = 0;
            do
            {
                Console.Write("\n{0}/5 Kérlek írj be egy számot: ", szamlalo + 1);
                szam = Convert.ToInt32(Console.ReadLine());

                szamlalo++;

            } while (szamKitalalas(randSzam, szam) == false && szamlalo <= 5);

            Console.Write("A kilépéshez üss Entert. ");
            Console.ReadLine();
        }

        private static bool szamKitalalas(int randSzam, int szam)
        {
            if (szam > randSzam)
            {
                Console.WriteLine("Az általad beírt szám nagyobb mint a gondolt szám.");
            }
            else if (szam < randSzam)
            {
                Console.WriteLine("Az általad beírt szám kisebb mint a gondolt szám.");
            }
            else
            {
                //Ki szeretnék íratni valamit.
                Console.WriteLine("Gratulálok! Sikeresen kitaláltad a számot.");
               
                return true;
            }

            return false;
        }

        private static int szamGondolas(int mettol, int meddig)
        {
            Random rnd = new Random();

            int randSzam = rnd.Next(mettol, meddig);
            return randSzam;
        }

        private static void kiiras()
        {
            Console.WriteLine("Szám kitatáló program\n");
            Console.WriteLine("A program gondol egy számra, és neked ki kell találni \nhogy melyik számra gondolt.\n");
            Console.WriteLine("5 esélyed lesz a kitalálásra.");

        }
    }
}