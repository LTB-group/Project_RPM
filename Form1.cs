using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_; // Добавляем ссылку на пространство имён

namespace Project_
{



    public partial class Form1 : Form
    {
        private int userId;
        private string connectionString = "Server=DESKTOP-LILFHVR\\MSSQLSERVERMAIN;Database=DbProject;Trusted_Connection=True;";

        public Form1(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void LoadThemes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Themes", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                themesListBox.DataSource = table;
                themesListBox.DisplayMember = "Name";  // Отображаем название темы
                themesListBox.ValueMember = "Id";     // Используем Id темы
            }
        }


        private void StartThemeButton_Click(object sender, EventArgs e)
        {
            // Получаем id выбранной темы как int
            int selectedThemeId = 0;
            if (themesListBox.SelectedValue != null)
            {
                // Преобразуем в int, если возможно
                if (!int.TryParse(themesListBox.SelectedValue.ToString(), out selectedThemeId))
                {
                    MessageBox.Show("Invalid theme selection.");
                    return;
                }
            }

            // Передаем значения в конструктор
            string option3 = "";  // Здесь можно передать значение для option3, если нужно
            TaskForm taskForm = new TaskForm(userId, selectedThemeId, connectionString);
            taskForm.ShowDialog();  // Открытие формы с заданиями
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            LoadThemes();
        }
    }
}
