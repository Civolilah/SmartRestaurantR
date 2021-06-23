
namespace SmartRestaurantWinUI.Narudzbe
{
    partial class frm_uredi
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_proizvodi = new System.Windows.Forms.DataGridView();
            this.cmb_mjestaposluzivanja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_snimi = new System.Windows.Forms.Button();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Narucen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NazivProizvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(320, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uredi narudžbu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_proizvodi);
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvodi";
            // 
            // dgv_proizvodi
            // 
            this.dgv_proizvodi.AllowUserToAddRows = false;
            this.dgv_proizvodi.AllowUserToDeleteRows = false;
            this.dgv_proizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodID,
            this.Narucen,
            this.NazivProizvoda,
            this.Cijena,
            this.Opis});
            this.dgv_proizvodi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_proizvodi.Location = new System.Drawing.Point(3, 18);
            this.dgv_proizvodi.Name = "dgv_proizvodi";
            this.dgv_proizvodi.ReadOnly = true;
            this.dgv_proizvodi.RowHeadersWidth = 51;
            this.dgv_proizvodi.RowTemplate.Height = 24;
            this.dgv_proizvodi.Size = new System.Drawing.Size(740, 148);
            this.dgv_proizvodi.TabIndex = 0;
            this.dgv_proizvodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_proizvodi_CellContentClick);
            // 
            // cmb_mjestaposluzivanja
            // 
            this.cmb_mjestaposluzivanja.FormattingEnabled = true;
            this.cmb_mjestaposluzivanja.Location = new System.Drawing.Point(182, 319);
            this.cmb_mjestaposluzivanja.Name = "cmb_mjestaposluzivanja";
            this.cmb_mjestaposluzivanja.Size = new System.Drawing.Size(121, 24);
            this.cmb_mjestaposluzivanja.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broj mjesta posluživanja:";
            // 
            // btn_snimi
            // 
            this.btn_snimi.Location = new System.Drawing.Point(338, 402);
            this.btn_snimi.Name = "btn_snimi";
            this.btn_snimi.Size = new System.Drawing.Size(131, 36);
            this.btn_snimi.TabIndex = 4;
            this.btn_snimi.Text = "Snimi promjene";
            this.btn_snimi.UseVisualStyleBackColor = true;
            this.btn_snimi.Click += new System.EventHandler(this.btn_snimi_Click);
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "ProizvodID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.MinimumWidth = 6;
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.ReadOnly = true;
            this.ProizvodID.Visible = false;
            this.ProizvodID.Width = 125;
            // 
            // Narucen
            // 
            this.Narucen.DataPropertyName = "Narucen";
            this.Narucen.HeaderText = "Naručen";
            this.Narucen.MinimumWidth = 6;
            this.Narucen.Name = "Narucen";
            this.Narucen.ReadOnly = true;
            this.Narucen.Width = 125;
            // 
            // NazivProizvoda
            // 
            this.NazivProizvoda.DataPropertyName = "NazivProizvoda";
            this.NazivProizvoda.HeaderText = "NazivProizvoda";
            this.NazivProizvoda.MinimumWidth = 6;
            this.NazivProizvoda.Name = "NazivProizvoda";
            this.NazivProizvoda.ReadOnly = true;
            this.NazivProizvoda.Width = 125;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 125;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 125;
            // 
            // frm_uredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_snimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_mjestaposluzivanja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_uredi";
            this.Text = "frm_uredi";
            this.Load += new System.EventHandler(this.frm_uredi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_proizvodi;
        private System.Windows.Forms.ComboBox cmb_mjestaposluzivanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_snimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Narucen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivProizvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}