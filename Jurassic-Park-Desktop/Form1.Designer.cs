namespace Jurassic_Park_Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customButton1 = new Jurassic_Park_Desktop.Controls.CustomButton();
            customButton2 = new Jurassic_Park_Desktop.Controls.CustomButton();
            customCommandBar1 = new Jurassic_Park_Desktop.Controls.CustomCommandBar();
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.Image = Properties.Resources.Console;
            customButton1.ImageLayout = ImageLayout.Stretch;
            customButton1.Location = new Point(173, 13);
            customButton1.Margin = new Padding(0);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(124, 130);
            customButton1.TabIndex = 0;
            customButton1.Title = "Console";
            // 
            // customButton2
            // 
            customButton2.Image = Properties.Resources.System;
            customButton2.ImageLayout = ImageLayout.Stretch;
            customButton2.Location = new Point(297, 13);
            customButton2.Margin = new Padding(0);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(124, 130);
            customButton2.TabIndex = 1;
            customButton2.Title = "System";
            // 
            // customCommandBar1
            // 
            customCommandBar1.Location = new Point(13, 13);
            customCommandBar1.Margin = new Padding(0, 0, 10, 0);
            customCommandBar1.Name = "customCommandBar1";
            customCommandBar1.Size = new Size(150, 203);
            customCommandBar1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(800, 450);
            Controls.Add(customCommandBar1);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Name = "Form1";
            Padding = new Padding(10);
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Controls.CustomButton customButton1;
        private Controls.CustomButton customButton2;
        private Controls.CustomCommandBar customCommandBar1;
    }
}
