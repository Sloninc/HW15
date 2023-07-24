using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    public interface IRobot
    {
        string GetInfo();

        List<string> GetComponents();

        public string GetRobotType()
        {
            return "I am a simple robot.";
        }
    }
}
