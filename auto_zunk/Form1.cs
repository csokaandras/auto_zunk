using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace auto_zunk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<Jarmu> jarmuvek = new List<Jarmu>();
        static List<Ugyfel> ugyfelek = new List<Ugyfel>();
        static List<Berbeadas> berbeadasok = new List<Berbeadas>();
        private void Kiiras_jarmu()
        {
            try
            {
                StreamWriter file = new StreamWriter("jarmu.csv");
                file.WriteLine("rendszam;tipus;gyarto;modell;kiadva;km");
                foreach(Jarmu item in jarmuvek)
                {
                    file.WriteLine(item.rendszam + ";" + item.tipus + ";" + item.gyarto + ";" + item.modell + ";" + item.kiadva + ";" + item.km);
                }
                file.Close();
            }
            catch (IOException)
            {    
                MessageBox.Show("Hiba a jarmu.csv kiírással");
            }
        }

        private void Kiiras_ugyfel()
        {
            try
            {
                StreamWriter file = new StreamWriter("ugyfel.csv");
                file.WriteLine("sz_ig;nev;lakcim");
                foreach (Ugyfel item in ugyfelek)
                {
                    file.WriteLine(item.sz_ig + ";" + item.nev + ";" + item.lakcim);
                }
                file.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Hiba a ugyfel.csv kiírással");
            }
        }

        private void Kiiras_berbeadasok()
        {
            try
            {
                StreamWriter file = new StreamWriter("berbeadasok.csv");
                file.WriteLine("rendszam;sz_ig;elvitel_datuma;visszahozas_datuma;elvitel_km;visszahozas_km;osszeg");
                foreach (Berbeadas item in berbeadasok)
                {
                    file.WriteLine(item.auto.rendszam + ";" + item.ugyfel.sz_ig + ";" + item.elvitel_datum + ";" + item.vissza_datum + ";" + item.elvitel_km + ";" + item.vissza_km + ";" + item.osszeg);
                }
                file.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Hiba a berbeadasok.csv kiírással");
            }
        }
    }
}
