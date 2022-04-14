using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib;

public class Wall : MapSite
{
    public Wall()
    {
    }

    public Wall(Wall copy) : base(copy)
    {
    }

    public override MapSite Clone()
    {
        return new Wall(this);
    }

    public override void Enter()
    {
        Message = "OUCH! You bump into a wall!";
    }
}
