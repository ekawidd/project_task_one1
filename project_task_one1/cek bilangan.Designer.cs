namespace project_task_one
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
            this.input = new System.Windows.Forms.TextBox();
            this.Hasillabel = new System.Windows.Forms.Label();
            this.texthasil = new System.Windows.Forms.TextBox();
            this.proses = new System.Windows.Forms.Button();
            this.keluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cek Bilangan Ganjil Genap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukan Bilangan";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(125, 88);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(72, 20);
            this.input.TabIndex = 2;
            // 
            // Hasillabel
            // 
            this.Hasillabel.AutoSize = true;
            this.Hasillabel.Location = new System.Drawing.Point(24, 127);
            this.Hasillabel.Name = "Hasillabel";
            this.Hasillabel.Size = new System.Drawing.Size(30, 13);
            this.Hasillabel.TabIndex = 3;
            this.Hasillabel.Text = "Hasil";
            // 
            // texthasil
            // 
            this.texthasil.Location = new System.Drawing.Point(125, 124);
            this.texthasil.Name = "texthasil";
            this.texthasil.Size = new System.Drawing.Size(290, 20);
            this.texthasil.TabIndex = 4;
            // 
            // proses
            // 
            this.proses.Location = new System.Drawing.Point(216, 88);
            this.proses.Name = "proses";
            this.proses.Size = new System.Drawing.Size(75, 23);
            this.proses.TabIndex = 5;
            this.proses.Text = "Proses";
            this.proses.UseVisualStyleBackColor = true;
            this.proses.Click += new System.EventHandler(this.proses_Click);
            // 
            // keluar
            // 
            this.keluar.Location = new System.Drawing.Point(340, 171);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(75, 23);
            this.keluar.TabIndex = 6;
            this.keluar.Text = "Keluar";
            this.keluar.UseVisualStyleBackColor = true;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 223);
            this.Controls.Add(this.keluar);
            this.Controls.Add(this.proses);
            this.Controls.Add(this.texthasil);
            this.Controls.Add(this.Hasillabel);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cek Bilangan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label Hasillabel;
        private System.Windows.Forms.TextBox texthasil;
        private System.Windows.Forms.Button proses;
        private System.Windows.Forms.Button keluar;
    }
}

