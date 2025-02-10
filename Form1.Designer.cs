namespace Project_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox themesListBox;
        private System.Windows.Forms.Button startButton;

        // Ваши другие элементы управления здесь

        /// <summary>
        /// Очистить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">True, если управляемые ресурсы должны быть освобождены; иначе — false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором формы

        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private void InitializeComponent()
        {
            this.themesListBox = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // themesListBox
            // 
            this.themesListBox.FormattingEnabled = true;
            this.themesListBox.ItemHeight = 16;
            this.themesListBox.Location = new System.Drawing.Point(12, 12);
            this.themesListBox.Name = "themesListBox";
            this.themesListBox.Size = new System.Drawing.Size(200, 148);
            this.themesListBox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 170);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 30);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Task";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartThemeButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.themesListBox);
            this.Name = "Form1";
            this.Text = "Theme Selection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
