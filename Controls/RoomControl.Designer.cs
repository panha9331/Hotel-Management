namespace Hotel_Management.RoomManagement
{
    partial class RoomControl
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
            label1 = new Label();
            label2 = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lbTotalRooms = new Label();
            lbTotalRoom = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            lbAvailableRooms = new Label();
            label5 = new Label();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            lbOccupiedRooms = new Label();
            label7 = new Label();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            lbReservedRooms = new Label();
            label9 = new Label();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            btRoomUpdate = new Krypton.Toolkit.KryptonButton();
            pricePerNight = new NumericUpDown();
            roomType = new ComboBox();
            roomStatus = new ComboBox();
            Clear = new MaterialSkin.Controls.MaterialButton();
            btRoomDelete = new MaterialSkin.Controls.MaterialButton();
            btRoomAdd = new MaterialSkin.Controls.MaterialButton();
            label16 = new Label();
            label15 = new Label();
            roomNumber = new Krypton.Toolkit.KryptonMaskedTextBox();
            label14 = new Label();
            roomId = new Krypton.Toolkit.KryptonMaskedTextBox();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            txtSearch = new Krypton.Toolkit.KryptonRichTextBox();
            filterType = new ComboBox();
            filterStatus = new ComboBox();
            btRoomRest = new MaterialSkin.Controls.MaterialButton();
            materialCard7 = new MaterialSkin.Controls.MaterialCard();
            dgvRooms = new DataGridView();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard5.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pricePerNight).BeginInit();
            materialCard6.SuspendLayout();
            materialCard7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(225, 31);
            label1.TabIndex = 1;
            label1.Text = "Room Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 55);
            label2.Name = "label2";
            label2.Size = new Size(609, 23);
            label2.TabIndex = 1;
            label2.Text = "Manage room details, pricing, room categories, and current operational states.";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lbTotalRooms);
            materialCard1.Controls.Add(lbTotalRoom);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(22, 118);
            materialCard1.Margin = new Padding(16);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(16);
            materialCard1.Size = new Size(288, 106);
            materialCard1.TabIndex = 2;
            // 
            // lbTotalRooms
            // 
            lbTotalRooms.AutoSize = true;
            lbTotalRooms.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalRooms.Location = new Point(19, 39);
            lbTotalRooms.Name = "lbTotalRooms";
            lbTotalRooms.Size = new Size(40, 46);
            lbTotalRooms.TabIndex = 0;
            lbTotalRooms.Text = "8";
            // 
            // lbTotalRoom
            // 
            lbTotalRoom.AutoSize = true;
            lbTotalRoom.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalRoom.Location = new Point(19, 16);
            lbTotalRoom.Name = "lbTotalRoom";
            lbTotalRoom.Size = new Size(103, 23);
            lbTotalRoom.TabIndex = 0;
            lbTotalRoom.Text = "Total Rooms";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(lbAvailableRooms);
            materialCard2.Controls.Add(label5);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(353, 118);
            materialCard2.Margin = new Padding(16);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(16);
            materialCard2.Size = new Size(288, 106);
            materialCard2.TabIndex = 2;
            // 
            // lbAvailableRooms
            // 
            lbAvailableRooms.AutoSize = true;
            lbAvailableRooms.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAvailableRooms.ForeColor = Color.FromArgb(128, 255, 128);
            lbAvailableRooms.Location = new Point(19, 39);
            lbAvailableRooms.Name = "lbAvailableRooms";
            lbAvailableRooms.Size = new Size(40, 46);
            lbAvailableRooms.TabIndex = 0;
            lbAvailableRooms.Text = "2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 16);
            label5.Name = "label5";
            label5.Size = new Size(135, 23);
            label5.TabIndex = 0;
            label5.Text = "Available Rooms";
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(lbOccupiedRooms);
            materialCard5.Controls.Add(label7);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(685, 118);
            materialCard5.Margin = new Padding(16);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(16);
            materialCard5.Size = new Size(288, 106);
            materialCard5.TabIndex = 2;
            // 
            // lbOccupiedRooms
            // 
            lbOccupiedRooms.AutoSize = true;
            lbOccupiedRooms.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOccupiedRooms.ForeColor = Color.FromArgb(255, 128, 0);
            lbOccupiedRooms.Location = new Point(19, 39);
            lbOccupiedRooms.Name = "lbOccupiedRooms";
            lbOccupiedRooms.Size = new Size(40, 46);
            lbOccupiedRooms.TabIndex = 0;
            lbOccupiedRooms.Text = "3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 16);
            label7.Name = "label7";
            label7.Size = new Size(139, 23);
            label7.TabIndex = 0;
            label7.Text = "Occupied Rooms";
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(lbReservedRooms);
            materialCard3.Controls.Add(label9);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(1005, 118);
            materialCard3.Margin = new Padding(16);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(16);
            materialCard3.Size = new Size(288, 106);
            materialCard3.TabIndex = 2;
            // 
            // lbReservedRooms
            // 
            lbReservedRooms.AutoSize = true;
            lbReservedRooms.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbReservedRooms.ForeColor = Color.Fuchsia;
            lbReservedRooms.Location = new Point(19, 39);
            lbReservedRooms.Name = "lbReservedRooms";
            lbReservedRooms.Size = new Size(40, 46);
            lbReservedRooms.TabIndex = 0;
            lbReservedRooms.Text = "1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(19, 16);
            label9.Name = "label9";
            label9.Size = new Size(155, 23);
            label9.TabIndex = 0;
            label9.Text = "Reservation Rooms";
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(btRoomUpdate);
            materialCard4.Controls.Add(pricePerNight);
            materialCard4.Controls.Add(roomType);
            materialCard4.Controls.Add(roomStatus);
            materialCard4.Controls.Add(Clear);
            materialCard4.Controls.Add(btRoomDelete);
            materialCard4.Controls.Add(btRoomAdd);
            materialCard4.Controls.Add(label16);
            materialCard4.Controls.Add(label15);
            materialCard4.Controls.Add(roomNumber);
            materialCard4.Controls.Add(label14);
            materialCard4.Controls.Add(roomId);
            materialCard4.Controls.Add(label10);
            materialCard4.Controls.Add(label12);
            materialCard4.Controls.Add(label13);
            materialCard4.Controls.Add(label11);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(22, 256);
            materialCard4.Margin = new Padding(16);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(16);
            materialCard4.Size = new Size(390, 608);
            materialCard4.TabIndex = 2;
            // 
            // btRoomUpdate
            // 
            btRoomUpdate.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            btRoomUpdate.Cursor = Cursors.Hand;
            btRoomUpdate.Location = new Point(200, 496);
            btRoomUpdate.Name = "btRoomUpdate";
            btRoomUpdate.Size = new Size(158, 36);
            btRoomUpdate.StateCommon.Border.Rounding = 4F;
            btRoomUpdate.TabIndex = 6;
            btRoomUpdate.Values.DropDownArrowColor = Color.Empty;
            btRoomUpdate.Values.Text = "UPDATE";
            // 
            // pricePerNight
            // 
            pricePerNight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pricePerNight.Location = new Point(34, 349);
            pricePerNight.Name = "pricePerNight";
            pricePerNight.Size = new Size(321, 34);
            pricePerNight.TabIndex = 4;
            // 
            // roomType
            // 
            roomType.AllowDrop = true;
            roomType.Cursor = Cursors.Hand;
            roomType.DisplayMember = "Anvailable";
            roomType.FlatStyle = FlatStyle.System;
            roomType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomType.FormattingEnabled = true;
            roomType.Location = new Point(29, 261);
            roomType.Name = "roomType";
            roomType.Size = new Size(326, 36);
            roomType.Sorted = true;
            roomType.TabIndex = 4;
            roomType.SelectedIndexChanged += roomType_SelectedIndexChanged;
            // 
            // roomStatus
            // 
            roomStatus.AllowDrop = true;
            roomStatus.Cursor = Cursors.Hand;
            roomStatus.DisplayMember = "Anvailable";
            roomStatus.FlatStyle = FlatStyle.System;
            roomStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomStatus.FormattingEnabled = true;
            roomStatus.Items.AddRange(new object[] { "Anvailable", "Maintenece", "Occupied", "Reserved" });
            roomStatus.Location = new Point(35, 432);
            roomStatus.Name = "roomStatus";
            roomStatus.Size = new Size(320, 36);
            roomStatus.Sorted = true;
            roomStatus.TabIndex = 4;
            roomStatus.Text = "Anvailable";
            // 
            // Clear
            // 
            Clear.AutoSize = false;
            Clear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Clear.Cursor = Cursors.Hand;
            Clear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Clear.Depth = 0;
            Clear.HighEmphasis = true;
            Clear.Icon = null;
            Clear.Location = new Point(200, 550);
            Clear.Margin = new Padding(4, 6, 4, 6);
            Clear.MouseState = MaterialSkin.MouseState.HOVER;
            Clear.Name = "Clear";
            Clear.NoAccentTextColor = Color.Empty;
            Clear.Size = new Size(158, 36);
            Clear.TabIndex = 5;
            Clear.Text = "Clear";
            Clear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Clear.UseAccentColor = false;
            Clear.UseVisualStyleBackColor = true;
            // 
            // btRoomDelete
            // 
            btRoomDelete.AutoSize = false;
            btRoomDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btRoomDelete.Cursor = Cursors.Hand;
            btRoomDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btRoomDelete.Depth = 0;
            btRoomDelete.HighEmphasis = true;
            btRoomDelete.Icon = null;
            btRoomDelete.Location = new Point(35, 550);
            btRoomDelete.Margin = new Padding(4, 6, 4, 6);
            btRoomDelete.MouseState = MaterialSkin.MouseState.HOVER;
            btRoomDelete.Name = "btRoomDelete";
            btRoomDelete.NoAccentTextColor = Color.Empty;
            btRoomDelete.Size = new Size(158, 36);
            btRoomDelete.TabIndex = 5;
            btRoomDelete.Text = "Delete";
            btRoomDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btRoomDelete.UseAccentColor = true;
            btRoomDelete.UseVisualStyleBackColor = true;
            // 
            // btRoomAdd
            // 
            btRoomAdd.AutoSize = false;
            btRoomAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btRoomAdd.Cursor = Cursors.Hand;
            btRoomAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btRoomAdd.Depth = 0;
            btRoomAdd.HighEmphasis = true;
            btRoomAdd.Icon = null;
            btRoomAdd.Location = new Point(35, 496);
            btRoomAdd.Margin = new Padding(4, 6, 4, 6);
            btRoomAdd.MouseState = MaterialSkin.MouseState.HOVER;
            btRoomAdd.Name = "btRoomAdd";
            btRoomAdd.NoAccentTextColor = Color.Empty;
            btRoomAdd.Size = new Size(158, 36);
            btRoomAdd.TabIndex = 5;
            btRoomAdd.Text = "Add Room";
            btRoomAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btRoomAdd.UseAccentColor = false;
            btRoomAdd.UseVisualStyleBackColor = true;
            btRoomAdd.Click += btRoomAdd_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(27, 404);
            label16.Name = "label16";
            label16.Size = new Size(63, 25);
            label16.TabIndex = 0;
            label16.Text = "Status";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(27, 317);
            label15.Name = "label15";
            label15.Size = new Size(159, 25);
            label15.TabIndex = 0;
            label15.Text = "Price Per Night($)";
            // 
            // roomNumber
            // 
            roomNumber.Cursor = Cursors.IBeam;
            roomNumber.Location = new Point(29, 178);
            roomNumber.Name = "roomNumber";
            roomNumber.Size = new Size(326, 38);
            roomNumber.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            roomNumber.StateActive.Border.Rounding = 8F;
            roomNumber.StateActive.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            roomNumber.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomNumber.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            roomNumber.StateNormal.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            roomNumber.TabIndex = 4;
            roomNumber.Text = "1";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(27, 233);
            label14.Name = "label14";
            label14.Size = new Size(105, 25);
            label14.TabIndex = 0;
            label14.Text = "Room Type";
            // 
            // roomId
            // 
            roomId.Cursor = Cursors.IBeam;
            roomId.Location = new Point(27, 95);
            roomId.Name = "roomId";
            roomId.ReadOnly = true;
            roomId.Size = new Size(328, 38);
            roomId.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            roomId.StateActive.Border.Rounding = 8F;
            roomId.StateActive.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            roomId.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomId.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            roomId.StateNormal.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            roomId.TabIndex = 4;
            roomId.Text = "1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(24, 150);
            label10.Name = "label10";
            label10.Size = new Size(135, 25);
            label10.TabIndex = 0;
            label10.Text = "Room Number";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 44);
            label12.Name = "label12";
            label12.Size = new Size(339, 23);
            label12.TabIndex = 3;
            label12.Text = "-----------------------------------------------";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(19, 67);
            label13.Name = "label13";
            label13.Size = new Size(84, 25);
            label13.TabIndex = 0;
            label13.Text = "Room ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(19, 16);
            label11.Name = "label11";
            label11.Size = new Size(160, 28);
            label11.TabIndex = 0;
            label11.Text = "Add New Room";
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(txtSearch);
            materialCard6.Controls.Add(filterType);
            materialCard6.Controls.Add(filterStatus);
            materialCard6.Controls.Add(btRoomRest);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(456, 256);
            materialCard6.Margin = new Padding(16);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(16);
            materialCard6.Size = new Size(837, 78);
            materialCard6.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.AlwaysActive = false;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Location = new Point(23, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(364, 36);
            txtSearch.StateActive.Border.Color1 = Color.Red;
            txtSearch.StateActive.Border.Rounding = 8F;
            txtSearch.StateNormal.Border.Color1 = Color.FromArgb(128, 255, 128);
            txtSearch.StateNormal.Border.Rounding = 8F;
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Search by Room ID or Number...";
            // 
            // filterType
            // 
            filterType.AllowDrop = true;
            filterType.Cursor = Cursors.Hand;
            filterType.DisplayMember = "Anvailable";
            filterType.FlatStyle = FlatStyle.System;
            filterType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterType.FormattingEnabled = true;
            filterType.Items.AddRange(new object[] { "All Types", "Double", "Single", "Suit", "Twin", "VIP" });
            filterType.Location = new Point(409, 22);
            filterType.Name = "filterType";
            filterType.Size = new Size(127, 36);
            filterType.Sorted = true;
            filterType.TabIndex = 4;
            filterType.Text = "All Types";
            // 
            // filterStatus
            // 
            filterStatus.AllowDrop = true;
            filterStatus.Cursor = Cursors.Hand;
            filterStatus.DisplayMember = "Anvailable";
            filterStatus.FlatStyle = FlatStyle.System;
            filterStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterStatus.FormattingEnabled = true;
            filterStatus.Items.AddRange(new object[] { "All Statuses", "Anvailable", "Maintenece", "Occupied", "Reserved" });
            filterStatus.Location = new Point(549, 22);
            filterStatus.Name = "filterStatus";
            filterStatus.Size = new Size(154, 36);
            filterStatus.Sorted = true;
            filterStatus.TabIndex = 4;
            filterStatus.Text = "All Statuses";
            // 
            // btRoomRest
            // 
            btRoomRest.AutoSize = false;
            btRoomRest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btRoomRest.Cursor = Cursors.Hand;
            btRoomRest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btRoomRest.Depth = 0;
            btRoomRest.HighEmphasis = true;
            btRoomRest.Icon = null;
            btRoomRest.Location = new Point(714, 22);
            btRoomRest.Margin = new Padding(4, 6, 4, 6);
            btRoomRest.MouseState = MaterialSkin.MouseState.HOVER;
            btRoomRest.Name = "btRoomRest";
            btRoomRest.NoAccentTextColor = Color.Empty;
            btRoomRest.Size = new Size(103, 36);
            btRoomRest.TabIndex = 5;
            btRoomRest.Text = "Rest";
            btRoomRest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btRoomRest.UseAccentColor = false;
            btRoomRest.UseVisualStyleBackColor = true;
            // 
            // materialCard7
            // 
            materialCard7.AutoScroll = true;
            materialCard7.BackColor = Color.FromArgb(255, 255, 255);
            materialCard7.Controls.Add(dgvRooms);
            materialCard7.Cursor = Cursors.Hand;
            materialCard7.Depth = 0;
            materialCard7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard7.Location = new Point(456, 351);
            materialCard7.Margin = new Padding(16);
            materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard7.Name = "materialCard7";
            materialCard7.Padding = new Padding(16);
            materialCard7.Size = new Size(837, 513);
            materialCard7.TabIndex = 2;
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToOrderColumns = true;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Dock = DockStyle.Fill;
            dgvRooms.Location = new Point(16, 16);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.Size = new Size(805, 481);
            dgvRooms.TabIndex = 6;
            // 
            // RoomControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(materialCard7);
            Controls.Add(materialCard6);
            Controls.Add(materialCard3);
            Controls.Add(materialCard5);
            Controls.Add(materialCard2);
            Controls.Add(materialCard4);
            Controls.Add(materialCard1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "RoomControl";
            Size = new Size(1307, 900);
            Load += RoomControl_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pricePerNight).EndInit();
            materialCard6.ResumeLayout(false);
            materialCard7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
            //ResumeLayout(false);
            //PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lbTotalRoom;
        private Label lbTotalRooms;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label lbAvailableRooms;
        private Label label5;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private Label lbOccupiedRooms;
        private Label label7;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Label lbReservedRooms;
        private Label label9;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private Label label11;
        private Label label12;
        private Label label13;
        private Krypton.Toolkit.KryptonMaskedTextBox roomId;
        private Label label15;
        private Krypton.Toolkit.KryptonMaskedTextBox roomNumber;
        private Label label14;
        private Label label10;
        private Label label16;
        private MaterialSkin.Controls.MaterialButton Clear;
        private MaterialSkin.Controls.MaterialButton btRoomDelete;
        private MaterialSkin.Controls.MaterialButton btRoomAdd;
        //private Krypton.Toolkit.KryptonButton btRoomUpdate;
        private ComboBox roomStatus;
        private NumericUpDown pricePerNight;
        private ComboBox roomType;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private Krypton.Toolkit.KryptonRichTextBox txtSearch;
        private ComboBox filterType;
        private ComboBox filterStatus;
        private MaterialSkin.Controls.MaterialButton btRoomRest;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private Krypton.Toolkit.KryptonButton btRoomUpdate;
        private DataGridView dgvRooms;
    }
}
