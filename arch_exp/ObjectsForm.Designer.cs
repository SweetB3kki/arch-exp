namespace arch_exp
{
    partial class ObjectsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView;
        private Button buttonAdd;
        private Button buttonBack;
        private TextBox objectNameTextBox;
        private TextBox locationTextBox;
        private TextBox historicalSignificanceTextBox;
        private TextBox expeditionIdTextBox;
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
            objectNameTextBox = new TextBox();
            locationTextBox = new TextBox();
            historicalSignificanceTextBox = new TextBox();
            expeditionIdTextBox = new TextBox();
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
            buttonAdd.Text = "Добавить Объект";
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
            // objectNameTextBox
            // 
            objectNameTextBox.Location = new Point(50, 60);
            objectNameTextBox.Name = "objectNameTextBox";
            objectNameTextBox.Size = new Size(100, 27);
            objectNameTextBox.TabIndex = 4;
            // 
            // locationTextBox
            // 
            locationTextBox.Location = new Point(200, 60);
            locationTextBox.Name = "locationTextBox";
            locationTextBox.Size = new Size(100, 27);
            locationTextBox.TabIndex = 5;
            // 
            // historicalSignificanceTextBox
            // 
            historicalSignificanceTextBox.Location = new Point(350, 60);
            historicalSignificanceTextBox.Name = "historicalSignificanceTextBox";
            historicalSignificanceTextBox.Size = new Size(100, 27);
            historicalSignificanceTextBox.TabIndex = 6;
            // 
            // expeditionIdTextBox
            // 
            expeditionIdTextBox.Location = new Point(500, 60);
            expeditionIdTextBox.Name = "expeditionIdTextBox";
            expeditionIdTextBox.Size = new Size(100, 27);
            expeditionIdTextBox.TabIndex = 7;
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
            label1.Text = "Objects";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ObjectsForm
            // 
            ClientSize = new Size(996, 553);
            Controls.Add(headerPanel);
            Controls.Add(dataGridView);
            Controls.Add(buttonAdd);
            Controls.Add(buttonBack);
            Controls.Add(objectNameTextBox);
            Controls.Add(locationTextBox);
            Controls.Add(historicalSignificanceTextBox);
            Controls.Add(expeditionIdTextBox);
            Name = "ObjectsForm";
            Text = "Объекты";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}