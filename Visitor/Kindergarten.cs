namespace Visitor;

public class Kindergarten : IZooVisitor
{
    public void VisitCopenhagenZoo(CopenhagenZoo zoo)
    {
        Console.WriteLine("The kindergarten spent the entire day by the horses at Copenhagen Zoo.");
    }

    public void VisitAalborgZoo(AalborgZoo zoo)
    {
        Console.WriteLine("The kindergarten spent the entire day by the horses at Aalborg Zoo.");
    }

    public void VisitAarhusZoo(AarhusZoo zoo)
    {
        Console.WriteLine("The kindergarten spent the entire day by the horses at Aarhus Zoo.");
    }
}