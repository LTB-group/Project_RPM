namespace Project_
{
    partial class TaskForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;

        private void InitializeComponent()
        {
            this.questionLabel = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();



            // questionLabel
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(12, 9);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(124, 16);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Вопрос будет здесь";

            // option1Button
            this.option1Button.Location = new System.Drawing.Point(15, 50);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(200, 30);
            this.option1Button.TabIndex = 1;
            this.option1Button.Text = "Вариант 1";
            this.option1Button.UseVisualStyleBackColor = true;

            // option2Button
            this.option2Button.Location = new System.Drawing.Point(15, 90);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(200, 30);
            this.option2Button.TabIndex = 2;
            this.option2Button.Text = "Вариант 2";
            this.option2Button.UseVisualStyleBackColor = true;

            // option3Button
            this.option3Button.Location = new System.Drawing.Point(15, 130);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(200, 30);
            this.option3Button.TabIndex = 3;
            this.option3Button.Text = "Вариант 3";
            this.option3Button.UseVisualStyleBackColor = true;

            // TaskForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option3Button);
            this.Name = "TaskForm";
            this.Text = "Задания";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskForm_FormClosing);
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaskForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}