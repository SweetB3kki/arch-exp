using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace arch_exp
{
    public partial class FindingsForm : Form
    {
        private readonly string connectionString = DatabaseSettings.ConnectionString;

        public FindingsForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void FindingsForm_Load(object sender, EventArgs e)
        {
            // Логика, если необходима дополнительная инициализация
        }

        // Загрузка данных из базы в DataGridView
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Findings";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
            }
        }

        // Добавление новой находки
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Получение данных из текстовых полей
            string description = descriptionTextBox.Text;
            string findingDate = findingDateTextBox.Text;
            string status = statusTextBox.Text;
            string objectId = objectIdTextBox.Text;

            // Проверка, что обязательные поля не пустые
            if (string.IsNullOrEmpty(description) || string.IsNullOrEmpty(findingDate) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(objectId))
            {
                MessageBox.Show("Заполните все обязательные поля.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Findings (description, finding_date, status, object_id) " +
                                   "VALUES (@description, @findingDate, @status, @objectId)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@findingDate", findingDate);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@objectId", objectId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Находка успешно добавлена.");
                    LoadData();  // Перезагрузить данные
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления данных: " + ex.Message);
            }
        }

        // Обработчик для кнопки "Назад", которая вернет пользователя на главную страницу
        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm("admin"); // Пример для роли администратора
            mainForm.Show();
            this.Hide();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}