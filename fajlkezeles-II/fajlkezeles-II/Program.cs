using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fajlkezeles_II
{
    class Program
    {
        struct EpitmenyStruktura  //ez a telkek adatszerkezete
        {
            //struktúra adatszerkezet megadása || A változó neveket mezőnévnek nevezzük
            public string tulajAdoszam;     //a telek tulajdonosának 5 jegyű adószáma
            public string Utcanev;          //a telek utcájának a neve, szóköz nélkül
            public string Hazszam;          //a telek házszáma
            public char Adosav;             //az adó összegét meghatározó kategória
            public int Terulet;             //az építmény alapterülete
        }

        static int a_Sav, b_Sav, c_Sav;


        private static int ado(char adosav, int alapterulet)
        {
            int fizetendoAdo;


            return fizetendoAdo;
        }


        static void Main(string[] args)
        {
            Epitmenyado();
            Console.ReadLine();
        }

        private static void Epitmenyado()
        {
            //deklarációs rész
            int aSav, bSav, cSav;
            


            //Fájl beolvasása és adatok eltárolása

            StreamReader olvasocsatorna = new StreamReader("utca.txt");

            string elsosor = olvasocsatorna.ReadLine();
            string sor;

            aSav = int.Parse(elsosor.Split(' ')[0]);  //ez feldarabolja szóköz mentén
            bSav = int.Parse(elsosor.Split(' ')[1]);
            cSav = int.Parse(elsosor.Split(' ')[2]);

            List<EpitmenyStruktura> adatok = new List<EpitmenyStruktura>(); //a struktúra felhasználásával készült lista, az első sort leszámítva ide kerül az összes adat
            string[] darabol;

            while (!olvasocsatorna.EndOfStream) //addig olvas amíg nincsen vége a fájlnak || olvasocsatorna.EndOfStream != true
            {
                sor = olvasocsatorna.ReadLine();
                darabol = sor.Split(' ');

                EpitmenyStruktura epitmeny = new EpitmenyStruktura(); //példányosítás

                epitmeny.tulajAdoszam = darabol[0];
                epitmeny.Utcanev = darabol[1];
                epitmeny.Hazszam = darabol[2];
                epitmeny.Adosav = char.Parse(darabol[3]);
                epitmeny.Terulet = int.Parse(darabol[4]);

                adatok.Add(epitmeny);
            }

            olvasocsatorna.Close();


            //2.feladat
            Console.WriteLine($"2. feladat. A mintában {adatok.Count} telek szerepel.");


            //3.feladat
            Console.Write("3. feladat. Egy tulajdonos adószáma: ");
            string bekert_adoszam;
            bekert_adoszam = Console.ReadLine();
            bool talalt = false;


            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].tulajAdoszam == bekert_adoszam)
                {
                    Console.WriteLine(adatok[i].Utcanev + " utca " + adatok[i].Hazszam);
                    talalt = true;
                }
            }

            if(!talalt)
            {
                Console.WriteLine("Nem szerepel az adatállományban.");
            }



        }
    }
}
