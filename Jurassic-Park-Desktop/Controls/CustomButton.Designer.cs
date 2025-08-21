namespace Jurassic_Park_Desktop.Controls
{
    partial class CustomButton
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customPanel = new CustomPanel();
            titleLabel = new Label();
            pictureBox = new PictureBox();
            titlePanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            titlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel
            // 
            customPanel.Location = new Point(0, 0);
            customPanel.Name = "customPanel";
            customPanel.Size = new Size(124, 93);
            customPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.FromArgb(204, 206, 210);
            titleLabel.Dock = DockStyle.Fill;
            titleLabel.Font = new Font("MS UI Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Padding = new Padding(7);
            titleLabel.Size = new Size(122, 36);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Console";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.MouseClick += Button_Click;
            titleLabel.MouseEnter += Button_Enter;
            titleLabel.MouseLeave += Button_Leave;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(7, 7);
            pictureBox.Margin = new Padding(7);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(110, 79);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // titlePanel
            // 
            titlePanel.BorderStyle = BorderStyle.FixedSingle;
            titlePanel.Controls.Add(titleLabel);
            titlePanel.Location = new Point(0, 92);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(124, 38);
            titlePanel.TabIndex = 3;
            // 
            // CustomButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(titlePanel);
            Controls.Add(pictureBox);
            Controls.Add(customPanel);
            Name = "CustomButton";
            Size = new Size(124, 130);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            titlePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomPanel customPanel;
        private Label titleLabel;
        private PictureBox pictureBox;
        private Panel titlePanel;
    }
}
