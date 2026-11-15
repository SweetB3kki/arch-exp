namespace arch_exp
{
    partial class FindingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView;
        private Button buttonAdd;
        private Button buttonBack;
        private TextBox descriptionTextBox;
        private TextBox findingDateTextBox;
        private TextBox statusTextBox;
        private TextBox objectIdTextBox;
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
            descriptionTextBox = new TextBox();
            findingDateTextBox = new TextBox();
            statusTextBox = new TextBox();
            objectIdTextBox = new TextBox();
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
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(50, 500);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(177, 31);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить Находку";
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
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(50, 60);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 27);
            descriptionTextBox.TabIndex = 4;
            // 
            // findingDateTextBox
            // 
            findingDateTextBox.Location = new Point(200, 60);
            findingDateTextBox.Name = "findingDateTextBox";
            findingDateTextBox.Size = new Size(100, 27);
            findingDateTextBox.TabIndex = 5;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(350, 60);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(100, 27);
            statusTextBox.TabIndex = 6;
            // 
            // objectIdTextBox
            // 
            objectIdTextBox.Location = new Point(500, 60);
            objectIdTextBox.Name = "objectIdTextBox";
            objectIdTextBox.Size = new Size(100, 27);
            objectIdTextBox.TabIndex = 7;
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
            label1.Text = "Findings";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FindingsForm
            // 
            ClientSize = new Size(996, 553);
            Controls.Add(headerPanel);
            Controls.Add(dataGridView);
            Controls.Add(buttonAdd);
            Controls.Add(buttonBack);
            Controls.Add(descriptionTextBox);
            Controls.Add(findingDateTextBox);
            Controls.Add(statusTextBox);
            Controls.Add(objectIdTextBox);
            Name = "FindingsForm";
            Text = "Находки";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}