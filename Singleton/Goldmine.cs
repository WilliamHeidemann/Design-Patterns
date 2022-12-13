namespace Singleton;

public class Goldmine
{
    public void MineGold()
    {
        GameResourcesSingleton.Instance.Gold += 3;
        Console.WriteLine($"Gold increased to {GameResourcesSingleton.Instance.Gold}.");
    }
}