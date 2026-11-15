namespace arch_exp
{
    partial class ExpeditionsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView;
        private Button buttonAdd;
        private Button buttonBack;
        private TextBox expeditionNameTextBox;
        private TextBox startDateTextBox;
        private TextBox endDateTextBox;
        private TextBox locationTextBox;
        private TextBox goalTextBox;
        private TextBox leaderTextBox;
        private TextBox stakeholderTextBox;
        private TextBox budgetTextBox;
        private Label labelTitle;

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
            expeditionNameTextBox = new TextBox();
            startDateTextBox = new TextBox();
            endDateTextBox = new TextBox();
            locationTextBox = new TextBox();
            goalTextBox = new TextBox();
            leaderTextBox = new TextBox();
            stakeholderTextBox = new TextBox();
            budgetTextBox = new TextBox();
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
            buttonAdd.Text = "Добавить Экспедицию";
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
            // expeditionNameTextBox
            // 
            expeditionNameTextBox.Location = new Point(50, 60);
            expeditionNameTextBox.Name = "expeditionNameTextBox";
            expeditionNameTextBox.Size = new Size(100, 27);
            expeditionNameTextBox.TabIndex = 4;
            // 
            // startDateTextBox
            // 
            startDateTextBox.Location = new Point(200, 60);
            startDateTextBox.Name = "startDateTextBox";
            startDateTextBox.Size = new Size(100, 27);
            startDateTextBox.TabIndex = 5;
            // 
            // endDateTextBox
            // 
            endDateTextBox.Location = new Point(350, 60);
            endDateTextBox.Name = "endDateTextBox";
            endDateTextBox.Size = new Size(100, 27);
            endDateTextBox.TabIndex = 6;
            // 
            // locationTextBox
            // 
            locationTextBox.Location = new Point(500, 60);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(100, 27);
            locationTextBox.TabIndex = 7;
            // 
            // goalTextBox
            // 
            goalTextBox.Location = new Point(650, 60);
            goalTextBox.Name = "goalTextBox";
            goalTextBox.Size = new Size(100, 27);
            goalTextBox.TabIndex = 8;
            // 
            // leaderTextBox
            // 
            leaderTextBox.Location = new Point(800, 60);
            leaderTextBox.Name = "leaderTextBox";
            leaderTextBox.Size = new Size(100, 27);
            leaderTextBox.TabIndex = 9;
            // 
            // stakeholderTextBox
            // 
            stakeholderTextBox.Location = new Point(950, 60);
            stakeholderTextBox.Name = "stakeholderTextBox";
            stakeholderTextBox.Size = new Size(100, 27);
            stakeholderTextBox.TabIndex = 10;
            // 
            // budgetTextBox
            // 
            budgetTextBox.Location = new Point(1100, 60);
            budgetTextBox.Name = "budgetTextBox";
            budgetTextBox.Size = new Size(100, 27);
            budgetTextBox.TabIndex = 11;
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
            headerPanel.Paint += headerPanel_Paint_1;
            // 
            // label1
            // 
            label1.Font = new Font("Courier New", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(348, 30);
            label1.Name = "label1";
            label1.Size = new Size(300, 40);
            label1.TabIndex = 9;
            label1.Text = "Exhibition";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExpeditionsForm
            // 
            ClientSize = new Size(996, 553);
            Controls.Add(headerPanel);
            Controls.Add(dataGridView);
            Controls.Add(buttonAdd);
            Controls.Add(buttonBack);
            Controls.Add(expeditionNameTextBox);
            Controls.Add(startDateTextBox);
            Controls.Add(endDateTextBox);
            Controls.Add(locationTextBox);
            Controls.Add(goalTextBox);
            Controls.Add(leaderTextBox);
            Controls.Add(stakeholderTextBox);
            Controls.Add(budgetTextBox);
            Name = "ExpeditionsForm";
            Text = "Экспедиции";
            Load += ExpeditionsForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        private Panel headerPanel;
        private Label label1;
    }
}
