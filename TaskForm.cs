using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_
{
    public partial class TaskForm : Form
    {
        private int userId;
        private int themeId;
        private string connectionString;
        private List<TaskItem> tasks;
        private int currentTaskIndex;

        public TaskForm(int userId, int themeId, string connectionString)
        {
            InitializeComponent();
            this.userId = userId;
            this.themeId = themeId;
            this.connectionString = connectionString;
            tasks = new List<TaskItem>();
            currentTaskIndex = 0;

            LoadTasks();
        }

        private void LoadTasks()
        {
            string queryString = "SELECT TaskId, Question, Option1, Option2, Option3, CorrectAnswer FROM Tasks WHERE ThemeId = @ThemeId";

            try
            {
                using (SqlConnection connection = Database.GetConnection())
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@ThemeId", themeId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Заполняем список задач
                    foreach (DataRow row in table.Rows)
                    {
                        TaskItem task = new TaskItem
                        {
                            TaskId = (int)row["TaskId"],
                            Question = row["Question"].ToString(),
                            Option1 = row["Option1"].ToString(),
                            Option2 = row["Option2"].ToString(),
                            Option3 = row["Option3"].ToString(),
                            CorrectAnswer = row["CorrectAnswer"].ToString()
                        };
                        tasks.Add(task);
                    }

                    // Загружаем первый вопрос, если есть задачи
                    if (tasks.Count > 0)
                    {
                        LoadTask(tasks[currentTaskIndex]);
                    }
                    else
                    {
                        MessageBox.Show("Нет доступных заданий для этой темы.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTask(TaskItem task)
        {
            questionLabel.Text = task.Question;
            option1Button.Text = task.Option1;
            option2Button.Text = task.Option2;
            option3Button.Text = task.Option3;

            // Удаляем предыдущие события
            option1Button.Click -= OptionButton_Click;
            option2Button.Click -= OptionButton_Click;
            option3Button.Click -= OptionButton_Click;

            // Добавляем обработчики событий
            option1Button.Click += OptionButton_Click;
            option2Button.Click += OptionButton_Click;
            option3Button.Click += OptionButton_Click;
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string selectedAnswer = clickedButton.Text;

            if (selectedAnswer == tasks[currentTaskIndex].CorrectAnswer)
            {
                MessageBox.Show("Правильно!");
            }
            else
            {
                MessageBox.Show("Неправильно.");
            }

            currentTaskIndex++;
            if (currentTaskIndex < tasks.Count)
            {
                LoadTask(tasks[currentTaskIndex]);
            }
            else
            {
                MessageBox.Show("Все задания завершены!");
                Close();
            }
        }
    }

    public class TaskItem
    {
        public int TaskId { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string CorrectAnswer { get; set; }
    }
}