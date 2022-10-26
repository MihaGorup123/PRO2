namespace IgraKarte
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPonastavi1 = new System.Windows.Forms.Button();
            this.btnMešaj1 = new System.Windows.Forms.Button();
            this.btnPonastavi2 = new System.Windows.Forms.Button();
            this.btnMešaj2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPonastavi1
            // 
            this.btnPonastavi1.Location = new System.Drawing.Point(25, 349);
            this.btnPonastavi1.Name = "btnPonastavi1";
            this.btnPonastavi1.Size = new System.Drawing.Size(161, 32);
            this.btnPonastavi1.TabIndex = 1;
            this.btnPonastavi1.Text = "Ponastavi Kup #1";
            this.btnPonastavi1.UseVisualStyleBackColor = true;
            this.btnPonastavi1.Click += new System.EventHandler(this.btnPonastavi1_Click);
            // 
            // btnMešaj1
            // 
            this.btnMešaj1.Location = new System.Drawing.Point(25, 387);
            this.btnMešaj1.Name = "btnMešaj1";
            this.btnMešaj1.Size = new System.Drawing.Size(161, 31);
            this.btnMešaj1.TabIndex = 2;
            this.btnMešaj1.Text = "Mešaj Kup #1";
            this.btnMešaj1.UseVisualStyleBackColor = true;
            this.btnMešaj1.Click += new System.EventHandler(this.btnMešaj1_Click);
            // 
            // btnPonastavi2
            // 
            this.btnPonastavi2.Location = new System.Drawing.Point(303, 348);
            this.btnPonastavi2.Name = "btnPonastavi2";
            this.btnPonastavi2.Size = new System.Drawing.Size(152, 33);
            this.btnPonastavi2.TabIndex = 3;
            this.btnPonastavi2.Text = "Ponastavi Kup #2";
            this.btnPonastavi2.UseVisualStyleBackColor = true;
            this.btnPonastavi2.Click += new System.EventHandler(this.btnPonastavi2_Click);
            // 
            // btnMešaj2
            // 
            this.btnMešaj2.Location = new System.Drawing.Point(303, 387);
            this.btnMešaj2.Name = "btnMešaj2";
            this.btnMešaj2.Size = new System.Drawing.Size(152, 31);
            this.btnMešaj2.TabIndex = 4;
            this.btnMešaj2.Text = "Mešaj Kup #2";
            this.btnMešaj2.UseVisualStyleBackColor = true;
            this.btnMešaj2.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(25, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 238);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(303, 100);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(152, 238);
            this.listBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kup #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kup #2 (52 kart)";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(229, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 26);
            this.button6.TabIndex = 9;
            this.button6.Text = "<<";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 467);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnMešaj2);
            this.Controls.Add(this.btnPonastavi2);
            this.Controls.Add(this.btnMešaj1);
            this.Controls.Add(this.btnPonastavi1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPonastavi1;
        private System.Windows.Forms.Button btnMešaj1;
        private System.Windows.Forms.Button btnPonastavi2;
        private System.Windows.Forms.Button btnMešaj2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
    }
}

