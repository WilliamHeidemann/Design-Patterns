namespace Bridge;

public class Magician
{
    private readonly IDeck _deck;

    public Magician(IDeck deck)
    {
        _deck = deck;
    }
    public void PerformMagicTrick()
    {
        _deck.Shuffle();
        _deck.ViewTopCard();
        // ... 
    }
}
