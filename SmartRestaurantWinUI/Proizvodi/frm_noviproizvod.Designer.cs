
namespace SmartRestaurantWinUI.Proizvodi
{
    partial class frm_noviproizvod
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputcijena = new System.Windows.Forms.NumericUpDown();
            this.inputkolicina = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_jedinicakolicine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_kategorijaproizvoda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_skladiste = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_ucitajsliku = new System.Windows.Forms.Button();
            this.btn_snimiproizvod = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txt_opis = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.insert_kolicinanaskladistu = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.check_aktivan = new System.Windows.Forms.CheckBox();
            this.inputnabavnacijena = new System.Windows.Forms.NumericUpDown();
            this.labl = new System.Windows.Forms.Label();
            this.dtp_istekroka = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputcijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputkolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insert_kolicinanaskladistu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputnabavnacijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(179, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novi proizvod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv:";
            // 
            // txt_naziv
            // 
            this.txt_naziv.Location = new System.Drawing.Point(27, 92);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.Size = new System.Drawing.Size(211, 22);
            this.txt_naziv.TabIndex = 2;
            this.txt_naziv.Validating += new System.ComponentModel.CancelEventHandler(this.txt_naziv_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prodajna cijena:";
            // 
            // inputcijena
            // 
            this.inputcijena.DecimalPlaces = 2;
            this.inputcijena.Location = new System.Drawing.Point(28, 303);
            this.inputcijena.Name = "inputcijena";
            this.inputcijena.Size = new System.Drawing.Size(120, 22);
            this.inputcijena.TabIndex = 4;
            this.inputcijena.Validating += new System.ComponentModel.CancelEventHandler(this.inputcijena_Validating);
            // 
            // inputkolicina
            // 
            this.inputkolicina.DecimalPlaces = 2;
            this.inputkolicina.Location = new System.Drawing.Point(27, 426);
            this.inputkolicina.Name = "inputkolicina";
            this.inputkolicina.Size = new System.Drawing.Size(120, 22);
            this.inputkolicina.TabIndex = 6;
            this.inputkolicina.Validating += new System.ComponentModel.CancelEventHandler(this.inputkolicina_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Količina:";
            // 
            // cmb_jedinicakolicine
            // 
            this.cmb_jedinicakolicine.FormattingEnabled = true;
            this.cmb_jedinicakolicine.Location = new System.Drawing.Point(173, 426);
            this.cmb_jedinicakolicine.Name = "cmb_jedinicakolicine";
            this.cmb_jedinicakolicine.Size = new System.Drawing.Size(121, 24);
            this.cmb_jedinicakolicine.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jedinica količine:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kategorija proizvoda:";
            // 
            // cmb_kategorijaproizvoda
            // 
            this.cmb_kategorijaproizvoda.FormattingEnabled = true;
            this.cmb_kategorijaproizvoda.Location = new System.Drawing.Point(26, 482);
            this.cmb_kategorijaproizvoda.Name = "cmb_kategorijaproizvoda";
            this.cmb_kategorijaproizvoda.Size = new System.Drawing.Size(121, 24);
            this.cmb_kategorijaproizvoda.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Skladište:";
            // 
            // cmb_skladiste
            // 
            this.cmb_skladiste.FormattingEnabled = true;
            this.cmb_skladiste.Location = new System.Drawing.Point(26, 541);
            this.cmb_skladiste.Name = "cmb_skladiste";
            this.cmb_skladiste.Size = new System.Drawing.Size(121, 24);
            this.cmb_skladiste.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_ucitajsliku
            // 
            this.btn_ucitajsliku.Location = new System.Drawing.Point(24, 853);
            this.btn_ucitajsliku.Name = "btn_ucitajsliku";
            this.btn_ucitajsliku.Size = new System.Drawing.Size(125, 35);
            this.btn_ucitajsliku.TabIndex = 13;
            this.btn_ucitajsliku.Text = "Slika";
            this.btn_ucitajsliku.UseVisualStyleBackColor = true;
            this.btn_ucitajsliku.Click += new System.EventHandler(this.btn_ucitajsliku_Click);
            this.btn_ucitajsliku.Validating += new System.ComponentModel.CancelEventHandler(this.btn_ucitajsliku_Validating);
            // 
            // btn_snimiproizvod
            // 
            this.btn_snimiproizvod.Location = new System.Drawing.Point(415, 853);
            this.btn_snimiproizvod.Name = "btn_snimiproizvod";
            this.btn_snimiproizvod.Size = new System.Drawing.Size(125, 35);
            this.btn_snimiproizvod.TabIndex = 14;
            this.btn_snimiproizvod.Text = "Snimi proizvod";
            this.btn_snimiproizvod.UseVisualStyleBackColor = true;
            this.btn_snimiproizvod.Click += new System.EventHandler(this.btn_snimiproizvod_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 820);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Učitaj sliku:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(171, 754);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(194, 134);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // txt_opis
            // 
            this.txt_opis.Location = new System.Drawing.Point(27, 160);
            this.txt_opis.Name = "txt_opis";
            this.txt_opis.Size = new System.Drawing.Size(210, 96);
            this.txt_opis.TabIndex = 18;
            this.txt_opis.Text = "";
            this.txt_opis.Validating += new System.ComponentModel.CancelEventHandler(this.txt_opis_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Opis:";
            // 
            // insert_kolicinanaskladistu
            // 
            this.insert_kolicinanaskladistu.Location = new System.Drawing.Point(27, 603);
            this.insert_kolicinanaskladistu.Name = "insert_kolicinanaskladistu";
            this.insert_kolicinanaskladistu.Size = new System.Drawing.Size(120, 22);
            this.insert_kolicinanaskladistu.TabIndex = 21;
            this.insert_kolicinanaskladistu.Validating += new System.ComponentModel.CancelEventHandler(this.insert_kolicinanaskladistu_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 583);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Broj proizvoda na skladištu:";
            // 
            // check_aktivan
            // 
            this.check_aktivan.AutoSize = true;
            this.check_aktivan.Location = new System.Drawing.Point(26, 644);
            this.check_aktivan.Name = "check_aktivan";
            this.check_aktivan.Size = new System.Drawing.Size(84, 21);
            this.check_aktivan.TabIndex = 22;
            this.check_aktivan.Text = "Aktivan?";
            this.check_aktivan.UseVisualStyleBackColor = true;
            // 
            // inputnabavnacijena
            // 
            this.inputnabavnacijena.DecimalPlaces = 2;
            this.inputnabavnacijena.Location = new System.Drawing.Point(29, 366);
            this.inputnabavnacijena.Name = "inputnabavnacijena";
            this.inputnabavnacijena.Size = new System.Drawing.Size(120, 22);
            this.inputnabavnacijena.TabIndex = 24;
            this.inputnabavnacijena.Validating += new System.ComponentModel.CancelEventHandler(this.inputnabavnacijena_Validating);
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Location = new System.Drawing.Point(25, 346);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(110, 17);
            this.labl.TabIndex = 23;
            this.labl.Text = "Nabavna cijena:";
            // 
            // dtp_istekroka
            // 
            this.dtp_istekroka.Location = new System.Drawing.Point(24, 708);
            this.dtp_istekroka.Name = "dtp_istekroka";
            this.dtp_istekroka.Size = new System.Drawing.Size(200, 22);
            this.dtp_istekroka.TabIndex = 25;
            this.dtp_istekroka.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_istekroka_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 680);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Datum isteka roka:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_noviproizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(561, 1005);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtp_istekroka);
            this.Controls.Add(this.inputnabavnacijena);
            this.Controls.Add(this.labl);
            this.Controls.Add(this.check_aktivan);
            this.Controls.Add(this.insert_kolicinanaskladistu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_opis);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_snimiproizvod);
            this.Controls.Add(this.btn_ucitajsliku);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_skladiste);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_kategorijaproizvoda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_jedinicakolicine);
            this.Controls.Add(this.inputkolicina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputcijena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_naziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_noviproizvod";
            this.Text = "frm_noviproizvod";
            this.Load += new System.EventHandler(this.frm_noviproizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputcijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputkolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insert_kolicinanaskladistu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputnabavnacijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputcijena;
        private System.Windows.Forms.NumericUpDown inputkolicina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_jedinicakolicine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_kategorijaproizvoda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_skladiste;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_ucitajsliku;
        private System.Windows.Forms.Button btn_snimiproizvod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox txt_opis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown insert_kolicinanaskladistu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox check_aktivan;
        private System.Windows.Forms.NumericUpDown inputnabavnacijena;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.DateTimePicker dtp_istekroka;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}