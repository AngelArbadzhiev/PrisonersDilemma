namespace PrisonersDilemma;

public interface IPlayer{
    string Name();
    Choice Play(IPlayer opponent);
    void Start();
    void Result();
}
