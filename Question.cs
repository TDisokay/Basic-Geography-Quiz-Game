using System;
using System.Collections.Generic;
using System.Linq;

namespace Game_WFDemo_1202
{
    public enum QuestionType
    {
        MultipleChoice,
        OpenEnded,
        TrueFalse
    }

    public enum GeographyRegion
    {
        World,
        Americas,
        Europe,
        Asia,
        Africa,
        Oceania
    }

    public abstract class Question
    {
        public string QuestionText { get; set; }
        public int Points { get; set; }
        public GeographyRegion Region { get; set; }
        public QuestionType Type { get; protected set; }

        public Question(string questionText, int points, GeographyRegion region)
        {
            QuestionText = questionText;
            Points = points;
            Region = region;
        }

        public abstract bool CheckAnswer(string userAnswer);
        public abstract string GetCorrectAnswer();
    }

    public class MultipleChoiceQuestion : Question
    {
        public string[] Options { get; set; }
        public int CorrectOptionIndex { get; set; }

        public MultipleChoiceQuestion(string questionText, string[] options, int correctOptionIndex,
            int points, GeographyRegion region) : base(questionText, points, region)
        {
            Type = QuestionType.MultipleChoice;
            Options = options;
            CorrectOptionIndex = correctOptionIndex;
        }

        public override bool CheckAnswer(string userAnswer)
        {
            if (int.TryParse(userAnswer, out int selectedOption))
            {
                return selectedOption - 1 == CorrectOptionIndex;
            }
            return false;
        }

        public override string GetCorrectAnswer()
        {
            return Options[CorrectOptionIndex];
        }
    }

    public class OpenEndedQuestion : Question
    {
        public List<string> AcceptableAnswers { get; set; }

        public OpenEndedQuestion(string questionText, List<string> acceptableAnswers,
            int points, GeographyRegion region) : base(questionText, points, region)
        {
            Type = QuestionType.OpenEnded;
            AcceptableAnswers = acceptableAnswers;
        }

        public override bool CheckAnswer(string userAnswer)
        {
            return AcceptableAnswers.Any(answer =>
                answer.Equals(userAnswer.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public override string GetCorrectAnswer()
        {
            return AcceptableAnswers[0];
        }
    }

    public class TrueFalseQuestion : Question
    {
        public bool CorrectAnswer { get; set; }

        public TrueFalseQuestion(string questionText, bool correctAnswer,
            int points, GeographyRegion region) : base(questionText, points, region)
        {
            Type = QuestionType.TrueFalse;
            CorrectAnswer = correctAnswer;
        }

        public override bool CheckAnswer(string userAnswer)
        {
            if (bool.TryParse(userAnswer, out bool answer))
            {
                return answer == CorrectAnswer;
            }
            return false;
        }

        public override string GetCorrectAnswer()
        {
            return CorrectAnswer.ToString();
        }
    }

    public static class GameData
    {
        public static List<Question> QuestionBank { get; set; } = new List<Question>();
    }
}