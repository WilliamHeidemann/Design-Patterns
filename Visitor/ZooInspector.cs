namespace Visitor;

public class ZooInspector : IZooVisitor
{
    public void VisitCopenhagenZoo(CopenhagenZoo zoo)
    {
        Console.WriteLine("Inspector gave Copenhagen Zoo a rating of 10/10");
    }
    public void VisitAalborgZoo(AalborgZoo zoo)
    {
        Console.WriteLine("Inspector gave Copenhagen Zoo a rating of 8/10");
    }
    public void VisitAarhusZoo(AarhusZoo zoo)
    {
        Console.WriteLine("Inspector gave Copenhagen Zoo a rating of 9/10");
    }
}