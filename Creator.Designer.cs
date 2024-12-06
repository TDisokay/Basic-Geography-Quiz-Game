// Creator.Designer.cs
namespace Game_WFDemo_1202
{
    partial class Creator
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creator));
            this.questionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.pointsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.multipleChoicePanel = new System.Windows.Forms.Panel();
            this.option1TextBox = new System.Windows.Forms.TextBox();
            this.option2TextBox = new System.Windows.Forms.TextBox();
            this.option3TextBox = new System.Windows.Forms.TextBox();
            this.option4TextBox = new System.Windows.Forms.TextBox();
            this.correctOptionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.openEndedPanel = new System.Windows.Forms.Panel();
            this.acceptableAnswersTextBox = new System.Windows.Forms.TextBox();
            this.trueFalsePanel = new System.Windows.Forms.Panel();
            this.trueFalseComboBox = new System.Windows.Forms.ComboBox();
            this.questionsListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNumericUpDown)).BeginInit();
            this.multipleChoicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.correctOptionNumericUpDown)).BeginInit();
            this.openEndedPanel.SuspendLayout();
            this.trueFalsePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionTypeComboBox
            // 
            this.questionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionTypeComboBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTypeComboBox.Location = new System.Drawing.Point(20, 45);
            this.questionTypeComboBox.Name = "questionTypeComboBox";
            this.questionTypeComboBox.Size = new System.Drawing.Size(200, 36);
            this.questionTypeComboBox.TabIndex = 0;
            this.questionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.questionTypeComboBox_SelectedIndexChanged);
            // 
            // regionComboBox
            // 
            this.regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionComboBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionComboBox.Location = new System.Drawing.Point(240, 45);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(200, 36);
            this.regionComboBox.TabIndex = 1;
            // 
            // pointsNumericUpDown
            // 
            this.pointsNumericUpDown.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsNumericUpDown.Location = new System.Drawing.Point(460, 45);
            this.pointsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pointsNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointsNumericUpDown.Name = "pointsNumericUpDown";
            this.pointsNumericUpDown.Size = new System.Drawing.Size(80, 34);
            this.pointsNumericUpDown.TabIndex = 2;
            this.pointsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // questionTextBox
            // 
            this.questionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.questionTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextBox.Location = new System.Drawing.Point(20, 85);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(520, 50);
            this.questionTextBox.TabIndex = 3;
            // 
            // multipleChoicePanel
            // 
            this.multipleChoicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multipleChoicePanel.Controls.Add(this.option1TextBox);
            this.multipleChoicePanel.Controls.Add(this.option2TextBox);
            this.multipleChoicePanel.Controls.Add(this.option3TextBox);
            this.multipleChoicePanel.Controls.Add(this.option4TextBox);
            this.multipleChoicePanel.Controls.Add(this.correctOptionNumericUpDown);
            this.multipleChoicePanel.Location = new System.Drawing.Point(20, 145);
            this.multipleChoicePanel.Name = "multipleChoicePanel";
            this.multipleChoicePanel.Size = new System.Drawing.Size(520, 200);
            this.multipleChoicePanel.TabIndex = 4;
            // 
            // option1TextBox
            // 
            this.option1TextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1TextBox.Location = new System.Drawing.Point(10, 10);
            this.option1TextBox.Name = "option1TextBox";
            this.option1TextBox.Size = new System.Drawing.Size(480, 34);
            this.option1TextBox.TabIndex = 0;
            // 
            // option2TextBox
            // 
            this.option2TextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2TextBox.Location = new System.Drawing.Point(10, 45);
            this.option2TextBox.Name = "option2TextBox";
            this.option2TextBox.Size = new System.Drawing.Size(480, 34);
            this.option2TextBox.TabIndex = 1;
            // 
            // option3TextBox
            // 
            this.option3TextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3TextBox.Location = new System.Drawing.Point(10, 80);
            this.option3TextBox.Name = "option3TextBox";
            this.option3TextBox.Size = new System.Drawing.Size(480, 34);
            this.option3TextBox.TabIndex = 2;
            // 
            // option4TextBox
            // 
            this.option4TextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option4TextBox.Location = new System.Drawing.Point(10, 115);
            this.option4TextBox.Name = "option4TextBox";
            this.option4TextBox.Size = new System.Drawing.Size(480, 34);
            this.option4TextBox.TabIndex = 3;
            // 
            // correctOptionNumericUpDown
            // 
            this.correctOptionNumericUpDown.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctOptionNumericUpDown.Location = new System.Drawing.Point(10, 159);
            this.correctOptionNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.correctOptionNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.correctOptionNumericUpDown.Name = "correctOptionNumericUpDown";
            this.correctOptionNumericUpDown.Size = new System.Drawing.Size(80, 34);
            this.correctOptionNumericUpDown.TabIndex = 4;
            this.correctOptionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // openEndedPanel
            // 
            this.openEndedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openEndedPanel.Controls.Add(this.acceptableAnswersTextBox);
            this.openEndedPanel.Location = new System.Drawing.Point(20, 145);
            this.openEndedPanel.Name = "openEndedPanel";
            this.openEndedPanel.Size = new System.Drawing.Size(520, 100);
            this.openEndedPanel.TabIndex = 5;
            // 
            // acceptableAnswersTextBox
            // 
            this.acceptableAnswersTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptableAnswersTextBox.Location = new System.Drawing.Point(10, 10);
            this.acceptableAnswersTextBox.Multiline = true;
            this.acceptableAnswersTextBox.Name = "acceptableAnswersTextBox";
            this.acceptableAnswersTextBox.Size = new System.Drawing.Size(480, 60);
            this.acceptableAnswersTextBox.TabIndex = 0;
            // 
            // trueFalsePanel
            // 
            this.trueFalsePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trueFalsePanel.Controls.Add(this.trueFalseComboBox);
            this.trueFalsePanel.Location = new System.Drawing.Point(20, 145);
            this.trueFalsePanel.Name = "trueFalsePanel";
            this.trueFalsePanel.Size = new System.Drawing.Size(520, 50);
            this.trueFalsePanel.TabIndex = 6;
            // 
            // trueFalseComboBox
            // 
            this.trueFalseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trueFalseComboBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trueFalseComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.trueFalseComboBox.Location = new System.Drawing.Point(10, 10);
            this.trueFalseComboBox.Name = "trueFalseComboBox";
            this.trueFalseComboBox.Size = new System.Drawing.Size(120, 36);
            this.trueFalseComboBox.TabIndex = 0;
            // 
            // questionsListBox
            // 
            this.questionsListBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionsListBox.ItemHeight = 28;
            this.questionsListBox.Location = new System.Drawing.Point(20, 365);
            this.questionsListBox.Name = "questionsListBox";
            this.questionsListBox.Size = new System.Drawing.Size(520, 172);
            this.questionsListBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Turquoise;
            this.addButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(560, 365);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 40);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Turquoise;
            this.editButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(560, 415);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 40);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Turquoise;
            this.deleteButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(560, 465);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 40);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Question Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Geography Region";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Points";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Turquoise;
            this.exitButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(560, 85);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 40);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Creator
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(670, 561);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionTypeComboBox);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.pointsNumericUpDown);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.multipleChoicePanel);
            this.Controls.Add(this.openEndedPanel);
            this.Controls.Add(this.trueFalsePanel);
            this.Controls.Add(this.questionsListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Name = "Creator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question Creator";
            ((System.ComponentModel.ISupportInitialize)(this.pointsNumericUpDown)).EndInit();
            this.multipleChoicePanel.ResumeLayout(false);
            this.multipleChoicePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.correctOptionNumericUpDown)).EndInit();
            this.openEndedPanel.ResumeLayout(false);
            this.openEndedPanel.PerformLayout();
            this.trueFalsePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox questionTypeComboBox;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.NumericUpDown pointsNumericUpDown;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Panel multipleChoicePanel;
        private System.Windows.Forms.Panel openEndedPanel;
        private System.Windows.Forms.Panel trueFalsePanel;
        private System.Windows.Forms.ListBox questionsListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox option1TextBox;
        private System.Windows.Forms.TextBox option2TextBox;
        private System.Windows.Forms.TextBox option3TextBox;
        private System.Windows.Forms.TextBox option4TextBox;
        private System.Windows.Forms.NumericUpDown correctOptionNumericUpDown;
        private System.Windows.Forms.TextBox acceptableAnswersTextBox;
        private System.Windows.Forms.ComboBox trueFalseComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitButton;
    }
}