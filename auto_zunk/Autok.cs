using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_zunk
{
    public partial class Autok : Form
    {
        public Autok()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        static List<Jarmu> jarmuvek = new List<Jarmu>();
        static bool isLoaded = false;
        static int selectedIndex = -1;

        private void Autok_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ugyfelekkezeleseBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ujForm = new Form1();
            ujForm.ShowDialog();
        }

        private void berbeadasokBTN2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Berbeadas_From ujForm = new Berbeadas_From();
            ujForm.ShowDialog();
        }


        
        private void Kiiras_jarmu()
        {
            try
            {
                StreamWriter file = new StreamWriter("jarmu.csv");
                file.WriteLine("rendszam;tipus;gyarto;modell;kiadva;km");
                foreach (Jarmu item in jarmuvek)
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

        private void Beolvas_jarmuvek()
        {
            try
            {
                jarmuvek.Clear();
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

        //hozzáad
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
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
