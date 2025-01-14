using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurassic_Park_Console
{
    public static class Theme
    {
        /// <summary>
        /// Bool to check if theme is set if so it cant be changed
        /// </summary>
        private static bool isThemeSet = false;

        /// <summary>
        /// method to change the theme of the 
        /// </summary>
        /// <param name="background"></param>
        /// <param name="foreground"></param>
        public static void SetTheme(ConsoleColor foreground = ConsoleColor.White, ConsoleColor background = ConsoleColor.Black)
        {
            try
            {
                //Check if theme is already true 
                if (isThemeSet == true)
                {
                    //Throw error
                    throw new InvalidOperationException("Can only set console theme once.");
                }
                else
                {
                    //Clear console
                    Console.Clear();

                    //Set console colours
                    Console.ForegroundColor = foreground;
                    Console.BackgroundColor = background;

                    //Set theme status
                    isThemeSet = true;
                }
            }
            catch (Exception)
            { 
                throw;
            }
        }
    }
}
