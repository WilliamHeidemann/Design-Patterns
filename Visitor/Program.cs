// See https://aka.ms/new-console-template for more information

using Visitor;

Kindergarten kindergarten = new();
ZooInspector zooInspector = new();

CopenhagenZoo copenhagenZoo = new();
AarhusZoo aarhusZoo = new();
AalborgZoo aalborgZoo = new();

Zoo[] zoos = { copenhagenZoo, aalborgZoo, aarhusZoo };

foreach (var zoo in zoos)
{
    zoo.Accept(kindergarten);
    zoo.Accept(zooInspector);
}