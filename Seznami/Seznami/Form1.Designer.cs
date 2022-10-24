namespace Seznami
{
    partial class Form1
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
            this.LastnostVnos = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOdstrani = new System.Windows.Forms.Button();
            this.btnPrvi = new System.Windows.Forms.Button();
            this.btnIzpis = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnZadnji = new System.Windows.Forms.Button();
            this.btnVsebuje = new System.Windows.Forms.Button();
            this.btnLokacija = new System.Windows.Forms.Button();
            this.btnPrazna = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vnesi Niz";
            // 
            // LastnostVnos
            // 
            this.LastnostVnos.Location = new System.Drawing.Point(297, 29);
            this.LastnostVnos.Name = "LastnostVnos";
            this.LastnostVnos.Size = new System.Drawing.Size(100, 30);
            this.LastnostVnos.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(563, 25);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 33);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOdstrani
            // 
            this.btnOdstrani.Location = new System.Drawing.Point(12, 137);
            this.btnOdstrani.Name = "btnOdstrani";
            this.btnOdstrani.Size = new System.Drawing.Size(153, 33);
            this.btnOdstrani.TabIndex = 3;
            this.btnOdstrani.Text = "Odstrani";
            this.btnOdstrani.UseVisualStyleBackColor = true;
            this.btnOdstrani.Click += new System.EventHandler(this.btnOdstrani_Click);
            // 
            // btnPrvi
            // 
            this.btnPrvi.Location = new System.Drawing.Point(287, 137);
            this.btnPrvi.Name = "btnPrvi";
            this.btnPrvi.Size = new System.Drawing.Size(110, 33);
            this.btnPrvi.TabIndex = 4;
            this.btnPrvi.Text = "Prvi";
            this.btnPrvi.UseVisualStyleBackColor = true;
            this.btnPrvi.Click += new System.EventHandler(this.btnPrvi_Click);
            // 
            // btnIzpis
            // 
            this.btnIzpis.Location = new System.Drawing.Point(551, 291);
            this.btnIzpis.Name = "btnIzpis";
            this.btnIzpis.Size = new System.Drawing.Size(97, 33);
            this.btnIzpis.TabIndex = 5;
            this.btnIzpis.Text = "Izpiši";
            this.btnIzpis.UseVisualStyleBackColor = true;
            this.btnIzpis.Click += new System.EventHandler(this.btnIzpis_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 354);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(581, 210);
            this.textBox1.TabIndex = 6;
            // 
            // btnZadnji
            // 
            this.btnZadnji.Location = new System.Drawing.Point(551, 137);
            this.btnZadnji.Name = "btnZadnji";
            this.btnZadnji.Size = new System.Drawing.Size(97, 33);
            this.btnZadnji.TabIndex = 7;
            this.btnZadnji.Text = "Zadnji";
            this.btnZadnji.UseVisualStyleBackColor = true;
            this.btnZadnji.Click += new System.EventHandler(this.btnZadnji_Click);
            // 
            // btnVsebuje
            // 
            this.btnVsebuje.Location = new System.Drawing.Point(287, 209);
            this.btnVsebuje.Name = "btnVsebuje";
            this.btnVsebuje.Size = new System.Drawing.Size(110, 33);
            this.btnVsebuje.TabIndex = 8;
            this.btnVsebuje.Text = "Vsebuje";
            this.btnVsebuje.UseVisualStyleBackColor = true;
            this.btnVsebuje.Click += new System.EventHandler(this.btnVsebuje_Click);
            // 
            // btnLokacija
            // 
            this.btnLokacija.Location = new System.Drawing.Point(551, 209);
            this.btnLokacija.Name = "btnLokacija";
            this.btnLokacija.Size = new System.Drawing.Size(97, 33);
            this.btnLokacija.TabIndex = 9;
            this.btnLokacija.Text = "Lokacija";
            this.btnLokacija.UseVisualStyleBackColor = true;
            this.btnLokacija.Click += new System.EventHandler(this.btnLokacija_Click);
            // 
            // btnPrazna
            // 
            this.btnPrazna.Location = new System.Drawing.Point(12, 219);
            this.btnPrazna.Name = "btnPrazna";
            this.btnPrazna.Size = new System.Drawing.Size(153, 33);
            this.btnPrazna.TabIndex = 10;
            this.btnPrazna.Text = "Je Prazna?";
            this.btnPrazna.UseVisualStyleBackColor = true;
            this.btnPrazna.Click += new System.EventHandler(this.btnPrazna_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(287, 291);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(110, 33);
            this.btnStatistika.TabIndex = 11;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(12, 291);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(153, 33);
            this.btnTrim.TabIndex = 12;
            this.btnTrim.Text = "Trim";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 608);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnPrazna);
            this.Controls.Add(this.btnLokacija);
            this.Controls.Add(this.btnVsebuje);
            this.Controls.Add(this.btnZadnji);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIzpis);
            this.Controls.Add(this.btnPrvi);
            this.Controls.Add(this.btnOdstrani);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.LastnostVnos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LastnostVnos;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOdstrani;
        private System.Windows.Forms.Button btnPrvi;
        private System.Windows.Forms.Button btnIzpis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnZadnji;
        private System.Windows.Forms.Button btnVsebuje;
        private System.Windows.Forms.Button btnLokacija;
        private System.Windows.Forms.Button btnPrazna;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Button btnTrim;
    }
}

