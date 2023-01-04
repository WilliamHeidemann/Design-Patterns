namespace Observer;
public class AlgorithmicTrader
{
    public void ReactToStockChange(object sender, EventArgs e)
    {
        // condition 
            // SellStocks();
        // else
            // BuyStocks();
        Console.WriteLine("Algorithm reacted to market change.");
    }
}

public class RealPersonTrader
{
    public void ReactToStockChange(object sender, EventArgs e)
    {
        // condition 
            // SellStocks();
        // else
            // BuyStocks();
        Console.WriteLine("Trader reacted to market change.");
    }
}