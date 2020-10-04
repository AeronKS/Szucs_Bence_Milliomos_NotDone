using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Milliomos
{
    class SorKerd
    {
        private List<SorKerd> sorkrds = new List<SorKerd>();

        private string kerdes;
        private string a;
        private string b;
        private string c;
        private string d;
        private string helyes;
        private string tema;

        internal List<SorKerd> Sorkrds { get => sorkrds; set => sorkrds = value; }
        public string Helyes { get => helyes; set => helyes = value; }

        public override string ToString()
        {
            return this.tema + 
                "\n\n" + this.kerdes + 
                "\n\n\tA: " + this.a + 
                "\n\n\tB: " + this.b + 
                "\n\n\tC: " + this.c + 
                "\n\n\tD: " + this.d ;
        }

        public void Beolv()
        {
            StreamReader sr = new StreamReader("sorkerdes.txt");
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(';');
                var sor_temp = new SorKerd
                {
                    kerdes = temp[0],
                    a = temp[1],
                    b = temp[2],
                    c = temp[3],
                    d = temp[4],
                    Helyes = temp[5],
                    tema = temp[6]
                };

                Sorkrds.Add(sor_temp);
            }
            sr.Close();
        }
    }
}
