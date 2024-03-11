namespace PrisonersDilemma;

internal class Program
{
    private static void Main(string[] args)
    {
        IPlayer player = new Altruist();
        IPlayer player2 = new UltimateEgoist();
        player.Play(player2);
    }
}

public enum Choice
{
    Betray,
    Cooperate
}