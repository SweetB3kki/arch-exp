using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace arch_exp
{
    public partial class ExpeditionsForm : Form
    {
        private readonly string connectionString = DatabaseSettings.ConnectionString;

        public ExpeditionsForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void ExpeditionsForm_Load(object sender, EventArgs e)
        {
            // Логика, если необходима дополнительная инициализация
        }

        // Загрузка данных из базы в DataGridView
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Expeditions";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
            }
        }

        // Добавление новой экспедиции
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Получение данных из текстовых полей
            string name = expeditionNameTextBox.Text;
            string startDate = startDateTextBox.Text;
            string endDate = endDateTextBox.Text;
            string location = locationTextBox.Text;
            string goal = goalTextBox.Text;
            string leader = leaderTextBox.Text;
            string stakeholder = stakeholderTextBox.Text;
            string budget = budgetTextBox.Text;

            // Проверка, что обязательные поля не пустые
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(startDate) || string.IsNullOrEmpty(endDate) ||
                string.IsNullOrEmpty(location) || string.IsNullOrEmpty(goal) || string.IsNullOrEmpty(leader) ||
                string.IsNullOrEmpty(stakeholder) || string.IsNullOrEmpty(budget))
            {
                MessageBox.Show("Заполните все обязательные поля.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Expeditions (expedition_name, start_date, end_date, geographical_location, research_goal, leader, stakeholder, budget) " +
                                   "VALUES (@name, @startDate, @endDate, @location, @goal, @leader, @stakeholder, @budget)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@goal", goal);
                    cmd.Parameters.AddWithValue("@leader", leader);
                    cmd.Parameters.AddWithValue("@stakeholder", stakeholder);
                    cmd.Parameters.AddWithValue("@budget", budget);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Экспедиция успешно добавлена.");
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

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void headerPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ExpeditionsForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
