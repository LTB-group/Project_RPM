using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_
{
    public partial class log_in : Form
    {
        DataBase database = new DataBase();
        private int userId;

        // Constructor with userId parameter
        public log_in(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            string queryString = "SELECT id_user, login_user, password_user, is_admin FROM register WHERE login_user = @loginUser AND password_user = @passUser";

            using (SqlConnection connection = database.getConnection())
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@loginUser", loginUser);
                command.Parameters.AddWithValue("@passUser", passUser);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(table);

                    if (table.Rows.Count == 1)
                    {
                        // Получаем userId и is_admin из результата запроса
                        int userId = Convert.ToInt32(table.Rows[0]["id_user"]);
                        bool isAdmin = Convert.ToBoolean(table.Rows[0]["is_admin"]); // Получаем is_admin

                        // Если пользователь администратор, открываем админ панель
                        if (isAdmin)
                        {
                            MessageBox.Show($"Вы успешно вошли как администратор! ID пользователя: {userId}", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Передаем userId в Form1
                            AdminForm adminForm = new AdminForm(userId); // Передаем userId в админ форму
                            this.Hide();
                            adminForm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show($"Вы успешно вошли как пользователь! ID пользователя: {userId}", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Открытие обычной формы пользователя
                            Form1 frm1 = new Form1(userId);
                            this.Hide();
                            frm1.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Такого аккаунта не существует!", "Аккаунт не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Выводим ошибку, если возникла проблема с запросом или соединением
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }







        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_in frm_sign = new sign_in();
            frm_sign.Show();
            this.Hide();
        }
    }
}
