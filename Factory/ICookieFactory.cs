namespace Factory;

public interface ICookieFactory
{
    public ICookie CreateCookie(string request);
}