using System;
using System.Windows.Forms;

namespace arch_exp
{
    public partial class MainForm : Form
    {
        private string userRole;

        public MainForm(string role)
        {
            InitializeComponent();
            userRole = role;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Отображаем или скрываем кнопки в зависимости от роли
            if (userRole == "admin")
            {
                // Администратор может видеть все
                buttonExpeditions.Enabled = true;
                buttonObjects.Enabled = true;
                buttonFindings.Enabled = true;
                buttonSpecialists.Enabled = true;
                buttonExpenses.Enabled = true;
            }
            else if (userRole == "leader")
            {
                // Лидер видит все кроме админских прав
                buttonExpeditions.Enabled = true;
                buttonObjects.Enabled = true;
                buttonFindings.Enabled = true;
                buttonSpecialists.Enabled = false;  // Лидер не может управлять специалистами
                buttonExpenses.Enabled = true;
            }
            else if (userRole == "specialist")
            {
                // Специалист может только просматривать определенные данные
                buttonExpeditions.Enabled = false;  // Специалист не может управлять экспедициями
                buttonObjects.Enabled = true;
                buttonFindings.Enabled = true;
                buttonSpecialists.Enabled = false;  // Специалист не может управлять специалистами
                buttonExpenses.Enabled = false;  // Специалист не может управлять расходами
            }
        }

        // Обработчик для кнопки "Назад", которая вернет пользователя на главную страницу
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Возвращаемся на форму входа
            form1.Show();
            this.Hide(); // Скрываем текущую форму
        }
        // Обработчики событий для кнопок
        private void buttonExpeditions_Click(object sender, EventArgs e)
        {
            if (!buttonExpeditions.Enabled)
            {
                MessageBox.Show("У вас недостаточно прав для выполнения этого действия.");
                return;
            }

            ExpeditionsForm expeditionsForm = new ExpeditionsForm();
            expeditionsForm.Show();
            this.Hide();
        }

        private void buttonObjects_Click(object sender, EventArgs e)
        {
            if (!buttonObjects.Enabled)
            {
                MessageBox.Show("У вас недостаточно прав для выполнения этого действия.");
                return;
            }

            ObjectsForm objectsForm = new ObjectsForm();
            objectsForm.Show();
            this.Hide();
        }

        private void buttonFindings_Click(object sender, EventArgs e)
        {
            if (!buttonFindings.Enabled)
            {
                MessageBox.Show("У вас недостаточно прав для выполнения этого действия.");
                return;
            }

            FindingsForm findingsForm = new FindingsForm();
            findingsForm.Show();
            this.Hide();
        }

        private void buttonSpecialists_Click(object sender, EventArgs e)
        {
            if (!buttonSpecialists.Enabled)
            {
                MessageBox.Show("У вас недостаточно прав для выполнения этого действия.");
                return;
            }

            SpecialistsForm specialistsForm = new SpecialistsForm();
            specialistsForm.Show();
            this.Hide();
        }

        private void buttonExpenses_Click(object sender, EventArgs e)
        {
            if (!buttonExpenses.Enabled)
            {
                MessageBox.Show("У вас недостаточно прав для выполнения этого действия.");
                return;
            }

            ExpensesForm expensesForm = new ExpensesForm();
            expensesForm.Show();
            this.Hide();

        }
        // Логика выхода из программы при закрытии формы
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Если форма закрывается (крестик или закрытие окна), то закрываем программу
            Application.Exit();
        }

    }
}
