using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_
{
    public partial class AdminForm : Form
    {
        // Объявляем поле userId для хранения идентификатора пользователя
        private int userId;

        // Конструктор для инициализации формы и сохранения userId
        public AdminForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadThemes(); // Загружаем темы при инициализации формы
        }

        // Метод для загрузки тем в DataGridView
        private void LoadThemes()
        {
            string queryString = "SELECT Id, Name, IsVisible FROM Themes"; // Используем правильные имена столбцов

            try
            {
                using (SqlConnection connection = Database.GetConnection()) // Используем GetConnection()
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Проверка на null и выводим данные в DataGridView
                    if (dataGridViewThemes != null)
                    {
                        dataGridViewThemes.DataSource = table;
                        MessageBox.Show("Данные загружены в DataGridView!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось найти DataGridView.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для сохранения изменений по всем темам
        private void btnSaveAllChanges_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = Database.GetConnection()) // Используем GetConnection()
                {
                    connection.Open();

                    foreach (DataGridViewRow row in dataGridViewThemes.Rows)
                    {
                        if (row.Cells["IsVisible"] != null) // Проверка на существование ячейки
                        {
                            bool isVisible = Convert.ToBoolean(row.Cells["IsVisible"].Value); // Получаем значение флажка
                            int themeId = Convert.ToInt32(row.Cells["Id"].Value); // Получаем ID темы

                            // Обновляем видимость в базе данных
                            string queryString = "UPDATE Themes SET IsVisible = @IsVisible WHERE Id = @ThemeId";
                            SqlCommand command = new SqlCommand(queryString, connection);
                            command.Parameters.AddWithValue("@IsVisible", isVisible ? 1 : 0); // Преобразуем в 1 или 0
                            command.Parameters.AddWithValue("@ThemeId", themeId);

                            command.ExecuteNonQuery(); // Выполняем обновление для каждой строки
                        }
                    }

                    MessageBox.Show("Все изменения сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // После сохранения обновляем DataGridView
                LoadThemes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Класс для работы с базой данных
    public static class Database
    {
        // Строка подключения
        private static string connectionString = "Server=DESKTOP-LILFHVR\\MSSQLSERVERMAIN;Database=DbProject;Trusted_Connection=True;";

        // Метод для получения подключения к базе данных
        public static SqlConnection GetConnection() // Метод теперь называется GetConnection, а не getConnection
        {
            return new SqlConnection(connectionString); // Возвращаем подключение к базе данных
        }
    }
}
