using MazeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeBuilderLib;

public class StandardMazeBuilder : MazeBuilder
{
    private Maze? _maze;
    public override void BuildMaze(string name)
    {
        _maze = new Maze
        {
            Name = name
        };
    }

    public override Maze? GetMaze()
    {
        return _maze;
    }

    public override void BuildRoom(int roomNumber)
    {
        if (_maze != null && _maze.GetRoom(roomNumber) == null)
        {
            Room room = new(roomNumber);
            _maze.AddRoom(room);

            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.East, new Wall());
            room.SetSide(Direction.West, new Wall());
        }
    }

    public override void BuildDoor(int roomFrom, int roomTo)
    {
        Room? r1 = _maze!.GetRoom(roomFrom);
        Room? r2 = _maze!.GetRoom(roomTo);
        Door door = new(r1!, r2!);

        r1!.SetSide(Direction.East, door);
        r2!.SetSide(Direction.West, door);
    }
}
