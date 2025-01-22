using System.Diagnostics;
using System.Timers;

namespace Jurassic_Park_Console
{
    public class Hacked
    {
        //Failed attempts counter
        private static int failedAttempts = 0;

        //Create new stopwatch
        private static System.Timers.Timer hackTimer = new System.Timers.Timer();

        /// <summary>
        /// Returns if system is hacked
        /// </summary>
        public static bool isHacked { get; private set; }

        /// <summary>
        /// Get status of if system is hacked
        /// </summary>
        /// <returns>The bool value of the system status</returns>
        public static void GenerateHackTimer()
        {
            try
            {
                //Generate either 0 or 1 
                Random random = new Random();
                int interval = random.Next(60000, 300000);

                hackTimer.Interval = interval;
                hackTimer.Elapsed += HackTimer_Elapsed;
                hackTimer.Enabled = true;
               
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Execute the hack once the random time is elapsed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void HackTimer_Elapsed(object? sender, ElapsedEventArgs e)
        {
             isHacked = true;
             hackTimer.Enabled = false;
        }

        /// <summary>
        /// Add a failed attempt and show nedrys error message one it reaches 3
        /// </summary>
        public static void FailedAttempt()
        {
            try
            {
                failedAttempts++;

                //Display error
                Console.WriteLine("Access. Permission Denied");

                //If failed attemps is 3 then show error
                if (failedAttempts == 3)
                {
                    Console.WriteLine("Permission Denied....And...");

                    while (true)
                    {
                        Console.WriteLine("YOU DIDN'T SAY THE MAGIC WORD!");
                        Thread.Sleep(100);
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        
    }
}
