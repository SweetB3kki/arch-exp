namespace arch_exp
{
    partial class SpecialistsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView;
        private Button buttonAdd;
        private Button buttonBack;
        private TextBox fullNameTextBox;
        private TextBox specialtyIdTextBox;
        private TextBox participationIdTextBox;
        private Panel headerPanel;
        private Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            buttonAdd = new Button();
            buttonBack = new Button();
            fullNameTextBox = new TextBox();
            specialtyIdTextBox = new TextBox();
            participationIdTextBox = new TextBox();
            headerPanel = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeight = 29;
            dataGridView.Location = new Point(50, 150);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(899, 300);
            dataGridView.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(50, 500);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(177, 31);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить Специалиста";
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(233, 500);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 31);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Назад";
            buttonBack.Click += buttonBack_Click;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(50, 60);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(100, 27);
            fullNameTextBox.TabIndex = 4;
            // 
            // specialtyIdTextBox
            // 
            specialtyIdTextBox.Location = new Point(200, 60);
            specialtyIdTextBox.Name = "specialtyIdTextBox";
            specialtyIdTextBox.Size = new Size(100, 27);
            specialtyIdTextBox.TabIndex = 5;
            // 
            // participationIdTextBox
            // 
            participationIdTextBox.Location = new Point(350, 60);
            participationIdTextBox.Name = "participationIdTextBox";
            participationIdTextBox.Size = new Size(100, 27);
            participationIdTextBox.TabIndex = 6;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Black;
            headerPanel.Controls.Add(label1);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(996, 100);
            headerPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Courier New", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(348, 30);
            label1.Name = "label1";
            label1.Size = new Size(300, 40);
            label1.TabIndex = 9;
            label1.Text = "Specialists";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SpecialistsForm
            // 
            ClientSize = new Size(996, 553);
            Controls.Add(headerPanel);
            Controls.Add(dataGridView);
            Controls.Add(buttonAdd);
            Controls.Add(buttonBack);
            Controls.Add(fullNameTextBox);
            Controls.Add(specialtyIdTextBox);
            Controls.Add(participationIdTextBox);
            Name = "SpecialistsForm";
            Text = "Специалисты";
            Load += SpecialistsForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
