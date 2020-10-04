using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milliomos
{
    class Beugro
    {
        private List<SorKerd> beugro = new List<SorKerd>();

        public Beugro(List<SorKerd> beugro)
        {
            this.beugro = beugro;
        }

        public bool BeugroKerd()
        {
            Console.Clear();

            bool valasz = Kerdes(beugro);

            if (valasz == true)
            {
                Console.Clear();
                Console.WriteLine("Gratulálunk! \n Bent van!");
                Console.ReadKey();
                return true;
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Ez most nem sikerült.");
                Console.ReadKey();
                return false;
            }
        }

        private bool Kerdes(List<SorKerd> krds)
        {
            var r = new Random();
            int n = r.Next(0, beugro.Count);
            string valasz;
            bool check = false;

            while (true)
            {
                Console.WriteLine(krds[n]);
                //Console.WriteLine(krds[n].Helyes);
                Console.WriteLine();

                Console.Write("Válasza: ");
                valasz = Console.ReadLine();

                if (valasz.ToUpper() == krds[n].Helyes)
                {
                    check = true;
                    break;
                }
                else 
                {
                    break;
                }
            }
            return check;
        }
    }
}
