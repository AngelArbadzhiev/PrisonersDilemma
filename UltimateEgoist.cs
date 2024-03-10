namespace PrisonersDilemma;

class UltimateEgoist : IPlayer
{
    public string Name()
    {
        return "UltimateEgoist";
    }

    public void Start()
    {

    }

    public Choice Play(IPlayer opponent)
    {
        return Choice.Betray;
    }
}