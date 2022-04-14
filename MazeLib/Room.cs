using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib;

public class Room : MapSite
{
    private readonly Dictionary<Direction, MapSite> _sides 
        = new();
    public int RoomNumber { get; set; }

    public Room()
    {
    }

    public Room(int roomNumber)
    {
        RoomNumber = roomNumber;
    }

    public Room(Room copy)
    {
        RoomNumber = copy.RoomNumber;
        _sides = new();
        foreach (KeyValuePair<Direction, MapSite> entry in copy._sides)
        {
            Direction direction = entry.Key;
            var value = entry.Value.Clone();
            _sides[direction] = value;
        }
    }

    public MapSite GetSide(Direction direction)
    {
        return _sides[direction];
    }

    public void SetSide(Direction direction, MapSite site)
    {
        _sides[direction] = site;
    }

    public override void Enter()
    {
        Message = "You entered a room.";
    }

    public override MapSite Clone()
    {
        return new Room(this);
    }
}
