
namespace SmartRestaurantWinUI.Proizvodi
{
    partial class frm_detalji
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
            this.txt_kolicinaskladiste = new System.Windows.Forms.TextBox();
            this.txt_opis = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_kategorijaproizvoda = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_jedinicakolicine = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opis:";
            // 
            // txt_kolicinaskladiste
            // 
            this.txt_kolicinaskladiste.Location = new System.Drawing.Point(15, 274);
            this.txt_kolicinaskladiste.Name = "txt_kolicinaskladiste";
            this.txt_kolicinaskladiste.ReadOnly = true;
            this.txt_kolicinaskladiste.Size = new System.Drawing.Size(74, 22);
            this.txt_kolicinaskladiste.TabIndex = 1;
            // 
            // txt_opis
            // 
            this.txt_opis.Location = new System.Drawing.Point(15, 124);
            this.txt_opis.Name = "txt_opis";
            this.txt_opis.ReadOnly = true;
            this.txt_opis.Size = new System.Drawing.Size(210, 96);
            this.txt_opis.TabIndex = 19;
            this.txt_opis.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(66, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Detalji proizvoda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Količina na skladištu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kategorija proizvoda:";
            // 
            // txt_kategorijaproizvoda
            // 
            this.txt_kategorijaproizvoda.Location = new System.Drawing.Point(15, 349);
            this.txt_kategorijaproizvoda.Name = "txt_kategorijaproizvoda";
            this.txt_kategorijaproizvoda.ReadOnly = true;
            this.txt_kategorijaproizvoda.Size = new System.Drawing.Size(100, 22);
            this.txt_kategorijaproizvoda.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 24;
            this.button1.Text = "Uredu!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_jedinicakolicine
            // 
            this.txt_jedinicakolicine.Location = new System.Drawing.Point(95, 274);
            this.txt_jedinicakolicine.Name = "txt_jedinicakolicine";
            this.txt_jedinicakolicine.ReadOnly = true;
            this.txt_jedinicakolicine.Size = new System.Drawing.Size(59, 22);
            this.txt_jedinicakolicine.TabIndex = 25;
            // 
            // frm_detalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.txt_jedinicakolicine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_kategorijaproizvoda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_opis);
            this.Controls.Add(this.txt_kolicinaskladiste);
            this.Controls.Add(this.label1);
            this.Name = "frm_detalji";
            this.Text = "frm_detalji";
            this.Load += new System.EventHandler(this.frm_detalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kolicinaskladiste;
        private System.Windows.Forms.RichTextBox txt_opis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_kategorijaproizvoda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_jedinicakolicine;
    }
}