using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using JurassicParkSystem.JPConsole;
using JurassicParkSystem.Controls;

namespace JurassicParkSystem.JPDesktop
{
    class JPDesktopClass
    {
        /// <summary>
        /// Load everything on the desktop
        /// </summary>
        /// <param name="desktopIcons"></param>
        public void LoadDesktop(ItemsControl desktopIcons)
        {
            JPConsoleClass jPConsoleClass = new JPConsoleClass();
            jPConsoleClass.LoadConsole(desktopIcons);
        }


        /// <summary>
        /// Makes controls children the same size as control if children are maximised
        /// </summary>
        public void Resized(Canvas canvas)
        {
            try
            {
                foreach(var control in canvas.Children)
                {
                    if (control is CustomWindow customWindow)
                    {
                        //Resize custom window to fill parent if custom window is maximized
                        if (customWindow.IsMaximized == true)
                        {
                            customWindow.Width = canvas.ActualWidth;
                            customWindow.Height = canvas.ActualHeight;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Handles the drag over event for the canvas so children controls can be moved in real time
        /// </summary>
        /// <param name="canvas"></param>
        /// <param name="e"></param>
        public void DragOver(Canvas canvas, DragEventArgs e)
        {
            //Get data of event
            object data = e.Data.GetData(DataFormats.Serializable);

            try
            {
                if (data is UserControl currentCustomWindow)
                {
                    //Get position of cursor relative to canvas
                    Point dropPosition = e.GetPosition(canvas);

                    //Set location of window
                    Canvas.SetLeft(currentCustomWindow, dropPosition.X - currentCustomWindow.ActualWidth / 2);
                    Canvas.SetTop(currentCustomWindow, dropPosition.Y - 12);

                    foreach (UIElement customWindow in canvas.Children)
                    {
                        if (customWindow != currentCustomWindow)
                        {
                            //Send all other windows to back
                            Panel.SetZIndex(customWindow, 0);
                        }
                        else
                        {
                            //Send current window to front
                            Panel.SetZIndex(currentCustomWindow, 1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
