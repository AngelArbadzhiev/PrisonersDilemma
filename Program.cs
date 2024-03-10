namespace PrisonersDilemma;

class Program
{
    static void Main(string[] args)
    {
	    Player player = new Altruist();
	    Player player2 = new Egoist();
	    player.Play(player2);
    }
}
enum Choice{
	Betray,
	Cooperate
}








