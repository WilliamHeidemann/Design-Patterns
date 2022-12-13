using Strategy;

var bluffingPlayer = new PokerPlayer(new BluffStrategy());
var insecurePlayer = new PokerPlayer(new InsecureStrategy());
var aggressivePlayer = new PokerPlayer(new BluffStrategy());
var mixedStrategyPlayer = new PokerPlayer(new BluffStrategy());

List<PokerPlayer> pokerPlayers = new() { bluffingPlayer, insecurePlayer, aggressivePlayer, mixedStrategyPlayer };

// while ( GameIsRunning() )
    foreach (var player in pokerPlayers)
    {
        player.TakeTurn();
    }
// at some point one player changes strategy at runtime
mixedStrategyPlayer.ChangeStrategy(new AggressiveStrategy());