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
            Beolvas_jarmuvek();
            jarmuGridUpdate();
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

        private void jarmuGridUpdate()
        {
            jarmuGrid.Rows.Clear();
            jarmuvek.ForEach(item =>
            {
                jarmuGrid.Rows.Add();
                jarmuGrid.Rows[jarmuGrid.Rows.Count - 1].Cells[0].Value = item.rendszam;
                jarmuGrid.Rows[jarmuGrid.Rows.Count - 1].Cells[1].Value = item.tipus;
                jarmuGrid.Rows[jarmuGrid.Rows.Count - 1].Cells[2].Value = item.gyarto;
                jarmuGrid.Rows[jarmuGrid.Rows.Count - 1].Cells[3].Value = item.modell;
                jarmuGrid.Rows[jarmuGrid.Rows.Count - 1].Cells[4].Value = item.km;
                if (item.kiadva == 0)
                {
                    jarmuGrid.Rows[jarmuGrid.Rows.Count - 1].Cells[5].Value = "Nem";
                }
                else
                {
                    jarmuGrid.Rows[jarmuGrid.Rows.Count - 1].Cells[5].Value = "Igen";
                }
            });
            Kiiras_jarmu();
            SetDefaultState();
            isLoaded = true;
        }

        private void SetDefaultState()
        {
            jarmuGrid.ClearSelection();
            rendszamTBOX.Text = "";
            gyartoTBOX.Text = "";
            modellTBOX.Text = "";
            kmoraTBOX.Text = "";

            szemelyRBTN.Checked = false;
            teherRBTN.Checked = false;

            felveszBTN.Enabled = true;
            modositBTN.Enabled = false;
            torolBTN.Enabled = false;
        }

        //módosítás
        private void button3_Click(object sender, EventArgs e)
        {
            if (rendszamTBOX.Text != "" 
                && gyartoTBOX.Text != "" 
                && modellTBOX.Text != "" 
                && kmoraTBOX.Text != "" 
                && (!szemelyRBTN.Checked || !teherRBTN.Checked))
            {
                isLoaded = false;
                int index = jarmuGrid.CurrentRow.Index;
                jarmuvek[index].rendszam = rendszamTBOX.Text;
                if (szemelyRBTN.Checked)
                {
                    jarmuvek[index].tipus = "Személy";
                }
                else
                {
                    jarmuvek[index].tipus = "Teher";
                }
                jarmuvek[index].gyarto = gyartoTBOX.Text;
                jarmuvek[index].modell = modellTBOX.Text;
                jarmuvek[index].km = Convert.ToInt32(kmoraTBOX.Text);
                jarmuGridUpdate();
                MessageBox.Show("Adat módosítva.");

            }
            else
            {
                MessageBox.Show("Nem adta meg a szükséges adatokat.");
            }
        }

        private void jarmuGrid_SelectionChanged(object sender, EventArgs e)
        {
            int index;
            if (isLoaded)
            {
                if (selectedIndex == -1)
                {
                    index = jarmuGrid.CurrentRow.Index;
                }
                else
                {
                    index = selectedIndex;
                }

                if (index > -1)
                {
                    rendszamTBOX.Text = jarmuGrid.Rows[index].Cells[0].Value.ToString();
                    if (jarmuGrid.Rows[index].Cells[1].Value.ToString() == "Személy")
                    {
                        szemelyRBTN.Checked = true;
                    }
                    else
                    {
                        teherRBTN.Checked = true;
                    }
                    gyartoTBOX.Text = jarmuGrid.Rows[index].Cells[2].Value.ToString();
                    modellTBOX.Text = jarmuGrid.Rows[index].Cells[3].Value.ToString();
                    kmoraTBOX.Text = jarmuGrid.Rows[index].Cells[4].Value.ToString();

                    felveszBTN.Enabled = false;
                    modositBTN.Enabled = true;
                    torolBTN.Enabled = true;
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
                int index = jarmuGrid.CurrentRow.Index;
                jarmuvek.RemoveAt(index);
                jarmuGridUpdate();
                MessageBox.Show("Sikeresen törölve!");
            }
        }

        private void felveszBTN_Click(object sender, EventArgs e)
        {
            if (rendszamTBOX.Text != ""
                && gyartoTBOX.Text != ""
                && modellTBOX.Text != ""
                && kmoraTBOX.Text != ""
                && (!szemelyRBTN.Checked || !teherRBTN.Checked))
            {
                isLoaded = false;

                string tipus = "";
                if (szemelyRBTN.Checked)
                {
                    tipus = "Személy";
                }
                else
                {
                    tipus = "Teher";
                }

                string uj_jarmu = rendszamTBOX.Text + ";" + tipus + ";" + gyartoTBOX.Text + ";" + modellTBOX.Text + ";" + 0 + ";" + kmoraTBOX.Text;
                jarmuvek.Add(new Jarmu(uj_jarmu.Split(';')));
                jarmuGridUpdate();
                MessageBox.Show("Hozzá van adva az új adat!");
            }
            else
            {
                MessageBox.Show("Kérem adjon meg minden adatot!");
            }
        }

        
    }
}
