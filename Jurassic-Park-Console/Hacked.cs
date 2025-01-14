using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurassic_Park_Console
{
    public class Hacked
    {
        private static int failedAttempts = 0;

        /// <summary>
        /// Get status of if system is hacked
        /// </summary>
        /// <returns>The bool value of the system status</returns>
        public static bool GetStatus()
        {
            try
            {
                //Generate either 0 or 1 
                Random random = new Random();
                int status = random.Next(0, 2);

                if (status == 1)
                {
                    return true;
                }
                else if (status == 0)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Add a failed attempt and show nedrys error message one it reaches 3
        /// </summary>
        public static void FailedAttempt()
        {
            try
            {
                //Display error
                Console.WriteLine("Access. Permission Denied");

                //If failed attemps is 2 then show error
                if (failedAttempts == 2)
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
