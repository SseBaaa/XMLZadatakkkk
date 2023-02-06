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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpisKorisnika));
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
            this.ImeKorisnika.BackColor = System.Drawing.Color.SkyBlue;
            this.ImeKorisnika.Location = new System.Drawing.Point(108, 34);
            this.ImeKorisnika.Name = "ImeKorisnika";
            this.ImeKorisnika.Size = new System.Drawing.Size(100, 20);
            this.ImeKorisnika.TabIndex = 0;
            this.ImeKorisnika.TextChanged += new System.EventHandler(this.ImeKorisnika_TextChanged);
            // 
            // OIBKorisnika
            // 
            this.OIBKorisnika.BackColor = System.Drawing.Color.SkyBlue;
            this.OIBKorisnika.Location = new System.Drawing.Point(108, 120);
            this.OIBKorisnika.Name = "OIBKorisnika";
            this.OIBKorisnika.Size = new System.Drawing.Size(100, 20);
            this.OIBKorisnika.TabIndex = 1;
            // 
            // PrezimeKorisnika
            // 
            this.PrezimeKorisnika.BackColor = System.Drawing.Color.SkyBlue;
            this.PrezimeKorisnika.Location = new System.Drawing.Point(108, 77);
            this.PrezimeKorisnika.Name = "PrezimeKorisnika";
            this.PrezimeKorisnika.Size = new System.Drawing.Size(100, 20);
            this.PrezimeKorisnika.TabIndex = 2;
            this.PrezimeKorisnika.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Ime
            // 
            this.Ime.AutoSize = true;
            this.Ime.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ime.Location = new System.Drawing.Point(108, 15);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(29, 17);
            this.Ime.TabIndex = 3;
            this.Ime.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UnosButun
            // 
            this.UnosButun.BackColor = System.Drawing.Color.SkyBlue;
            this.UnosButun.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.UnosButun.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnosButun.Location = new System.Drawing.Point(108, 147);
            this.UnosButun.Name = "UnosButun";
            this.UnosButun.Size = new System.Drawing.Size(100, 23);
            this.UnosButun.TabIndex = 6;
            this.UnosButun.Text = "Unesi";
            this.UnosButun.UseVisualStyleBackColor = false;
            this.UnosButun.Click += new System.EventHandler(this.UnosButun_Click);
            // 
            // UpisKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(315, 182);
            this.Controls.Add(this.UnosButun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.PrezimeKorisnika);
            this.Controls.Add(this.OIBKorisnika);
            this.Controls.Add(this.ImeKorisnika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpisKorisnika";
            this.Text = "Libreno -  Upis korisnika";
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