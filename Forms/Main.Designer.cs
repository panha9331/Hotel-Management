using Microsoft.UI.Xaml;

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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            label2 = new Label();
            lblPageTitle = new Label();
            panel5 = new Panel();
            lbTime = new Label();
            lbDate = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            globalSearch = new Krypton.Toolkit.KryptonRichTextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btCustomer = new MaterialSkin.Controls.MaterialButton();
            btReservation = new MaterialSkin.Controls.MaterialButton();
            btRoom = new MaterialSkin.Controls.MaterialButton();
            btDashboard = new MaterialSkin.Controls.MaterialButton();
            panel4 = new Panel();
            btLogout = new PictureBox();
            picAccount = new PictureBox();
            lbRole = new Label();
            lbAccountName = new Label();
            pnlContent = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAccount).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            kryptonPanel1.Controls.Add(label2);
            kryptonPanel1.Controls.Add(lblPageTitle);
            kryptonPanel1.Controls.Add(panel5);
            kryptonPanel1.Controls.Add(panel2);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Margin = new Padding(4);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.GridHeaderColumnCustom3;
            kryptonPanel1.Size = new Size(1582, 78);
            kryptonPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DeepPink;
            label2.Location = new Point(346, 24);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 7;
            label2.Text = "StayEasy =>";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.BackColor = Color.Transparent;
            lblPageTitle.Cursor = Cursors.Hand;
            lblPageTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.Location = new Point(445, 20);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(225, 31);
            lblPageTitle.TabIndex = 7;
            lblPageTitle.Text = "Room Management";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Right;
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(lbTime);
            panel5.Controls.Add(lbDate);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(globalSearch);
            panel5.Location = new Point(967, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(615, 81);
            panel5.TabIndex = 6;
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.BackColor = Color.Transparent;
            lbTime.Font = new Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTime.ForeColor = Color.Blue;
            lbTime.Location = new Point(437, 34);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(162, 23);
            lbTime.TabIndex = 5;
            lbTime.Text = "System Time: UTC+7";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.BackColor = Color.Transparent;
            lbDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDate.ForeColor = Color.MediumBlue;
            lbDate.Location = new Point(486, 11);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(113, 23);
            lbDate.TabIndex = 5;
            lbDate.Text = "Oct 03, 2026";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = Properties.Resources.search;
            pictureBox3.Location = new Point(397, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 41);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = Properties.Resources.search;
            pictureBox2.Location = new Point(350, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 41);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // globalSearch
            // 
            globalSearch.AlwaysActive = false;
            globalSearch.Cursor = Cursors.IBeam;
            globalSearch.EnableAutoDragDrop = true;
            globalSearch.Location = new Point(20, 21);
            globalSearch.Name = "globalSearch";
            globalSearch.Size = new Size(324, 36);
            globalSearch.StateActive.Back.Color1 = Color.White;
            globalSearch.StateActive.Border.Color1 = Color.Fuchsia;
            globalSearch.StateActive.Border.Rounding = 8F;
            globalSearch.StateNormal.Border.Color1 = Color.Blue;
            globalSearch.StateNormal.Border.Rounding = 8F;
            globalSearch.TabIndex = 0;
            globalSearch.Text = "Global Search (Ctrl + /)...";
            globalSearch.TextChanged += globalSearch_TextChanged;
            globalSearch.Enter += globalSearch_Enter;
            globalSearch.Leave += globalSearch_Leave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 78);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Tomato;
            label5.Location = new Point(74, 42);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 0;
            label5.Text = "V 1.2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(70, 11);
            label1.Name = "label1";
            label1.Size = new Size(164, 31);
            label1.TabIndex = 0;
            label1.Text = "StayEasy HMS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(btCustomer);
            panel1.Controls.Add(btReservation);
            panel1.Controls.Add(btRoom);
            panel1.Controls.Add(btDashboard);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 78);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 900);
            panel1.TabIndex = 1;
            // 
            // btCustomer
            // 
            btCustomer.AutoSize = false;
            btCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btCustomer.Cursor = Cursors.Hand;
            btCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btCustomer.Depth = 0;
            btCustomer.FlatStyle = FlatStyle.Popup;
            btCustomer.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCustomer.HighEmphasis = true;
            btCustomer.Icon = Properties.Resources.identity_platform_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            btCustomer.Location = new Point(16, 203);
            btCustomer.Margin = new Padding(4, 6, 4, 6);
            btCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            btCustomer.Name = "btCustomer";
            btCustomer.NoAccentTextColor = Color.Empty;
            btCustomer.Size = new Size(230, 77);
            btCustomer.TabIndex = 1;
            btCustomer.Text = "Customer Management";
            btCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btCustomer.UseAccentColor = false;
            btCustomer.UseVisualStyleBackColor = false;
            btCustomer.Click += btCustomer_Click;
            // 
            // btReservation
            // 
            btReservation.AutoSize = false;
            btReservation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btReservation.Cursor = Cursors.Hand;
            btReservation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btReservation.Depth = 0;
            btReservation.FlatStyle = FlatStyle.Popup;
            btReservation.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btReservation.HighEmphasis = true;
            btReservation.Icon = Properties.Resources.hotel_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            btReservation.Location = new Point(16, 292);
            btReservation.Margin = new Padding(4, 6, 4, 6);
            btReservation.MouseState = MaterialSkin.MouseState.HOVER;
            btReservation.Name = "btReservation";
            btReservation.NoAccentTextColor = Color.Empty;
            btReservation.Size = new Size(230, 77);
            btReservation.TabIndex = 1;
            btReservation.Text = "Reservation managemet";
            btReservation.TextAlign = ContentAlignment.MiddleRight;
            btReservation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btReservation.UseAccentColor = false;
            btReservation.UseVisualStyleBackColor = false;
            btReservation.Click += btReservation_Click;
            // 
            // btRoom
            // 
            btRoom.AutoSize = false;
            btRoom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btRoom.Cursor = Cursors.Hand;
            btRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btRoom.Depth = 0;
            btRoom.FlatStyle = FlatStyle.Popup;
            btRoom.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btRoom.HighEmphasis = true;
            btRoom.Icon = Properties.Resources.room_service_24dp_FFFFFF_FILL0_wght400_GRAD0_opsz24;
            btRoom.Location = new Point(16, 114);
            btRoom.Margin = new Padding(4, 6, 4, 6);
            btRoom.MouseState = MaterialSkin.MouseState.HOVER;
            btRoom.Name = "btRoom";
            btRoom.NoAccentTextColor = Color.Empty;
            btRoom.Size = new Size(230, 77);
            btRoom.TabIndex = 1;
            btRoom.Text = "Room Management";
            btRoom.TextAlign = ContentAlignment.MiddleLeft;
            btRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btRoom.UseAccentColor = false;
            btRoom.UseVisualStyleBackColor = false;
            btRoom.Click += btRoom_Click;
            // 
            // btDashboard
            // 
            btDashboard.AutoSize = false;
            btDashboard.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btDashboard.Cursor = Cursors.Hand;
            btDashboard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btDashboard.Depth = 0;
            btDashboard.FlatStyle = FlatStyle.Flat;
            btDashboard.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDashboard.HighEmphasis = true;
            btDashboard.Icon = Properties.Resources.dashboard;
            btDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btDashboard.Location = new Point(16, 25);
            btDashboard.Margin = new Padding(4, 6, 4, 6);
            btDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            btDashboard.Name = "btDashboard";
            btDashboard.NoAccentTextColor = Color.Empty;
            btDashboard.Size = new Size(230, 77);
            btDashboard.TabIndex = 1;
            btDashboard.Text = "Dashboard Overview";
            btDashboard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btDashboard.UseAccentColor = false;
            btDashboard.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.BackColor = Color.MidnightBlue;
            panel4.Controls.Add(btLogout);
            panel4.Controls.Add(picAccount);
            panel4.Controls.Add(lbRole);
            panel4.Controls.Add(lbAccountName);
            panel4.Location = new Point(4, 818);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(260, 78);
            panel4.TabIndex = 2;
            // 
            // btLogout
            // 
            btLogout.Cursor = Cursors.Hand;
            btLogout.Image = (Image)resources.GetObject("btLogout.Image");
            btLogout.Location = new Point(198, 16);
            btLogout.Name = "btLogout";
            btLogout.Size = new Size(52, 41);
            btLogout.SizeMode = PictureBoxSizeMode.Zoom;
            btLogout.TabIndex = 1;
            btLogout.TabStop = false;
            btLogout.Click += btLogout_Click;
            // 
            // picAccount
            // 
            picAccount.Cursor = Cursors.Hand;
            picAccount.Image = (Image)resources.GetObject("picAccount.Image");
            picAccount.Location = new Point(12, 16);
            picAccount.Name = "picAccount";
            picAccount.Size = new Size(52, 41);
            picAccount.SizeMode = PictureBoxSizeMode.Zoom;
            picAccount.TabIndex = 1;
            picAccount.TabStop = false;
            picAccount.MouseLeave += picAccount_MouseLeave;
            picAccount.MouseHover += picAccount_MouseHover;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRole.ForeColor = Color.Yellow;
            lbRole.Location = new Point(70, 39);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(60, 23);
            lbRole.TabIndex = 0;
            lbRole.Text = "Admin";
            // 
            // lbAccountName
            // 
            lbAccountName.AutoSize = true;
            lbAccountName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAccountName.ForeColor = Color.Aqua;
            lbAccountName.Location = new Point(70, 11);
            lbAccountName.Name = "lbAccountName";
            lbAccountName.Size = new Size(106, 28);
            lbAccountName.TabIndex = 0;
            lbAccountName.Text = "Mr. Panha";
            lbAccountName.MouseLeave += lbAccountName_MouseLeave;
            lbAccountName.MouseHover += lbAccountName_MouseHover;
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.BackColor = Color.Silver;
            pnlContent.ForeColor = SystemColors.ControlText;
            pnlContent.Location = new Point(260, 78);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1322, 900);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 978);
            Controls.Add(pnlContent);
            Controls.Add(panel1);
            Controls.Add(kryptonPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1200, 720);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StayEasy Hotel Star V";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAccount).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton btDashboard;
        private MaterialSkin.Controls.MaterialButton btReservation;
        private MaterialSkin.Controls.MaterialButton btCustomer;
        private MaterialSkin.Controls.MaterialButton btRoom;
        private Panel pnlContent;
        private Krypton.Toolkit.KryptonRichTextBox globalSearch;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lbTime;
        private Label lbDate;
        private Panel panel4;
        private PictureBox picAccount;
        private Label lbRole;
        private Label lbAccountName;
        private Label label5;
        private Panel panel5;
        private Label lblPageTitle;
        private PictureBox btLogout;
        private System.Windows.Forms.Timer timer;
        private Label label2;
    }
}
