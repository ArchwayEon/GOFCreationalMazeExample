namespace MazeLib;

public abstract class MapSite
{
    public string Message { get; set; } = String.Empty;
    public abstract void Enter();
}
