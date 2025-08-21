namespace Jurassic_Park_Desktop.Controls
{
    partial class CustomPanel
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
            OutsideBorder = new Panel();
            InsideBorder = new Panel();
            OutsideBorder.SuspendLayout();
            SuspendLayout();
            // 
            // OutsideBorder
            // 
            OutsideBorder.BackColor = Color.FromArgb(204, 206, 210);
            OutsideBorder.BorderStyle = BorderStyle.FixedSingle;
            OutsideBorder.Controls.Add(InsideBorder);
            OutsideBorder.Dock = DockStyle.Fill;
            OutsideBorder.Location = new Point(0, 0);
            OutsideBorder.Name = "OutsideBorder";
            OutsideBorder.Padding = new Padding(5);
            OutsideBorder.Size = new Size(150, 150);
            OutsideBorder.TabIndex = 0;
            // 
            // InsideBorder
            // 
            InsideBorder.BackColor = Color.FromArgb(170, 169, 167);
            InsideBorder.BorderStyle = BorderStyle.FixedSingle;
            InsideBorder.Dock = DockStyle.Fill;
            InsideBorder.Location = new Point(5, 5);
            InsideBorder.Name = "InsideBorder";
            InsideBorder.Size = new Size(138, 138);
            InsideBorder.TabIndex = 0;
            // 
            // CustomButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OutsideBorder);
            Name = "CustomButton";
            OutsideBorder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel OutsideBorder;
        private Panel InsideBorder;
    }
}
