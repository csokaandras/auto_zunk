
namespace auto_zunk
{
    partial class Berbeadas_From
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.osszesLBL = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.autoRendszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UgyfelSzigSzam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElvitelDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisszahozatalDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElvitelKmOra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisszHozKmOra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.visszaKmTBOX = new System.Windows.Forms.TextBox();
            this.elvitelkmoraTBOX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.visszahozatalDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.elvitelDTP = new System.Windows.Forms.DateTimePicker();
            this.ugyfelCBOX = new System.Windows.Forms.ComboBox();
            this.autoCBOX = new System.Windows.Forms.ComboBox();
            this.torolBTN = new System.Windows.Forms.Button();
            this.modositBTN = new System.Windows.Forms.Button();
            this.felveszBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.autokkezeleseBTN2 = new System.Windows.Forms.Button();
            this.ugyfelekkezelesBTN2 = new System.Windows.Forms.Button();
            this.statisztikaTBOX = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // osszesLBL
            // 
            this.osszesLBL.AutoSize = true;
            this.osszesLBL.Location = new System.Drawing.Point(12, 586);
            this.osszesLBL.Name = "osszesLBL";
            this.osszesLBL.Size = new System.Drawing.Size(99, 24);
            this.osszesLBL.TabIndex = 8;
            this.osszesLBL.Text = "Összesen:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoRendszam,
            this.UgyfelSzigSzam,
            this.ElvitelDatum,
            this.VisszahozatalDatum,
            this.ElvitelKmOra,
            this.VisszHozKmOra,
            this.Osszeg});
            this.dataGridView1.Location = new System.Drawing.Point(12, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1271, 217);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.ugyfelGrid_SelectionChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // autoRendszam
            // 
            this.autoRendszam.HeaderText = "Autó rendszám";
            this.autoRendszam.Name = "autoRendszam";
            this.autoRendszam.ReadOnly = true;
            this.autoRendszam.Width = 120;
            // 
            // UgyfelSzigSzam
            // 
            this.UgyfelSzigSzam.HeaderText = "Ügyfél személyi szám";
            this.UgyfelSzigSzam.Name = "UgyfelSzigSzam";
            this.UgyfelSzigSzam.ReadOnly = true;
            this.UgyfelSzigSzam.Width = 220;
            // 
            // ElvitelDatum
            // 
            this.ElvitelDatum.HeaderText = "Elvitel dátum";
            this.ElvitelDatum.Name = "ElvitelDatum";
            this.ElvitelDatum.ReadOnly = true;
            this.ElvitelDatum.Width = 200;
            // 
            // VisszahozatalDatum
            // 
            this.VisszahozatalDatum.HeaderText = "Visszahozatal dátum";
            this.VisszahozatalDatum.Name = "VisszahozatalDatum";
            this.VisszahozatalDatum.ReadOnly = true;
            this.VisszahozatalDatum.Width = 200;
            // 
            // ElvitelKmOra
            // 
            this.ElvitelKmOra.HeaderText = "Elvitel km óra";
            this.ElvitelKmOra.Name = "ElvitelKmOra";
            this.ElvitelKmOra.ReadOnly = true;
            this.ElvitelKmOra.Width = 200;
            // 
            // VisszHozKmOra
            // 
            this.VisszHozKmOra.HeaderText = "Visszahozatal km óra";
            this.VisszHozKmOra.Name = "VisszHozKmOra";
            this.VisszHozKmOra.ReadOnly = true;
            this.VisszHozKmOra.Width = 200;
            // 
            // Osszeg
            // 
            this.Osszeg.HeaderText = "Összeg";
            this.Osszeg.Name = "Osszeg";
            this.Osszeg.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.visszaKmTBOX);
            this.groupBox1.Controls.Add(this.elvitelkmoraTBOX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.visszahozatalDTP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.elvitelDTP);
            this.groupBox1.Controls.Add(this.ugyfelCBOX);
            this.groupBox1.Controls.Add(this.autoCBOX);
            this.groupBox1.Controls.Add(this.torolBTN);
            this.groupBox1.Controls.Add(this.modositBTN);
            this.groupBox1.Controls.Add(this.felveszBTN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(635, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 307);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bérbeadások adatai:";
            // 
            // visszaKmTBOX
            // 
            this.visszaKmTBOX.Location = new System.Drawing.Point(233, 210);
            this.visszaKmTBOX.Name = "visszaKmTBOX";
            this.visszaKmTBOX.Size = new System.Drawing.Size(174, 29);
            this.visszaKmTBOX.TabIndex = 18;
            // 
            // elvitelkmoraTBOX
            // 
            this.elvitelkmoraTBOX.Location = new System.Drawing.Point(233, 175);
            this.elvitelkmoraTBOX.Name = "elvitelkmoraTBOX";
            this.elvitelkmoraTBOX.ReadOnly = true;
            this.elvitelkmoraTBOX.Size = new System.Drawing.Size(174, 29);
            this.elvitelkmoraTBOX.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Visszahozatal km óra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Elvitel km óra:";
            // 
            // visszahozatalDTP
            // 
            this.visszahozatalDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.visszahozatalDTP.Location = new System.Drawing.Point(233, 139);
            this.visszahozatalDTP.Name = "visszahozatalDTP";
            this.visszahozatalDTP.Size = new System.Drawing.Size(174, 29);
            this.visszahozatalDTP.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Visszahozatal dátum:";
            // 
            // elvitelDTP
            // 
            this.elvitelDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.elvitelDTP.Location = new System.Drawing.Point(233, 104);
            this.elvitelDTP.Name = "elvitelDTP";
            this.elvitelDTP.Size = new System.Drawing.Size(174, 29);
            this.elvitelDTP.TabIndex = 11;
            // 
            // ugyfelCBOX
            // 
            this.ugyfelCBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ugyfelCBOX.FormattingEnabled = true;
            this.ugyfelCBOX.Location = new System.Drawing.Point(233, 66);
            this.ugyfelCBOX.Name = "ugyfelCBOX";
            this.ugyfelCBOX.Size = new System.Drawing.Size(174, 32);
            this.ugyfelCBOX.TabIndex = 10;
            // 
            // autoCBOX
            // 
            this.autoCBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoCBOX.FormattingEnabled = true;
            this.autoCBOX.Location = new System.Drawing.Point(233, 24);
            this.autoCBOX.Name = "autoCBOX";
            this.autoCBOX.Size = new System.Drawing.Size(174, 32);
            this.autoCBOX.TabIndex = 9;
            this.autoCBOX.SelectedIndexChanged += new System.EventHandler(this.autoCBOX_SelectedIndexChanged);
            // 
            // torolBTN
            // 
            this.torolBTN.Location = new System.Drawing.Point(322, 255);
            this.torolBTN.Name = "torolBTN";
            this.torolBTN.Size = new System.Drawing.Size(85, 32);
            this.torolBTN.TabIndex = 8;
            this.torolBTN.Text = "Töröl";
            this.torolBTN.UseVisualStyleBackColor = true;
            this.torolBTN.Click += new System.EventHandler(this.torolBTN_Click);
            // 
            // modositBTN
            // 
            this.modositBTN.Location = new System.Drawing.Point(175, 255);
            this.modositBTN.Name = "modositBTN";
            this.modositBTN.Size = new System.Drawing.Size(85, 32);
            this.modositBTN.TabIndex = 7;
            this.modositBTN.Text = "Módosít";
            this.modositBTN.UseVisualStyleBackColor = true;
            this.modositBTN.Click += new System.EventHandler(this.modositBTN_Click);
            // 
            // felveszBTN
            // 
            this.felveszBTN.Location = new System.Drawing.Point(34, 255);
            this.felveszBTN.Name = "felveszBTN";
            this.felveszBTN.Size = new System.Drawing.Size(85, 32);
            this.felveszBTN.TabIndex = 6;
            this.felveszBTN.Text = "Felvesz";
            this.felveszBTN.UseVisualStyleBackColor = true;
            this.felveszBTN.Click += new System.EventHandler(this.felveszBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Elvitel dátum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ügyfél személyi száma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autó rendszáma:";
            // 
            // autokkezeleseBTN2
            // 
            this.autokkezeleseBTN2.Location = new System.Drawing.Point(12, 324);
            this.autokkezeleseBTN2.Name = "autokkezeleseBTN2";
            this.autokkezeleseBTN2.Size = new System.Drawing.Size(215, 36);
            this.autokkezeleseBTN2.TabIndex = 9;
            this.autokkezeleseBTN2.Text = "Céges autók kezelése";
            this.autokkezeleseBTN2.UseVisualStyleBackColor = true;
            this.autokkezeleseBTN2.Click += new System.EventHandler(this.autokkezeleseBTN2_Click);
            // 
            // ugyfelekkezelesBTN2
            // 
            this.ugyfelekkezelesBTN2.Location = new System.Drawing.Point(1477, 321);
            this.ugyfelekkezelesBTN2.Name = "ugyfelekkezelesBTN2";
            this.ugyfelekkezelesBTN2.Size = new System.Drawing.Size(209, 36);
            this.ugyfelekkezelesBTN2.TabIndex = 10;
            this.ugyfelekkezelesBTN2.Text = "Ügyfelek kezelése";
            this.ugyfelekkezelesBTN2.UseVisualStyleBackColor = true;
            this.ugyfelekkezelesBTN2.Click += new System.EventHandler(this.ugyfelekkezelesBTN2_Click);
            // 
            // statisztikaTBOX
            // 
            this.statisztikaTBOX.FormattingEnabled = true;
            this.statisztikaTBOX.ItemHeight = 24;
            this.statisztikaTBOX.Location = new System.Drawing.Point(1289, 363);
            this.statisztikaTBOX.Name = "statisztikaTBOX";
            this.statisztikaTBOX.Size = new System.Drawing.Size(397, 220);
            this.statisztikaTBOX.TabIndex = 11;
            // 
            // Berbeadas_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 617);
            this.Controls.Add(this.statisztikaTBOX);
            this.Controls.Add(this.ugyfelekkezelesBTN2);
            this.Controls.Add(this.autokkezeleseBTN2);
            this.Controls.Add(this.osszesLBL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Berbeadas_From";
            this.ShowIcon = false;
            this.Text = "Bérbeadások kezelése";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Berbeadas_From_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label osszesLBL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button torolBTN;
        private System.Windows.Forms.Button modositBTN;
        private System.Windows.Forms.Button felveszBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button autokkezeleseBTN2;
        private System.Windows.Forms.Button ugyfelekkezelesBTN2;
        private System.Windows.Forms.ListBox statisztikaTBOX;
        private System.Windows.Forms.TextBox visszaKmTBOX;
        private System.Windows.Forms.TextBox elvitelkmoraTBOX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker visszahozatalDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker elvitelDTP;
        private System.Windows.Forms.ComboBox ugyfelCBOX;
        private System.Windows.Forms.ComboBox autoCBOX;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoRendszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn UgyfelSzigSzam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElvitelDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisszahozatalDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElvitelKmOra;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisszHozKmOra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osszeg;
    }
}