
using rock_paper_scissors.models;

internal class Program
{
  static List<Player> Players = [];
  static int UserWins = 0;
  static int ComputerWins = 0;
  static int Ties = 0;

  private static void Main()
  {
    Console.Clear();
    Console.WriteLine("Rock,Paper,Scissors");
    Player playerOne = AddPlayer();
    Players.Add(playerOne);
    Console.WriteLine("Would you like to add a second player? (y/n)");
    string playerCount = Console.ReadLine();
    if (playerCount.ToLower() == "y")
    {
      Player playerTwo = AddPlayer();
      Players.Add(playerTwo);
      for (int i = 0; i < Players.Count; i++)
      {
        Player player = Players[i];
        Console.WriteLine(player);
      }
      Console.Clear();
    }
    if (Players.Count > 1)
    {
      PlayTwoPlayerRound();
    }
    else
    {
      PlayerVsComputerRound();
    }
    Console.WriteLine(DisplayScore());
    playAgain();
  }

  static Player AddPlayer()
  {
    Console.WriteLine("Enter Players Name...");
    string playerName = Console.ReadLine();
    Console.WriteLine($"Players Name Is {playerName}");
    Player newPlayer = new Player(playerName);
    return newPlayer;
  }

  static void PlayTwoPlayerRound()
  {
    Console.WriteLine($"{Players[0].Name}, its your turn");
    string playerOneHand = ChooseHand();
    Console.Clear();

    Console.WriteLine($"{Players[1].Name}, its your turn");
    string playerTwoHand = ChooseHand();
    Console.Clear();

    Console.WriteLine($"{Players[0].Name} chose {playerOneHand}");
    Console.WriteLine($"{Players[1].Name} chose {playerTwoHand}");
    string result = DetermineWinner(playerOneHand, playerTwoHand);
    Console.WriteLine(result);
    UpdateScore(result);
  }

  static void PlayerVsComputerRound()
  {
    string userHand = ChooseHand();
    Console.WriteLine(userHand);
    string computerHand = GetComputerHand();
    Console.WriteLine("Computer chose " + computerHand);
    string result = DetermineWinner(userHand, computerHand);
    Console.WriteLine(result);
    UpdateScore(result);
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
    if (Players.Count > 1)
    {
      return DetermineWinner(Players[0].Name, Players[1].Name);
    }
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
      return $"You win!";
    }
    else
    {
      return "Computer wins!";
    }
  }

  static string DisplayScore()
  {
    if (Players.Count > 1)
    {
      return $"Score: {Players[0].Name}: {UserWins} - {Players[1].Name} {UserWins} - Ties {Ties}";
    }
    else
    {
      return $"Score: {Players[0].Name}: {UserWins} - Computer: {ComputerWins} - Ties {Ties}";
    }
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
      if (Players.Count > 1)
      {
        PlayTwoPlayerRound();
      }
      else
      {
        PlayerVsComputerRound();
      }
    }
    else
    {
      Console.WriteLine("Thanks for playing!");
      Environment.Exit(0);
    }
    return playAgain;
  }
}


