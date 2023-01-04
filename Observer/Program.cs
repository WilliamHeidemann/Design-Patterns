// See https://aka.ms/new-console-template for more information

using Observer;

StockMarket stockMarket = new();

AlgorithmicTrader algoTrader = new();
RealPersonTrader realTrader = new();

stockMarket.MarketNotifications += algoTrader.ReactToStockChange;
stockMarket.MarketNotifications += realTrader.ReactToStockChange;

// Crash the market
stockMarket.OnMarketCrash();