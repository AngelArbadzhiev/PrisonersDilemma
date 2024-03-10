namespace PrisonersDilemma;

class EyeForEye : Player
{
    public string Name()
    {
        return "EyeForEye";
    }

    public Choice Play(Player opponent)
    {
        Random rnd = new Random();
        var num = rnd.Next(1, 2);
        var choice = Choice.Betray;
        return Choice.Betray;
    }
}