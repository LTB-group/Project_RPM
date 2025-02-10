using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_
{
    public partial class sign_in : Form
    {
        DataBase dataBase = new DataBase();

        public sign_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var login = textBox_login2.Text;
            var password = textBox_password2.Text;

            // Check if user already exists
            if (checkuser())
                return;

            string querystring = $"INSERT INTO register(login_user, password_user) VALUES('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");

                // Fetch the id of the newly created user
                string idQuery = $"SELECT id_user FROM register WHERE login_user = '{login}' AND password_user = '{password}'";
                SqlCommand idCommand = new SqlCommand(idQuery, dataBase.getConnection());
                SqlDataReader reader = idCommand.ExecuteReader();

                if (reader.Read())
                {
                    int userId = reader.GetInt32(0); // Get the user ID
                    // Pass userId to the log_in form
                    log_in frm_login = new log_in(userId);
                    frm_login.ShowDialog();
                }

                dataBase.closeConnection();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
        }

        private bool checkuser()
        {
            var loginUser = textBox_login2.Text;
            var passUser = textBox_password2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"SELECT id_user FROM register WHERE login_user = '{loginUser}' AND password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
                return false;
        }

        private void sign_in_Load(object sender, EventArgs e)
        {
            textBox_password2.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            log_in frm_login = new log_in(0); // Default userId set to 0 if no user is logged in
            frm_login.Show();
            this.Hide();
        }
    }
}
