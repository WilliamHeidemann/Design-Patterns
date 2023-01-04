namespace Visitor;

public interface IZooVisitor
{
    public void VisitCopenhagenZoo(CopenhagenZoo zoo);
    public void VisitAalborgZoo(AalborgZoo zoo);
    public void VisitAarhusZoo(AarhusZoo zoo);
}