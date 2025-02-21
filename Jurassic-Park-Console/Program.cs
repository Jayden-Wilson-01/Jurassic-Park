using Jurassic_Park_Console;

namespace JurassicParkConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initial theme
            Theme.SetTheme(ConsoleColor.Green);

            //Initial welcome text
            Console.WriteLine("Jurassic Park, System Security Interface\nVersion 4.0.5, Alpha E\nReady...");

            //Hacked status
            Hacked.GenerateHackTimer();

            while (true)
            {
                Commands.GetInput();
            }
        }
    }
}
