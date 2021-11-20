using System;
using System.Collections.Generic;
using System.Text;

namespace Drivers
{
    class Biker : Driver
    {
        public void MotorBikerHas()
        {
            Console.WriteLine("and a motorbike");
            MotorBikerGoal();
        }
        private void MotorBikerGoal()
        {
            Console.Write("Goal: ");
            Console.WriteLine("Wants a bikergang");
        }
    }
}
