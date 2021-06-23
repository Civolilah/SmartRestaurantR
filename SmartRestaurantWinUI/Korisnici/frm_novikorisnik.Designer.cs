
namespace SmartRestaurantWinUI.Korisnici
{
    partial class frm_novikorisnik
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
            this.btn_snimi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nazivkorisnika = new System.Windows.Forms.TextBox();
            this.txt_passwordpotvrda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_uloge = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novi korisnik";
            // 
            // btn_snimi
            // 
            this.btn_snimi.Location = new System.Drawing.Point(137, 341);
            this.btn_snimi.Name = "btn_snimi";
            this.btn_snimi.Size = new System.Drawing.Size(136, 39);
            this.btn_snimi.TabIndex = 1;
            this.btn_snimi.Text = "Snimi korisnika";
            this.btn_snimi.UseVisualStyleBackColor = true;
            this.btn_snimi.Click += new System.EventHandler(this.btn_snimi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime korisnika";
            // 
            // txt_nazivkorisnika
            // 
            this.txt_nazivkorisnika.Location = new System.Drawing.Point(15, 102);
            this.txt_nazivkorisnika.Name = "txt_nazivkorisnika";
            this.txt_nazivkorisnika.Size = new System.Drawing.Size(121, 22);
            this.txt_nazivkorisnika.TabIndex = 3;
            this.txt_nazivkorisnika.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nazivkorisnika_Validating);
            // 
            // txt_passwordpotvrda
            // 
            this.txt_passwordpotvrda.Location = new System.Drawing.Point(236, 257);
            this.txt_passwordpotvrda.Name = "txt_passwordpotvrda";
            this.txt_passwordpotvrda.Size = new System.Drawing.Size(162, 22);
            this.txt_passwordpotvrda.TabIndex = 5;
            this.txt_passwordpotvrda.Validating += new System.ComponentModel.CancelEventHandler(this.txt_passwordpotvrda_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password potvrda";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(15, 257);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(162, 22);
            this.txt_password.TabIndex = 7;
            this.txt_password.Validating += new System.ComponentModel.CancelEventHandler(this.txt_password_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // cmb_uloge
            // 
            this.cmb_uloge.FormattingEnabled = true;
            this.cmb_uloge.Location = new System.Drawing.Point(15, 178);
            this.cmb_uloge.Name = "cmb_uloge";
            this.cmb_uloge.Size = new System.Drawing.Size(121, 24);
            this.cmb_uloge.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Uloga";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_novikorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 392);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_uloge);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_passwordpotvrda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nazivkorisnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_snimi);
            this.Controls.Add(this.label1);
            this.Name = "frm_novikorisnik";
            this.Text = "frm_novikorisnik";
            this.Load += new System.EventHandler(this.frm_novikorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_snimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nazivkorisnika;
        private System.Windows.Forms.TextBox txt_passwordpotvrda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_uloge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}