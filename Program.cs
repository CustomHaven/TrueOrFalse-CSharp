// https://www.codecademy.com/courses/learn-c-sharp/projects/csharp-true-or-false
using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            // Q1
            string[] questions = new string[] {
        "An eggplant is also known as an aubergine",
        "Eggplants are a species in the nightshade family.",
        "According to botanical definition, eggplanet is a vegetable.",
        "When cut open, eggplants do not brown (oxidation).",
        "Eggplants were originally domesticated from the wild species bitter apple, or S. incanum."
      };

            // Q2
            bool[] answers = new bool[] { true, true, false, false, true };

            // Q3
            bool[] responses = new bool[questions.Length];

            // Q4
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning! questions doesn't equal answers.");
            }

            // Q5
            int askingIndex = 0;

            // Q6 - Q13
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;

                Console.WriteLine(question);
                Console.Write("True or False? ");

                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            // Q15
            int scoringIndex = 0;
            int score = 0;

            // Q16 - Q20
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {response}\t| Answer: {answer}");
                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;
            }

            // Q21 
            Console.WriteLine($"You got {score} out of {answers.Length} correct!");

            // Q22 run code extra put all the above in method RunQuiz() with two param string[] questions and bool[] answers

        }
    }
}
