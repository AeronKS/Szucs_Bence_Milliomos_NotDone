using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Milliomos
{
    class Kerdes
    {
        private List<Kerdes> krds_temp = new List<Kerdes>();

        private int szint;
        private string krds;
        private string a;
        private string b;
        private string c;
        private string d;
        private string helyes;
        private string tema;

        public int Szint { get => szint; set => szint = value; }
        public string Krds { get => krds; set => krds = value; }
        public string A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
        public string C { get => c; set => c = value; }
        public string D { get => d; set => d = value; }
        public string Tema { get => tema; set => tema = value; }
        public string Helyes { get => helyes; set => helyes = value; }
        public List<Kerdes> Krds_temp { get => krds_temp; set => krds_temp = value; }

        public override string ToString()
        {
            return Tema + 
                "\n\n" + this.Krds + 
                    "\n\n\tA: " + this.A + 
                    "\n\n\tB: " + this.b + 
                    "\n\n\tC: " + this.C + 
                    "\n\n\tD: " + this.D;
        }

        public void Beolv()
        {
            StreamReader sr = new StreamReader("kerdes.txt");
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(';');
                Kerdes kerd = new Kerdes
                {
                    Szint = Convert.ToInt32(temp[0]),
                    Krds = temp[1],
                    A = temp[2],
                    B = temp[3],
                    C = temp[4],
                    D = temp[5],
                    Helyes = temp[6],
                    Tema = temp[7]
                };

                Krds_temp.Add(kerd);
            }
            sr.Close();
        }
    }
}
