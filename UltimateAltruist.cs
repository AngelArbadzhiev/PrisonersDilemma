namespace PrisonersDilemma;

class UltimateAltruist : Player
{
    public string Name()
    {
        return "UltimateAltruist";
    }

    public Choice Play(Player opponent)
    {
        return Choice.Cooperate;
    }
}