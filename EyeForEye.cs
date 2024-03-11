namespace PrisonersDilemma;

internal class EyeForEye : IPlayer
{
    private List<Choice> opponentMoves;
    private Random rnd;

    public string Name()
    {
        return "EyeForEye";
    }

    public void Result()
    {
    }

    public Choice Play(IPlayer opponent)
    {
        if (opponentMoves.Contains(Choice.Betray))
            while (opponentMoves.Contains(Choice.Betray))
                return Choice.Betray;
        else if (opponentMoves.Contains(Choice.Cooperate))
            return Choice.Cooperate;
        else
            throw new Exception("Invalid choice.");
        var result = rnd.Next(0, 1);
        switch (result)
        {
            case 0:
                return Choice.Betray;
                break;
            case 1:
                return Choice.Cooperate;
                break;
        }

        return Choice.Betray;
    }
}