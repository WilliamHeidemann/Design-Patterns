// See https://aka.ms/new-console-template for more information

using Composite;

var ericJuniorJunior = new Father(Array.Empty<Father>());
var ericJunior = new Father( new [] { ericJuniorJunior });
var ericSenior = new Father( new [] { ericJunior });

// BFS approach
int Descendants(IFamilyMember member)
{
    if (!member.Children().Any()) return 0;
    return member.Children().Count() + member.Children().Sum(Descendants);
}

Console.WriteLine(ericSenior.Name() + " has " + Descendants(ericSenior) + " descendants");