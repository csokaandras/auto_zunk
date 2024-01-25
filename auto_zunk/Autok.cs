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
    public partial class Autok : Form
    {
        public Autok()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

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
    }
}
