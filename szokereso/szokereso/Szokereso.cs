using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szokereso
{
    internal class Szokereso
    {
        public string Szo;
        public int S_index;
        public int O_index;
        public int Irany;

        public Szokereso(string Sor)
        {
            var dbok = Sor.Split('*');

            Szo = dbok[0];
            S_index = int.Parse(dbok[1]);
            O_index = int.Parse(dbok[2]);
            Irany = int.Parse(dbok[3]);
        }

    }
}
