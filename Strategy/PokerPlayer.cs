namespace Strategy;

public class PokerPlayer
{
    private IPokerStrategy _strategy;

    public PokerPlayer(IPokerStrategy strategy)
    {
        _strategy = strategy;
    }

    public void TakeTurn()
    {
        _strategy.Execute();
    }

    public void ChangeStrategy(IPokerStrategy strategy)
    {
        _strategy = strategy;
    }
}

public interface IPokerStrategy
{
    public void Execute();
}

public class BluffStrategy : IPokerStrategy
{
    public void Execute()
    {
        // AllIn();
    }
}

public class InsecureStrategy : IPokerStrategy
{
    public void Execute()
    {
        /* if ( AnyoneRaised() )
             Fold();
           else
             Check();
         */
        
    }
}

public class AggressiveStrategy : IPokerStrategy
{
    public void Execute()
    {
        /* if ( AnyoneRaised() )
         *    ReRaise();
         * else
         *     Check();
         */
    }
}