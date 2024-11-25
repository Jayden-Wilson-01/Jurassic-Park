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
    /// Interaction logic for CustomWindow.xaml
    /// </summary>
    public partial class CustomWindow : UserControl
    {
        /// <summary>
        /// Title of the window
        /// </summary>
        public string Title
        {
            set { WindowTitle.Text = value; }
        }

        /// <summary>
        /// Allow or prevent window from being minimised
        /// </summary>
        public bool IsMinimisable
        {
            set { MinimiseButton.IsEnabled = value; }
        }

        /// <summary>
        /// Allow or prevent window from being maximised
        /// </summary>
        public bool IsMaximisable
        {
            set { MaximiseButton.IsEnabled = value; }
        }

        /// <summary>
        /// Set content of the window
        /// </summary>
        public UserControl Content
        {
            set { ContentArea.Children.Add(value); }
        }

        public CustomWindow()
        {
            InitializeComponent();
        }

        #region Events
        /// <summary>
        /// Minimise the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimiseButton_Click(object sender, RoutedEventArgs e)
        {
            //Make window hidden
            this.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Maximise the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaximiseButton_Click(object sender, RoutedEventArgs e)
        {
            //Get canvas
            Canvas canvas = (Canvas)this.Parent;

            //Collapse window if already maximised
            if (this.ActualWidth == canvas.ActualWidth && this.ActualHeight == canvas.ActualHeight)
            {
                this.Width = 500;
                this.Height = 400;
            }
            //Maximise window if already collapsed
            else
            {
                //Set window size and location
                this.Width = canvas.ActualWidth;
                this.Height = canvas.ActualHeight;
                Canvas.SetLeft(this, 0);
                Canvas.SetTop(this, 0);

                foreach (UIElement customWindow in canvas.Children)
                {
                    if (customWindow != this)
                    {
                        //Send all other windows to back
                        Panel.SetZIndex(customWindow, 0);
                    }
                    else
                    {
                        //Send current window to front
                        Panel.SetZIndex(this, 1);
                    }
                }
            }
        }

        /// <summary>
        /// Close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            //Remove window from canvas
            Canvas canvas = (Canvas)this.Parent;
            canvas.Children.Remove(this);
        }

        /// <summary>
        /// Move the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Titlebar_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                {
                    //Get canvas
                    Canvas canvas = (Canvas)this.Parent;

                    //Collapse window if already maximised
                    if (this.ActualWidth == canvas.ActualWidth && this.ActualHeight == canvas.ActualHeight)
                    {
                        this.Width = 500;
                        this.Height = 400;
                    }

                    //Initiate drag drop for window 
                    DragDrop.DoDragDrop(this, new DataObject(DataFormats.Serializable, this), DragDropEffects.Move);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
