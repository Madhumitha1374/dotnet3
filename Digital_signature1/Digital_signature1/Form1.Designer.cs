namespace Digital_signature1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_bwse = new System.Windows.Forms.Button();
            this.btn_gtsgntr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 26);
            this.textBox1.TabIndex = 0;
            // 
            // btn_bwse
            // 
            this.btn_bwse.Location = new System.Drawing.Point(228, 184);
            this.btn_bwse.Name = "btn_bwse";
            this.btn_bwse.Size = new System.Drawing.Size(165, 34);
            this.btn_bwse.TabIndex = 1;
            this.btn_bwse.Text = "Browse";
            this.btn_bwse.UseVisualStyleBackColor = true;
            this.btn_bwse.Click += new System.EventHandler(this.btn_bwse_Click);
            // 
            // btn_gtsgntr
            // 
            this.btn_gtsgntr.Location = new System.Drawing.Point(421, 184);
            this.btn_gtsgntr.Name = "btn_gtsgntr";
            this.btn_gtsgntr.Size = new System.Drawing.Size(187, 34);
            this.btn_gtsgntr.TabIndex = 2;
            this.btn_gtsgntr.Text = "GET SIGNATURE";
            this.btn_gtsgntr.UseVisualStyleBackColor = true;
            this.btn_gtsgntr.Click += new System.EventHandler(this.btn_gtsgntr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 642);
            this.Controls.Add(this.btn_gtsgntr);
            this.Controls.Add(this.btn_bwse);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_bwse;
        private System.Windows.Forms.Button btn_gtsgntr;
    }
}

