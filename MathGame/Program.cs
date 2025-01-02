using System;
// Review string interpolation

class Program
{
    static void Main(string[] args)
    {
        // Asking for user's name
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine();
        DateTime date = DateTime.Now;
       /* int gamesPlayed = 0;
        char userOption;
        decimal averageScore;
       */ bool isScoreEmpty = true;
        List<string> gamesHistory = new();

        Console.WriteLine($"Welcome to the math game, {userName}.\n" + "Press any key to continue.");
        Console.ReadKey();
        Console.Clear();

        while (true)
        {
            Console.WriteLine(@"What game would you like to play?
        A -   Addition
        S -   Subtraction
        M -   Multiplication  
        D -   Division");


            var usersChoice = Console.ReadLine().Trim().ToUpper();

            switch (usersChoice)
            {
                case "A":
                    AdditionGame();
                    break;
                case "S":
                    SubtractionGame();
                    break;
                case "M":
                    MultiplicationGame();
                    break;
                case "D":
                    DivisionGame();
                    break;
                case "V":
                    ViewPreviousGame("List of Games");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    //Main(args); // This calls Main to restart the selection
                    break;
            }
        }
        /* for (int i = 0; i < 5; i++) 
         {
             Console.WriteLine($"This code has executed {i} times");
         }*/

        void AdditionGame()
        {
            Console.Clear();
            var random = new Random();
            var score = 0;
            int num1;
            int num2;

            Console.WriteLine($"How many times would you like to play?");
            var numberOfRounds = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRounds; i++)
            {
                num1 = random.Next(1, 9);
                num2 = random.Next(1, 9);
                bool correct = false;
                int attempts = 0;

                while (!correct && attempts < 1)
                {
                    Console.WriteLine($"{num1} + {num2}");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == num1 + num2)
                    {
                        Console.WriteLine("That's Right!");
                        score++;
                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine("Sorry that wasn't right!");
                        attempts++;
                    }
                }
                if (!correct)
                {
                    Console.WriteLine($"The correct answer is {num1 + num2}");
                }
            }

            Console.WriteLine($"Your score: {score} out of {numberOfRounds}. " +
                $"Press any key to go back to main menu.");
            Console.ReadKey();
            gamesHistory.Add($"{DateTime.Now} - Addition - Score: {score} out of {numberOfRounds}");
            PlayAgain();
        }

        void SubtractionGame()
        {
            Console.Clear();
            var random = new Random();
            var score = 0;
            Console.WriteLine($"How many times would you like to play?");
            var numberOfRounds = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRounds; i++)
            {
                int num1 = random.Next(1, 9);
                int num2 = random.Next(1, 9);
                bool correct = false;

                while (!correct)
                {
                    Console.WriteLine($"What is {num1} - {num2}?");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == num1 - num2)
                    {
                        Console.WriteLine("That's Right!");
                        score++;
                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }

            }
            Console.WriteLine($"Your score: {score}");
            PlayAgain();
        }
        void MultiplicationGame()
        {
            Console.Clear();
            var random = new Random();
            var score = 0;

            Console.WriteLine($"How many times would you like to play?");
            var numberOfRounds = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRounds; i++)
            {
                int num1 = random.Next(1, 9);
                int num2 = random.Next(1, 9);
                bool correct = false;

                while (!correct)
                {
                    Console.WriteLine($"What is {num1} * {num2}?");
                    var result = Console.ReadLine();

                    if (int.Parse(result) == num1 * num2)
                    {
                        Console.WriteLine("That's Right!");
                        score++;
                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
            }
            Console.WriteLine($"Your score: {score}");
            PlayAgain();
        }

        void DivisionGame()
        {
            Console.Clear();
            var random = new Random();
            var score = 0;
            Console.WriteLine($"How many times would you like to play?");
            var numberOfRounds = int.Parse(Console.ReadLine());

            for (int i=0; i < numberOfRounds; i++)
            {                
                    var divisionNumbers = GetDivisionNumbers();

                    bool correct = false;

                    while (!correct)
                    {
                        Console.WriteLine($"What is {divisionNumbers[0]} / {divisionNumbers[1]}?");
                        var result = Console.ReadLine();

                        if (int.Parse(result) == divisionNumbers[0] / divisionNumbers[1])
                        {
                            Console.WriteLine("That's Right!");
                            score++;
                            correct = true;
                        }
                        else
                        {
                            Console.WriteLine("Try again!");
                        }
                    }
            }
            Console.WriteLine($"Your score: {score}");
            PlayAgain();
        }

        int[] GetDivisionNumbers()
        {
            var random = new Random();
            var num1 = random.Next(1, 99);
            var num2 = random.Next(1, 99);
            

            var result = new int[2];

            while (num1 % num2 != 0)
            {
                num1 = random.Next(1, 99);
                num2 = random.Next(1, 99);
            }

            result[0] = num1;
            result[1] = num2;
            return result;

        }
        void PlayAgain()
        {
            Console.WriteLine("Do you want to play another game? (yes/no)");
            string playAgain = Console.ReadLine().Trim().ToLower();
            if (playAgain != "yes")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();

            }
        }
    }
   
    // lets see if this runs
        static void ViewPreviousGame(string message) 
        {
            Console.WriteLine(message);
        }

    }