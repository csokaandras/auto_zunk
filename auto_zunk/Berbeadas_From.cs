using System;
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
    public partial class Berbeadas_From : Form
    {
        public Berbeadas_From()
        {
            InitializeComponent();
            this.CenterToScreen();
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
