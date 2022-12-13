namespace Singleton;

public class GameResourcesSingleton
{
    public int Gold;
    public int PlayerHealth;

    private static GameResourcesSingleton? _instance;
    public static GameResourcesSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameResourcesSingleton();
            }
            return _instance;
        }
    }
    private GameResourcesSingleton(){}
}