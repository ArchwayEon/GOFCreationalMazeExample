using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib;

public class Maze
{
    public string Name { get; set; } = String.Empty;
    private readonly Dictionary<int, Room> _rooms 
        = new();

    public Maze()
    {
    }

    public Maze(Maze copy)
    {
        Name = copy.Name;
        _rooms = copy._rooms;
    }

    public void AddRoom(Room room)
    {
        _rooms[room.RoomNumber] = room;
    }

    public Room? GetRoom(int roomNumber)
    {
        if (!_rooms.ContainsKey(roomNumber))
        {
            return null;
        }
        return _rooms[roomNumber];
    }

    public Maze Clone()
    {
        return new Maze(this);
    }
}
