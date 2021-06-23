
namespace SmartRestaurantWinUI.Narudzbe
{
    partial class frm_Detalji
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Cijena = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_proizvodi = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_imeiprezimenar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_brojtelefonanar = new System.Windows.Forms.TextBox();
            this.txt_adresanar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_proizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cijena";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Cijena
            // 
            this.txt_Cijena.Location = new System.Drawing.Point(98, 216);
            this.txt_Cijena.Name = "txt_Cijena";
            this.txt_Cijena.ReadOnly = true;
            this.txt_Cijena.Size = new System.Drawing.Size(100, 22);
            this.txt_Cijena.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_proizvodi);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 147);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Naručeni proizvodi";
            // 
            // dtg_proizvodi
            // 
            this.dtg_proizvodi.AllowUserToAddRows = false;
            this.dtg_proizvodi.AllowUserToDeleteRows = false;
            this.dtg_proizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_proizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Opis,
            this.Cijena});
            this.dtg_proizvodi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_proizvodi.Location = new System.Drawing.Point(3, 18);
            this.dtg_proizvodi.Name = "dtg_proizvodi";
            this.dtg_proizvodi.ReadOnly = true;
            this.dtg_proizvodi.RowHeadersWidth = 51;
            this.dtg_proizvodi.RowTemplate.Height = 24;
            this.dtg_proizvodi.Size = new System.Drawing.Size(565, 126);
            this.dtg_proizvodi.TabIndex = 0;
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
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 125;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Detalji narudžbe";
            // 
            // txt_imeiprezimenar
            // 
            this.txt_imeiprezimenar.Location = new System.Drawing.Point(246, 246);
            this.txt_imeiprezimenar.Name = "txt_imeiprezimenar";
            this.txt_imeiprezimenar.ReadOnly = true;
            this.txt_imeiprezimenar.Size = new System.Drawing.Size(180, 22);
            this.txt_imeiprezimenar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ime i prezime naručioca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adresa naručioca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Broj telefona naručioca:";
            // 
            // txt_brojtelefonanar
            // 
            this.txt_brojtelefonanar.Location = new System.Drawing.Point(246, 388);
            this.txt_brojtelefonanar.Name = "txt_brojtelefonanar";
            this.txt_brojtelefonanar.ReadOnly = true;
            this.txt_brojtelefonanar.Size = new System.Drawing.Size(180, 22);
            this.txt_brojtelefonanar.TabIndex = 11;
            // 
            // txt_adresanar
            // 
            this.txt_adresanar.Location = new System.Drawing.Point(246, 314);
            this.txt_adresanar.Name = "txt_adresanar";
            this.txt_adresanar.ReadOnly = true;
            this.txt_adresanar.Size = new System.Drawing.Size(180, 22);
            this.txt_adresanar.TabIndex = 12;
            // 
            // frm_Detalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 487);
            this.Controls.Add(this.txt_adresanar);
            this.Controls.Add(this.txt_brojtelefonanar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_imeiprezimenar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Cijena);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "frm_Detalji";
            this.Text = "frm_Detalji";
            this.Load += new System.EventHandler(this.frm_Detalji_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_proizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Cijena;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_proizvodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.TextBox txt_imeiprezimenar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_brojtelefonanar;
        private System.Windows.Forms.TextBox txt_adresanar;
    }
}