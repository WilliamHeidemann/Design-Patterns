namespace Bridge;

public class StandardDeck : IDeck
{
    private readonly Stack<Card> _cards;

    public StandardDeck(Stack<Card> cards)
    {
        _cards = cards;
    }

    public void Shuffle()
    {
        // Some shuffle algorithm
    }

    public Card ViewTopCard()
    {
        return _cards.Peek();
    }
}

public class Card
{
    // {...}
}