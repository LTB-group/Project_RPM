namespace Project_
{
    partial class sign_in
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.textBox_password2 = new System.Windows.Forms.TextBox();
            this.textBox_login2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(159, 202);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Войти";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(126, 119);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(109, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Создать аккаунт";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // textBox_password2
            // 
            this.textBox_password2.Location = new System.Drawing.Point(105, 81);
            this.textBox_password2.Multiline = true;
            this.textBox_password2.Name = "textBox_password2";
            this.textBox_password2.Size = new System.Drawing.Size(147, 22);
            this.textBox_password2.TabIndex = 3;
            // 
            // textBox_login2
            // 
            this.textBox_login2.Location = new System.Drawing.Point(105, 53);
            this.textBox_login2.Multiline = true;
            this.textBox_login2.Name = "textBox_login2";
            this.textBox_login2.Size = new System.Drawing.Size(147, 22);
            this.textBox_login2.TabIndex = 4;
            // 
            // sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 224);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.textBox_password2);
            this.Controls.Add(this.textBox_login2);
            this.Name = "sign_in";
            this.Text = "sign_in";
            this.Load += new System.EventHandler(this.sign_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox textBox_password2;
        private System.Windows.Forms.TextBox textBox_login2;
    }
}