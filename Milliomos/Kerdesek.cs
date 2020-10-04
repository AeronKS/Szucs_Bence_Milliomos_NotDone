using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Milliomos
{
    class Kerdesek
    {
        private List<Kerdes> krds = new List<Kerdes>(); // Main lista
        private List<Kerdes> temp = new List<Kerdes>(); // Temp lista
        private int counter = 1;  // tárolandó szint
        

        public Kerdesek(List<Kerdes> krds)
        {
            this.krds = krds;
        }


        public void KerdDef()
        {
            var v = new Valid();
            var l = new leadb();
            
            while (counter <= 15)
            {
                bool valasz;

                Console.Clear();
                temp.Clear();

                Szur(counter);
                valasz = KerdVal(temp);

                if (valasz == true)
                {
                    Console.WriteLine("Jó válasz!");

                    //Kérdés után
                    if (counter == 15)
                    {
                        Console.Clear();
                        Console.WriteLine("Gratulálunk, ÖN milliomos!");
                        //leaderboard
                        l.Beir(counter);

                        Console.ReadKey();
                        break; 
                    }
                    else if (counter < 15)
                    {
                        Console.Clear();
                        Console.WriteLine("Folytatja?" +
                            "\n\t1. Igen" +
                            "\n\t2. Nem");
                        //validálás
                        if (v.MakeValid() == false)
                        {
                            Console.Clear();
                            
                            //leaderboard
                            Console.WriteLine("Köszönjük a részvételt!");
                            l.Beir(counter);
                            break;
                        }
                        else 
                        {
                            counter++;
                        }
                    }

                    //Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Nem jó válasz, vesztettél!");

                    Console.ReadKey();
                    break;
                }
            }
        }

        //Kiszűri a temp listába a kérdéseket
        private void Szur(int count)
        {
            foreach (var x in krds)
            {
                if (x.Szint == count)
                {
                    temp.Add(x);
                }
            }
        }
        
        //meghatározza a kérdést és a választ
        private bool KerdVal(List<Kerdes> kv)
        {
            Random r = new Random();
            string valasz; //felhasználó válasza

            int n = r.Next(0, temp.Count);

            Console.WriteLine(kv[n]);
            //Console.WriteLine(kv[n].Helyes);
            Console.WriteLine();

            bool set;
            while (true)
            {
                Console.Write(kv[n].Szint + "\tVálasza? ");
                valasz = Console.ReadLine();

                if (IsValaszAvailable(valasz) == true)
                {
                    //ellenőrzi a válasz helyességét
                    if (valasz.ToUpper() == kv[n].Helyes)
                    {
                        set = true;
                        break;
                    }
                    else
                    {
                        set = false;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ilyen lehetősség nem létezik!");
                }
            }

            return set;
        }

        //ellenőrzi, hogy létezik e ilyen lehetőség
        private bool IsValaszAvailable(string v)
        {
            string[] s = new string[4] { "A", "B", "C", "D" };
            bool x = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == v.ToUpper())
                {
                    x = true;
                    break;
                }
            }

            return x;
        }
    }
}
