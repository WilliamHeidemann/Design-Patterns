// See https://aka.ms/new-console-template for more information

using Singleton;

GameResourcesSingleton.Instance.Gold = 50;
GameResourcesSingleton.Instance.PlayerHealth = 100;

var goldmine = new Goldmine();
var monster = new Monster();

goldmine.MineGold();
monster.AttackPlayer();