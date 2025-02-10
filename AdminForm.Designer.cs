namespace Project_
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewThemes;
        private System.Windows.Forms.Button btnSaveAllChanges;

        // Очистка ресурсов
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewThemes = new System.Windows.Forms.DataGridView();
            this.btnSaveAllChanges = new System.Windows.Forms.Button();

            // dataGridViewThemes
            this.dataGridViewThemes.AllowUserToAddRows = false;
            this.dataGridViewThemes.AllowUserToDeleteRows = false;
            this.dataGridViewThemes.AllowUserToResizeColumns = false;
            this.dataGridViewThemes.AllowUserToResizeRows = false;
            this.dataGridViewThemes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThemes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            });
            this.dataGridViewThemes.Location = new System.Drawing.Point(30, 30);
            this.dataGridViewThemes.Name = "dataGridViewThemes";
            this.dataGridViewThemes.ReadOnly = false;
            this.dataGridViewThemes.RowHeadersVisible = false;
            this.dataGridViewThemes.Size = new System.Drawing.Size(500, 300);
            this.dataGridViewThemes.TabIndex = 0;

            // btnSaveAllChanges
            this.btnSaveAllChanges.Location = new System.Drawing.Point(350, 400);
            this.btnSaveAllChanges.Name = "btnSaveAllChanges";
            this.btnSaveAllChanges.Size = new System.Drawing.Size(150, 40);
            this.btnSaveAllChanges.TabIndex = 1;
            this.btnSaveAllChanges.Text = "Сохранить все изменения";
            this.btnSaveAllChanges.UseVisualStyleBackColor = true;
            this.btnSaveAllChanges.Click += new System.EventHandler(this.btnSaveAllChanges_Click);

            // AdminForm
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.dataGridViewThemes);
            this.Controls.Add(this.btnSaveAllChanges);
            this.Name = "AdminForm";
            this.Text = "Admin Panel";
            //this.Load += new System.EventHandler(this.AdminPanelForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThemes)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
