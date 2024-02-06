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

        static int kmAra = 100;

        static bool isLoaded = false;
        static int selectedIndex = -1;

        public Berbeadas_From()
        {
            InitializeComponent();
            this.CenterToScreen();
            Beolvas_jarmuvek();
            Beolvas_ugyfel();
            Beolvas_berbeadasok();
            
            CboxFeltoltes();
            UgyfelGridUpdate();


            //StatisztikaSzamitas();
        }

        private void CboxFeltoltes()
        {
            for (int i = 0; i < jarmuvek.Count; i++)
            {
                autoCBOX.Items.Add(jarmuvek[i].rendszam);
            }

            for (int o = 0; o < ugyfelek.Count; o++)
            {
                ugyfelCBOX.Items.Add(ugyfelek[o].sz_ig);
            }
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
            int osszeBevetel = osszKM * 100;


            statisztikaTBOX.Items.Add($"---------Statisztika---------");
            statisztikaTBOX.Items.Add($"Összes bevétel : {osszeBevetel} Ft");
            statisztikaTBOX.Items.Add($"Legtöbbet kiadott autó: {legtobbAuto.Max()}-szor lett kiadva. Rendszáma: {legtobbAuto[legtobbAuto.IndexOf(legtobbAuto.Max())-1]}");
            statisztikaTBOX.Items.Add($"Legtöbbet kölcsönző ügyfél: {legtobbUgyfel.Max()}-szor bérelt. Neve: {legtobbAuto[legtobbUgyfel.IndexOf(legtobbUgyfel.Max()) - 1]}");
            statisztikaTBOX.Items.Add($"Átlagos kölcsönzés naponta: {Sum/(legtobbNap.Count/2)}");

        }
        //Be olvasások
        private void Beolvas_jarmuvek()
        {
            try
            {
                StreamReader file = new StreamReader("jarmu.csv");
                file.ReadLine();
                while (!file.EndOfStream)
                {
                    jarmuvek.Add(new Jarmu(file.ReadLine().Split(';')));
                }
                file.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Hiba a jarmu.csv beolvasással");
            }
        }

        private void Beolvas_ugyfel()
        {
            try
            {
                ugyfelek.Clear();
                StreamReader file = new StreamReader("ugyfel.csv");
                file.ReadLine();
                while (!file.EndOfStream)
                {
                    ugyfelek.Add(new Ugyfel(file.ReadLine().Split(';')));
                }
                file.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Hiba a ugyfel.csv beolvasással");
            }
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
                    Ugyfel berlo = ugyfelek.Find(item => item.sz_ig.Equals(Convert.ToInt32(sor[1])));
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
                    file.WriteLine(item.auto.rendszam + ";" + item.ugyfel.sz_ig + ";" + item.elvitel_datum + ";" + item.vissza_datum + ";" + item.elvitel_km + ";" + item.vissza_km + ";" + item.osszeg + ";");
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

        private void felveszBTN_Click(object sender, EventArgs e)
        {
            if (autoCBOX.SelectedItem != null && ugyfelCBOX.SelectedItem != null && elvitelDTP.Text != "" || visszahozatalDTP.Text != "" || elvitelkmoraTBOX.Text != "" || visszaKmTBOX.Text != "")
            {
                isLoaded = false;
                Jarmu KivAuto = jarmuvek.Find(element => element.rendszam.Equals(autoCBOX.SelectedItem));
                Ugyfel KivUgyfel = ugyfelek.Find(element => element.sz_ig.Equals(ugyfelCBOX.SelectedItem));
                /*
                for (int i = 0; i < jarmuvek.Count; i++)
                {
                    if (jarmuvek[i].rendszam == autoCBOX.Text)
                    {
                        KivAuto = jarmuvek[i];
                    }
                }
                
                for (int o = 0; o < ugyfelek.Count; o++)
                {
                    if (ugyfelek[o].sz_ig == Convert.ToInt32(ugyfelCBOX.Text))
                    {
                        KivUgyfel = ugyfelek[o];
                    }
                }
                */
                berbeadasok.Add(new Berbeadas(KivAuto, KivUgyfel, Convert.ToDateTime(elvitelDTP.Value), Convert.ToDateTime(visszahozatalDTP.Value), Convert.ToInt32(elvitelkmoraTBOX.Text), Convert.ToInt32(visszaKmTBOX.Text), (Convert.ToInt32(visszaKmTBOX.Text) - Convert.ToInt32(elvitelkmoraTBOX.Text)) * kmAra));
                UgyfelGridUpdate();
                MessageBox.Show("Hozzá van adva az új adat!");
            }
            else
            {
                MessageBox.Show("Kérem adjon meg minden adatot!");
            }
        }

        private void modositBTN_Click(object sender, EventArgs e)
        {
            if (autoCBOX.SelectedItem != null && ugyfelCBOX.SelectedItem != null && elvitelDTP.Text != "" || visszahozatalDTP.Text != "" || elvitelkmoraTBOX.Text != "" || visszaKmTBOX.Text != "")
            {
                isLoaded = false;
                int index = dataGridView1.CurrentRow.Index;
                Jarmu KivAuto = null;
                Ugyfel KivUgyfel = null;

                for (int i = 0; i < jarmuvek.Count; i++)
                {
                    if (jarmuvek[i].rendszam == autoCBOX.Text)
                    {
                        KivAuto = jarmuvek[i];
                    }
                }

                for (int o = 0; o < ugyfelek.Count; o++)
                {
                    if (ugyfelek[o].sz_ig == Convert.ToInt32(ugyfelCBOX.Text))
                    {
                        KivUgyfel = ugyfelek[o];
                    }
                }
                berbeadasok[index].auto = KivAuto;
                berbeadasok[index].ugyfel = KivUgyfel;
                berbeadasok[index].elvitel_datum = Convert.ToDateTime(elvitelDTP.Text);
                berbeadasok[index].vissza_datum = Convert.ToDateTime(visszahozatalDTP.Text);
                berbeadasok[index].vissza_km = Convert.ToInt32(visszaKmTBOX.Text);
                berbeadasok[index].elvitel_km= Convert.ToInt32(elvitelkmoraTBOX.Text);
                UgyfelGridUpdate();
                MessageBox.Show("Adat módosítva.");

            }
            else
            {
                MessageBox.Show("Nem adta meg a szükséges adatokat.");
            }
        }

        private void ugyfelGrid_SelectionChanged(object sender, EventArgs e)
        {
            int index;
            if (isLoaded)
            {
                if (selectedIndex == -1)
                {
                    index = dataGridView1.CurrentRow.Index;
                }
                else
                {
                    index = selectedIndex;
                }

                if (index > -1)
                {
                    autoCBOX.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    ugyfelCBOX.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    elvitelDTP.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    visszahozatalDTP.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    elvitelkmoraTBOX.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    visszaKmTBOX.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    dataGridView1.Rows[index].Cells[6].Value = Convert.ToInt32(visszaKmTBOX.Text) - Convert.ToInt32(elvitelkmoraTBOX.Text) * kmAra;

                    torolBTN.Enabled = true;
                    felveszBTN.Enabled = false;
                    modositBTN.Enabled = true;
                }
            }
        }

        private void UgyfelGridUpdate()
        {
            dataGridView1.Rows.Clear();
            berbeadasok.ForEach(item =>
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = item.auto.rendszam;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = item.ugyfel.sz_ig;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = item.elvitel_datum;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = item.vissza_datum;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = item.elvitel_km;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value = item.vissza_km;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Value = item.osszeg;
            });
            Kiiras_berbeadasok();
            SetDefaultState();
            isLoaded = true;
        }

        private void SetDefaultState()
        {
            dataGridView1.ClearSelection();
            autoCBOX.Items.Clear();
            ugyfelCBOX.Items.Clear();
            elvitelDTP.Text = "";
            visszahozatalDTP.Text = "";
            elvitelkmoraTBOX.Text = "";
            visszaKmTBOX.Text = "";

            torolBTN.Enabled = false;
            modositBTN.Enabled = false;
            felveszBTN.Enabled = true;
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SetDefaultState();
            }
        }
    }
}
