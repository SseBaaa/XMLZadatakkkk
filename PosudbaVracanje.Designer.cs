namespace AplikacijaZaBiblioteku
{
    partial class PosudbaVracanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosudbaVracanje));
            this.ZavrsiButun = new System.Windows.Forms.Button();
            this.VracanjeCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxKorisnik = new System.Windows.Forms.TextBox();
            this.textBoxKnjiga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ZavrsiButun
            // 
            this.ZavrsiButun.BackColor = System.Drawing.Color.SkyBlue;
            this.ZavrsiButun.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZavrsiButun.Location = new System.Drawing.Point(177, 69);
            this.ZavrsiButun.Name = "ZavrsiButun";
            this.ZavrsiButun.Size = new System.Drawing.Size(121, 23);
            this.ZavrsiButun.TabIndex = 0;
            this.ZavrsiButun.Text = "Ok";
            this.ZavrsiButun.UseVisualStyleBackColor = false;
            this.ZavrsiButun.Click += new System.EventHandler(this.ZavrsiButun_Click);
            // 
            // VracanjeCheck
            // 
            this.VracanjeCheck.AutoSize = true;
            this.VracanjeCheck.BackColor = System.Drawing.Color.SteelBlue;
            this.VracanjeCheck.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VracanjeCheck.Location = new System.Drawing.Point(177, 35);
            this.VracanjeCheck.Name = "VracanjeCheck";
            this.VracanjeCheck.Size = new System.Drawing.Size(75, 21);
            this.VracanjeCheck.TabIndex = 3;
            this.VracanjeCheck.Text = "Vracanje";
            this.VracanjeCheck.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Korisnik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Knjiga";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBoxKorisnik
            // 
            this.textBoxKorisnik.BackColor = System.Drawing.Color.SkyBlue;
            this.textBoxKorisnik.Location = new System.Drawing.Point(53, 31);
            this.textBoxKorisnik.Name = "textBoxKorisnik";
            this.textBoxKorisnik.Size = new System.Drawing.Size(100, 20);
            this.textBoxKorisnik.TabIndex = 7;
            // 
            // textBoxKnjiga
            // 
            this.textBoxKnjiga.BackColor = System.Drawing.Color.SkyBlue;
            this.textBoxKnjiga.Location = new System.Drawing.Point(54, 75);
            this.textBoxKnjiga.Name = "textBoxKnjiga";
            this.textBoxKnjiga.Size = new System.Drawing.Size(100, 20);
            this.textBoxKnjiga.TabIndex = 8;
            // 
            // PosudbaVracanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(344, 104);
            this.Controls.Add(this.textBoxKnjiga);
            this.Controls.Add(this.textBoxKorisnik);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VracanjeCheck);
            this.Controls.Add(this.ZavrsiButun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PosudbaVracanje";
            this.Text = "Libreno - posudba i vracanje";
            this.Load += new System.EventHandler(this.PosudbaVracanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZavrsiButun;
        private System.Windows.Forms.CheckBox VracanjeCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxKorisnik;
        private System.Windows.Forms.TextBox textBoxKnjiga;
    }
}