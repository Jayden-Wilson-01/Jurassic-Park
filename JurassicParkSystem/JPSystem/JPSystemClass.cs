using JurassicParkSystem.JPDesktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JurassicParkSystem.JPSystem
{
    class JPSystemClass
    {
        /// <summary>
        /// Load entire JP system
        /// </summary>
        /// <param name="window"></param>
        public void LoadSystem(Window window)
        {
            JPDesktopContent jPDesktopContent = new JPDesktopContent();
            window.Content = jPDesktopContent;
        }
    }
}
