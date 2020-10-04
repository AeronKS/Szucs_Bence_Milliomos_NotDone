using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milliomos
{
    class Valid
    {
        private int choice;

        //Két irányú validálást végez
        public bool MakeValid()
        {
            bool valid = false;

            while (true)
            {
                try
                {
                    Console.Write("Válasza? ");
                    choice = Int32.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        valid = true;
                        break;
                    }
                    else if (choice == 2)
                    {
                        valid = false;
                        break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Ilyen lehetőség nem létezik!");
                }
            }

            return valid;

        }
    }
}
