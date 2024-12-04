using JurassicParkSystem.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace JurassicParkSystem.JPConsole
{
    public class JPConsoleClass
    {
        //TODO: clean code 
        private bool hacked = false;
        private int failedAttempts = 0;
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        /// <summary>
        /// Load all the required controls and content
        /// </summary>
        /// <param name="desktopIcons"></param>
        public void LoadConsole(ItemsControl desktopIcons)
        {
            //Create console window
            CustomWindow consoleWindow = new CustomWindow();
            consoleWindow.Title = "Central Park Control Console";
            consoleWindow.Width = 300;
            consoleWindow.Height = 250;
            consoleWindow.Content = new JPConsoleContent();

            //Create console desktop icon
            CustomDesktopIcon consoleDesktopIcon = new CustomDesktopIcon();
            consoleDesktopIcon.Text = "Console";
            consoleDesktopIcon.Icon = new BitmapImage(new Uri(@"pack://application:,,,/Resources/Images/Console.png"));
            consoleDesktopIcon.Width = 75;
            consoleDesktopIcon.Height = 75;
            consoleDesktopIcon.CustomWindow = consoleWindow;

            //Add Desktop icon to canvas
            desktopIcons.Items.Add(consoleDesktopIcon);
        }

        /// <summary>
        /// Welcome message
        /// </summary>
        /// <param name="textBox">Textbox to show welcome message</param>
        public void Welcome(TextBox textBox)
        {
            //Resets all text
            textBox.Clear();

            //Reset all values
            failedAttempts = 0;
            cancellationTokenSource = new CancellationTokenSource();
            hacked = true; // would be false to begin with

            //Welcome message
            textBox.AppendText("Jurassic Park, System Security Interface\nVersion 1.0.0, Alpha E\nReady...\n>");
        }

        /// <summary>
        /// Prevent deletion of characters before and including >
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="e"></param>
        public void Console(TextBox textBox, KeyEventArgs e)
        {
            //Check if backspace key is pressed
            if (e.Key == Key.Back)
            {
                //Get the last time where > is shown
                int lastIndex = textBox.Text.LastIndexOf('>');
                if (textBox.SelectionStart <= lastIndex + 1)
                {
                    // Prevent backspace if cursor is at or before '>'
                    e.Handled = true; 
                }
            }
            else if(e.Key == Key.Enter)
            {
                //Commands
                Commands(textBox);
            }    
        }

        /// <summary>
        /// All commands
        /// </summary>
        /// <param name="textBox">Textbox to add outputs to</param>
        private async void Commands(TextBox textBox)
        {
            //Get all text after > in this case the command
            int lastIndex = textBox.Text.LastIndexOf('>');
            string command = textBox.Text.Substring(lastIndex + 1).Trim(); //Remove extra spaces

            //Commands
            if (command.Contains("security"))
            {
                //Output result
                textBox.AppendText($"\n{Security(command)}\n");
            }
            else
            {
                textBox.AppendText("\nCommand does not exist.");
            }

            //If user has 3 failed attempts show Nedry's phrase
            if (failedAttempts >= 3)
            {
                textBox.AppendText("\naccess: PERMISSION DENIED....and....\n");

                //Display Nedry's phrase 1000 times
                for (int i = 0; i < 2000; i++)
                {
                    //If the tasks is not cancelled
                    if (!cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        textBox.AppendText("YOU DIDN'T SAY THE MAGIC WORD!\n");
                        await Task.Delay(1000);
                    }
                }
            }

            //Set default start position
            textBox.AppendText("> ");
            textBox.CaretIndex = textBox.Text.Length;
        }

        /// <summary>
        /// Security commands
        /// </summary>
        /// <param name="command">Command to execute</param>
        /// <returns>Text displayed after command is inputted</returns>
        private string Security(string command)
        {
            //If the system is hacked
            if (hacked)
            {
                //Commands
                if (command == "access security")
                {
                    failedAttempts++;
                    return "access: PERMISSION DENIED.";
                }
                else if (command == "access security grid")
                {
                    failedAttempts++;
                    return "access: PERMISSION DENIED.";
                }
                else if (command == "access main security grid")
                {
                    failedAttempts++;
                    return "access: PERMISSION DENIED.";
                }
                else
                {
                    //Return error
                    return "Command does not exist.";
                }
            }
            else
            {
                //Default command actions
            }

            return command;
        }

        /// <summary>
        /// Adds ability to access the close button click event of custom window
        /// </summary>
        /// <param name="currentControl">The current control (Console content)</param>
        /// <param name="routedEventHandler">The button click event</param>
        public void CloseButton(UserControl currentControl, RoutedEventHandler routedEventHandler)
        {
            DependencyObject parent = currentControl;
            while (parent != null && !(parent is CustomWindow))
            {
                parent = VisualTreeHelper.GetParent(parent);
            }

            CustomWindow customWindow = parent as CustomWindow;
            if (customWindow != null)
            {
                customWindow.CloseButton.Click += routedEventHandler;
            }
        }

        /// <summary>
        /// Stops all async and await tasks in the class
        /// </summary>
        public void StopTasks()
        {
            cancellationTokenSource.Cancel();
        }
    }
}
