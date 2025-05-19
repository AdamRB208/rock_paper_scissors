namespace rock_paper_scissors.models;

public class Player
{

  public Player(string name)
  {
    Name = name;
    Score = 0;
  }
  public string Name { get; set; }

  public int Score { get; set; }

}
