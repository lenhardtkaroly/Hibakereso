using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //ezt be kell importálni


namespace FajlkezelesBevezetes
{
    class Program
    {
        static void fel01() 
        {
            //fájlba írás StreamWriter segítségével

            Console.WriteLine("Fájlba írás...");

            StreamWriter irocsatorna = new StreamWriter(@"E:\c#\hello.txt", false, Encoding.GetEncoding("iso-8859-2"));  //hello.txt, ezt is lehet használni és akkor ugyanoda kerül a fájl ahol a kód van, a false nem kötelező paraméter
            irocsatorna.WriteLine("Helló, Karcsi vagyok.");
            irocsatorna.WriteLine("Ez a fájl második sora.");
            irocsatorna.WriteLine("ŐÜÖÓÚŰÁÉ");

            irocsatorna.Close();

            Console.WriteLine("Fájlba írás kész.");
        }


        static void fel02()
        {
            //fájl tartalmának kiolvasása StreamReader segítségével

            Console.WriteLine("Fájlból olvasás...");

            StreamReader olvasocsatorna = new StreamReader(@"E:\c#\hello.txt", Encoding.GetEncoding("iso-8859-2"), false);
            //StreamReader olvasocsatorna = new StreamReader(@"E:\c#\hello.txt");  //itt az ékezetek nem jól jelennek meg

            Console.WriteLine(olvasocsatorna.ReadLine());  //kiírja a konzolra azt amit az elsősorban talált
            Console.WriteLine(olvasocsatorna.ReadLine());
            Console.WriteLine(olvasocsatorna.ReadLine());

            olvasocsatorna.Close();

            Console.WriteLine("Fájlból olvasás vége.");
        }


        static void fel03()
        {
            Console.WriteLine("Randomok fájlba.");
            int mennyiseg;
            Random rnd = new Random();

            Console.Write("Hány számot generáljon a program? ");
            mennyiseg = int.Parse(Console.ReadLine());

            Console.WriteLine("Fájlba írás...");
            StreamWriter irocsatorna = new StreamWriter(@"E:\c#\veletlenek.txt");

            for (int i = 1; i <=mennyiseg; i++)
            {
                irocsatorna.WriteLine(rnd.Next(50, 501));
            }

            irocsatorna.Close();
            Console.WriteLine("Fájlba írás kész.");
        }

        static void fel04()
        {
            string sor;
            Console.WriteLine("Randomok olvasása fájlból.");

            Console.WriteLine("Fájlból olvasás...");
            StreamReader olvasocsatorna = new StreamReader(@"E:\c#\veletlenek.txt", Encoding.GetEncoding("iso-8859-2"), false);

            sor = olvasocsatorna.ReadLine();

            while(sor != null)
            {
                Console.WriteLine(sor);
                sor = olvasocsatorna.ReadLine();
            }
            olvasocsatorna.Close();

            Console.WriteLine("Fájból olvasás vége.");

        }


        static void fel05()
        {
            int darab = 0;
            double atlag = 0;
            
            Console.WriteLine("Randomok átlaga.");
            Console.WriteLine("Fájlból olvasás...");
            StreamReader olvasocsatorna = new StreamReader(@"E:\c#\veletlenek.txt", Encoding.GetEncoding("iso-8859-2"), false);
            string sor = olvasocsatorna.ReadLine();

            while (sor != null)
            {
                atlag = atlag + double.Parse(sor);
                darab = darab + 1;
                sor = olvasocsatorna.ReadLine();
            }
            olvasocsatorna.Close();
            
            Console.WriteLine("Fájból olvasás vége.");

            atlag = atlag / darab;
            Console.WriteLine("Átlag = {0}", atlag);
        }


        static void fel06() 
        {
            int darab;
            int dobas;
            Random rnd = new Random();
            
            Console.WriteLine("Pénzfeldobás program");

            Console.Write("Kérek egy számot: ");
            darab = int.Parse(Console.ReadLine());


            Console.WriteLine("Fájlba írás...");
            StreamWriter irocsatorna = new StreamWriter(@"E:\c#\penzfeldobasok.txt");

            for (int i = 1; i <= darab; i++)
            {
                dobas = rnd.Next(0, 2);

                if(dobas == 0)
                {
                    irocsatorna.WriteLine("F");
                }
                else
                {
                    irocsatorna.WriteLine("I");
                }
            }

            irocsatorna.Close();

            Console.WriteLine("Fájlba írás vége.");


        }
        static void Main(string[] args)
        {
            /*
             Fájlkezelés alaplépései:
             1. lépés a fájl létrehozása és/vagy megnyitása
             2. lépés író vagy olvasó csatorna létrehozása
             3. lépés fájl olvasása/írása
             4. lépés fájl bezárása


            Fájlok két típusa (kezelési típusok) pl. xml, html, txt, csw:
            1. szöveges típusú --> nincs benne formázott szöveg, karakterek alkotják
            2. bináris típusú ---> azok, amiket nem lehet egy egyszerű jegyzettömben megnyitni pl. képek
             */

            //fel01();

            //fel02();

            //fel03();

            //fel04();

            //fel05();

            fel06();
            Console.ReadLine();
        }
    }
}
