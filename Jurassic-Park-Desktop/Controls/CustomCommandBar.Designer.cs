namespace Jurassic_Park_Desktop.Controls
{
    partial class CustomCommandBar
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
            customPanel1 = new CustomPanel();
            DesktopPanel = new Panel();
            desktopLabel = new Label();
            selectedPanel = new Panel();
            selectedLabel = new Label();
            findPanel = new Panel();
            findLabel = new Label();
            systemPanel = new Panel();
            systemLabel = new Label();
            helpPanel = new Panel();
            helpLabel = new Label();
            DesktopPanel.SuspendLayout();
            selectedPanel.SuspendLayout();
            findPanel.SuspendLayout();
            systemPanel.SuspendLayout();
            helpPanel.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.Dock = DockStyle.Fill;
            customPanel1.Location = new Point(0, 0);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(150, 203);
            customPanel1.TabIndex = 0;
            // 
            // DesktopPanel
            // 
            DesktopPanel.BorderStyle = BorderStyle.FixedSingle;
            DesktopPanel.Controls.Add(desktopLabel);
            DesktopPanel.Location = new Point(6, 6);
            DesktopPanel.Margin = new Padding(6, 6, 6, 0);
            DesktopPanel.Name = "DesktopPanel";
            DesktopPanel.Size = new Size(138, 39);
            DesktopPanel.TabIndex = 4;
            // 
            // desktopLabel
            // 
            desktopLabel.BackColor = Color.FromArgb(204, 206, 210);
            desktopLabel.Dock = DockStyle.Fill;
            desktopLabel.Font = new Font("MS PGothic", 11.25F, FontStyle.Bold | FontStyle.Italic);
            desktopLabel.Location = new Point(0, 0);
            desktopLabel.Name = "desktopLabel";
            desktopLabel.Padding = new Padding(7);
            desktopLabel.Size = new Size(136, 37);
            desktopLabel.TabIndex = 0;
            desktopLabel.Text = "Desktop";
            desktopLabel.TextAlign = ContentAlignment.MiddleCenter;
            desktopLabel.Click += CommandBarButton_Click;
            desktopLabel.MouseEnter += CommandBarButton_Enter;
            desktopLabel.MouseLeave += CommandBarButton_Leave;
            // 
            // selectedPanel
            // 
            selectedPanel.BorderStyle = BorderStyle.FixedSingle;
            selectedPanel.Controls.Add(selectedLabel);
            selectedPanel.Location = new Point(6, 44);
            selectedPanel.Margin = new Padding(6, 0, 6, 0);
            selectedPanel.Name = "selectedPanel";
            selectedPanel.Size = new Size(138, 39);
            selectedPanel.TabIndex = 5;
            // 
            // selectedLabel
            // 
            selectedLabel.BackColor = Color.FromArgb(204, 206, 210);
            selectedLabel.Dock = DockStyle.Fill;
            selectedLabel.Font = new Font("MS PGothic", 11.25F, FontStyle.Bold | FontStyle.Italic);
            selectedLabel.Location = new Point(0, 0);
            selectedLabel.Name = "selectedLabel";
            selectedLabel.Padding = new Padding(7);
            selectedLabel.Size = new Size(136, 37);
            selectedLabel.TabIndex = 0;
            selectedLabel.Text = "Selected";
            selectedLabel.TextAlign = ContentAlignment.MiddleCenter;
            selectedLabel.Click += CommandBarButton_Click;
            selectedLabel.MouseEnter += CommandBarButton_Enter;
            selectedLabel.MouseLeave += CommandBarButton_Leave;
            // 
            // findPanel
            // 
            findPanel.BorderStyle = BorderStyle.FixedSingle;
            findPanel.Controls.Add(findLabel);
            findPanel.Location = new Point(6, 82);
            findPanel.Margin = new Padding(6, 0, 6, 0);
            findPanel.Name = "findPanel";
            findPanel.Size = new Size(138, 39);
            findPanel.TabIndex = 6;
            // 
            // findLabel
            // 
            findLabel.BackColor = Color.FromArgb(204, 206, 210);
            findLabel.Dock = DockStyle.Fill;
            findLabel.Font = new Font("MS PGothic", 11.25F, FontStyle.Bold | FontStyle.Italic);
            findLabel.Location = new Point(0, 0);
            findLabel.Name = "findLabel";
            findLabel.Padding = new Padding(7);
            findLabel.Size = new Size(136, 37);
            findLabel.TabIndex = 0;
            findLabel.Text = "Find";
            findLabel.TextAlign = ContentAlignment.MiddleCenter;
            findLabel.Click += CommandBarButton_Click;
            findLabel.MouseEnter += CommandBarButton_Enter;
            findLabel.MouseLeave += CommandBarButton_Leave;
            // 
            // systemPanel
            // 
            systemPanel.BorderStyle = BorderStyle.FixedSingle;
            systemPanel.Controls.Add(systemLabel);
            systemPanel.Location = new Point(6, 120);
            systemPanel.Margin = new Padding(6, 0, 6, 0);
            systemPanel.Name = "systemPanel";
            systemPanel.Size = new Size(138, 39);
            systemPanel.TabIndex = 7;
            // 
            // systemLabel
            // 
            systemLabel.BackColor = Color.FromArgb(204, 206, 210);
            systemLabel.Dock = DockStyle.Fill;
            systemLabel.Font = new Font("MS PGothic", 11.25F, FontStyle.Bold | FontStyle.Italic);
            systemLabel.Location = new Point(0, 0);
            systemLabel.Name = "systemLabel";
            systemLabel.Padding = new Padding(7);
            systemLabel.Size = new Size(136, 37);
            systemLabel.TabIndex = 0;
            systemLabel.Text = "System";
            systemLabel.TextAlign = ContentAlignment.MiddleCenter;
            systemLabel.Click += CommandBarButton_Click;
            systemLabel.MouseEnter += CommandBarButton_Enter;
            systemLabel.MouseLeave += CommandBarButton_Leave;
            // 
            // helpPanel
            // 
            helpPanel.BorderStyle = BorderStyle.FixedSingle;
            helpPanel.Controls.Add(helpLabel);
            helpPanel.Location = new Point(6, 158);
            helpPanel.Margin = new Padding(6, 0, 6, 0);
            helpPanel.Name = "helpPanel";
            helpPanel.Size = new Size(138, 39);
            helpPanel.TabIndex = 8;
            // 
            // helpLabel
            // 
            helpLabel.BackColor = Color.FromArgb(204, 206, 210);
            helpLabel.Dock = DockStyle.Fill;
            helpLabel.Font = new Font("MS PGothic", 11.25F, FontStyle.Bold | FontStyle.Italic);
            helpLabel.Location = new Point(0, 0);
            helpLabel.Name = "helpLabel";
            helpLabel.Padding = new Padding(7);
            helpLabel.Size = new Size(136, 37);
            helpLabel.TabIndex = 0;
            helpLabel.Text = "Help";
            helpLabel.TextAlign = ContentAlignment.MiddleCenter;
            helpLabel.Click += CommandBarButton_Click;
            helpLabel.MouseEnter += CommandBarButton_Enter;
            helpLabel.MouseLeave += CommandBarButton_Leave;
            // 
            // CustomCommandBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(helpPanel);
            Controls.Add(systemPanel);
            Controls.Add(findPanel);
            Controls.Add(selectedPanel);
            Controls.Add(DesktopPanel);
            Controls.Add(customPanel1);
            Name = "CustomCommandBar";
            Size = new Size(150, 203);
            DesktopPanel.ResumeLayout(false);
            selectedPanel.ResumeLayout(false);
            findPanel.ResumeLayout(false);
            systemPanel.ResumeLayout(false);
            helpPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomPanel customPanel1;
        private Panel DesktopPanel;
        private Label desktopLabel;
        private Panel selectedPanel;
        private Label selectedLabel;
        private Panel findPanel;
        private Label findLabel;
        private Panel systemPanel;
        private Label systemLabel;
        private Panel helpPanel;
        private Label helpLabel;
    }
}
