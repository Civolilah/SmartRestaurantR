
namespace SmartRestaurantWinUI.Narudzbe
{
    partial class frm_Pregled
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_preglednarudzbi = new System.Windows.Forms.DataGridView();
            this.NarudzbaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoPosluzivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeKreiranjaNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_osvjezi = new System.Windows.Forms.Button();
            this.txt_mjestoposluzivanja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nazivnarudzbe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.dtp_OD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_DO = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_preglednarudzbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(508, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled narudžbi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_preglednarudzbi);
            this.groupBox1.Location = new System.Drawing.Point(12, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1148, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Narudžbe";
            // 
            // dgv_preglednarudzbi
            // 
            this.dgv_preglednarudzbi.AllowUserToAddRows = false;
            this.dgv_preglednarudzbi.AllowUserToDeleteRows = false;
            this.dgv_preglednarudzbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_preglednarudzbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaID,
            this.MjestoPosluzivanja,
            this.NazivNarudzbe,
            this.VrijemeKreiranjaNarudzbe,
            this.Status,
            this.Obrisi});
            this.dgv_preglednarudzbi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_preglednarudzbi.Location = new System.Drawing.Point(3, 18);
            this.dgv_preglednarudzbi.Name = "dgv_preglednarudzbi";
            this.dgv_preglednarudzbi.ReadOnly = true;
            this.dgv_preglednarudzbi.RowHeadersWidth = 51;
            this.dgv_preglednarudzbi.RowTemplate.Height = 24;
            this.dgv_preglednarudzbi.Size = new System.Drawing.Size(1142, 235);
            this.dgv_preglednarudzbi.TabIndex = 0;
            this.dgv_preglednarudzbi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_preglednarudzbi_CellContentClick);
            // 
            // NarudzbaID
            // 
            this.NarudzbaID.DataPropertyName = "NarudzbaID";
            this.NarudzbaID.HeaderText = "NarudzbaID";
            this.NarudzbaID.MinimumWidth = 6;
            this.NarudzbaID.Name = "NarudzbaID";
            this.NarudzbaID.ReadOnly = true;
            this.NarudzbaID.Visible = false;
            this.NarudzbaID.Width = 125;
            // 
            // MjestoPosluzivanja
            // 
            this.MjestoPosluzivanja.DataPropertyName = "IDMjestaPosluzivanja";
            this.MjestoPosluzivanja.HeaderText = "ID Mjesta posluživanja";
            this.MjestoPosluzivanja.MinimumWidth = 6;
            this.MjestoPosluzivanja.Name = "MjestoPosluzivanja";
            this.MjestoPosluzivanja.ReadOnly = true;
            this.MjestoPosluzivanja.Width = 180;
            // 
            // NazivNarudzbe
            // 
            this.NazivNarudzbe.DataPropertyName = "NazivNarudzbe";
            this.NazivNarudzbe.HeaderText = "Naziv narudžbe";
            this.NazivNarudzbe.MinimumWidth = 6;
            this.NazivNarudzbe.Name = "NazivNarudzbe";
            this.NazivNarudzbe.ReadOnly = true;
            this.NazivNarudzbe.Width = 150;
            // 
            // VrijemeKreiranjaNarudzbe
            // 
            this.VrijemeKreiranjaNarudzbe.DataPropertyName = "VrijemeKreiranjaNarudzbe";
            this.VrijemeKreiranjaNarudzbe.HeaderText = "Vrijeme kreiranja narudžbe";
            this.VrijemeKreiranjaNarudzbe.MinimumWidth = 6;
            this.VrijemeKreiranjaNarudzbe.Name = "VrijemeKreiranjaNarudzbe";
            this.VrijemeKreiranjaNarudzbe.ReadOnly = true;
            this.VrijemeKreiranjaNarudzbe.Width = 220;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // Obrisi
            // 
            this.Obrisi.HeaderText = "Obriši";
            this.Obrisi.MinimumWidth = 6;
            this.Obrisi.Name = "Obrisi";
            this.Obrisi.ReadOnly = true;
            this.Obrisi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Obrisi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Obrisi.Text = "Obriši";
            this.Obrisi.UseColumnTextForButtonValue = true;
            this.Obrisi.Width = 125;
            // 
            // btn_osvjezi
            // 
            this.btn_osvjezi.Location = new System.Drawing.Point(1067, 114);
            this.btn_osvjezi.Name = "btn_osvjezi";
            this.btn_osvjezi.Size = new System.Drawing.Size(86, 40);
            this.btn_osvjezi.TabIndex = 2;
            this.btn_osvjezi.Text = "Osvježi";
            this.btn_osvjezi.UseVisualStyleBackColor = true;
            this.btn_osvjezi.Click += new System.EventHandler(this.btn_osvjezi_Click);
            // 
            // txt_mjestoposluzivanja
            // 
            this.txt_mjestoposluzivanja.Location = new System.Drawing.Point(296, 134);
            this.txt_mjestoposluzivanja.Name = "txt_mjestoposluzivanja";
            this.txt_mjestoposluzivanja.Size = new System.Drawing.Size(132, 22);
            this.txt_mjestoposluzivanja.TabIndex = 3;
            this.txt_mjestoposluzivanja.Validating += new System.ComponentModel.CancelEventHandler(this.txt_mjestoposluzivanja_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mjesto posluživanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Naziv narudžbe:";
            // 
            // txt_nazivnarudzbe
            // 
            this.txt_nazivnarudzbe.Location = new System.Drawing.Point(449, 134);
            this.txt_nazivnarudzbe.Name = "txt_nazivnarudzbe";
            this.txt_nazivnarudzbe.Size = new System.Drawing.Size(132, 22);
            this.txt_nazivnarudzbe.TabIndex = 5;
            this.txt_nazivnarudzbe.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nazivnarudzbe_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status:";
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(607, 134);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(132, 22);
            this.txt_status.TabIndex = 7;
            this.txt_status.Validating += new System.ComponentModel.CancelEventHandler(this.txt_status_Validating);
            // 
            // dtp_OD
            // 
            this.dtp_OD.Location = new System.Drawing.Point(794, 132);
            this.dtp_OD.Name = "dtp_OD";
            this.dtp_OD.Size = new System.Drawing.Size(113, 22);
            this.dtp_OD.TabIndex = 9;
            this.dtp_OD.Value = new System.DateTime(2021, 5, 15, 21, 53, 0, 0);
            this.dtp_OD.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_OD_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(791, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Od:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(921, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Do:";
            // 
            // dtp_DO
            // 
            this.dtp_DO.Location = new System.Drawing.Point(924, 132);
            this.dtp_DO.Name = "dtp_DO";
            this.dtp_DO.Size = new System.Drawing.Size(113, 22);
            this.dtp_DO.TabIndex = 11;
            this.dtp_DO.Validating += new System.ComponentModel.CancelEventHandler(this.dtp_DO_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_DO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_OD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nazivnarudzbe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mjestoposluzivanja);
            this.Controls.Add(this.btn_osvjezi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_Pregled";
            this.Text = "fmr_Pregled";
            this.Load += new System.EventHandler(this.frm_Pregled_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_preglednarudzbi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_preglednarudzbi;
        private System.Windows.Forms.Button btn_osvjezi;
        private System.Windows.Forms.TextBox txt_mjestoposluzivanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nazivnarudzbe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.DateTimePicker dtp_OD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_DO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjestoPosluzivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeKreiranjaNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Obrisi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}