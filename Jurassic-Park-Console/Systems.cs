using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurassic_Park_Console
{
    public static class Systems
    {
        public static bool Power;
        public static bool Cameras;
        public static bool MotionSensors;
        public static bool PermimeterGatesLocked;
        public static bool EnclosureGatesLocked;
        public static bool PermimeterFence;
        public static bool EnclosureFences;

        /// <summary>
        /// Generate a random value for a target system
        /// </summary>
        /// <param name="systemName"></param>
        /// <returns></returns>
        public static bool RandomSystemValue(bool systemName)
        {
            //Random number
            Random randomValue = new Random();

            //If random value is 1 then the system is true
            if(randomValue.Next(0,2) == 1)
            {
                systemName = true;
                return true;
            }
            else
            {
                systemName = true;
                return false;
            }
        }
    }
}
