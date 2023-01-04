namespace Observer;

public class StockMarket
{
    public event EventHandler MarketNotifications;

    public void OnMarketCrash()
    {
        MarketNotifications(this, EventArgs.Empty);
    }
}