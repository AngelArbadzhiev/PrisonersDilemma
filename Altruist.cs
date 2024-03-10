namespace PrisonersDilemma;

class Altruist: Player{
    public string Name(){
        return "Altruist";
    }
    public Choice Play(Player opponent)
    {
        Random rnd = new Random();
        var num = rnd.Next(0, 2);
        var choice = Choice.Cooperate;
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
