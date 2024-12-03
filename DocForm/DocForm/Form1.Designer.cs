namespace DocForm
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(346, 82);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(266, 53);
            this.txtId.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(346, 176);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(266, 53);
            this.txtName.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(75, 82);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(45, 37);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(75, 187);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 37);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoc.Location = new System.Drawing.Point(66, 319);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(195, 37);
            this.lblDoc.TabIndex = 5;
            this.lblDoc.Text = "Upload Doc";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(346, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 80);
            this.button1.TabIndex = 6;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDoc
            // 
            this.txtDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoc.Location = new System.Drawing.Point(793, 40);
            this.txtDoc.Multiline = true;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDoc.Size = new System.Drawing.Size(508, 774);
            this.txtDoc.TabIndex = 7;
            this.txtDoc.TextChanged += new System.EventHandler(this.txtDoc_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(82, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 74);
            this.button2.TabIndex = 8;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(412, 488);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(212, 74);
            this.btnGet.TabIndex = 9;
            this.btnGet.Text = "Get Doc";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 914);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGet;
    }
}

