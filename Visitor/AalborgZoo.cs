namespace Visitor;

public class AalborgZoo : Zoo
{
    public override void Accept(IZooVisitor zooVisitor)
    {
        zooVisitor.VisitAalborgZoo(this);
    }
}