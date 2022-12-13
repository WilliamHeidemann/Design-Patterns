namespace Singleton;

public class Monster
{
    public void AttackPlayer()
    {
        GameResourcesSingleton.Instance.PlayerHealth -= 10;
        Console.WriteLine($"Player left with {GameResourcesSingleton.Instance.PlayerHealth} health.");
    }
}