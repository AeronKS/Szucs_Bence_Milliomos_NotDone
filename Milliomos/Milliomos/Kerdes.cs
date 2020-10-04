using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milliomos
{
    class Kerdes
    {
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

        public override string ToString()
        {
            return Convert.ToString(this.Szint) + ". " + this.Krds + " " + "\n\tA: " + this.A + "\n\tB: " + this.b + "\n\tC: " +
                this.C + "\n\tD: " + this.D;
        }
    }
}
