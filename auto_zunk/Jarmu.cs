using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_zunk
{
    class Jarmu
    {
        public string rendszam;
        public string tipus;
        public string gyarto;
        public string modell;
        public byte kiadva; // 1 ha ki van már adva 0 ha még nincs kiadva
        public int km;

        public Jarmu(string[] jarmuvek)
        {
            rendszam = jarmuvek[0];
            tipus = jarmuvek[1];
            gyarto = jarmuvek[2];
            modell = jarmuvek[3];
            kiadva = Convert.ToByte(jarmuvek[4]);
            km = Convert.ToInt32(jarmuvek[5]);
        }
    }
}
