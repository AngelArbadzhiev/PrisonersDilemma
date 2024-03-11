namespace PrisonersDilemma;

internal class UltimateAltruist : IPlayer
{
    public string Name()
    {
        return "UltimateAltruist";
    }

    public void Result()
    {
    }

    public Choice Play(IPlayer opponent)
    {
        return Choice.Cooperate;
    }
}