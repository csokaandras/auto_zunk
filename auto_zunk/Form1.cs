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
            this.CenterToScreen();
            Beolvas_ugyfel();
            UgyfelGridUpdate();
        }

        static List<Jarmu> jarmuvek = new List<Jarmu>();
        static List<Ugyfel> ugyfelek = new List<Ugyfel>();
        static List<Berbeadas> berbeadasok = new List<Berbeadas>();

        static bool isLoaded = false;
        static int selectedIndex = -1;

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

        private void berbeadasokBTN1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Berbeadas_From ujForm = new Berbeadas_From();
            
            ujForm.ShowDialog();
        }
        
        private void UgyfelGridUpdate()
        {
            ugyfelGrid.Rows.Clear();
            ugyfelek.ForEach(item =>
            {
                ugyfelGrid.Rows.Add();
                ugyfelGrid.Rows[ugyfelGrid.Rows.Count - 1].Cells[0].Value = item.sz_ig;
                ugyfelGrid.Rows[ugyfelGrid.Rows.Count - 1].Cells[1].Value = item.nev;
                ugyfelGrid.Rows[ugyfelGrid.Rows.Count - 1].Cells[2].Value = item.lakcim;
            });
            Kiiras_ugyfel();
            ugyfelGrid.ClearSelection();
            SetDefaultState();
            isLoaded = true;
        }

        private void SetDefaultState()
        {
            ugyfelGrid.ClearSelection();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
            button2.Enabled = false;
            button4.Enabled = true;
            button3.Enabled = false;
        }
        
        private void autokkezeleseBTN2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autok ujForm = new Autok();
            
            ujForm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }

        //hozzáad
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text != "" && textBox3.Text != "")
            {
                isLoaded = false;
                string uj_ugyfel = textBox3.Text + ";" + textBox2.Text + ";" + textBox1.Text;
                ugyfelek.Add(new Ugyfel(uj_ugyfel.Split(';')));
                UgyfelGridUpdate();
                MessageBox.Show("Hozzá van adva az új adat!");
            }
            else
            {
                MessageBox.Show("Kérem adjon meg minden adatot!");
            }
        }
        
        //módosítás
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                isLoaded = false;
                int index = ugyfelGrid.CurrentRow.Index;
                ugyfelek[index].sz_ig = Convert.ToInt32(textBox3.Text);
                ugyfelek[index].nev = textBox2.Text;
                ugyfelek[index].lakcim = textBox1.Text;
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
                    index = ugyfelGrid.CurrentRow.Index;
                }
                else
                {
                    index = selectedIndex;
                }

                if (index > -1)
                {
                    textBox3.Text = ugyfelGrid.Rows[index].Cells[0].Value.ToString();
                    textBox2.Text = ugyfelGrid.Rows[index].Cells[1].Value.ToString();
                    textBox1.Text = ugyfelGrid.Rows[index].Cells[2].Value.ToString();

                    button2.Enabled = true;
                    button4.Enabled = false;
                    button3.Enabled = true;                    
                }
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SetDefaultState();
            }
        }

        //törlés
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bizti?", "Megerősítés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                isLoaded = false;
                int index = ugyfelGrid.CurrentRow.Index;
                ugyfelek.RemoveAt(index);
                UgyfelGridUpdate();
                MessageBox.Show("Sikeresen törölve!");
            }
        }
    }
}
