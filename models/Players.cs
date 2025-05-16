namespace rock_paper_scissors.models;

public class Players
{

  public Players(string name)
  {
    Name = name;
    Score = 0;
  }
  public string Name { get; set; }

  public int Score { get; set; }

}
