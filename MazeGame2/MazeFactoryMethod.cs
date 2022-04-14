using MazeLib;

namespace MazeFactoryMethodLib;

public class MazeFactoryMethod
{
    public Maze? Maze { get; set; }

    public void CreateMaze(string name)
    {
        Maze = MakeMaze(name);
        Room r1 = MakeRoom(1);
        Room r2 = MakeRoom(2);
        Door door = MakeDoor(r1, r2);

        Maze!.AddRoom(r1);
        Maze!.AddRoom(r2);

        r1.SetSide(Direction.North, MakeWall());
        r1.SetSide(Direction.East, door);
        r1.SetSide(Direction.South, MakeWall());
        r1.SetSide(Direction.West, MakeWall());

        r2.SetSide(Direction.North, MakeWall());
        r2.SetSide(Direction.East, MakeWall());
        r2.SetSide(Direction.South, MakeWall());
        r2.SetSide(Direction.West, door);
    }

    protected virtual MapSite MakeWall()
    {
        return new Wall();
    }

    protected virtual Door MakeDoor(Room r1, Room r2)
    {
        return new Door(r1, r2);
    }

    protected virtual Room MakeRoom(int roomNumber)
    {
        return new Room(roomNumber);
    }

    protected virtual Maze? MakeMaze(string name)
    {
        return new Maze{Name = name};
    }
}
