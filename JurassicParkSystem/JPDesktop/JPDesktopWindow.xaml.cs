using JurassicParkSystem.JPConsole;
using JurassicParkSystem.JPSystem;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JurassicParkSystem.JPDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class JPDesktopWindow : Window
    {
        public JPDesktopWindow()
        {
            InitializeComponent();
            JPConsoleClass.LoadConsole(DesktopIcons);
        }

        #region Events
        /// <summary>
        /// Move window with cursor then drop when done in canvas.
        /// </summary>
        private void Canvas_DragOver(object sender, DragEventArgs e)
        {
            //Get data of event
            object data = e.Data.GetData(DataFormats.Serializable);

            try
            {
                if (data is UserControl currentCustomWindow)
                {
                    //Get position of cursor relative to canvas
                    Point dropPosition = e.GetPosition(Canvas);

                    //Set location of window
                    Canvas.SetLeft(currentCustomWindow, dropPosition.X - currentCustomWindow.ActualWidth / 2);
                    Canvas.SetTop(currentCustomWindow, dropPosition.Y - 12);

                    foreach (UIElement customWindow in Canvas.Children)
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
        #endregion
    }
}