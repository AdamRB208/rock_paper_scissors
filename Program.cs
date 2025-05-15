internal class Program
{
  private static void Main()
  {
    Console.Clear();
    Console.WriteLine("Rock,Paper,Scissors");
    string userHand = ChooseHand();
    Console.WriteLine(userHand);
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

    return "You have chosen " + userInput;
  }
}
