namespace arch_exp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button buttonExpeditions;
        private Button buttonObjects;
        private Button buttonFindings;
        private Button buttonSpecialists;
        private Button buttonExpenses;
        private Panel headerPanel;

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
            headerPanel = new Panel();
            buttonExpeditions = new Button();
            buttonExpenses = new Button();
            buttonObjects = new Button();
            buttonSpecialists = new Button();
            buttonFindings = new Button();
            labelTitle = new Label();
            label1 = new Label();
            buttonBack = new Button();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.Black;
            headerPanel.Controls.Add(buttonExpeditions);
            headerPanel.Controls.Add(buttonExpenses);
            headerPanel.Controls.Add(buttonObjects);
            headerPanel.Controls.Add(buttonSpecialists);
            headerPanel.Controls.Add(buttonFindings);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1014, 100);
            headerPanel.TabIndex = 6;
            // 
            // buttonExpeditions
            // 
            buttonExpeditions.BackColor = Color.Transparent;
            buttonExpeditions.FlatAppearance.BorderSize = 0;
            buttonExpeditions.FlatStyle = FlatStyle.Flat;
            buttonExpeditions.Font = new Font("Courier New", 12F);
            buttonExpeditions.ForeColor = Color.White;
            buttonExpeditions.Location = new Point(74, 22);
            buttonExpeditions.Name = "buttonExpeditions";
            buttonExpeditions.Size = new Size(140, 50);
            buttonExpeditions.TabIndex = 1;
            buttonExpeditions.Text = "Экспедиции";
            buttonExpeditions.UseVisualStyleBackColor = false;
            buttonExpeditions.Click += buttonExpeditions_Click;
            // 
            // buttonExpenses
            // 
            buttonExpenses.BackColor = Color.Transparent;
            buttonExpenses.FlatAppearance.BorderSize = 0;
            buttonExpenses.FlatStyle = FlatStyle.Flat;
            buttonExpenses.Font = new Font("Courier New", 12F);
            buttonExpenses.ForeColor = Color.White;
            buttonExpenses.Location = new Point(834, 22);
            buttonExpenses.Name = "buttonExpenses";
            buttonExpenses.Size = new Size(108, 50);
            buttonExpenses.TabIndex = 5;
            buttonExpenses.Text = "Расходы";
            buttonExpenses.UseVisualStyleBackColor = false;
            buttonExpenses.Click += buttonExpenses_Click;
            // 
            // buttonObjects
            // 
            buttonObjects.BackColor = Color.Transparent;
            buttonObjects.FlatAppearance.BorderSize = 0;
            buttonObjects.FlatStyle = FlatStyle.Flat;
            buttonObjects.Font = new Font("Courier New", 12F);
            buttonObjects.ForeColor = Color.White;
            buttonObjects.Location = new Point(269, 22);
            buttonObjects.Name = "buttonObjects";
            buttonObjects.Size = new Size(112, 50);
            buttonObjects.TabIndex = 2;
            buttonObjects.Text = "Объекты";
            buttonObjects.UseVisualStyleBackColor = false;
            buttonObjects.Click += buttonObjects_Click;
            // 
            // buttonSpecialists
            // 
            buttonSpecialists.BackColor = Color.Transparent;
            buttonSpecialists.FlatAppearance.BorderSize = 0;
            buttonSpecialists.FlatStyle = FlatStyle.Flat;
            buttonSpecialists.Font = new Font("Courier New", 12F);
            buttonSpecialists.ForeColor = Color.White;
            buttonSpecialists.Location = new Point(618, 22);
            buttonSpecialists.Name = "buttonSpecialists";
            buttonSpecialists.Size = new Size(157, 50);
            buttonSpecialists.TabIndex = 4;
            buttonSpecialists.Text = "Специалисты";
            buttonSpecialists.UseVisualStyleBackColor = false;
            buttonSpecialists.Click += buttonSpecialists_Click;
            // 
            // buttonFindings
            // 
            buttonFindings.BackColor = Color.Transparent;
            buttonFindings.FlatAppearance.BorderSize = 0;
            buttonFindings.FlatStyle = FlatStyle.Flat;
            buttonFindings.Font = new Font("Courier New", 12F);
            buttonFindings.ForeColor = Color.White;
            buttonFindings.Location = new Point(455, 22);
            buttonFindings.Name = "buttonFindings";
            buttonFindings.Size = new Size(111, 50);
            buttonFindings.TabIndex = 3;
            buttonFindings.Text = "Находки";
            buttonFindings.UseVisualStyleBackColor = false;
            buttonFindings.Click += buttonFindings_Click;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Courier New", 14F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(269, 320);
            labelTitle.Name = "labelTitle";
            labelTitle.RightToLeft = RightToLeft.No;
            labelTitle.Size = new Size(457, 115);
            labelTitle.TabIndex = 7;
            labelTitle.Text = "Добро пожаловать в инструмент для работы с базой данных Археологических Экспедиций!\r\n";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Courier New", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(345, 240);
            label1.Name = "label1";
            label1.Size = new Size(300, 40);
            label1.TabIndex = 8;
            label1.Text = "ArchExpeditionDB";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 471);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 31);
            buttonBack.TabIndex = 9;
            buttonBack.Text = "Назад";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 514);
            Controls.Add(buttonBack);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная страница";
            Load += MainForm_Load;
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
        private Label labelTitle;
        private Label label1;
        private Button buttonBack;
    }
}
