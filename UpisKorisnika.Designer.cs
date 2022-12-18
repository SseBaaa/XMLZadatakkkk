namespace AplikacijaZaBiblioteku
{
    partial class UpisKorisnika
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
            this.ImeKorisnika = new System.Windows.Forms.TextBox();
            this.OIBKorisnika = new System.Windows.Forms.TextBox();
            this.PrezimeKorisnika = new System.Windows.Forms.TextBox();
            this.Ime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UnosButun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImeKorisnika
            // 
            this.ImeKorisnika.Location = new System.Drawing.Point(12, 27);
            this.ImeKorisnika.Name = "ImeKorisnika";
            this.ImeKorisnika.Size = new System.Drawing.Size(100, 20);
            this.ImeKorisnika.TabIndex = 0;
            // 
            // OIBKorisnika
            // 
            this.OIBKorisnika.Location = new System.Drawing.Point(12, 100);
            this.OIBKorisnika.Name = "OIBKorisnika";
            this.OIBKorisnika.Size = new System.Drawing.Size(100, 20);
            this.OIBKorisnika.TabIndex = 1;
            // 
            // PrezimeKorisnika
            // 
            this.PrezimeKorisnika.Location = new System.Drawing.Point(12, 65);
            this.PrezimeKorisnika.Name = "PrezimeKorisnika";
            this.PrezimeKorisnika.Size = new System.Drawing.Size(100, 20);
            this.PrezimeKorisnika.TabIndex = 2;
            this.PrezimeKorisnika.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Location = new System.Drawing.Point(12, 8);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(24, 13);
            this.Ime.TabIndex = 3;
            this.Ime.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UnosButun
            // 
            this.UnosButun.Location = new System.Drawing.Point(12, 140);
            this.UnosButun.Name = "UnosButun";
            this.UnosButun.Size = new System.Drawing.Size(100, 23);
            this.UnosButun.TabIndex = 6;
            this.UnosButun.Text = "Unesi";
            this.UnosButun.UseVisualStyleBackColor = true;
            this.UnosButun.Click += new System.EventHandler(this.UnosButun_Click);
            // 
            // UpisKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(123, 182);
            this.Controls.Add(this.UnosButun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.PrezimeKorisnika);
            this.Controls.Add(this.OIBKorisnika);
            this.Controls.Add(this.ImeKorisnika);
            this.Name = "UpisKorisnika";
            this.Text = "UpisKorisnika";
            this.Load += new System.EventHandler(this.UpisKorisnika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImeKorisnika;
        private System.Windows.Forms.TextBox OIBKorisnika;
        private System.Windows.Forms.TextBox PrezimeKorisnika;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UnosButun;
    }
}