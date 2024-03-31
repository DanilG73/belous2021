using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0220
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        class Question
        {
            public string QuestionText { get; set; }
            public List<string> Options { get; set; }
            public int CorrectOption { get; set; }
            public int Points { get; set; }
        }

        class Answers
        {
            public List<int> SelectedOptions { get; set; }
        }

        private Question question1 = new Question
        {
            QuestionText = "What is the capital of France?",
            Options = new List<string> { "London", "Paris", "Berlin", "Madrid" },
            CorrectOption = 2,
            Points = 1
        };

        private Question question2 = new Question
        {
            QuestionText = "Which planet is known as the Red Planet?",
            Options = new List<string> { "Mars", "Venus", "Jupiter", "Saturn" },
            CorrectOption = 0,
            Points = 1
        };

        private Question question3 = new Question
        {
            QuestionText = "What is the largest mammal on Earth?",
            Options = new List<string> { "Elephant", "Blue Whale", "Giraffe", "Hippopotamus" },
            CorrectOption = 1,
            Points = 1
        };

        private Answers userAnswers = new Answers();

        public void DisplayQuestion(int questionNumber)
        {
            Question question = null;
            switch (questionNumber)
            {
                case 1:
                    question = question1;
                    break;
                case 2:
                    question = question2;
                    break;
                case 3:
                    question = question3;
                    break;
                default:
                    Console.WriteLine("Invalid question number.");
                    return;
            }

            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {question.Options[i]}");
            }
        }

        public void SetUserAnswer(int questionNumber, List<int> selectedOptions)
        {
            userAnswers.SelectedOptions = selectedOptions;
        }

        public void GradeTest()
        {
            int correctAnswers = 0;
            int totalPoints = 0;

            if (question1.CorrectOption == userAnswers.SelectedOptions[0])
            {
                correctAnswers++;
                totalPoints += question1.Points;
            }

            if (question2.CorrectOption == userAnswers.SelectedOptions[1])
            {
                correctAnswers++;
                totalPoints += question2.Points;
            }

            if (question3.CorrectOption == userAnswers.SelectedOptions[2])
            {
                correctAnswers++;
                totalPoints += question3.Points;
            }

            Console.WriteLine($"Number of correct answers: {correctAnswers}");
            Console.WriteLine($"Number of incorrect answers: {3 - correctAnswers}");
            Console.WriteLine($"Total points: {totalPoints}");
        }
    }

    class Program
    {
        static void Main()
        {
            Test test = new Test();

            test.DisplayQuestion(1);

            List<int> userSelectedOptions = new List<int> { 2, 0, 1 };

            test.SetUserAnswer(1, userSelectedOptions);

            test.GradeTest();
            Console.ReadKey();
        }
    }
    
}
