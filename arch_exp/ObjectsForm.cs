using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace arch_exp
{
    public partial class ObjectsForm : Form
    {
        private readonly string connectionString = DatabaseSettings.ConnectionString;

        public ObjectsForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void ObjectsForm_Load(object sender, EventArgs e)
        {
            // Логика, если необходима дополнительная инициализация
        }

        // Загрузка данных из базы в DataGridView
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Archaeological_Site_Objects";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
            }
        }

        // Добавление нового объекта
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Получение данных из текстовых полей
            string name = objectNameTextBox.Text;
            string location = locationTextBox.Text;
            string historicalSignificance = historicalSignificanceTextBox.Text;
            string expeditionId = expeditionIdTextBox.Text;

            // Проверка, что обязательные поля не пустые
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(expeditionId))
            {
                MessageBox.Show("Заполните все обязательные поля.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Archaeological_Site_Objects (object_name, location, historical_significance, expedition_id) " +
                                   "VALUES (@name, @location, @historicalSignificance, @expeditionId)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@historicalSignificance", historicalSignificance);
                    cmd.Parameters.AddWithValue("@expeditionId", expeditionId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Объект успешно добавлен.");
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
