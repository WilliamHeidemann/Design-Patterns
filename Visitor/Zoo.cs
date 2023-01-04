namespace Visitor;

public abstract class Zoo
{
    public abstract void Accept(IZooVisitor zooVisitor);
}