using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace Game_WFDemo_1202
{
    public partial class Player : Form
    {
        private List<Question> currentQuestions;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private readonly Stopwatch gameTimer = new Stopwatch();
        private List<(Question Question, string UserAnswer, bool Correct)> gameResults;

        public Player()
        {
            InitializeComponent();
            SetupGame();
        }

        private void SetupGame()
        {
            currentQuestions = new List<Question>(GameData.QuestionBank);
            ShuffleQuestions();

            gameResults = new List<(Question, string, bool)>();
            currentQuestionIndex = 0;
            score = 0;

            resultPanel.Visible = false;
            reviewPanel.Visible = false;
            questionPanel.Visible = true;

            gameTimer.Restart();
            DisplayCurrentQuestion();
        }

        private void ShuffleQuestions()
        {
            Random rng = new Random();
            int n = currentQuestions.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                (currentQuestions[n], currentQuestions[k]) = (currentQuestions[k], currentQuestions[n]);
            }
        }

        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex >= currentQuestions.Count)
            {
                ShowResults();
                return;
            }

            Question currentQuestion = currentQuestions[currentQuestionIndex];
            questionTextLabel.Text = $"Question {currentQuestionIndex + 1} of {currentQuestions.Count}\n" +
                                   $"Region: {currentQuestion.Region}\n" +
                                   $"Points: {currentQuestion.Points}\n\n" +
                                   currentQuestion.QuestionText;

            multipleChoicePanel.Visible = false;
            openEndedPanel.Visible = false;
            trueFalsePanel.Visible = false;

            switch (currentQuestion.Type)
            {
                case QuestionType.MultipleChoice:
                    SetupMultipleChoiceQuestion((MultipleChoiceQuestion)currentQuestion);
                    break;

                case QuestionType.OpenEnded:
                    SetupOpenEndedQuestion();
                    break;

                case QuestionType.TrueFalse:
                    SetupTrueFalseQuestion();
                    break;
            }
        }

        private void SetupMultipleChoiceQuestion(MultipleChoiceQuestion question)
        {
            multipleChoicePanel.Visible = true;

            mcOptionsListBox.Items.Clear();
            foreach (string option in question.Options)
            {
                mcOptionsListBox.Items.Add(option);
            }
        }

        private void SetupOpenEndedQuestion()
        {
            openEndedPanel.Visible = true;
            answerTextBox.Clear();
        }

        private void SetupTrueFalseQuestion()
        {
            trueFalsePanel.Visible = true;
            trueRadioButton.Checked = false;
            falseRadioButton.Checked = false;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!ValidateAnswer(out string userAnswer))
            {
                MessageBox.Show("Please provide an answer.");
                return;
            }

            Question currentQuestion = currentQuestions[currentQuestionIndex];
            bool isCorrect = currentQuestion.CheckAnswer(userAnswer);

            if (isCorrect)
            {
                score += currentQuestion.Points;
            }

            gameResults.Add((currentQuestion, userAnswer, isCorrect));
            currentQuestionIndex++;
            DisplayCurrentQuestion();
        }

        private bool ValidateAnswer(out string userAnswer)
        {
            userAnswer = string.Empty;
            Question currentQuestion = currentQuestions[currentQuestionIndex];

            switch (currentQuestion.Type)
            {
                case QuestionType.MultipleChoice:
                    if (mcOptionsListBox.SelectedIndex == -1) return false;
                    userAnswer = (mcOptionsListBox.SelectedIndex + 1).ToString();
                    break;

                case QuestionType.OpenEnded:
                    if (string.IsNullOrWhiteSpace(answerTextBox.Text)) return false;
                    userAnswer = answerTextBox.Text.Trim();
                    break;

                case QuestionType.TrueFalse:
                    if (!trueRadioButton.Checked && !falseRadioButton.Checked) return false;
                    userAnswer = trueRadioButton.Checked ? "True" : "False";
                    break;
            }

            return true;
        }

        private void ShowResults()
        {
            gameTimer.Stop();
            questionPanel.Visible = false;
            resultPanel.Visible = true;

            double timeInMinutes = gameTimer.Elapsed.TotalMinutes;
            int totalPossibleScore = currentQuestions.Sum(q => q.Points);

            resultLabel.Text = $"Quiz Complete!\n\n" +
                             $"Score: {score} out of {totalPossibleScore}\n" +
                             $"Percentage: {(score * 100.0 / totalPossibleScore):F1}%\n" +
                             $"Time taken: {timeInMinutes:F1} minutes";
        }

        private void reviewAnswersButton_Click(object sender, EventArgs e)
        {
            resultPanel.Visible = false;
            reviewPanel.Visible = true;
            DisplayReview();
        }

        private void DisplayReview()
        {
            reviewListBox.Items.Clear();
            foreach (var result in gameResults)
            {
                string reviewText = String.Format(
                    "Question: {0}\n" +
                    "Your answer: {1}\n" +
                    "Correct answer: {2}\n" +
                    "Result: {3}\n" +
                    "Points: {4}\n" +
                    "{5}",
                    result.Question.QuestionText,
                    result.UserAnswer,
                    result.Question.GetCorrectAnswer(),
                    result.Correct ? "Correct" : "Incorrect",
                    result.Correct ? result.Question.Points : 0,
                    new string('-', 75)
                );
                reviewText = reviewText.Replace("\n", "\n    ");
                reviewListBox.Items.Add(reviewText);
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            SetupGame();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}