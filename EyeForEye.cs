using System.Collections;

namespace PrisonersDilemma;

class EyeForEye : IPlayer
{
    private Hashtable lastResult;
    public string Name()
    {
        return "EyeForEye";
    }

    public void Start()
    {
        lastResult = new Hashtable();
    }

    public Choice Play(IPlayer opponent)
    {

    }
}