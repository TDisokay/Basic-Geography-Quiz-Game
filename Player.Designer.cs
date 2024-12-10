// Player.Designer.cs
using System.Windows.Forms;

namespace Game_WFDemo_1202
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.questionPanel = new System.Windows.Forms.Panel();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.multipleChoicePanel = new System.Windows.Forms.Panel();
            this.mcOptionsListBox = new System.Windows.Forms.ListBox();
            this.openEndedPanel = new System.Windows.Forms.Panel();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.trueFalsePanel = new System.Windows.Forms.Panel();
            this.trueRadioButton = new System.Windows.Forms.RadioButton();
            this.falseRadioButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.reviewAnswersButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.reviewPanel = new System.Windows.Forms.Panel();
            this.reviewGridView = new System.Windows.Forms.DataGridView();
            this.backToResultsButton = new System.Windows.Forms.Button();
            this.reviewListBox = new System.Windows.Forms.ListBox();
            this.questionPanel.SuspendLayout();
            this.multipleChoicePanel.SuspendLayout();
            this.openEndedPanel.SuspendLayout();
            this.trueFalsePanel.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.reviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionPanel
            // 
            this.questionPanel.Controls.Add(this.questionTextLabel);
            this.questionPanel.Controls.Add(this.multipleChoicePanel);
            this.questionPanel.Controls.Add(this.openEndedPanel);
            this.questionPanel.Controls.Add(this.trueFalsePanel);
            this.questionPanel.Controls.Add(this.submitButton);
            this.questionPanel.Location = new System.Drawing.Point(20, 20);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(760, 520);
            this.questionPanel.TabIndex = 0;
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextLabel.Location = new System.Drawing.Point(10, 10);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(740, 157);
            this.questionTextLabel.TabIndex = 0;
            // 
            // multipleChoicePanel
            // 
            this.multipleChoicePanel.Controls.Add(this.mcOptionsListBox);
            this.multipleChoicePanel.Location = new System.Drawing.Point(10, 170);
            this.multipleChoicePanel.Name = "multipleChoicePanel";
            this.multipleChoicePanel.Size = new System.Drawing.Size(740, 200);
            this.multipleChoicePanel.TabIndex = 1;
            // 
            // mcOptionsListBox
            // 
            this.mcOptionsListBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcOptionsListBox.ItemHeight = 28;
            this.mcOptionsListBox.Location = new System.Drawing.Point(10, 10);
            this.mcOptionsListBox.Name = "mcOptionsListBox";
            this.mcOptionsListBox.Size = new System.Drawing.Size(720, 172);
            this.mcOptionsListBox.TabIndex = 0;
            // 
            // openEndedPanel
            // 
            this.openEndedPanel.Controls.Add(this.answerTextBox);
            this.openEndedPanel.Location = new System.Drawing.Point(10, 170);
            this.openEndedPanel.Name = "openEndedPanel";
            this.openEndedPanel.Size = new System.Drawing.Size(740, 100);
            this.openEndedPanel.TabIndex = 2;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.Location = new System.Drawing.Point(10, 10);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(720, 80);
            this.answerTextBox.TabIndex = 0;
            // 
            // trueFalsePanel
            // 
            this.trueFalsePanel.Controls.Add(this.trueRadioButton);
            this.trueFalsePanel.Controls.Add(this.falseRadioButton);
            this.trueFalsePanel.Location = new System.Drawing.Point(10, 170);
            this.trueFalsePanel.Name = "trueFalsePanel";
            this.trueFalsePanel.Size = new System.Drawing.Size(740, 50);
            this.trueFalsePanel.TabIndex = 3;
            // 
            // trueRadioButton
            // 
            this.trueRadioButton.BackColor = System.Drawing.Color.Turquoise;
            this.trueRadioButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trueRadioButton.Location = new System.Drawing.Point(10, 10);
            this.trueRadioButton.Name = "trueRadioButton";
            this.trueRadioButton.Size = new System.Drawing.Size(100, 30);
            this.trueRadioButton.TabIndex = 0;
            this.trueRadioButton.Text = "True";
            this.trueRadioButton.UseVisualStyleBackColor = false;
            // 
            // falseRadioButton
            // 
            this.falseRadioButton.BackColor = System.Drawing.Color.Turquoise;
            this.falseRadioButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.falseRadioButton.Location = new System.Drawing.Point(120, 10);
            this.falseRadioButton.Name = "falseRadioButton";
            this.falseRadioButton.Size = new System.Drawing.Size(100, 30);
            this.falseRadioButton.TabIndex = 1;
            this.falseRadioButton.Text = "False";
            this.falseRadioButton.UseVisualStyleBackColor = false;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Turquoise;
            this.submitButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(10, 440);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(740, 40);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit Answer";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resultPanel
            // 
            this.resultPanel.Controls.Add(this.resultLabel);
            this.resultPanel.Controls.Add(this.reviewAnswersButton);
            this.resultPanel.Controls.Add(this.restartButton);
            this.resultPanel.Controls.Add(this.exitButton);
            this.resultPanel.Location = new System.Drawing.Point(20, 20);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(760, 520);
            this.resultPanel.TabIndex = 1;
            this.resultPanel.Visible = false;
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(10, 10);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(740, 200);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reviewAnswersButton
            // 
            this.reviewAnswersButton.BackColor = System.Drawing.Color.Turquoise;
            this.reviewAnswersButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewAnswersButton.Location = new System.Drawing.Point(10, 220);
            this.reviewAnswersButton.Name = "reviewAnswersButton";
            this.reviewAnswersButton.Size = new System.Drawing.Size(740, 40);
            this.reviewAnswersButton.TabIndex = 1;
            this.reviewAnswersButton.Text = "Review Answers";
            this.reviewAnswersButton.UseVisualStyleBackColor = false;
            this.reviewAnswersButton.Click += new System.EventHandler(this.reviewAnswersButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Turquoise;
            this.restartButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(10, 270);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(740, 40);
            this.restartButton.TabIndex = 2;
            this.restartButton.Text = "Play Again";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Turquoise;
            this.exitButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(10, 320);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(740, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // reviewPanel
            // 
            this.reviewPanel.Controls.Add(this.reviewGridView);
            this.reviewPanel.Controls.Add(this.backToResultsButton);
            this.reviewPanel.Location = new System.Drawing.Point(20, 20);
            this.reviewPanel.Name = "reviewPanel";
            this.reviewPanel.Size = new System.Drawing.Size(760, 520);
            this.reviewPanel.TabIndex = 2;
            this.reviewPanel.Visible = false;
            //
            //  reviewGridView
            //
            this.reviewGridView.AllowUserToAddRows = false;
            this.reviewGridView.AllowUserToDeleteRows = false;
            this.reviewGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.reviewGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.reviewGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reviewGridView.Location = new System.Drawing.Point(10, 10);
            this.reviewGridView.Name = "reviewGridView";
            this.reviewGridView.ReadOnly = true;
            this.reviewGridView.Size = new System.Drawing.Size(740, 440);
            this.reviewGridView.TabIndex = 0;
            this.reviewGridView.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.reviewGridView.MultiSelect = false;
            this.reviewGridView.RowHeadersVisible = false;
            //
            //  backToResultsButton
            //
            this.backToResultsButton.BackColor = System.Drawing.Color.Turquoise;
            this.backToResultsButton.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.backToResultsButton.Location = new System.Drawing.Point(10, 460);
            this.backToResultsButton.Name = "backToResultsButton";
            this.backToResultsButton.Size = new System.Drawing.Size(740, 40);
            this.backToResultsButton.TabIndex = 1;
            this.backToResultsButton.Text = "Back to Results";
            this.backToResultsButton.UseVisualStyleBackColor = false;
            this.backToResultsButton.Click += new System.EventHandler(this.backToResultsButton_Click);
            // 
            // reviewListBox
            // 
            this.reviewListBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewListBox.ItemHeight = 28;
            this.reviewListBox.Location = new System.Drawing.Point(10, 10);
            this.reviewListBox.Name = "reviewListBox";
            this.reviewListBox.Size = new System.Drawing.Size(740, 480);
            this.reviewListBox.TabIndex = 0;
            // 
            // Player
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 561);
            this.Controls.Add(this.questionPanel);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.reviewPanel);
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geography Quiz";
            this.questionPanel.ResumeLayout(false);
            this.multipleChoicePanel.ResumeLayout(false);
            this.openEndedPanel.ResumeLayout(false);
            this.openEndedPanel.PerformLayout();
            this.trueFalsePanel.ResumeLayout(false);
            this.resultPanel.ResumeLayout(false);
            this.reviewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Panel reviewPanel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Panel multipleChoicePanel;
        private System.Windows.Forms.Panel openEndedPanel;
        private System.Windows.Forms.Panel trueFalsePanel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ListBox mcOptionsListBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.RadioButton trueRadioButton;
        private System.Windows.Forms.RadioButton falseRadioButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button reviewAnswersButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView reviewGridView;
        private System.Windows.Forms.Button backToResultsButton;
        private System.Windows.Forms.ListBox reviewListBox;
    }
}