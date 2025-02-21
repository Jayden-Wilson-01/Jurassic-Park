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

                Console.WriteLine($"Power: \t\t\t\t{Systems.RandomSystemValue(Systems.Power)}");
                Console.WriteLine($"Cameras: \t\t\t{Systems.RandomSystemValue(Systems.Cameras)}");
                Console.WriteLine($"Motion Sensors: \t\t{Systems.RandomSystemValue(Systems.MotionSensors)}");
                Console.WriteLine($"Perimeter Gates Locked: \t{Systems.RandomSystemValue(Systems.PermimeterGatesLocked)}");
                Console.WriteLine($"Enclosure Gates Locked: \t{Systems.RandomSystemValue(Systems.EnclosureGatesLocked)}");
                Console.WriteLine($"Perimeter Fence: \t\t{Systems.RandomSystemValue(Systems.PermimeterFence)}");
                Console.WriteLine($"Enclosure Fences: \t\t{Systems.RandomSystemValue(Systems.EnclosureFences)}");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
