using Bridge;

// The algorithms for the deck used during the magician's magic trick
// have been seperated into a separate deck class.

// Another deck can be swapped for the existing both at compile time and runtime. 

var deck = new StandardDeck(new Stack<Card>());
var magician = new Magician(deck);
magician.PerformMagicTrick();



