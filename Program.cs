namespace PrisonersDilemma;

class Program
{
    static void Main(string[] args)
    {
	    IPlayer player = new Altruist();
	    IPlayer player2 = new RandomChooser();
	    player.Play(player2);
    }
}

public enum Choice{
	Betray,
	Cooperate
}








