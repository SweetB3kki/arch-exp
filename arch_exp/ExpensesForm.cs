using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace arch_exp
{
    public partial class ExpensesForm : Form
    {
        private readonly string connectionString = DatabaseSettings.ConnectionString;

        public ExpensesForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void ExpensesForm_Load(object sender, EventArgs e)
        {
            // Логика, если необходима дополнительная инициализация
        }

        // Загрузка данных из базы в DataGridView
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Expenses";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
            }
        }

        // Добавление нового расхода
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Получение данных из текстовых полей
            string expeditionId = expeditionIdTextBox.Text;
            string amount = amountTextBox.Text;
            string description = descriptionTextBox.Text;
            string expenseDate = expenseDateTextBox.Text;

            // Проверка, что обязательные поля не пустые
            if (string.IsNullOrEmpty(expeditionId) || string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(expenseDate))
            {
                MessageBox.Show("Заполните все обязательные поля.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Expenses (expedition_id, amount, description, expense_date) " +
                                   "VALUES (@expeditionId, @amount, @description, @expenseDate)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@expeditionId", expeditionId);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@expenseDate", expenseDate);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Расход успешно добавлен.");
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
    }
}
