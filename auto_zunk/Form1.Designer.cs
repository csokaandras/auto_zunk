
namespace auto_zunk
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.torolBTN = new System.Windows.Forms.Button();
            this.modositBTN = new System.Windows.Forms.Button();
            this.felveszBTN = new System.Windows.Forms.Button();
            this.lakcimTBOX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ugyNevTBOX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.szigSzamTBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ugyfelGrid = new System.Windows.Forms.DataGridView();
            this.sz_ig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lakcim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osszesLBL = new System.Windows.Forms.Label();
            this.berbeadasokBTN1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.autokkezeleseBTN2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.torolBTN);
            this.groupBox1.Controls.Add(this.modositBTN);
            this.groupBox1.Controls.Add(this.felveszBTN);
            this.groupBox1.Controls.Add(this.lakcimTBOX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ugyNevTBOX);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.szigSzamTBOX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(227, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ügyfél adatai:";
            // 
            // torolBTN
            // 
            this.torolBTN.Location = new System.Drawing.Point(244, 159);
            this.torolBTN.Name = "torolBTN";
            this.torolBTN.Size = new System.Drawing.Size(96, 32);
            this.torolBTN.TabIndex = 8;
            this.torolBTN.Text = "Töröl";
            this.torolBTN.UseVisualStyleBackColor = true;
            // 
            // modositBTN
            // 
            this.modositBTN.Location = new System.Drawing.Point(126, 159);
            this.modositBTN.Name = "modositBTN";
            this.modositBTN.Size = new System.Drawing.Size(96, 32);
            this.modositBTN.TabIndex = 9;
            this.modositBTN.Text = "Módosít";
            // 
            // felveszBTN
            // 
            this.felveszBTN.Location = new System.Drawing.Point(10, 159);
            this.felveszBTN.Name = "felveszBTN";
            this.felveszBTN.Size = new System.Drawing.Size(96, 32);
            this.felveszBTN.TabIndex = 10;
            this.felveszBTN.Text = "Felvesz";
            // 
            // lakcimTBOX
            // 
            this.lakcimTBOX.Location = new System.Drawing.Point(166, 112);
            this.lakcimTBOX.Name = "lakcimTBOX";
            this.lakcimTBOX.Size = new System.Drawing.Size(174, 20);
            this.lakcimTBOX.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lakcím:";
            // 
            // ugyNevTBOX
            // 
            this.ugyNevTBOX.Location = new System.Drawing.Point(166, 73);
            this.ugyNevTBOX.Name = "ugyNevTBOX";
            this.ugyNevTBOX.Size = new System.Drawing.Size(174, 20);
            this.ugyNevTBOX.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // szigSzamTBOX
            // 
            this.szigSzamTBOX.Location = new System.Drawing.Point(166, 36);
            this.szigSzamTBOX.Name = "szigSzamTBOX";
            this.szigSzamTBOX.Size = new System.Drawing.Size(174, 20);
            this.szigSzamTBOX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Személyi i. szám:";
            // 
            // ugyfelGrid
            // 
            this.ugyfelGrid.AllowUserToAddRows = false;
            this.ugyfelGrid.AllowUserToDeleteRows = false;
            this.ugyfelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ugyfelGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sz_ig,
            this.nev,
            this.lakcim});
            this.ugyfelGrid.Location = new System.Drawing.Point(12, 257);
            this.ugyfelGrid.Name = "ugyfelGrid";
            this.ugyfelGrid.ReadOnly = true;
            this.ugyfelGrid.Size = new System.Drawing.Size(776, 157);
            this.ugyfelGrid.TabIndex = 2;
            // 
            // sz_ig
            // 
            this.sz_ig.HeaderText = "Személyi igazolvány szám";
            this.sz_ig.Name = "sz_ig";
            this.sz_ig.ReadOnly = true;
            this.sz_ig.Width = 300;
            // 
            // nev
            // 
            this.nev.HeaderText = "Név";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Width = 200;
            // 
            // lakcim
            // 
            this.lakcim.HeaderText = "Lakcím";
            this.lakcim.Name = "lakcim";
            this.lakcim.ReadOnly = true;
            this.lakcim.Width = 200;
            // 
            // osszesLBL
            // 
            this.osszesLBL.AutoSize = true;
            this.osszesLBL.Location = new System.Drawing.Point(12, 417);
            this.osszesLBL.Name = "osszesLBL";
            this.osszesLBL.Size = new System.Drawing.Size(99, 24);
            this.osszesLBL.TabIndex = 3;
            this.osszesLBL.Text = "Összesen:";
            // 
            // berbeadasokBTN1
            // 
            this.berbeadasokBTN1.Location = new System.Drawing.Point(12, 215);
            this.berbeadasokBTN1.Name = "berbeadasokBTN1";
            this.berbeadasokBTN1.Size = new System.Drawing.Size(215, 36);
            this.berbeadasokBTN1.TabIndex = 4;
            this.berbeadasokBTN1.Text = "Bérbeadások kezelése";
            this.berbeadasokBTN1.UseVisualStyleBackColor = true;
            this.berbeadasokBTN1.Click += new System.EventHandler(this.berbeadasokBTN1_Click);
            // 
            // autokkezeleseBTN2
            // 
            this.autokkezeleseBTN2.Location = new System.Drawing.Point(573, 215);
            this.autokkezeleseBTN2.Name = "autokkezeleseBTN2";
            this.autokkezeleseBTN2.Size = new System.Drawing.Size(215, 36);
            this.autokkezeleseBTN2.TabIndex = 10;
            this.autokkezeleseBTN2.Text = "Céges autók kezelése";
            this.autokkezeleseBTN2.UseVisualStyleBackColor = true;
            this.autokkezeleseBTN2.Click += new System.EventHandler(this.autokkezeleseBTN2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(227, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 197);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ügyfél adatai:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Töröl";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(126, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 32);
            this.button3.TabIndex = 9;
            this.button3.Text = "Módosít";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 32);
            this.button4.TabIndex = 10;
            this.button4.Text = "Felvesz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 29);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lakcím:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 29);
            this.textBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Név:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 29);
            this.textBox3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Személyi i. szám:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.autokkezeleseBTN2);
            this.Controls.Add(this.berbeadasokBTN1);
            this.Controls.Add(this.osszesLBL);
            this.Controls.Add(this.ugyfelGrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ügyfél";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button torolBTN;
        private System.Windows.Forms.Button modositBTN;
        private System.Windows.Forms.Button felveszBTN;
        private System.Windows.Forms.TextBox lakcimTBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ugyNevTBOX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox szigSzamTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ugyfelGrid;
        private System.Windows.Forms.Label osszesLBL;
        private System.Windows.Forms.Button berbeadasokBTN1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sz_ig;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn lakcim;
        private System.Windows.Forms.Button autokkezeleseBTN2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
    }
}

