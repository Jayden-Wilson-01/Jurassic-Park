using JurassicParkSystem.JPDesktop;
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
using System.Windows.Shapes;

namespace JurassicParkSystem.JPSystem
{
    /// <summary>
    /// Interaction logic for JPSystemWindow.xaml
    /// </summary>
    public partial class JPSystemWindow : Window
    {
        public JPSystemWindow()
        {
            InitializeComponent();

            JPSystemClass jPSystemClass = new JPSystemClass();
            jPSystemClass.LoadSystem(this);
        }
    }
}
