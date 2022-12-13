namespace Mediator;

public class Participant
{
    private IChatRoom _chatRoom;
    
    public void Join(IChatRoom chatRoom)
    {
        _chatRoom = chatRoom;
        _chatRoom.Subscribe += Receive!;
    }
    
    public void Send(string message)
    {
        _chatRoom.Send(message);
    }

    private void Receive(object sender, StringEventArgs e)
    {
        Console.WriteLine(e.Message);
    }
}