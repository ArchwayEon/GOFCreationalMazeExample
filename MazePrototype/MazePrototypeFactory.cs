using MazeAbstractFactory;
using MazeLib;

namespace MazePrototype;

public class MazePrototypeFactory : MazeFactory
{
    private readonly Maze _prototypeMaze;
    private readonly Wall _prototypeWall;
    private readonly Room _prototypeRoom;
    private readonly Door _prototypeDoor;

    public MazePrototypeFactory(Maze maze, Room room, Wall wall, Door door)
    {
        _prototypeMaze = maze;
        _prototypeWall = wall;
        _prototypeRoom = room;
        _prototypeDoor = door;
    }

    public override Maze MakeMaze(string name)
    {
        var maze = _prototypeMaze.Clone();
        maze.Name = name;
        return maze;
    }

    public override Wall MakeWall()
    {
        return (Wall)_prototypeWall.Clone();
    }

    public override Room MakeRoom(int roomNumber)
    {
        var room = _prototypeRoom.Clone();
        ((Room)room).RoomNumber = roomNumber;
        return (Room)room;
    }

    public override Door MakeDoor(Room room1, Room room2)
    {
        var door = (Door)_prototypeDoor.Clone();
        door.SetRooms(room1, room2);
        return door;
    }
}
