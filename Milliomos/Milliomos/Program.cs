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
        static List<Kerdes> krds_temp = new List<Kerdes>();

        static void Beolv()
        {
            StreamReader sr = new StreamReader("kerdes.txt");
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(';');
                Kerdes kerd = new Kerdes();
                kerd.Szint = Convert.ToInt32(temp[0]);
                kerd.Krds = temp[1];
                kerd.A = temp[2];
                kerd.B = temp[3];
                kerd.C = temp[4];
                kerd.D = temp[5];
                kerd.Helyes = temp[6];
                kerd.Tema = temp[7];

                krds_temp.Add(kerd);
            }
            sr.Close();
        }

        static void Main(string[] args)
        {
            Beolv();
            var k = new Kerdesek(krds_temp);
            int MenuChoice = 0;
            do
            {
                try
                {

                    Console.WriteLine("\nLegyen ÖN is Milliomos! " +
                    "\n1. Start" +
                    "\n2. \"Leaderboard\"" +
                    "\n3. Kilépés");
                    Console.Write("Válasszon egy lehetőséget: ");
                    MenuChoice = Int32.Parse(Console.ReadLine());

                    switch (MenuChoice)
                    {
                        case 1:
                            k.KerdDef();

                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Kettes");
                            break;
                        case 3:
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Nincs ilyen lehetőség!");
                            break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Catch: Nincs ilyen lehetőség!");
                }
            } while (MenuChoice != 3);
        }
    }
}
