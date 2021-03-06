using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib;

public class Door : MapSite
{
    protected Room? _room1;
    protected Room? _room2;
    protected bool _isOpen;

    public Door()
    {
    }

    public Door(Room room1, Room room2)
    {
        _room1 = room1;
        _room2 = room2;
        _isOpen = false;
    }

    public Door(Door copy)
    {
        _room1 = copy._room1;
        _room2 = copy._room2;
        _isOpen = copy._isOpen;
    }

    public void SetRooms(Room room1, Room room2)
    {
        _room1 = room1;
        _room2 = room2;
    }

    public override void Enter()
    {
        if (_isOpen)
        {
            Message = "You pass through a door";
        }
        else
        {
            Message = "The door is closed!";
        }
        
    }

    public Room? OtherSideFrom (Room room)
    {
        return null;
    }

    public override MapSite Clone()
    {
        return new Door(this);
    }
}
