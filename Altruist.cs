using System.Collections;

namespace PrisonersDilemma;

class Altruist: IPlayer
{
    private Hashtable _lastResult;

    public string Name(){
        return "Altruist";
    }

    public void Start()
    {
        _lastResult = new Hashtable();
    }

    public Choice Play(IPlayer opponent)
    {
        if (_lastResult.ContainsKey(opponent.Name()))
        {
            var lastaction = (Choice)(_lastResult[opponent.Name()] ?? throw new Exception("Argument is null."));
            return lastaction;
        }

        return Choice.Betray;
    }
}
