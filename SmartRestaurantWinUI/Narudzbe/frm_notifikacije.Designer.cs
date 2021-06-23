
namespace SmartRestaurantWinUI.Narudzbe
{
    partial class frm_notifikacije
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mjestoposluzivanja = new System.Windows.Forms.TextBox();
            this.txt_nazivnarudzbe = new System.Windows.Forms.TextBox();
            this.btn_prihvati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(129, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodana je nova narudžba!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mjesto posluživanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Naziv narudžbe";
            // 
            // txt_mjestoposluzivanja
            // 
            this.txt_mjestoposluzivanja.Location = new System.Drawing.Point(70, 168);
            this.txt_mjestoposluzivanja.Name = "txt_mjestoposluzivanja";
            this.txt_mjestoposluzivanja.ReadOnly = true;
            this.txt_mjestoposluzivanja.Size = new System.Drawing.Size(100, 22);
            this.txt_mjestoposluzivanja.TabIndex = 3;
            // 
            // txt_nazivnarudzbe
            // 
            this.txt_nazivnarudzbe.Location = new System.Drawing.Point(274, 168);
            this.txt_nazivnarudzbe.Name = "txt_nazivnarudzbe";
            this.txt_nazivnarudzbe.ReadOnly = true;
            this.txt_nazivnarudzbe.Size = new System.Drawing.Size(219, 22);
            this.txt_nazivnarudzbe.TabIndex = 4;
            // 
            // btn_prihvati
            // 
            this.btn_prihvati.Location = new System.Drawing.Point(236, 223);
            this.btn_prihvati.Name = "btn_prihvati";
            this.btn_prihvati.Size = new System.Drawing.Size(90, 33);
            this.btn_prihvati.TabIndex = 5;
            this.btn_prihvati.Text = "Prihvati";
            this.btn_prihvati.UseVisualStyleBackColor = true;
            this.btn_prihvati.Click += new System.EventHandler(this.btn_prihvati_Click);
            // 
            // frm_notifikacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 288);
            this.Controls.Add(this.btn_prihvati);
            this.Controls.Add(this.txt_nazivnarudzbe);
            this.Controls.Add(this.txt_mjestoposluzivanja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_notifikacije";
            this.Text = "frm_notifikacije";
            this.Load += new System.EventHandler(this.frm_notifikacije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mjestoposluzivanja;
        private System.Windows.Forms.TextBox txt_nazivnarudzbe;
        private System.Windows.Forms.Button btn_prihvati;
    }
}