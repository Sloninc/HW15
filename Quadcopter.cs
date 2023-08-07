using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15
{
    public class Quadcopter:IFlyingRobot,IChargeable
    {
        public Quadcopter(List<string> components, string notes)
        {
            _components = components;
            _notes = notes; 
        }

        List<string> _components; // = new() { "rotor1", "rotor2", "rotor3", "rotor4" };

        string _notes;


        public List<string> GetComponents()
        {
            return _components; 
        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Charged!");
        }

        public string GetInfo()
        {
            return _notes;
        }

        string IChargeable.GetInfo()
        {
            return "Battery: 94%";
        }

        string IFlyingRobot.GetInfo()
        {
            return "Total flight time: 48Hr10Min\t Total distance: 1 557 160m\t Total flight: 248";
        }

        //public string GetRobotType()
        //{
        //    return "I am a flying robot.";
        //}
    }
}
