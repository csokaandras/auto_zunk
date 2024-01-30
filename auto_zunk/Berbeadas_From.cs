using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace auto_zunk
{
    public partial class Berbeadas_From : Form
    {
        static List<Jarmu> jarmuvek = new List<Jarmu>();
        static List<Ugyfel> ugyfelek = new List<Ugyfel>();
        static List<Berbeadas> berbeadasok = new List<Berbeadas>();

        public Berbeadas_From()
        {
            InitializeComponent();
            this.CenterToScreen();
            Beolvas_berbeadasok();


            StatisztikaSzamitas();
        }

        private void StatisztikaSzamitas()
        {
            List<string> legtobbAuto = new List<string>();
            List<string> legtobbUgyfel = new List<string>();
            List<string> legtobbNap = new List<string>();

            int osszKM = 0;
            int AutoIndex = 0;
            int UgyfelIndex = 0;
            int NapIndex = 0;
            int Sum = 0;
            for (int i = 0; i < berbeadasok.Count; i++)
            {
                //Összes bevétel
                osszKM = berbeadasok[i].elvitel_km - berbeadasok[i].vissza_km;

                //Legtöbb autó
                if (!legtobbAuto.Contains(berbeadasok[i].auto.rendszam))
                {
                    legtobbAuto.Add(berbeadasok[i].auto.rendszam);
                }
                else
                {
                    AutoIndex = legtobbAuto.IndexOf(berbeadasok[i].auto.rendszam);
                    legtobbAuto[AutoIndex + 1] = (Convert.ToInt32(legtobbAuto[AutoIndex + 1]) + 1).ToString();
                }

                //Legtöbb ügyfél
                if (!legtobbUgyfel.Contains(berbeadasok[i].ugyfel.nev))
                {
                    legtobbUgyfel.Add(berbeadasok[i].ugyfel.nev);
                }
                else
                {
                    UgyfelIndex = legtobbUgyfel.IndexOf(berbeadasok[i].ugyfel.nev);
                    legtobbUgyfel[UgyfelIndex + 1] = (Convert.ToInt32(legtobbUgyfel[UgyfelIndex + 1]) + 1).ToString();
                }

                //Átlag bérbeadás / nap
                if(!legtobbNap.Contains(berbeadasok[i].elvitel_datum.ToString()))
                {
                    legtobbNap.Add(berbeadasok[i].elvitel_datum.ToString());
                }
                else
                {
                    NapIndex = legtobbNap.IndexOf(berbeadasok[i].elvitel_datum.ToString());
                    legtobbNap[NapIndex+1] = (Convert.ToInt32(legtobbNap[NapIndex + 1]) + 1).ToString();
                }
            }

            for (int o = 0; o < legtobbNap.Count; o++)
            {
                if (legtobbNap.IndexOf(legtobbNap[o])%2==1)
                {
                    Sum += Convert.ToInt32(legtobbNap[o]);
                }
            }
            int osszeBevetel = osszKM * 250;


            statisztikaTBOX.Items.Add($"---------Statisztika---------");
            statisztikaTBOX.Items.Add($"Összes bevétel : {osszeBevetel} Ft");
            statisztikaTBOX.Items.Add($"Legtöbbet kiadott autó: {legtobbAuto.Max()}-szor lett kiadva. Rendszáma: {legtobbAuto[legtobbAuto.IndexOf(legtobbAuto.Max())-1]}");
            statisztikaTBOX.Items.Add($"Legtöbbet kölcsönző ügyfél: {legtobbUgyfel.Max()}-szor bérelt. Neve: {legtobbAuto[legtobbUgyfel.IndexOf(legtobbUgyfel.Max()) - 1]}");
            statisztikaTBOX.Items.Add($"Átlagos kölcsönzés naponta: {Sum/(legtobbNap.Count/2)}");

        }

        private void Beolvas_berbeadasok()
        {
            try
            {
                StreamReader file = new StreamReader("berbeadasok.csv");
                file.ReadLine();
                while (!file.EndOfStream)
                {
                    string[] sor = file.ReadLine().Split(';');
                    Jarmu auto = jarmuvek.Find(item => item.rendszam.Equals(sor[0]));
                    Ugyfel berlo = ugyfelek.Find(item => item.sz_ig.Equals(sor[1]));
                    berbeadasok.Add(new Berbeadas(auto, berlo, Convert.ToDateTime(sor[2]), Convert.ToDateTime(sor[3]), Convert.ToInt32(sor[4]), Convert.ToInt32(sor[5]), Convert.ToInt32(sor[6])));
                }
                file.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Hiba a berbeadasok.csv beolvasással");
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


        private void Berbeadas_From_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void autokkezeleseBTN2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autok ujForm = new Autok();
            ujForm.ShowDialog();
        }

        private void ugyfelekkezelesBTN2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ujForm = new Form1();
            ujForm.ShowDialog();
        }
    }
}
