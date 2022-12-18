namespace AplikacijaZaBiblioteku
{
    partial class UpisKnjige
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
            this.UnosButun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ime = new System.Windows.Forms.Label();
            this.AutorKnjige = new System.Windows.Forms.TextBox();
            this.KolicinaKnjige = new System.Windows.Forms.TextBox();
            this.NazivKnjige = new System.Windows.Forms.TextBox();
            this.ISBNKnjige = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UnosButun
            // 
            this.UnosButun.Location = new System.Drawing.Point(12, 173);
            this.UnosButun.Name = "UnosButun";
            this.UnosButun.Size = new System.Drawing.Size(100, 23);
            this.UnosButun.TabIndex = 13;
            this.UnosButun.Text = "Unesi";
            this.UnosButun.UseVisualStyleBackColor = true;
            this.UnosButun.Click += new System.EventHandler(this.UnosButun_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(0, 0);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(100, 23);
            this.Ime.TabIndex = 0;
            // 
            // AutorKnjige
            // 
            this.AutorKnjige.Location = new System.Drawing.Point(0, 0);
            this.AutorKnjige.Name = "AutorKnjige";
            this.AutorKnjige.Size = new System.Drawing.Size(100, 20);
            this.AutorKnjige.TabIndex = 0;
            // 
            // KolicinaKnjige
            // 
            this.KolicinaKnjige.Location = new System.Drawing.Point(0, 0);
            this.KolicinaKnjige.Name = "KolicinaKnjige";
            this.KolicinaKnjige.Size = new System.Drawing.Size(100, 20);
            this.KolicinaKnjige.TabIndex = 0;
            // 
            // NazivKnjige
            // 
            this.NazivKnjige.Location = new System.Drawing.Point(0, 0);
            this.NazivKnjige.Name = "NazivKnjige";
            this.NazivKnjige.Size = new System.Drawing.Size(100, 20);
            this.NazivKnjige.TabIndex = 0;
            // 
            // ISBNKnjige
            // 
            this.ISBNKnjige.Location = new System.Drawing.Point(15, 147);
            this.ISBNKnjige.Name = "ISBNKnjige";
            this.ISBNKnjige.Size = new System.Drawing.Size(97, 20);
            this.ISBNKnjige.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "ISBN";
            // 
            // UpisKnjige
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "UpisKnjige";
            this.Load += new System.EventHandler(this.UpisKnjige_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UnosButun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.TextBox AutorKnjige;
        private System.Windows.Forms.TextBox KolicinaKnjige;
        private System.Windows.Forms.TextBox NazivKnjige;
        private System.Windows.Forms.TextBox ISBNKnjige;
        private System.Windows.Forms.Label label1;
    }
}