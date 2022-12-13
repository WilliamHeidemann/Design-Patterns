using System.Collections;

namespace Mediator;

public class Logger
{
    private readonly ICollection<(object, string)> _log;

    public Logger(IChatRoom chatRoom)
    {
        _log = new List<(object, string)>();
        chatRoom.Subscribe += Log;
    }

    private void Log(object sender, StringEventArgs e)
    {
        _log.Add((sender, e.Message));
    }

    public IEnumerable GetLog()
    {
        return _log;
    }
}