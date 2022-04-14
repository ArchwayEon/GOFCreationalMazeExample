using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib;

public class EnchantedDoor : Door
{
    public EnchantedDoor(Room room1, Room room2) : base(room1, room2)
    {
    }

    public EnchantedDoor()
    {
    }

    public EnchantedDoor(EnchantedDoor copy) : base(copy)
    {
    }

    public override void Enter()
    {
        base.Enter();
        if (!_isOpen)
        {
            Message += "\nSay the spell to open the door!";
        }
    }
}
