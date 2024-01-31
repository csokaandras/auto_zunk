
namespace auto_zunk
{
    partial class Autok
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
            this.berbeadasokBTN2 = new System.Windows.Forms.Button();
            this.osszesLBL = new System.Windows.Forms.Label();
            this.jarmuGrid = new System.Windows.Forms.DataGridView();
            this.ugyfelekkezeleseBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kmoraTBOX = new System.Windows.Forms.TextBox();
            this.modellTBOX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teherRBTN = new System.Windows.Forms.RadioButton();
            this.szemelyRBTN = new System.Windows.Forms.RadioButton();
            this.torolBTN = new System.Windows.Forms.Button();
            this.modositBTN = new System.Windows.Forms.Button();
            this.felveszBTN = new System.Windows.Forms.Button();
            this.gyartoTBOX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rendszamTBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jarmuGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // berbeadasokBTN2
            // 
            this.berbeadasokBTN2.Location = new System.Drawing.Point(579, 237);
            this.berbeadasokBTN2.Name = "berbeadasokBTN2";
            this.berbeadasokBTN2.Size = new System.Drawing.Size(209, 36);
            this.berbeadasokBTN2.TabIndex = 9;
            this.berbeadasokBTN2.Text = "Bérbeadások kezelése";
            this.berbeadasokBTN2.UseVisualStyleBackColor = true;
            this.berbeadasokBTN2.Click += new System.EventHandler(this.berbeadasokBTN2_Click);
            // 
            // osszesLBL
            // 
            this.osszesLBL.AutoSize = true;
            this.osszesLBL.Location = new System.Drawing.Point(12, 454);
            this.osszesLBL.Name = "osszesLBL";
            this.osszesLBL.Size = new System.Drawing.Size(99, 24);
            this.osszesLBL.TabIndex = 8;
            this.osszesLBL.Text = "Összesen:";
            // 
            // jarmuGrid
            // 
            this.jarmuGrid.AllowUserToAddRows = false;
            this.jarmuGrid.AllowUserToDeleteRows = false;
            this.jarmuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jarmuGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.jarmuGrid.Location = new System.Drawing.Point(12, 279);
            this.jarmuGrid.MultiSelect = false;
            this.jarmuGrid.Name = "jarmuGrid";
            this.jarmuGrid.ReadOnly = true;
            this.jarmuGrid.RowHeadersVisible = false;
            this.jarmuGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.jarmuGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jarmuGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jarmuGrid.Size = new System.Drawing.Size(776, 172);
            this.jarmuGrid.TabIndex = 7;
            this.jarmuGrid.SelectionChanged += new System.EventHandler(this.jarmuGrid_SelectionChanged);
            this.jarmuGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // ugyfelekkezeleseBTN
            // 
            this.ugyfelekkezeleseBTN.Location = new System.Drawing.Point(12, 237);
            this.ugyfelekkezeleseBTN.Name = "ugyfelekkezeleseBTN";
            this.ugyfelekkezeleseBTN.Size = new System.Drawing.Size(209, 36);
            this.ugyfelekkezeleseBTN.TabIndex = 6;
            this.ugyfelekkezeleseBTN.Text = "Ügyfelek kezelése";
            this.ugyfelekkezeleseBTN.UseVisualStyleBackColor = true;
            this.ugyfelekkezeleseBTN.Click += new System.EventHandler(this.ugyfelekkezeleseBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.kmoraTBOX);
            this.groupBox1.Controls.Add(this.modellTBOX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.teherRBTN);
            this.groupBox1.Controls.Add(this.szemelyRBTN);
            this.groupBox1.Controls.Add(this.torolBTN);
            this.groupBox1.Controls.Add(this.modositBTN);
            this.groupBox1.Controls.Add(this.felveszBTN);
            this.groupBox1.Controls.Add(this.gyartoTBOX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rendszamTBOX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(227, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 258);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Az autó adatai:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kilométer óra:";
            // 
            // kmoraTBOX
            // 
            this.kmoraTBOX.Location = new System.Drawing.Point(147, 173);
            this.kmoraTBOX.Name = "kmoraTBOX";
            this.kmoraTBOX.Size = new System.Drawing.Size(193, 29);
            this.kmoraTBOX.TabIndex = 13;
            // 
            // modellTBOX
            // 
            this.modellTBOX.Location = new System.Drawing.Point(147, 138);
            this.modellTBOX.Name = "modellTBOX";
            this.modellTBOX.Size = new System.Drawing.Size(193, 29);
            this.modellTBOX.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Modell:";
            // 
            // teherRBTN
            // 
            this.teherRBTN.AutoSize = true;
            this.teherRBTN.Location = new System.Drawing.Point(255, 69);
            this.teherRBTN.Name = "teherRBTN";
            this.teherRBTN.Size = new System.Drawing.Size(79, 28);
            this.teherRBTN.TabIndex = 10;
            this.teherRBTN.TabStop = true;
            this.teherRBTN.Text = "Teher";
            this.teherRBTN.UseVisualStyleBackColor = true;
            // 
            // szemelyRBTN
            // 
            this.szemelyRBTN.AutoSize = true;
            this.szemelyRBTN.Location = new System.Drawing.Point(147, 71);
            this.szemelyRBTN.Name = "szemelyRBTN";
            this.szemelyRBTN.Size = new System.Drawing.Size(100, 28);
            this.szemelyRBTN.TabIndex = 9;
            this.szemelyRBTN.TabStop = true;
            this.szemelyRBTN.Text = "Személy";
            this.szemelyRBTN.UseVisualStyleBackColor = true;
            // 
            // torolBTN
            // 
            this.torolBTN.Location = new System.Drawing.Point(249, 214);
            this.torolBTN.Name = "torolBTN";
            this.torolBTN.Size = new System.Drawing.Size(85, 32);
            this.torolBTN.TabIndex = 8;
            this.torolBTN.Text = "Töröl";
            this.torolBTN.UseVisualStyleBackColor = true;
            this.torolBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // modositBTN
            // 
            this.modositBTN.Location = new System.Drawing.Point(137, 214);
            this.modositBTN.Name = "modositBTN";
            this.modositBTN.Size = new System.Drawing.Size(85, 32);
            this.modositBTN.TabIndex = 7;
            this.modositBTN.Text = "Módosít";
            this.modositBTN.UseVisualStyleBackColor = true;
            this.modositBTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // felveszBTN
            // 
            this.felveszBTN.Location = new System.Drawing.Point(6, 214);
            this.felveszBTN.Name = "felveszBTN";
            this.felveszBTN.Size = new System.Drawing.Size(85, 32);
            this.felveszBTN.TabIndex = 6;
            this.felveszBTN.Text = "Felvesz";
            this.felveszBTN.UseVisualStyleBackColor = true;
            this.felveszBTN.Click += new System.EventHandler(this.felveszBTN_Click);
            // 
            // gyartoTBOX
            // 
            this.gyartoTBOX.Location = new System.Drawing.Point(147, 105);
            this.gyartoTBOX.Name = "gyartoTBOX";
            this.gyartoTBOX.Size = new System.Drawing.Size(193, 29);
            this.gyartoTBOX.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gyártó:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Típus:";
            // 
            // rendszamTBOX
            // 
            this.rendszamTBOX.Location = new System.Drawing.Point(147, 36);
            this.rendszamTBOX.Name = "rendszamTBOX";
            this.rendszamTBOX.Size = new System.Drawing.Size(193, 29);
            this.rendszamTBOX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Rendszám";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Típus";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gyártó";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Modell";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Km óra";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kiadva?";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Autok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.berbeadasokBTN2);
            this.Controls.Add(this.osszesLBL);
            this.Controls.Add(this.jarmuGrid);
            this.Controls.Add(this.ugyfelekkezeleseBTN);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Autok";
            this.ShowIcon = false;
            this.Text = "Autók kezelése";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Autok_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.jarmuGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button berbeadasokBTN2;
        private System.Windows.Forms.Label osszesLBL;
        private System.Windows.Forms.DataGridView jarmuGrid;
        private System.Windows.Forms.Button ugyfelekkezeleseBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button torolBTN;
        private System.Windows.Forms.Button modositBTN;
        private System.Windows.Forms.Button felveszBTN;
        private System.Windows.Forms.TextBox gyartoTBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rendszamTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton teherRBTN;
        private System.Windows.Forms.RadioButton szemelyRBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kmoraTBOX;
        private System.Windows.Forms.TextBox modellTBOX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}