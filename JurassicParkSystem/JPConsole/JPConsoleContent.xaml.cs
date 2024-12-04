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

namespace JurassicParkSystem.JPConsole
{
    /// <summary>
    /// Interaction logic for ConsoleContent.xaml
    /// </summary>
    public partial class JPConsoleContent : UserControl
    {
        JPConsoleClass JPConsoleClass = new JPConsoleClass();

        public JPConsoleContent()
        {
            InitializeComponent();

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            JPConsoleClass.StopTasks();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            JPConsoleClass.Welcome(ConsoleTextBox);
            JPConsoleClass.CloseButton(this, CloseButton_Click);
        }

        private void ConsoleTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            JPConsoleClass.Console(ConsoleTextBox, e);
        }
    }
}
