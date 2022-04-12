using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib;

public class Wall : MapSite
{
    public override void Enter()
    {
        Message = "OUCH! You bump into a wall!";
    }
}
