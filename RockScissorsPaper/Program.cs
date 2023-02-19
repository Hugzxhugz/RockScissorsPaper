class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int computerChoice = random.Next(3); // 0 = rock, 1 = scissors, 2 = paper

        while (true)
        {
            Console.Write("Enter your choice (rock, scissors, or paper) or type quit to exit: ");
            string userChoice = Console.ReadLine().ToLower();

            if (userChoice == "rock" || userChoice == "scissors" || userChoice == "paper")
            {
                Console.WriteLine("The computer chose: {0}", AssignComputerChoice(computerChoice));

                int result = CompareChoices(userChoice, computerChoice);

                if (result == 0)
                {
                    Console.WriteLine("It's a tie! Let's play again.\n");
                }
                else if (result > 0)
                {
                    Console.WriteLine("You win! Congratulations. Let's play again.\n");
                    
                }
                else
                {
                    Console.WriteLine("You lose. Better luck next time. Let's play again.\n");
                }
            }

            else if (userChoice == "quit")
            {
                Console.WriteLine("Thank you for playing!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'rock', 'scissors', or 'paper'.");
            }
        }
    }

    static string AssignComputerChoice(int choice)
    {
        switch (choice)
        {
            case 0:
                return "rock";
            case 1:
                return "scissors";
            case 2:
                return "paper";
            default:
                return "";
        }
    }

    static int CompareChoices(string userChoice, int computerChoice)
    {
        if (userChoice == "rock")
        {
            if (computerChoice == 1)
            {
                return 1;
            }
            if (computerChoice == 2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        if (userChoice == "scissors")
        {
            if (computerChoice == 2)
            {
                return 1;
            }
            if (computerChoice == 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        else // userChoice == "paper"
        {
            if (computerChoice == 0)
            {
                return 1;
            }
            if (computerChoice == 1)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
