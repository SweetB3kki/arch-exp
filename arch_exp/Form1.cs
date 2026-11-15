using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace arch_exp
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = DatabaseSettings.ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Логика загрузки, если нужна дополнительная инициализация
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Запрос для получения пользователя по имени и паролю
                    string query = "SELECT * FROM Users WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();  // Переход к первой строке результатов
                        string role = reader["role"].ToString();

                        // Передаем роль пользователя в MainForm
                        MainForm mainForm = new MainForm(role);
                        mainForm.Show();
                        this.Hide();  // Скрыть текущую форму (Form1) после входа
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
        }
    }
}
