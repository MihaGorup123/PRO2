namespace DeljenjeZNič
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeljenec = new System.Windows.Forms.TextBox();
            this.txtDeljitelj = new System.Windows.Forms.TextBox();
            this.btnDeli = new System.Windows.Forms.Button();
            this.Rezultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deljenec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deljitelj";
            // 
            // txtDeljenec
            // 
            this.txtDeljenec.Location = new System.Drawing.Point(334, 87);
            this.txtDeljenec.Name = "txtDeljenec";
            this.txtDeljenec.Size = new System.Drawing.Size(100, 32);
            this.txtDeljenec.TabIndex = 2;
            // 
            // txtDeljitelj
            // 
            this.txtDeljitelj.Location = new System.Drawing.Point(334, 186);
            this.txtDeljitelj.Name = "txtDeljitelj";
            this.txtDeljitelj.Size = new System.Drawing.Size(100, 32);
            this.txtDeljitelj.TabIndex = 3;
            // 
            // btnDeli
            // 
            this.btnDeli.Location = new System.Drawing.Point(117, 288);
            this.btnDeli.Name = "btnDeli";
            this.btnDeli.Size = new System.Drawing.Size(81, 43);
            this.btnDeli.TabIndex = 4;
            this.btnDeli.Text = "Deli";
            this.btnDeli.UseVisualStyleBackColor = true;
            this.btnDeli.Click += new System.EventHandler(this.btnDeli_Click);
            // 
            // Rezultat
            // 
            this.Rezultat.AutoSize = true;
            this.Rezultat.Location = new System.Drawing.Point(329, 296);
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Size = new System.Drawing.Size(92, 26);
            this.Rezultat.TabIndex = 5;
            this.Rezultat.Text = "Rezultat";
            this.Rezultat.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 531);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.btnDeli);
            this.Controls.Add(this.txtDeljitelj);
            this.Controls.Add(this.txtDeljenec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeljenec;
        private System.Windows.Forms.TextBox txtDeljitelj;
        private System.Windows.Forms.Button btnDeli;
        private System.Windows.Forms.Label Rezultat;
    }
}

