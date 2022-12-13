namespace Mediator;

public interface IChatRoom
{
    public void Send(string message);
    public event EventHandler<StringEventArgs> Subscribe;
}

public class ChatRoom : IChatRoom
{
    public event EventHandler<StringEventArgs> Subscribe;
    
    public void Send(string message)
    {
        Subscribe.Invoke(this, new StringEventArgs(message));
    }
}

public class StringEventArgs : EventArgs
{
    public string Message { get; }
    public StringEventArgs(string message)
    {
        Message = message;
    }
}