using MazeLib;

namespace MazeBuilderLib;

public class MazeBuilder
{
    public virtual void BuildMaze(string name) { }
    public virtual void BuildRoom(int roomNumber) { }
    public virtual void BuildDoor(int roomFrom, int roomTo) { }
    public virtual Maze? GetMaze() { return null; }
}
