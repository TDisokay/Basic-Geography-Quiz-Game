using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Game_WFDemo_1202
{
    public partial class Creator : Form
    {
        private bool isEditing = false;
        private int editingIndex = -1;

        public Creator()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            questionTypeComboBox.Items.AddRange(Enum.GetNames(typeof(QuestionType)));
            regionComboBox.Items.AddRange(Enum.GetNames(typeof(GeographyRegion)));

            questionTypeComboBox.SelectedIndex = 0;
            regionComboBox.SelectedIndex = 0;
            pointsNumericUpDown.Value = 1;

            multipleChoicePanel.Visible = true;
            openEndedPanel.Visible = false;
            trueFalsePanel.Visible = false;

            UpdateQuestionList();
        }

        private void questionTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuestionType selectedType = (QuestionType)Enum.Parse(typeof(QuestionType),
                questionTypeComboBox.SelectedItem.ToString());

            multipleChoicePanel.Visible = selectedType == QuestionType.MultipleChoice;
            openEndedPanel.Visible = selectedType == QuestionType.OpenEnded;
            trueFalsePanel.Visible = selectedType == QuestionType.TrueFalse;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Question newQuestion = CreateQuestion();
                if (newQuestion != null)
                {
                    if (isEditing)
                    {
                        GameData.QuestionBank[editingIndex] = newQuestion;
                        MessageBox.Show("Question updated successfully!");
                    }
                    else
                    {
                        GameData.QuestionBank.Add(newQuestion);
                        MessageBox.Show("Question added successfully!");
                    }

                    ClearForm();
                    UpdateQuestionList();
                }
            }
        }

        private Question CreateQuestion()
        {
            string questionText = questionTextBox.Text.Trim();
            int points = (int)pointsNumericUpDown.Value;
            GeographyRegion region = (GeographyRegion)Enum.Parse(typeof(GeographyRegion),
                regionComboBox.SelectedItem.ToString());

            QuestionType type = (QuestionType)Enum.Parse(typeof(QuestionType),
                questionTypeComboBox.SelectedItem.ToString());

            switch (type)
            {
                case QuestionType.MultipleChoice:
                    string[] options = new string[]
                    {
                        option1TextBox.Text.Trim(),
                        option2TextBox.Text.Trim(),
                        option3TextBox.Text.Trim(),
                        option4TextBox.Text.Trim()
                    };
                    int correctIndex = (int)(correctOptionNumericUpDown.Value - 1);
                    return new MultipleChoiceQuestion(questionText, options, correctIndex, points, region);

                case QuestionType.OpenEnded:
                    List<string> acceptableAnswers = acceptableAnswersTextBox.Text
                        .Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(a => a.Trim())
                        .ToList();
                    return new OpenEndedQuestion(questionText, acceptableAnswers, points, region);

                case QuestionType.TrueFalse:
                    bool correctAnswer = trueFalseComboBox.SelectedItem.ToString() == "True";
                    return new TrueFalseQuestion(questionText, correctAnswer, points, region);

                default:
                    return null;
            }
        }

        private bool ValidateInput()
        {   
            if (string.IsNullOrWhiteSpace(questionTextBox.Text))
            {
                MessageBox.Show("Please enter a question.");
                return false;
            }

            QuestionType type = (QuestionType)Enum.Parse(typeof(QuestionType),
                questionTypeComboBox.SelectedItem.ToString());

            switch (type)
            {
                case QuestionType.MultipleChoice:
                    if (string.IsNullOrWhiteSpace(option1TextBox.Text) ||
                        string.IsNullOrWhiteSpace(option2TextBox.Text) ||
                        string.IsNullOrWhiteSpace(option3TextBox.Text) ||
                        string.IsNullOrWhiteSpace(option4TextBox.Text))
                    {
                        MessageBox.Show("Please fill in all options.");
                        return false;
                    }
                    break;

                case QuestionType.OpenEnded:
                    if (string.IsNullOrWhiteSpace(acceptableAnswersTextBox.Text))
                    {
                        MessageBox.Show("Please enter at least one acceptable answer.");
                        return false;
                    }
                    break;

                case QuestionType.TrueFalse:
                    if (trueFalseComboBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select True or False.");
                        return false;
                    }
                    break;
            }

            return true;
        }

        private void ClearForm()
        {
            questionTextBox.Clear();
            option1TextBox.Clear();
            option2TextBox.Clear();
            option3TextBox.Clear();
            option4TextBox.Clear();
            acceptableAnswersTextBox.Clear();
            trueFalseComboBox.SelectedIndex = -1;
            pointsNumericUpDown.Value = 1;
            isEditing = false;
            editingIndex = -1;
        }

        private void UpdateQuestionList()
        {
            questionsListBox.Items.Clear();
            foreach (var question in GameData.QuestionBank)
            {
                questionsListBox.Items.Add($"{question.Type} - {question.QuestionText}");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (questionsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a question to edit.");
                return;
            }

            isEditing = true;
            editingIndex = questionsListBox.SelectedIndex;
            LoadQuestionForEditing(GameData.QuestionBank[editingIndex]);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (questionsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a question to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this question?", "Confirm Delete",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GameData.QuestionBank.RemoveAt(questionsListBox.SelectedIndex);
                UpdateQuestionList();
                ClearForm();
            }
        }

        private void LoadQuestionForEditing(Question question)
        {
            questionTextBox.Text = question.QuestionText;
            pointsNumericUpDown.Value = question.Points;
            regionComboBox.SelectedItem = question.Region.ToString();
            questionTypeComboBox.SelectedItem = question.Type.ToString();

            switch (question)
            {
                case MultipleChoiceQuestion mcq:
                    for (int i = 0; i < mcq.Options.Length; i++)
                    {
                        switch (i)
                        {
                            case 0: option1TextBox.Text = mcq.Options[i]; break;
                            case 1: option2TextBox.Text = mcq.Options[i]; break;
                            case 2: option3TextBox.Text = mcq.Options[i]; break;
                            case 3: option4TextBox.Text = mcq.Options[i]; break;
                        }
                    }
                    correctOptionNumericUpDown.Value = mcq.CorrectOptionIndex + 1;
                    break;

                case OpenEndedQuestion oeq:
                    acceptableAnswersTextBox.Text = string.Join(", ", oeq.AcceptableAnswers);
                    break;

                case TrueFalseQuestion tfq:
                    trueFalseComboBox.SelectedItem = tfq.CorrectAnswer.ToString();
                    break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}