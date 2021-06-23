
namespace SmartRestaurantWinUI.Narudzbe
{
    partial class frm_uredistatus
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
            this.txt_narudzbanaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.btn_sacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(118, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uredi status";
            // 
            // txt_narudzbanaziv
            // 
            this.txt_narudzbanaziv.Location = new System.Drawing.Point(184, 121);
            this.txt_narudzbanaziv.Name = "txt_narudzbanaziv";
            this.txt_narudzbanaziv.ReadOnly = true;
            this.txt_narudzbanaziv.Size = new System.Drawing.Size(151, 22);
            this.txt_narudzbanaziv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Narudžba naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status:";
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(184, 175);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(121, 24);
            this.cmb_status.TabIndex = 4;
            // 
            // btn_sacuvaj
            // 
            this.btn_sacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_sacuvaj.Location = new System.Drawing.Point(166, 251);
            this.btn_sacuvaj.Name = "btn_sacuvaj";
            this.btn_sacuvaj.Size = new System.Drawing.Size(139, 39);
            this.btn_sacuvaj.TabIndex = 5;
            this.btn_sacuvaj.Text = "Snimi izmjenu";
            this.btn_sacuvaj.UseVisualStyleBackColor = true;
            this.btn_sacuvaj.Click += new System.EventHandler(this.btn_sacuvaj_Click);
            // 
            // frm_uredistatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 316);
            this.Controls.Add(this.btn_sacuvaj);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_narudzbanaziv);
            this.Controls.Add(this.label1);
            this.Name = "frm_uredistatus";
            this.Text = "frm_uredistatus";
            this.Load += new System.EventHandler(this.frm_uredistatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_narudzbanaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Button btn_sacuvaj;
    }
}