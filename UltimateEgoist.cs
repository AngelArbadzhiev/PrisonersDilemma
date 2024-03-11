namespace PrisonersDilemma;

internal class UltimateEgoist : IPlayer
{
    public string Name()
    {
        return "UltimateEgoist";
    }

    public void Result()
    {
    }

    public Choice Play(IPlayer opponent)
    {
        return Choice.Betray;
    }
}