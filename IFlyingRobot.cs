﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    interface IFlyingRobot:IRobot
    {
        string GetInfo();
        string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }
}
