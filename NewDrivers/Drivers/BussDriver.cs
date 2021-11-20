using System;
using System.Collections.Generic;
using System.Text;

namespace Drivers
{
    class BussDriver : Driver
    {
        public void BussDriveHas()
        {
            Console.Write("and a buss");
            BussdriverGoal();
        }
        internal void BussdriverGoal()
        {
            Console.WriteLine("Goal: ");
            Console.Write("to transport people");
        }
    }
}
