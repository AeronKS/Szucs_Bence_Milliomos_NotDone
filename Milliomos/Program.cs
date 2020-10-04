using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Milliomos
{
    class Program
    {
        /*
         To-do List:
         - kérdés-válasz *
         - beugro *
         - leaderboard kiirás fájlba*
         - leaderboard beolv. és nyeremény kiirás -> req. enum?
            vagy pont eredmény <- * 
         - segítségek
         */
        static void Main(string[] args)
        {
            var sorKer = new SorKerd();
            var kerdes = new Kerdes();
            var lb = new leadb();
            sorKer.Beolv();
            kerdes.Beolv();

            var s = new Beugro(sorKer.Sorkrds); //beugro-ba
            var k = new Kerdesek(kerdes.Krds_temp); //krds-be

            int MenuChoice = 0;
            do
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("\nLegyen ÖN is Milliomos! " +
                    "\n\n\t1. Start" +
                    "\n\n\t2. Eredménytábla" +
                    "\n\n\t3. Kilépés");
                    Console.Write("\nVálasszon egy lehetőséget: ");
                    MenuChoice = Int32.Parse(Console.ReadLine());

                    switch (MenuChoice)
                    {
                        case 1:
                            if (s.BeugroKerd() == true)
                            {
                                k.KerdDef();
                            }
                            break;

                        case 2:
                            lb.PontKiir();
                            Console.ReadKey();
                            break;

                        case 3:
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Nincs ilyen lehetőség!");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Nincs ilyen lehetőség!");
                    Console.ReadKey();
                }
            } while (MenuChoice != 3);
        }
    }
}
