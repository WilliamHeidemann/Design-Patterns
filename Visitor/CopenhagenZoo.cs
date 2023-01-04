namespace Visitor;

public class CopenhagenZoo : Zoo
{
    public override void Accept(IZooVisitor zooVisitor)
    {
        zooVisitor.VisitCopenhagenZoo(this);
    }
}