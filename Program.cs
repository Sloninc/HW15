namespace HW15
{
    internal class Program
    {
        static void Main()
        {
            Quadcopter quadcopter = new Quadcopter(new() { "rotor1", "rotor2", "rotor3", "rotor4" }, "Камера 4К, время работы 27 минут");
            quadcopter.Charge();
            IFlyingRobot flyingRobot = quadcopter;
            IChargeable chargeable = quadcopter;
            Console.WriteLine(flyingRobot.GetRobotType()); //вызов метода дефолтной реализации
            Console.WriteLine(quadcopter.GetInfo());
            Console.WriteLine(chargeable.GetInfo());
            Console.WriteLine(flyingRobot.GetInfo());
            Console.Write($"Компоненты робота {nameof(quadcopter)}: ");
            Console.WriteLine(quadcopter.GetComponents().Aggregate((a,b)=>a+" "+b));
            Console.ReadLine();
        }
    }
}
