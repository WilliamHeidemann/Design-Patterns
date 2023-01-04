namespace Composite;

public interface IFamilyMember
{
    public IEnumerable<IFamilyMember> Children();
    public string Name();
}

public class Father : IFamilyMember
{
    private readonly IEnumerable<Father> _sons;

    public Father(IEnumerable<Father> sons)
    {
        _sons = sons;
    }

    public IEnumerable<IFamilyMember> Children()
    {
        return _sons;
    }

    public string Name()
    {
        return "Eric";
    }
}