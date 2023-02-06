namespace AplikacijaZaBiblioteku
{
    partial class Libreno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Libreno));
            this.UpisKorisnikaButton = new System.Windows.Forms.Button();
            this.PVButton = new System.Windows.Forms.Button();
            this.UpisKnjigeButton = new System.Windows.Forms.Button();
            this.DBBrowserButun = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UpisKorisnikaButton
            // 
            this.UpisKorisnikaButton.BackColor = System.Drawing.Color.SkyBlue;
            this.UpisKorisnikaButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpisKorisnikaButton.Location = new System.Drawing.Point(22, 181);
            this.UpisKorisnikaButton.Name = "UpisKorisnikaButton";
            this.UpisKorisnikaButton.Size = new System.Drawing.Size(137, 69);
            this.UpisKorisnikaButton.TabIndex = 0;
            this.UpisKorisnikaButton.Text = "Upis Korisnika";
            this.UpisKorisnikaButton.UseVisualStyleBackColor = false;
            this.UpisKorisnikaButton.Click += new System.EventHandler(this.UpisKorisnikaButton_Click);
            // 
            // PVButton
            // 
            this.PVButton.BackColor = System.Drawing.Color.SkyBlue;
            this.PVButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PVButton.Location = new System.Drawing.Point(209, 181);
            this.PVButton.Name = "PVButton";
            this.PVButton.Size = new System.Drawing.Size(137, 69);
            this.PVButton.TabIndex = 1;
            this.PVButton.Text = "Posudivanje/Vracanje";
            this.PVButton.UseVisualStyleBackColor = false;
            this.PVButton.Click += new System.EventHandler(this.PVButton_Click);
            // 
            // UpisKnjigeButton
            // 
            this.UpisKnjigeButton.BackColor = System.Drawing.Color.SkyBlue;
            this.UpisKnjigeButton.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpisKnjigeButton.Location = new System.Drawing.Point(22, 266);
            this.UpisKnjigeButton.Name = "UpisKnjigeButton";
            this.UpisKnjigeButton.Size = new System.Drawing.Size(137, 69);
            this.UpisKnjigeButton.TabIndex = 2;
            this.UpisKnjigeButton.Text = "Upis Knjige";
            this.UpisKnjigeButton.UseVisualStyleBackColor = false;
            this.UpisKnjigeButton.Click += new System.EventHandler(this.UpisKnjigeButton_Click);
            // 
            // DBBrowserButun
            // 
            this.DBBrowserButun.BackColor = System.Drawing.Color.SkyBlue;
            this.DBBrowserButun.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DBBrowserButun.Location = new System.Drawing.Point(209, 266);
            this.DBBrowserButun.Name = "DBBrowserButun";
            this.DBBrowserButun.Size = new System.Drawing.Size(137, 69);
            this.DBBrowserButun.TabIndex = 3;
            this.DBBrowserButun.Text = "Pregled i pretraživanje podataka";
            this.DBBrowserButun.UseVisualStyleBackColor = false;
            this.DBBrowserButun.Click += new System.EventHandler(this.DBBrowserButun_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Libreno";
            // 
            // Libreno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(368, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DBBrowserButun);
            this.Controls.Add(this.UpisKnjigeButton);
            this.Controls.Add(this.PVButton);
            this.Controls.Add(this.UpisKorisnikaButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Libreno";
            this.Text = "Libreno";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpisKorisnikaButton;
        private System.Windows.Forms.Button PVButton;
        private System.Windows.Forms.Button UpisKnjigeButton;
        private System.Windows.Forms.Button DBBrowserButun;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

