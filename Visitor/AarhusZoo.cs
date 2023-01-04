namespace Visitor;

public class AarhusZoo : Zoo
{
    public override void Accept(IZooVisitor zooVisitor)
    {
        zooVisitor.VisitAarhusZoo(this);
    }
}