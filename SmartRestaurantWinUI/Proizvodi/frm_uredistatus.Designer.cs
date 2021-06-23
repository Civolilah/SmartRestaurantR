
namespace SmartRestaurantWinUI.Proizvodi
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
            this.txt_nazivnarudzbe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_snimi = new System.Windows.Forms.Button();
            this.cmb_statusi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promjena statusa";
            // 
            // txt_nazivnarudzbe
            // 
            this.txt_nazivnarudzbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_nazivnarudzbe.Location = new System.Drawing.Point(44, 65);
            this.txt_nazivnarudzbe.Name = "txt_nazivnarudzbe";
            this.txt_nazivnarudzbe.ReadOnly = true;
            this.txt_nazivnarudzbe.Size = new System.Drawing.Size(193, 30);
            this.txt_nazivnarudzbe.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(72, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "proizvoda";
            // 
            // btn_snimi
            // 
            this.btn_snimi.Location = new System.Drawing.Point(77, 255);
            this.btn_snimi.Name = "btn_snimi";
            this.btn_snimi.Size = new System.Drawing.Size(122, 37);
            this.btn_snimi.TabIndex = 3;
            this.btn_snimi.Text = "Snimi promjene";
            this.btn_snimi.UseVisualStyleBackColor = true;
            this.btn_snimi.Click += new System.EventHandler(this.btn_snimi_Click);
            // 
            // cmb_statusi
            // 
            this.cmb_statusi.FormattingEnabled = true;
            this.cmb_statusi.Location = new System.Drawing.Point(77, 175);
            this.cmb_statusi.Name = "cmb_statusi";
            this.cmb_statusi.Size = new System.Drawing.Size(121, 24);
            this.cmb_statusi.TabIndex = 4;
            // 
            // frm_uredistatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 314);
            this.Controls.Add(this.cmb_statusi);
            this.Controls.Add(this.btn_snimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nazivnarudzbe);
            this.Controls.Add(this.label1);
            this.Name = "frm_uredistatus";
            this.Text = "frm_uredistatus";
            this.Load += new System.EventHandler(this.frm_uredistatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nazivnarudzbe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_snimi;
        private System.Windows.Forms.ComboBox cmb_statusi;
    }
}