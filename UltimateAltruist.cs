namespace PrisonersDilemma;

class UltimateAltruist : IPlayer
{
    public string Name()
    {
        return "UltimateAltruist";
    }

    public void Start()
    {

    }

    public Choice Play(IPlayer opponent)
    {
        return Choice.Cooperate;
    }
}