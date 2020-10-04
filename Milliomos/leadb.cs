using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Milliomos
{
    class leadb
    {
        private string nev;
        private int score;
        private List<leadb> lb = new List<leadb>();

        public override string ToString()
        {
            return this.nev + ";" + this.score;
        }

        //játékos neve és pontszáma
        public void Beir(int count)
        {
            while (true)
            {
                Console.Write("\nAdja meg a nevét!\t");
                string temp_nev = Console.ReadLine();

                if (!(String.IsNullOrEmpty(temp_nev)))
                {
                    var b = new leadb()
                    {
                        nev = temp_nev,
                        score = count
                    };

                    lb.Add(b);
                    break;
                }
            }
            Kiir();
        }

        //eredmény fájlba írása
        private void Kiir()
        {
            StreamWriter sw = new StreamWriter("leadb.txt", true, Encoding.UTF8);
            for (int i = 0; i < lb.Count; i++)
            {
                sw.WriteLine(lb[i]);
            }
            sw.Close();
            lb.Clear();

            PontKiir();
            Console.ReadKey();
        }

        public void PontKiir()
        {
            Console.Clear();
            try
            {
                StreamReader sr = new StreamReader("leadb.txt");
                while (!sr.EndOfStream)
                {
                    string[] temp = sr.ReadLine().Split(';');
                    leadb k = new leadb
                    {
                        nev = temp[0],
                        score = Int32.Parse(temp[1])
                    };

                    lb.Add(k);
                }
                sr.Close();

                //Linq ORDER BY ...
                
                Console.WriteLine("{0,-30}{1}", "Neve:", "Helyes válaszok:");
                for (int i = 0; i < lb.Count; i++)
                {
                    Console.WriteLine("\n{0,-40}{1}", lb[i].nev, lb[i].score);
                }
                lb.Clear();
            }
            catch (Exception)
            {
                Console.WriteLine("Nincsenek még eredmények.");
            }
        }
    }
}
