namespace MazeLib;

public abstract class MapSite
{
    public string Message { get; set; } = String.Empty;

    public MapSite()
    {
    }

    public MapSite(MapSite copy)
    {
        Message = copy.Message;
    }

    public abstract void Enter();

    public abstract MapSite Clone();

}
