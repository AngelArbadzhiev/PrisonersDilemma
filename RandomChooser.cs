namespace PrisonersDilemma;

internal class RandomChooser : IPlayer
{
    private Random _rnd;

    public string Name()
    {
        return "RandomChooser";
    }

    public void Result()
    {
        var rnd = new Random();
    }

    public Choice Play(IPlayer opponent)
    {
        var num = _rnd.Next(1, 2);
        var choice = Choice.Betray;
        choice = num.Equals(1) ? Choice.Betray : Choice.Cooperate;
        if (Choice.Betray.ToString() == "Betray")
            return Choice.Betray;
        return Choice.Cooperate;
    }

    public void Start(Game game)
    {
    }
}