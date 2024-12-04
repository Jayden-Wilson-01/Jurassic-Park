using JurassicParkSystem.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JurassicParkSystem.Controls
{
    /// <summary>
    /// Interaction logic for DesktopIcon.xaml
    /// </summary>
    public partial class CustomDesktopIcon : UserControl
    {
        /// <summary>
        /// Set image of desktop icon
        /// </summary>
        public ImageSource Icon
        {
            set { IconImage.Source = value; }
        }

        /// <summary>
        /// Set text of desktop icon
        /// </summary>
        public string Text
        {
            set { IconText.Text = value; } 
        }

        /// <summary>
        /// Set associated window with desktop icon
        /// </summary>
        public CustomWindow CustomWindow { get; set; }

        public CustomDesktopIcon()
        {
            InitializeComponent();
        }

        #region Events
        /// <summary>
        /// Opens a specified window when double clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //Get item control
            ItemsControl itemsControl = (ItemsControl)this.Parent;

            //Get canvas control 
            Canvas canvas = (Canvas)itemsControl.Parent;

            if (!canvas.Children.Contains(CustomWindow))
            {
                
                //Add custom window to canvas
                canvas.Children.Add(CustomWindow);
            }
        }
        #endregion
    }
}
