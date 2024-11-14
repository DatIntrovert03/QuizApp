using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
	internal class Quiz
	{
		private Question[] _questions;
        private int _score;
        public Quiz(Question[] questions)
        {
           this._questions = questions;
            _score = 0;
        }
        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1;
            foreach (var question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.isCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct");
                    _score++;
                }
                else Console.WriteLine($"Wrong the correct answer was:{question.Answers[question.CorrectAnswerIndex]}");
            
            }
            DisplayResults();
        }
        private void DisplayResults()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
			Console.Write("----------------");
			Console.Write("Question");
			Console.Write("----------------");
			Console.ResetColor();
            Console.WriteLine($"Quiz finished your result is {_score} out of {_questions.Length}");
            double percentage=(double)_score/_questions.Length;
            if (percentage>=0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent Work!");
            }
            else if(percentage>=0.5)
            {
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Good effort!");
			}
			else 
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("keep Practicing");
			}
            Console.ResetColor();
		}
        public void DisplayQuestion(Question question)
        {
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.Write("----------------");
            Console.Write("Question");
			Console.Write("----------------");
            Console.ResetColor();
            Console.WriteLine();
			Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" ");
                Console.Write(i+1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }
        }
        private int GetUserChoice()
        {
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice)||choice<1||choice>4)
                {
                Console.WriteLine("Invalid choice .Plese enter a number between 1 and 4");
                input=Console.ReadLine();
            }
            return choice - 1;
        }
    }
}
