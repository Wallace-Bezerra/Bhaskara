using System;

namespace Bhaskara
{
    partial class Form1
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
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_c = new System.Windows.Forms.Label();
            this.label_Bhaskara = new System.Windows.Forms.Label();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(152, 171);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(100, 23);
            this.textBox_A.TabIndex = 0;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(152, 256);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(100, 23);
            this.textBox_C.TabIndex = 0;
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(152, 215);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(100, 23);
            this.textBox_B.TabIndex = 0;
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_a.Location = new System.Drawing.Point(118, 166);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(28, 25);
            this.label_a.TabIndex = 1;
            this.label_a.Text = "A:";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_b.Location = new System.Drawing.Point(118, 210);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(27, 25);
            this.label_b.TabIndex = 1;
            this.label_b.Text = "B:";
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_c.Location = new System.Drawing.Point(117, 251);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(28, 25);
            this.label_c.TabIndex = 1;
            this.label_c.Text = "C:";
            // 
            // label_Bhaskara
            // 
            this.label_Bhaskara.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Bhaskara.Location = new System.Drawing.Point(45, 54);
            this.label_Bhaskara.Name = "label_Bhaskara";
            this.label_Bhaskara.Size = new System.Drawing.Size(317, 71);
            this.label_Bhaskara.TabIndex = 2;
            this.label_Bhaskara.Text = "ax² + bx + c = 0";
            this.label_Bhaskara.Click += new System.EventHandler(this.label_Bhaskara_Click);
            // 
            // button_Calcular
            // 
            this.button_Calcular.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Calcular.Location = new System.Drawing.Point(126, 300);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(158, 41);
            this.button_Calcular.TabIndex = 3;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 374);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.label_Bhaskara);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label_Bhaskara_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.Label label_Bhaskara;
        private System.Windows.Forms.Button button_Calcular;
    }
}
