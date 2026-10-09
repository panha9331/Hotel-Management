namespace Hotel_Management
{
    partial class Main
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.TabStandardProfile;
            kryptonPanel1.Size = new Size(240, 774);
            kryptonPanel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(240, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.TabDock;
            kryptonPanel2.Size = new Size(1202, 74);
            kryptonPanel2.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 774);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1348, 798);
            Name = "Main";
            Text = "MainForm";
            WindowState = FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
    }
}
