internal class Program
{
  private static void Main()
  {
    Console.Clear();
    Console.WriteLine("Rock,Paper,Scissors");
    string userHand = ChooseHand();
  }
  static string ChooseHand()
  {
    Console.WriteLine("Choose a hand");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");
    string userInput = Console.ReadLine();

    return "";
  }
}
