﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLib;

public class EnchantedRoom : Room
{
    public EnchantedRoom(int roomNumber) : base(roomNumber)
    {
    }

    public override void Enter()
    {
        Message = "You entered an enchanted room";
    }
}