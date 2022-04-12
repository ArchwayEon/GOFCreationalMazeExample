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
    public int RoomNumber { get; private set; }

    public Room(int roomNumber)
    {
        RoomNumber = roomNumber;
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
}
