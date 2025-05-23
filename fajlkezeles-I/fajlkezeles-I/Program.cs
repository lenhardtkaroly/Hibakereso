using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //ezt be kell importálni

namespace fajlkezeles_I
{
    class Program
    {
        static void penzfeldobas() 
        {
            double fejekszama = 0;
            double irasokszama;
            double irasokszazaleka;
            int irasutaniras = 0;
            int fejirasfej = 0;


            //Pénzfeldobások elemzése feladat
            Console.WriteLine("Pénzfeldobások elemzése program");

            //Deklaráció
            List<string> dobasok = new List<string>();  //lista létrehozása a dobások tárolásához

            //Fájl megnyitása olvasásra
            StreamReader olvasocsatorna = new StreamReader(@"E:\c#\penzfeldobas.txt", Encoding.GetEncoding("iso-8859-2"), false);
            string dobas = olvasocsatorna.ReadLine();

            while(dobas != null)
            {
                dobasok.Add(dobas);
                dobas = olvasocsatorna.ReadLine();
            }
            olvasocsatorna.Close();


            //Feladatok elvégzése
            Console.WriteLine("a.) A pénzfeldobások száma: {0}", dobasok.Count);


            foreach (string ertek in dobasok)
            {
                if (ertek == "F")
                {
                    fejekszama++;
                }
            }
            Console.WriteLine("b.) A fejek száma: {0}", fejekszama);

            irasokszama = dobasok.Count - fejekszama;
            irasokszazaleka = irasokszama / dobasok.Count * 100; 
            Console.WriteLine("c.) Az írások százaléka: {0}%", Math.Round(irasokszazaleka),2);


            for (int i = 1; i < dobasok.Count; i++)
            {
                if (dobasok[i] == "I" && dobasok[i-1] == "I")
                {
                    irasutaniras++;
                }
            }
            Console.WriteLine("d.) Az írás után következett írások száma: {0}", irasutaniras);

            for (int i = 2; i < dobasok.Count; i++)
            {
                if (dobasok[i] == "F" && dobasok[i - 1] == "I" && dobasok[i-2] == "F")
                {
                    fejirasfej++;
                }
            }
            Console.WriteLine("e.) A fej-írás-fej sorozatok száma: {0}", fejirasfej);

        }

        static void Main(string[] args)
        {
            penzfeldobas();
            Console.ReadLine();
        }
    }
}
