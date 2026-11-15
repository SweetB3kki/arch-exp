using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace arch_exp
{
    public partial class SpecialistsForm : Form
    {
        private readonly string connectionString = DatabaseSettings.ConnectionString;

        public SpecialistsForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void SpecialistsForm_Load(object sender, EventArgs e)
        {
            // Логика, если необходима дополнительная инициализация
        }

        // Загрузка данных из базы в DataGridView
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Specialists";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
            }
        }

        // Добавление нового специалиста
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Получение данных из текстовых полей
            string fullName = fullNameTextBox.Text;
            string specialtyId = specialtyIdTextBox.Text;
            string participationId = participationIdTextBox.Text;

            // Проверка, что обязательные поля не пустые
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(specialtyId) || string.IsNullOrEmpty(participationId))
            {
                MessageBox.Show("Заполните все обязательные поля.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Specialists (full_name, specialty_id, participation_id) " +
                                   "VALUES (@fullName, @specialtyId, @participationId)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    cmd.Parameters.AddWithValue("@specialtyId", specialtyId);
                    cmd.Parameters.AddWithValue("@participationId", participationId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Специалист успешно добавлен.");
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

        private void SpecialistsForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
