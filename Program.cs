internal class Program
{
  static int UserWins = 0;
  static int ComputerWins = 0;
  static int Ties = 0;

  private static void Main()
  {
    Console.Clear();
    Console.WriteLine("Rock,Paper,Scissors");
    string userHand = ChooseHand();
    Console.WriteLine(userHand);
    string computerHand = GetComputerHand();
    Console.WriteLine("" + computerHand);
    string result = DetermineWinner(userHand, computerHand);
    Console.WriteLine(result);
    UpdateScore(result);
    Console.WriteLine(DisplayScore());
    playAgain();
  }
  static string ChooseHand()
  {
    Console.WriteLine("Choose a hand");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");
    string userInput = Console.ReadLine();
    if (userInput != "1" && userInput != "2" && userInput != "3")
    {
      Console.WriteLine("Invalid choice. Please choose 1, 2, or 3.");
      return ChooseHand();
    }
    switch (userInput)
    {
      case "1":
        userInput = "Rock";
        break;
      case "2":
        userInput = "Paper";
        break;
      case "3":
        userInput = "Scissors";
        break;
    }

    return userInput;
  }

  static string GetComputerHand()
  {
    Random random = new Random();
    int computerChoice = random.Next(1, 4);
    string computerHand = "";
    switch (computerChoice)
    {
      case 1:
        computerHand = "Rock";
        break;
      case 2:
        computerHand = "Paper";
        break;
      case 3:
        computerHand = "Scissors";
        break;
    }
    return computerHand;
  }

  static string DetermineWinner(string userHand, string computerHand)
  {
    if (userHand == computerHand)
    {
      return "It's a tie!";
    }
    else if ((userHand == "Rock" && computerHand == "Scissors") ||
             (userHand == "Paper" && computerHand == "Rock") ||
             (userHand == "Scissors" && computerHand == "Paper"))
    {
      return "You win!";
    }
    else
    {
      return "Computer wins!";
    }
  }

  static string DisplayScore()
  {
    return $"Score: You {UserWins} - Computer {ComputerWins} - Ties {Ties}";
  }
  static void UpdateScore(string result)
  {
    if (result == "You win!")
    {
      UserWins++;
    }
    else if (result == "Computer wins!")
    {
      ComputerWins++;
    }
    else
    {
      Ties++;
    }
  }

  static string playAgain()
  {
    Console.WriteLine("Do you want to play again? (y/n)");
    string playAgain = Console.ReadLine();
    if (playAgain.ToLower() == "y")
    {
      Main();
    }
    else
    {
      Console.WriteLine("Thanks for playing!");
      Environment.Exit(0);
    }
    return playAgain;
  }
}

