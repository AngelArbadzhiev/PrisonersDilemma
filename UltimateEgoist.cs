namespace PrisonersDilemma;

class UltimateEgoist : Player
{
    public string Name()
    {
        return "UltimateEgoist";
    }

    public Choice Play(Player opponent)
    {
        return Choice.Betray;
    }
}