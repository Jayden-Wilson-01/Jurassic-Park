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

namespace JurassicParkSystem.JPDesktop
{
    /// <summary>
    /// Interaction logic for JPDesktopContent.xaml
    /// </summary>
    public partial class JPDesktopContent : UserControl
    {
        JPDesktopClass JPDesktopClass = new JPDesktopClass();

        public JPDesktopContent()
        {
            InitializeComponent();
            JPDesktopClass.LoadDesktop(DesktopIcons);
        }

        private void Canvas_DragOver(object sender, DragEventArgs e)
        {
            JPDesktopClass.DragOver(Canvas, e);
        }

        private void Canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            JPDesktopClass.Resized(Canvas);
        }
    }
}
