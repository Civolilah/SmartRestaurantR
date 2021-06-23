
namespace SmartRestaurantWinUI.Proizvodi
{
    partial class frm_Pretraga
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
            this.dg_Proizvodi = new System.Windows.Forms.DataGridView();
            this.ProizvodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skladiste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Osvjezi = new System.Windows.Forms.Button();
            this.cmb_vrstaproizvoda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Proizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(492, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled svih dostupnih proizvoda:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_Proizvodi);
            this.groupBox1.Location = new System.Drawing.Point(1, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1344, 291);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvodi";
            // 
            // dg_Proizvodi
            // 
            this.dg_Proizvodi.AllowUserToAddRows = false;
            this.dg_Proizvodi.AllowUserToDeleteRows = false;
            this.dg_Proizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Proizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodID,
            this.Naziv,
            this.Cijena,
            this.Skladiste,
            this.Slika,
            this.Aktivan,
            this.Detalji,
            this.Uredi});
            this.dg_Proizvodi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Proizvodi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dg_Proizvodi.Location = new System.Drawing.Point(3, 18);
            this.dg_Proizvodi.Name = "dg_Proizvodi";
            this.dg_Proizvodi.ReadOnly = true;
            this.dg_Proizvodi.RowHeadersWidth = 51;
            this.dg_Proizvodi.RowTemplate.Height = 24;
            this.dg_Proizvodi.Size = new System.Drawing.Size(1338, 270);
            this.dg_Proizvodi.TabIndex = 0;
            this.dg_Proizvodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Proizvodi_CellContentClick);
            // 
            // ProizvodID
            // 
            this.ProizvodID.DataPropertyName = "ProizvodID";
            this.ProizvodID.HeaderText = "ProizvodID";
            this.ProizvodID.MinimumWidth = 4;
            this.ProizvodID.Name = "ProizvodID";
            this.ProizvodID.ReadOnly = true;
            this.ProizvodID.Visible = false;
            this.ProizvodID.Width = 125;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 125;
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
            // Skladiste
            // 
            this.Skladiste.DataPropertyName = "NazivSkladista";
            this.Skladiste.HeaderText = "Skladiste";
            this.Skladiste.MinimumWidth = 6;
            this.Skladiste.Name = "Skladiste";
            this.Skladiste.ReadOnly = true;
            this.Skladiste.Width = 125;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Slika.MinimumWidth = 6;
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Width = 180;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.MinimumWidth = 6;
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.Width = 125;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.MinimumWidth = 6;
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            this.Detalji.Width = 125;
            // 
            // Uredi
            // 
            this.Uredi.HeaderText = "Uredi status";
            this.Uredi.MinimumWidth = 6;
            this.Uredi.Name = "Uredi";
            this.Uredi.ReadOnly = true;
            this.Uredi.Text = "Uredi";
            this.Uredi.UseColumnTextForButtonValue = true;
            this.Uredi.Width = 125;
            // 
            // btn_Osvjezi
            // 
            this.btn_Osvjezi.Location = new System.Drawing.Point(1249, 118);
            this.btn_Osvjezi.Name = "btn_Osvjezi";
            this.btn_Osvjezi.Size = new System.Drawing.Size(75, 23);
            this.btn_Osvjezi.TabIndex = 2;
            this.btn_Osvjezi.Text = "Osvježi";
            this.btn_Osvjezi.UseVisualStyleBackColor = true;
            this.btn_Osvjezi.Click += new System.EventHandler(this.btn_Osvjezi_Click);
            // 
            // cmb_vrstaproizvoda
            // 
            this.cmb_vrstaproizvoda.FormattingEnabled = true;
            this.cmb_vrstaproizvoda.Location = new System.Drawing.Point(1097, 118);
            this.cmb_vrstaproizvoda.Name = "cmb_vrstaproizvoda";
            this.cmb_vrstaproizvoda.Size = new System.Drawing.Size(121, 24);
            this.cmb_vrstaproizvoda.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1021, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pretraži po statusu proizvoda:";
            // 
            // frm_Pretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_vrstaproizvoda);
            this.Controls.Add(this.btn_Osvjezi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_Pretraga";
            this.Text = "frm_Pretraga";
            this.Load += new System.EventHandler(this.frm_Pretraga_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Proizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_Proizvodi;
        private System.Windows.Forms.Button btn_Osvjezi;
        private System.Windows.Forms.ComboBox cmb_vrstaproizvoda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skladiste;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
        private System.Windows.Forms.DataGridViewButtonColumn Uredi;
    }
}