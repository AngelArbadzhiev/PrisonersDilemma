namespace PrisonersDilemma;

interface Player{
    string Name();
    Choice Play(Player opponent);
}
