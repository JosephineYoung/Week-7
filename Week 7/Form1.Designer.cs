namespace Week_7
{
    partial class QUIZPANDA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxInputKalimat = new System.Windows.Forms.TextBox();
            this.txtBoxIHuruf1 = new System.Windows.Forms.TextBox();
            this.txtBoxHuruf2 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Kalimat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Huruf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menjadi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil :";
            // 
            // txtBoxInputKalimat
            // 
            this.txtBoxInputKalimat.Location = new System.Drawing.Point(147, 32);
            this.txtBoxInputKalimat.Name = "txtBoxInputKalimat";
            this.txtBoxInputKalimat.Size = new System.Drawing.Size(336, 27);
            this.txtBoxInputKalimat.TabIndex = 4;
            // 
            // txtBoxIHuruf1
            // 
            this.txtBoxIHuruf1.Location = new System.Drawing.Point(147, 91);
            this.txtBoxIHuruf1.Name = "txtBoxIHuruf1";
            this.txtBoxIHuruf1.Size = new System.Drawing.Size(124, 27);
            this.txtBoxIHuruf1.TabIndex = 5;
            // 
            // txtBoxHuruf2
            // 
            this.txtBoxHuruf2.Location = new System.Drawing.Point(359, 91);
            this.txtBoxHuruf2.Name = "txtBoxHuruf2";
            this.txtBoxHuruf2.Size = new System.Drawing.Size(124, 27);
            this.txtBoxHuruf2.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(147, 154);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(336, 29);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Konversi!";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(147, 201);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(18, 20);
            this.lblOutput.TabIndex = 8;
            this.lblOutput.Text = "...";
            // 
            // QUIZPANDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 241);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtBoxHuruf2);
            this.Controls.Add(this.txtBoxIHuruf1);
            this.Controls.Add(this.txtBoxInputKalimat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QUIZPANDA";
            this.Text = "QUIZ PANDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxInputKalimat;
        private System.Windows.Forms.TextBox txtBoxIHuruf1;
        private System.Windows.Forms.TextBox txtBoxHuruf2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblOutput;
    }
}
