namespace QuizApp
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Question[] questions = new Question[]
			{
				new Question("What is the capital of Germany",new string[]{"Paris","Berlin","London","Madrid"},1),
				new Question("Who wrote 'Hamlet'?", new string[]{"Charles Dickens", "William Shakespeare", "Jane Austen", "Mark Twain"}, 1),
                new Question("What is the largest planet in our solar system?", new string[]{"Earth", "Mars", "Jupiter", "Saturn"}, 2),
                new Question("What is the chemical symbol for water?", new string[]{"H2O", "CO2", "NaCl", "O2"}, 0),
                new Question("Which element has the atomic number 1?", new string[]{"Oxygen", "Carbon", "Hydrogen", "Nitrogen"}, 2)
			};
			Quiz myQuiz = new Quiz(questions);
			myQuiz.StartQuiz();
			Console.ReadLine();
		}
	}
}
