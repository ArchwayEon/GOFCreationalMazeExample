using MazeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeAbstractFactory;

public class EnchantedMazeFactory : MazeFactory
{
    public override Room MakeRoom(int roomNumber)
    {
        return new EnchantedRoom(roomNumber);
    }

    public override Door MakeDoor(Room room1, Room room2)
    {
        return new EnchantedDoor(room1, room2);
    }
}
