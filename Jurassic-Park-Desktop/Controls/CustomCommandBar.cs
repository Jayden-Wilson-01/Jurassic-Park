using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jurassic_Park_Desktop.Controls
{
    public partial class CustomCommandBar : UserControl
    {
        public CustomCommandBar()
        {
            InitializeComponent();
        }

        private void CommandBarButton_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Label))
            {
                Label button = (Label)sender;
                MessageBox.Show(button.Text);
            }
        }

        private void CommandBarButton_Enter(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Label))
            {
                Label commandBarButton = (Label)sender;
                commandBarButton.BackColor = Color.FromArgb(194, 196, 200);
            }
        }

        private void CommandBarButton_Leave(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Label))
            {
                Label commandBarButton = (Label)sender;
                commandBarButton.BackColor = Color.FromArgb(204, 206, 210);
            }
        }
    }
}
