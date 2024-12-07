using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace JurassicParkSystem.JPConsole
{
    public class JPConsoleCommandsClass
    {
        private bool hacked = false;
        private int failedAttempts = 0;
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public bool IsExecutingAsyncCommand { get; set; }

        /// <summary>
        /// Adds text to textbox with a new line
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="text"></param>
        private void AddText(TextBox textBox, string text)
        {
            textBox.AppendText($"\n{text}");
        }

        /// <summary>
        /// Sets the default values of variables and console text box
        /// </summary>
        /// <param name="textBox">Console textbox</param>
        public void DefaultValues(TextBox textBox)
        {
            hacked = false;
            failedAttempts = 0;
            textBox.Text = "Jurassic Park, System Security Interface\nVersion 1.0.0, Alpha E\nReady...\n>";
            cancellationTokenSource = new CancellationTokenSource();
        }

        /// <summary>
        /// All commands
        /// </summary>
        /// <param name="textBox">Textbox to add outputs to</param>
        public async void Commands(TextBox textBox)
        {
            //Get all text after > in this case the command
            int lastIndex = textBox.Text.LastIndexOf('>');
            string command = textBox.Text.Substring(lastIndex + 1).Trim(); //Remove extra spaces

            //Commands
            if (command.Contains("security"))
            {
                //Output result
                await Security(command, textBox);
            }
            else if (command.Contains("hack"))
            {
                hacked = true;
            }
            else
            {
                AddText(textBox, command);
            }
            
            //Set default start position
            AddText(textBox, "> ");
            textBox.CaretIndex = textBox.Text.Length;       
        }

        /// <summary>
        /// Security commands
        /// </summary>
        /// <param name="command">Command to execute</param>
        /// <returns>Text displayed after command is inputted</returns>
        private async Task Security(string command, TextBox textBox)
        {
            //If the system is hacked
            if (hacked)
            {
                //If failed attempts is less than 3
                if (failedAttempts < 3)
                {
                    //Commands
                    switch (command)
                    {
                        case "access security":
                            break;

                        case "access security grid":
                            break;

                        case "access main security grid":
                            break;
                    }

                    AddText(textBox, "access: PERMISSION DENIED.");
                    failedAttempts++;
                }
                else if (failedAttempts >= 2)
                {
                    IsExecutingAsyncCommand = true;

                    AddText(textBox, "access: PERMISSION DENIED....and....");

                    //Display Nedry's magic phrase 1000 times
                    for (int i = 0; i < 2000; i++)
                    {
                        //If the tasks is not cancelled
                        if (!cancellationTokenSource.Token.IsCancellationRequested)
                        {
                            AddText(textBox, "YOU DIDN'T SAY THE MAGIC WORD!");
                            await Task.Delay(50);
                        }
                    }

                    IsExecutingAsyncCommand = false;
                }
            }

            else
            {
                //Commands
                switch (command)
                {
                    case "access security":
                        AddText(textBox, "SECURITY");
                        AddText(textBox, "Location\t\tStatus");
                        AddText(textBox, "Visitor Centre\tSecure");
                        AddText(textBox, "Raptors\t\tSecure");
                        AddText(textBox, "T-Tex Paddock\tSecure");
                        break;

                    case "access security grid":
                        break;

                    case "access main security grid":
                        break;

                    default:
                        AddText(textBox, "Command does not exist");
                        break;
                }

                // Set default start position (this is not printed while magic words are being displayed)
                if (failedAttempts < 3 || failedAttempts >= 2)
                {
                    AddText(textBox, "> ");
                    textBox.CaretIndex = textBox.Text.Length;
                }
            }
        }

        /// <summary>
        /// Stops all async in commands
        /// </summary>
        public void StopTasks()
        {
            cancellationTokenSource.Cancel();
        }
    }
}
