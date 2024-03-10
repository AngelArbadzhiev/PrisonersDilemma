namespace PrisonersDilemma;

class Egoist : Player
{
    public string Name()
    {
        return "Egoist";
    }

    public Choice Play(Player opponent)
    {
        Random rnd = new Random();
        var num = rnd.Next(1, 2);
        var choice = Choice.Betray;
        choice = num.Equals(1) ? Choice.Betray : Choice.Cooperate;
        if(Choice.Betray.ToString() == "Betray")
        {
            return Choice.Betray;
        }
        else
        {
            return Choice.Cooperate;
        }
    }
}