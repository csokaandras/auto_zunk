using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_zunk
{
    class Berbeadas
    {
        public Jarmu auto;
        public Ugyfel ugyfel;
        public DateTime elvitel_datum;
        public DateTime vissza_datum;
        public int elvitel_km;
        public int vissza_km;
        public int osszeg;
    
        public Berbeadas(Jarmu auto, Ugyfel ugyfel, DateTime e_date, DateTime v_date, int e_km, int v_km, int osszeg)
        {
            this.auto = auto;
            this.ugyfel = ugyfel;
            elvitel_datum = e_date;
            vissza_datum = v_date;
            elvitel_km = e_km;
            vissza_km = v_km;
            this.osszeg = osszeg;
        }
    }
}
