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
    public partial class CustomButton : UserControl
    {
        /// <summary>
        /// Set title of the button
        /// </summary>
        [Browsable(true)]
        [Category("Custom Properties")]
        public string? Title { get { return titleLabel.Text; } set { titleLabel.Text = value; } }

        /// <summary>
        /// Set image of the button
        /// </summary>
        [Browsable(true)]
        [Category("Custom Properties")]
        public Image? Image { get { return pictureBox.BackgroundImage; } set { pictureBox.BackgroundImage = value; } }

        /// <summary>
        /// Set image layout of the button
        /// </summary>
        [Browsable(true)]
        [Category("Custom Properties")]
        public ImageLayout ImageLayout { get { return pictureBox.BackgroundImageLayout; } set { pictureBox.BackgroundImageLayout = value; } }

        public CustomButton()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, MouseEventArgs e)
        {
            if (sender.GetType() == typeof(Label))
            {
                Label button = (Label)sender;
                MessageBox.Show(button.Text);
            }
        }

        private void Button_Enter(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Label))
            {
                Label button = (Label)sender;
                button.BackColor = Color.FromArgb(194, 196, 200);
            }
        }

        private void Button_Leave(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Label))
            {
                Label button = (Label)sender;
                button.BackColor = Color.FromArgb(204, 206, 210);
            }
        }
    }
}
