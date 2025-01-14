using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurassic_Park_Console
{
    public static class Systems
    {
        public static bool Power { get; set; } = true;
        public static bool Cameras { get; set; } = true;
        public static bool MotionSensors { get; set; } = true;
        public static bool PermimeterGatesLocked { get; set; } = true;
        public static bool EnclosureGatesLocked { get; set; } = true;
        public static bool PermimeterFence { get; set; } = true;
        public static bool EnclosureFences  { get; set; } = true;
    }
}
