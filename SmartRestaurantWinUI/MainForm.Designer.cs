
namespace SmartRestaurantWinUI
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviProizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajIzvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_narudzbe = new System.Windows.Forms.DataGridView();
            this.NarudzbaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mjestoposluzivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazivnarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrijemeKreiranjaNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UrediStatus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_osvjezipretragu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_pretraga = new System.Windows.Forms.TextBox();
            this.btn_pregled = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_narudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proizvodiToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.izvještajToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1327, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretragaToolStripMenuItem,
            this.noviProizvodToolStripMenuItem});
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // noviProizvodToolStripMenuItem
            // 
            this.noviProizvodToolStripMenuItem.Name = "noviProizvodToolStripMenuItem";
            this.noviProizvodToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.noviProizvodToolStripMenuItem.Text = "Novi proizvod";
            this.noviProizvodToolStripMenuItem.Click += new System.EventHandler(this.noviProizvodToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKorisnikaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // izvještajToolStripMenuItem
            // 
            this.izvještajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajIzvještajToolStripMenuItem});
            this.izvještajToolStripMenuItem.Name = "izvještajToolStripMenuItem";
            this.izvještajToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.izvještajToolStripMenuItem.Text = "Izvještaj";
            // 
            // kreirajIzvještajToolStripMenuItem
            // 
            this.kreirajIzvještajToolStripMenuItem.Name = "kreirajIzvještajToolStripMenuItem";
            this.kreirajIzvještajToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.kreirajIzvještajToolStripMenuItem.Text = "Kreiraj izvještaj";
            this.kreirajIzvještajToolStripMenuItem.Click += new System.EventHandler(this.kreirajIzvještajToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1327, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg_narudzbe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBox1.Location = new System.Drawing.Point(12, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1303, 308);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Narudžbe";
            // 
            // dg_narudzbe
            // 
            this.dg_narudzbe.AllowUserToAddRows = false;
            this.dg_narudzbe.AllowUserToDeleteRows = false;
            this.dg_narudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dg_narudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_narudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaID,
            this.Mjestoposluzivanja,
            this.Nazivnarudzbe,
            this.VrijemeKreiranjaNarudzbe,
            this.Status,
            this.btn_detalji,
            this.btn_uredi,
            this.UrediStatus});
            this.dg_narudzbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_narudzbe.GridColor = System.Drawing.SystemColors.Control;
            this.dg_narudzbe.Location = new System.Drawing.Point(3, 24);
            this.dg_narudzbe.Margin = new System.Windows.Forms.Padding(0);
            this.dg_narudzbe.Name = "dg_narudzbe";
            this.dg_narudzbe.ReadOnly = true;
            this.dg_narudzbe.RowHeadersVisible = false;
            this.dg_narudzbe.RowHeadersWidth = 51;
            this.dg_narudzbe.RowTemplate.Height = 24;
            this.dg_narudzbe.Size = new System.Drawing.Size(1297, 281);
            this.dg_narudzbe.TabIndex = 0;
            this.dg_narudzbe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_narudzbe_CellContentClick);
            // 
            // NarudzbaID
            // 
            this.NarudzbaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NarudzbaID.DataPropertyName = "NarudzbaID";
            this.NarudzbaID.HeaderText = "NarudzbaID";
            this.NarudzbaID.MinimumWidth = 6;
            this.NarudzbaID.Name = "NarudzbaID";
            this.NarudzbaID.ReadOnly = true;
            this.NarudzbaID.Visible = false;
            this.NarudzbaID.Width = 155;
            // 
            // Mjestoposluzivanja
            // 
            this.Mjestoposluzivanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Mjestoposluzivanja.DataPropertyName = "MjestoPosluzivanja";
            this.Mjestoposluzivanja.HeaderText = "Mjesto posluživanja";
            this.Mjestoposluzivanja.MinimumWidth = 6;
            this.Mjestoposluzivanja.Name = "Mjestoposluzivanja";
            this.Mjestoposluzivanja.ReadOnly = true;
            this.Mjestoposluzivanja.Width = 214;
            // 
            // Nazivnarudzbe
            // 
            this.Nazivnarudzbe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nazivnarudzbe.DataPropertyName = "NazivNarudzbe";
            this.Nazivnarudzbe.HeaderText = "Naziv narudžbe";
            this.Nazivnarudzbe.MinimumWidth = 6;
            this.Nazivnarudzbe.Name = "Nazivnarudzbe";
            this.Nazivnarudzbe.ReadOnly = true;
            this.Nazivnarudzbe.Width = 200;
            // 
            // VrijemeKreiranjaNarudzbe
            // 
            this.VrijemeKreiranjaNarudzbe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.VrijemeKreiranjaNarudzbe.DataPropertyName = "VrijemeKreiranjaNarudzbe";
            this.VrijemeKreiranjaNarudzbe.HeaderText = "Vrijeme kreiranja narudzbe";
            this.VrijemeKreiranjaNarudzbe.MinimumWidth = 6;
            this.VrijemeKreiranjaNarudzbe.Name = "VrijemeKreiranjaNarudzbe";
            this.VrijemeKreiranjaNarudzbe.ReadOnly = true;
            this.VrijemeKreiranjaNarudzbe.Width = 271;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "StatusNarudzbe";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 89;
            // 
            // btn_detalji
            // 
            this.btn_detalji.HeaderText = "Detalji";
            this.btn_detalji.MinimumWidth = 6;
            this.btn_detalji.Name = "btn_detalji";
            this.btn_detalji.ReadOnly = true;
            this.btn_detalji.Text = "Detalji";
            this.btn_detalji.UseColumnTextForButtonValue = true;
            this.btn_detalji.Width = 66;
            // 
            // btn_uredi
            // 
            this.btn_uredi.HeaderText = "Uredi";
            this.btn_uredi.MinimumWidth = 6;
            this.btn_uredi.Name = "btn_uredi";
            this.btn_uredi.ReadOnly = true;
            this.btn_uredi.Text = "Uredi";
            this.btn_uredi.UseColumnTextForButtonValue = true;
            this.btn_uredi.Width = 61;
            // 
            // UrediStatus
            // 
            this.UrediStatus.HeaderText = "Uredi status";
            this.UrediStatus.MinimumWidth = 80;
            this.UrediStatus.Name = "UrediStatus";
            this.UrediStatus.ReadOnly = true;
            this.UrediStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UrediStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UrediStatus.Text = "Uredi status";
            this.UrediStatus.UseColumnTextForButtonValue = true;
            this.UrediStatus.Width = 125;
            // 
            // btn_osvjezipretragu
            // 
            this.btn_osvjezipretragu.Location = new System.Drawing.Point(1142, 143);
            this.btn_osvjezipretragu.Name = "btn_osvjezipretragu";
            this.btn_osvjezipretragu.Size = new System.Drawing.Size(170, 41);
            this.btn_osvjezipretragu.TabIndex = 18;
            this.btn_osvjezipretragu.Text = "Osvježi pretragu";
            this.btn_osvjezipretragu.UseVisualStyleBackColor = true;
            this.btn_osvjezipretragu.Click += new System.EventHandler(this.btn_osvjezipretragu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(920, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pretraga po nazivu narudžbe:";
            // 
            // tx_pretraga
            // 
            this.tx_pretraga.Location = new System.Drawing.Point(914, 154);
            this.tx_pretraga.Name = "tx_pretraga";
            this.tx_pretraga.Size = new System.Drawing.Size(202, 22);
            this.tx_pretraga.TabIndex = 16;
            this.tx_pretraga.Validating += new System.ComponentModel.CancelEventHandler(this.tx_pretraga_Validating);
            // 
            // btn_pregled
            // 
            this.btn_pregled.Location = new System.Drawing.Point(1198, 36);
            this.btn_pregled.Name = "btn_pregled";
            this.btn_pregled.Size = new System.Drawing.Size(114, 43);
            this.btn_pregled.TabIndex = 15;
            this.btn_pregled.Text = "Pregled";
            this.btn_pregled.UseVisualStyleBackColor = true;
            this.btn_pregled.Click += new System.EventHandler(this.btn_pregled_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dobro došao";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_osvjezipretragu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_pretraga);
            this.Controls.Add(this.btn_pregled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_narudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_narudzbe;
        private System.Windows.Forms.Button btn_osvjezipretragu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_pretraga;
        private System.Windows.Forms.Button btn_pregled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajIzvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviProizvodToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mjestoposluzivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazivnarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrijemeKreiranjaNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn btn_detalji;
        private System.Windows.Forms.DataGridViewButtonColumn btn_uredi;
        private System.Windows.Forms.DataGridViewButtonColumn UrediStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}



