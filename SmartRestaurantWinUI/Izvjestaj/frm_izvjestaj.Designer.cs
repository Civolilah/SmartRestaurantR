
namespace SmartRestaurantWinUI.Izvjestaj
{
    partial class frm_izvjestaj
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
            this.components = new System.ComponentModel.Container();
            this.dtp_od = new System.Windows.Forms.DateTimePicker();
            this.dtp_do = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nazivproizvoda = new System.Windows.Forms.TextBox();
            this.btn_osvjezi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_izvjestaj = new System.Windows.Forms.DataGridView();
            this.NazivProizvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PutaProdan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrenutnoStanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ukupnazarada = new System.Windows.Forms.TextBox();
            this.txt_brojnarudzbi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_proizvodinaruceni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_procenatnarudzbe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_kreirajizvjestaj = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_izvjestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_od
            // 
            this.dtp_od.CustomFormat = "";
            this.dtp_od.Location = new System.Drawing.Point(190, 95);
            this.dtp_od.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtp_od.Name = "dtp_od";
            this.dtp_od.Size = new System.Drawing.Size(242, 22);
            this.dtp_od.TabIndex = 0;
            this.dtp_od.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_od_Validating);
            // 
            // dtp_do
            // 
            this.dtp_do.Location = new System.Drawing.Point(448, 95);
            this.dtp_do.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtp_do.Name = "dtp_do";
            this.dtp_do.Size = new System.Drawing.Size(242, 22);
            this.dtp_do.TabIndex = 1;
            this.dtp_do.Value = new System.DateTime(2021, 5, 25, 21, 23, 0, 0);
            this.dtp_do.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_do_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unesite period:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Naziv proizvoda:";
            // 
            // txt_nazivproizvoda
            // 
            this.txt_nazivproizvoda.Location = new System.Drawing.Point(190, 136);
            this.txt_nazivproizvoda.Name = "txt_nazivproizvoda";
            this.txt_nazivproizvoda.Size = new System.Drawing.Size(149, 22);
            this.txt_nazivproizvoda.TabIndex = 6;
            this.txt_nazivproizvoda.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nazivproizvoda_Validating);
            // 
            // btn_osvjezi
            // 
            this.btn_osvjezi.Location = new System.Drawing.Point(713, 133);
            this.btn_osvjezi.Name = "btn_osvjezi";
            this.btn_osvjezi.Size = new System.Drawing.Size(75, 25);
            this.btn_osvjezi.TabIndex = 7;
            this.btn_osvjezi.Text = "Osvježi";
            this.btn_osvjezi.UseVisualStyleBackColor = true;
            this.btn_osvjezi.Click += new System.EventHandler(this.btn_osvjezi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_izvjestaj);
            this.groupBox1.Location = new System.Drawing.Point(12, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 230);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izvještaj";
            // 
            // dgv_izvjestaj
            // 
            this.dgv_izvjestaj.AllowUserToAddRows = false;
            this.dgv_izvjestaj.AllowUserToDeleteRows = false;
            this.dgv_izvjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_izvjestaj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivProizvoda,
            this.PutaProdan,
            this.Cijena,
            this.TrenutnoStanje});
            this.dgv_izvjestaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_izvjestaj.Location = new System.Drawing.Point(3, 18);
            this.dgv_izvjestaj.Name = "dgv_izvjestaj";
            this.dgv_izvjestaj.ReadOnly = true;
            this.dgv_izvjestaj.RowHeadersWidth = 51;
            this.dgv_izvjestaj.RowTemplate.Height = 24;
            this.dgv_izvjestaj.Size = new System.Drawing.Size(770, 209);
            this.dgv_izvjestaj.TabIndex = 0;
            // 
            // NazivProizvoda
            // 
            this.NazivProizvoda.DataPropertyName = "NazivProizvoda";
            this.NazivProizvoda.HeaderText = "Naziv proizvoda";
            this.NazivProizvoda.MinimumWidth = 6;
            this.NazivProizvoda.Name = "NazivProizvoda";
            this.NazivProizvoda.ReadOnly = true;
            this.NazivProizvoda.Width = 140;
            // 
            // PutaProdan
            // 
            this.PutaProdan.DataPropertyName = "PutaProdan";
            this.PutaProdan.HeaderText = "Puta prodan";
            this.PutaProdan.MinimumWidth = 6;
            this.PutaProdan.Name = "PutaProdan";
            this.PutaProdan.ReadOnly = true;
            this.PutaProdan.Width = 125;
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
            // TrenutnoStanje
            // 
            this.TrenutnoStanje.DataPropertyName = "TrenutnoStanje";
            this.TrenutnoStanje.HeaderText = "Trenutno stanje";
            this.TrenutnoStanje.MinimumWidth = 6;
            this.TrenutnoStanje.Name = "TrenutnoStanje";
            this.TrenutnoStanje.ReadOnly = true;
            this.TrenutnoStanje.Width = 140;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ukupna zarada:";
            // 
            // txt_ukupnazarada
            // 
            this.txt_ukupnazarada.Location = new System.Drawing.Point(149, 417);
            this.txt_ukupnazarada.Name = "txt_ukupnazarada";
            this.txt_ukupnazarada.ReadOnly = true;
            this.txt_ukupnazarada.Size = new System.Drawing.Size(69, 22);
            this.txt_ukupnazarada.TabIndex = 10;
            // 
            // txt_brojnarudzbi
            // 
            this.txt_brojnarudzbi.Location = new System.Drawing.Point(367, 420);
            this.txt_brojnarudzbi.Name = "txt_brojnarudzbi";
            this.txt_brojnarudzbi.ReadOnly = true;
            this.txt_brojnarudzbi.Size = new System.Drawing.Size(79, 22);
            this.txt_brojnarudzbi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ukupno narudžbi:";
            // 
            // txt_proizvodinaruceni
            // 
            this.txt_proizvodinaruceni.Location = new System.Drawing.Point(641, 420);
            this.txt_proizvodinaruceni.Name = "txt_proizvodinaruceni";
            this.txt_proizvodinaruceni.ReadOnly = true;
            this.txt_proizvodinaruceni.Size = new System.Drawing.Size(79, 22);
            this.txt_proizvodinaruceni.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Broj narudžbi proizvoda:";
            // 
            // txt_procenatnarudzbe
            // 
            this.txt_procenatnarudzbe.Location = new System.Drawing.Point(173, 469);
            this.txt_procenatnarudzbe.Name = "txt_procenatnarudzbe";
            this.txt_procenatnarudzbe.ReadOnly = true;
            this.txt_procenatnarudzbe.Size = new System.Drawing.Size(153, 22);
            this.txt_procenatnarudzbe.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Procenat narudžbe:";
            // 
            // btn_kreirajizvjestaj
            // 
            this.btn_kreirajizvjestaj.Location = new System.Drawing.Point(641, 486);
            this.btn_kreirajizvjestaj.Name = "btn_kreirajizvjestaj";
            this.btn_kreirajizvjestaj.Size = new System.Drawing.Size(144, 25);
            this.btn_kreirajizvjestaj.TabIndex = 17;
            this.btn_kreirajizvjestaj.Text = "Kreiraj izvještaj";
            this.btn_kreirajizvjestaj.UseVisualStyleBackColor = true;
            this.btn_kreirajizvjestaj.Click += new System.EventHandler(this.btn_kreirajizvjestaj_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(348, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 29);
            this.label9.TabIndex = 18;
            this.label9.Text = "Izvještaj";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_izvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_kreirajizvjestaj);
            this.Controls.Add(this.txt_procenatnarudzbe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_proizvodinaruceni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_brojnarudzbi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ukupnazarada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_osvjezi);
            this.Controls.Add(this.txt_nazivproizvoda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_do);
            this.Controls.Add(this.dtp_od);
            this.Name = "frm_izvjestaj";
            this.Text = "frm_izvjestaj";
            this.Load += new System.EventHandler(this.frm_izvjestaj_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_izvjestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_od;
        private System.Windows.Forms.DateTimePicker dtp_do;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nazivproizvoda;
        private System.Windows.Forms.Button btn_osvjezi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_izvjestaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ukupnazarada;
        private System.Windows.Forms.TextBox txt_brojnarudzbi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_proizvodinaruceni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_procenatnarudzbe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_kreirajizvjestaj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivProizvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn PutaProdan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrenutnoStanje;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}