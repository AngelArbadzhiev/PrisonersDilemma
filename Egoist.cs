namespace PrisonersDilemma;

public class Egoist : IPlayer
{
    public string Name()
    {
        return "Egoist";
    }

    public void Result()
    {
    }

    public Choice Play(IPlayer opponent)
    {
        return Choice.Betray;
    }
}