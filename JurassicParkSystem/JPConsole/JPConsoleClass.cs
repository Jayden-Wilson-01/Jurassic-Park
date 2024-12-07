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
        private JPConsoleCommandsClass JPConsoleCommandsClass = new JPConsoleCommandsClass();


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
            consoleWindow.Height = 300;
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
        /// Sets the default values of variables and console text box
        /// </summary>
        /// <param name="textBox"></param>
        public void DefaultValues(TextBox textBox)
        {
            JPConsoleCommandsClass.DefaultValues(textBox);
        }

        /// <summary>
        /// Start of the console
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
            else if (e.Key == Key.Enter)
            {
                if (!JPConsoleCommandsClass.IsExecutingAsyncCommand)
                {
                    //Commands
                    JPConsoleCommandsClass.Commands(textBox);
                }
            } 
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
        /// Stops all async and await tasks in the comamnds class
        /// </summary>
        public void StopTasks()
        {
            if (JPConsoleCommandsClass.IsExecutingAsyncCommand)
            {
                JPConsoleCommandsClass.StopTasks();
            }
        }
    }
}
