using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurassic_Park_Console
{
    public static class Commands
    {
        /// <summary>
        /// Dictionary to store all possible commands
        /// </summary>
        private static Dictionary<string, Action> commands = new Dictionary<string, Action>()
        {
            {"access security", Security.SecuritySystem},
            {"access main security", Security.SecuritySystem},
            {"access main security grid", Security.SecuritySystem},
        };

        /// <summary>
        /// Allow user to input command
        /// </summary>
        /// <param name="hacked"></param>
        public static void GetInput()
        {
            try
            {
                Console.Write("> ");
                string command = Console.ReadLine().ToLower();

                if (Hacked.isHacked)
                {
                    //Display error
                    Hacked.FailedAttempt();
                }
                else
                {
                    //Check if command exists
                    if (commands.ContainsKey(command))
                    {
                        //Run the associated method
                        commands[command].Invoke();
                    }
                    else
                    {
                        //Display error
                        Console.WriteLine("Command does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
