using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_zunk
{
    class Ugyfel
    {
        public int sz_ig;
        public string nev;
        public string lakcim;

        public Ugyfel(string[] ugyfel)
        {
            sz_ig = Convert.ToInt32(ugyfel[0]);
            nev = ugyfel[1];
            lakcim = ugyfel[2];
        }
    }
}
