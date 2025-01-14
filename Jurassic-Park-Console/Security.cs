using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurassic_Park_Console
{
    public static class Security
    {
        /// <summary>
        /// Security command
        /// </summary>
        public static void SecuritySystem()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Security Details");
                Console.WriteLine("------------------------");

                Console.WriteLine($"Power: \t\t\t\t{Systems.Power}");
                Console.WriteLine($"Cameras: \t\t\t{Systems.Cameras}");
                Console.WriteLine($"Motion Sensors: \t\t{Systems.MotionSensors}");
                Console.WriteLine($"Perimeter Gates Locked: \t{Systems.PermimeterGatesLocked}");
                Console.WriteLine($"Enclosure Gates Locked: \t{Systems.EnclosureGatesLocked}");
                Console.WriteLine($"Perimeter Fences: \t\t{Systems.PermimeterFence}");
                Console.WriteLine($"Enclosure Fences: \t\t{Systems.EnclosureFences}");
                Console.WriteLine();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
