
namespace SmartRestaurantWinUI.Narudzbe
{
    partial class frm_brisanje
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
            this.txt_nazivnarudzbe = new System.Windows.Forms.TextBox();
            this.btn_da = new System.Windows.Forms.Button();
            this.btn_ne = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Da li ste sigurni da želite obrisati ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(543, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "narudžbu.";
            // 
            // txt_nazivnarudzbe
            // 
            this.txt_nazivnarudzbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_nazivnarudzbe.Location = new System.Drawing.Point(329, 71);
            this.txt_nazivnarudzbe.Name = "txt_nazivnarudzbe";
            this.txt_nazivnarudzbe.ReadOnly = true;
            this.txt_nazivnarudzbe.Size = new System.Drawing.Size(197, 24);
            this.txt_nazivnarudzbe.TabIndex = 2;
            // 
            // btn_da
            // 
            this.btn_da.Location = new System.Drawing.Point(220, 137);
            this.btn_da.Name = "btn_da";
            this.btn_da.Size = new System.Drawing.Size(97, 32);
            this.btn_da.TabIndex = 3;
            this.btn_da.Text = "Da!";
            this.btn_da.UseVisualStyleBackColor = true;
            this.btn_da.Click += new System.EventHandler(this.btn_da_Click);
            // 
            // btn_ne
            // 
            this.btn_ne.Location = new System.Drawing.Point(381, 137);
            this.btn_ne.Name = "btn_ne";
            this.btn_ne.Size = new System.Drawing.Size(97, 32);
            this.btn_ne.TabIndex = 4;
            this.btn_ne.Text = "Ne!";
            this.btn_ne.UseVisualStyleBackColor = true;
            this.btn_ne.Click += new System.EventHandler(this.btn_ne_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(258, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Brisanje narudžbe";
            // 
            // frm_brisanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 181);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ne);
            this.Controls.Add(this.btn_da);
            this.Controls.Add(this.txt_nazivnarudzbe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_brisanje";
            this.Text = "frm_brisanje";
            this.Load += new System.EventHandler(this.frm_brisanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nazivnarudzbe;
        private System.Windows.Forms.Button btn_da;
        private System.Windows.Forms.Button btn_ne;
        private System.Windows.Forms.Label label3;
    }
}