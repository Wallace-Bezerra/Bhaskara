namespace Bhaskara
{
    partial class Resultado
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
            this.label_X1 = new System.Windows.Forms.Label();
            this.label_X2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_X1
            // 
            this.label_X1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_X1.Location = new System.Drawing.Point(66, 9);
            this.label_X1.Name = "label_X1";
            this.label_X1.Size = new System.Drawing.Size(382, 110);
            this.label_X1.TabIndex = 0;
            // 
            // label_X2
            // 
            this.label_X2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_X2.Location = new System.Drawing.Point(53, 132);
            this.label_X2.Name = "label_X2";
            this.label_X2.Size = new System.Drawing.Size(395, 92);
            this.label_X2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_X2);
            this.Controls.Add(this.label_X1);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_X1;
        private System.Windows.Forms.Label label_X2;
        private System.Windows.Forms.Button button1;
    }
}