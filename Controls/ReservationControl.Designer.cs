namespace Hotel_Management.ReservationManagement
{
    partial class ReservationControl
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
        private void InitializeComponent() {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label15 = new Label();
            label14 = new Label();
            txtRoomId = new Krypton.Toolkit.KryptonMaskedTextBox();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            lbTotalReservedStatus = new Label();
            label5 = new Label();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            lbTotalCheckedIn = new Label();
            label7 = new Label();
            label11 = new Label();
            label2 = new Label();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            materialCard8 = new MaterialSkin.Controls.MaterialCard();
            lbTotalPayment = new Label();
            lbNight = new Label();
            label25 = new Label();
            label24 = new Label();
            checkOutDate = new Krypton.Toolkit.KryptonDateTimePicker();
            btCheckIn = new MaterialSkin.Controls.MaterialButton();
            checkInDate = new Krypton.Toolkit.KryptonDateTimePicker();
            cbReservationStatus = new ComboBox();
            cbCuctomerSelection = new ComboBox();
            cbRoomSelection = new ComboBox();
            btCheckOut = new Krypton.Toolkit.KryptonButton();
            btCancel = new MaterialSkin.Controls.MaterialButton();
            btBookRoom = new MaterialSkin.Controls.MaterialButton();
            label23 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label22 = new Label();
            label1 = new Label();
            lbTotalReservations = new Label();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            filterByStatus = new ComboBox();
            txtSearch = new Krypton.Toolkit.KryptonRichTextBox();
            btRest = new MaterialSkin.Controls.MaterialButton();
            materialCard7 = new MaterialSkin.Controls.MaterialCard();
            dgvReservations = new DataGridView();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            lbTotalCheckedOut = new Label();
            label9 = new Label();
            lbTotalRoom = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard2.SuspendLayout();
            materialCard5.SuspendLayout();
            materialCard4.SuspendLayout();
            materialCard8.SuspendLayout();
            materialCard6.SuspendLayout();
            materialCard7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            materialCard3.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(31, 321);
            label15.Name = "label15";
            label15.Size = new Size(126, 25);
            label15.TabIndex = 0;
            label15.Text = "Check-in Date";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(31, 237);
            label14.Name = "label14";
            label14.Size = new Size(143, 25);
            label14.TabIndex = 0;
            label14.Text = "Room Selection";
            // 
            // txtRoomId
            // 
            txtRoomId.Cursor = Cursors.IBeam;
            txtRoomId.Location = new Point(32, 99);
            txtRoomId.Name = "txtRoomId";
            txtRoomId.Size = new Size(205, 38);
            txtRoomId.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtRoomId.StateActive.Border.Rounding = 8F;
            txtRoomId.StateActive.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtRoomId.StateCommon.Back.Color1 = Color.FromArgb(224, 224, 224);
            txtRoomId.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomId.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtRoomId.StateNormal.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtRoomId.TabIndex = 4;
            txtRoomId.Text = "100";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(28, 154);
            label10.Name = "label10";
            label10.Size = new Size(180, 25);
            label10.TabIndex = 0;
            label10.Text = "Customer Selection ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 48);
            label12.Name = "label12";
            label12.Size = new Size(291, 20);
            label12.TabIndex = 3;
            label12.Text = "-----------------------------------------------";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(23, 71);
            label13.Name = "label13";
            label13.Size = new Size(134, 25);
            label13.TabIndex = 0;
            label13.Text = "Reservation ID";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(lbTotalReservedStatus);
            materialCard2.Controls.Add(label5);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(349, 124);
            materialCard2.Margin = new Padding(16);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(16);
            materialCard2.Size = new Size(288, 106);
            materialCard2.TabIndex = 22;
            // 
            // lbTotalReservedStatus
            // 
            lbTotalReservedStatus.AutoSize = true;
            lbTotalReservedStatus.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalReservedStatus.ForeColor = Color.FromArgb(255, 128, 0);
            lbTotalReservedStatus.Location = new Point(23, 43);
            lbTotalReservedStatus.Name = "lbTotalReservedStatus";
            lbTotalReservedStatus.Size = new Size(40, 46);
            lbTotalReservedStatus.TabIndex = 0;
            lbTotalReservedStatus.Text = "2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 20);
            label5.Name = "label5";
            label5.Size = new Size(129, 23);
            label5.TabIndex = 0;
            label5.Text = "Reserved Status";
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(lbTotalCheckedIn);
            materialCard5.Controls.Add(label7);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(681, 124);
            materialCard5.Margin = new Padding(16);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(16);
            materialCard5.Size = new Size(288, 106);
            materialCard5.TabIndex = 23;
            // 
            // lbTotalCheckedIn
            // 
            lbTotalCheckedIn.AutoSize = true;
            lbTotalCheckedIn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalCheckedIn.ForeColor = Color.Lime;
            lbTotalCheckedIn.Location = new Point(23, 43);
            lbTotalCheckedIn.Name = "lbTotalCheckedIn";
            lbTotalCheckedIn.Size = new Size(40, 46);
            lbTotalCheckedIn.TabIndex = 0;
            lbTotalCheckedIn.Text = "3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 20);
            label7.Name = "label7";
            label7.Size = new Size(95, 23);
            label7.TabIndex = 0;
            label7.Text = "Checked In";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(23, 20);
            label11.Name = "label11";
            label11.Size = new Size(241, 28);
            label11.TabIndex = 0;
            label11.Text = "Create New Reservation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(512, 23);
            label2.TabIndex = 16;
            label2.Text = "Manage reservations, check-ins, check-outs, and cost calculations.";
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(materialCard8);
            materialCard4.Controls.Add(checkOutDate);
            materialCard4.Controls.Add(btCheckIn);
            materialCard4.Controls.Add(checkInDate);
            materialCard4.Controls.Add(cbReservationStatus);
            materialCard4.Controls.Add(cbCuctomerSelection);
            materialCard4.Controls.Add(cbRoomSelection);
            materialCard4.Controls.Add(btCheckOut);
            materialCard4.Controls.Add(btCancel);
            materialCard4.Controls.Add(btBookRoom);
            materialCard4.Controls.Add(label23);
            materialCard4.Controls.Add(label15);
            materialCard4.Controls.Add(label19);
            materialCard4.Controls.Add(label18);
            materialCard4.Controls.Add(label17);
            materialCard4.Controls.Add(label14);
            materialCard4.Controls.Add(label22);
            materialCard4.Controls.Add(txtRoomId);
            materialCard4.Controls.Add(label10);
            materialCard4.Controls.Add(label12);
            materialCard4.Controls.Add(label13);
            materialCard4.Controls.Add(label11);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(18, 262);
            materialCard4.Margin = new Padding(16);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(16);
            materialCard4.Size = new Size(489, 608);
            materialCard4.TabIndex = 24;
            // 
            // materialCard8
            // 
            materialCard8.BackColor = Color.FromArgb(255, 255, 255);
            materialCard8.BorderStyle = BorderStyle.Fixed3D;
            materialCard8.Controls.Add(lbTotalPayment);
            materialCard8.Controls.Add(lbNight);
            materialCard8.Controls.Add(label25);
            materialCard8.Controls.Add(label24);
            materialCard8.Depth = 0;
            materialCard8.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard8.Location = new Point(35, 397);
            materialCard8.Margin = new Padding(16);
            materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard8.Name = "materialCard8";
            materialCard8.Padding = new Padding(16);
            materialCard8.Size = new Size(413, 94);
            materialCard8.TabIndex = 22;
            // 
            // lbTotalPayment
            // 
            lbTotalPayment.AutoSize = true;
            lbTotalPayment.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalPayment.ForeColor = Color.Lime;
            lbTotalPayment.Location = new Point(309, 46);
            lbTotalPayment.Name = "lbTotalPayment";
            lbTotalPayment.Size = new Size(85, 31);
            lbTotalPayment.TabIndex = 0;
            lbTotalPayment.Text = "$40.00";
            lbTotalPayment.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNight
            // 
            lbNight.AutoSize = true;
            lbNight.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNight.ForeColor = Color.FromArgb(255, 128, 0);
            lbNight.Location = new Point(29, 46);
            lbNight.Name = "lbNight";
            lbNight.Size = new Size(105, 31);
            lbNight.TabIndex = 0;
            lbNight.Text = "2 Nights";
            lbNight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(306, 16);
            label25.Name = "label25";
            label25.Size = new Size(88, 23);
            label25.TabIndex = 0;
            label25.Text = "Total Price";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(8, 16);
            label24.Name = "label24";
            label24.Size = new Size(126, 23);
            label24.TabIndex = 0;
            label24.Text = "Calculated Stay";
            // 
            // checkOutDate
            // 
            checkOutDate.CalendarTodayFormat = "MM/dd/yyyy";
            checkOutDate.Format = DateTimePickerFormat.Short;
            checkOutDate.Location = new Point(267, 349);
            checkOutDate.Name = "checkOutDate";
            checkOutDate.Size = new Size(181, 29);
            checkOutDate.StateActive.Border.Color1 = Color.Red;
            checkOutDate.StateActive.Border.Rounding = 4F;
            checkOutDate.StateActive.Content.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkOutDate.StateNormal.Border.Color1 = Color.FromArgb(255, 192, 128);
            checkOutDate.StateNormal.Border.Rounding = 4F;
            checkOutDate.StateNormal.Content.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkOutDate.TabIndex = 6;
            // 
            // btCheckIn
            // 
            btCheckIn.AutoSize = false;
            btCheckIn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btCheckIn.Cursor = Cursors.Hand;
            btCheckIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btCheckIn.Depth = 0;
            btCheckIn.HighEmphasis = true;
            btCheckIn.Icon = null;
            btCheckIn.Location = new Point(35, 553);
            btCheckIn.Margin = new Padding(4, 6, 4, 6);
            btCheckIn.MouseState = MaterialSkin.MouseState.HOVER;
            btCheckIn.Name = "btCheckIn";
            btCheckIn.NoAccentTextColor = Color.Empty;
            btCheckIn.Size = new Size(134, 36);
            btCheckIn.TabIndex = 5;
            btCheckIn.Text = "CHECK-IN";
            btCheckIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btCheckIn.UseAccentColor = false;
            btCheckIn.UseVisualStyleBackColor = true;
            btCheckIn.Click += btCheckIn_Click;
            // 
            // checkInDate
            // 
            checkInDate.CalendarTodayFormat = "MM/dd/yyyy";
            checkInDate.Format = DateTimePickerFormat.Short;
            checkInDate.Location = new Point(35, 349);
            checkInDate.Name = "checkInDate";
            checkInDate.Size = new Size(181, 29);
            checkInDate.StateActive.Border.Color1 = Color.Lime;
            checkInDate.StateActive.Border.Rounding = 4F;
            checkInDate.StateActive.Content.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkInDate.StateNormal.Border.Color1 = Color.FromArgb(128, 255, 128);
            checkInDate.StateNormal.Border.Rounding = 4F;
            checkInDate.StateNormal.Content.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkInDate.TabIndex = 6;
            // 
            // cbReservationStatus
            // 
            cbReservationStatus.AllowDrop = true;
            cbReservationStatus.Cursor = Cursors.Hand;
            cbReservationStatus.DisplayMember = "Anvailable";
            cbReservationStatus.FlatStyle = FlatStyle.System;
            cbReservationStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbReservationStatus.FormattingEnabled = true;
            cbReservationStatus.Items.AddRange(new object[] { "Cancelled", "Checked-In", "Checked-Out", "Reserved" });
            cbReservationStatus.Location = new Point(256, 101);
            cbReservationStatus.Name = "cbReservationStatus";
            cbReservationStatus.Size = new Size(192, 36);
            cbReservationStatus.Sorted = true;
            cbReservationStatus.TabIndex = 4;
            cbReservationStatus.Text = "Reserved";
            // 
            // cbCuctomerSelection
            // 
            cbCuctomerSelection.AllowDrop = true;
            cbCuctomerSelection.Cursor = Cursors.Hand;
            cbCuctomerSelection.DisplayMember = "Anvailable";
            cbCuctomerSelection.FlatStyle = FlatStyle.System;
            cbCuctomerSelection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCuctomerSelection.FormattingEnabled = true;
            cbCuctomerSelection.Items.AddRange(new object[] { "Female (F)", "Male (M)", "Other (N)" });
            cbCuctomerSelection.Location = new Point(35, 182);
            cbCuctomerSelection.Name = "cbCuctomerSelection";
            cbCuctomerSelection.Size = new Size(413, 36);
            cbCuctomerSelection.Sorted = true;
            cbCuctomerSelection.TabIndex = 4;
            cbCuctomerSelection.Text = "Moeurn Panha (1)";
            // 
            // cbRoomSelection
            // 
            cbRoomSelection.AllowDrop = true;
            cbRoomSelection.Cursor = Cursors.Hand;
            cbRoomSelection.DisplayMember = "Anvailable";
            cbRoomSelection.FlatStyle = FlatStyle.System;
            cbRoomSelection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRoomSelection.FormattingEnabled = true;
            cbRoomSelection.Items.AddRange(new object[] { "Female (F)", "Male (M)", "Other (N)" });
            cbRoomSelection.Location = new Point(35, 265);
            cbRoomSelection.Name = "cbRoomSelection";
            cbRoomSelection.Size = new Size(413, 36);
            cbRoomSelection.Sorted = true;
            cbRoomSelection.TabIndex = 4;
            cbRoomSelection.Text = "Room 101 - Single ($20night)";
            // 
            // btCheckOut
            // 
            btCheckOut.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            btCheckOut.Cursor = Cursors.Hand;
            btCheckOut.Location = new Point(177, 553);
            btCheckOut.Name = "btCheckOut";
            btCheckOut.Size = new Size(134, 36);
            btCheckOut.StateCommon.Border.Rounding = 4F;
            btCheckOut.TabIndex = 3;
            btCheckOut.Values.DropDownArrowColor = Color.Empty;
            btCheckOut.Values.Text = "CHECK-OUT";
            btCheckOut.Click += btCheckOut_Click;
            // 
            // btCancel
            // 
            btCancel.AutoSize = false;
            btCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btCancel.Cursor = Cursors.Hand;
            btCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btCancel.Depth = 0;
            btCancel.HighEmphasis = true;
            btCancel.Icon = null;
            btCancel.Location = new Point(322, 553);
            btCancel.Margin = new Padding(4, 6, 4, 6);
            btCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btCancel.Name = "btCancel";
            btCancel.NoAccentTextColor = Color.Empty;
            btCancel.Size = new Size(126, 36);
            btCancel.TabIndex = 5;
            btCancel.Text = "CANCEL";
            btCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btCancel.UseAccentColor = true;
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // btBookRoom
            // 
            btBookRoom.AutoSize = false;
            btBookRoom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btBookRoom.Cursor = Cursors.Hand;
            btBookRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btBookRoom.Depth = 0;
            btBookRoom.HighEmphasis = true;
            btBookRoom.Icon = null;
            btBookRoom.Location = new Point(35, 505);
            btBookRoom.Margin = new Padding(4, 6, 4, 6);
            btBookRoom.MouseState = MaterialSkin.MouseState.HOVER;
            btBookRoom.Name = "btBookRoom";
            btBookRoom.NoAccentTextColor = Color.Empty;
            btBookRoom.Size = new Size(413, 36);
            btBookRoom.TabIndex = 5;
            btBookRoom.Text = "Book Room";
            btBookRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btBookRoom.UseAccentColor = false;
            btBookRoom.UseVisualStyleBackColor = true;
            btBookRoom.Click += btBookRoom_Click_1;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(263, 321);
            label23.Name = "label23";
            label23.Size = new Size(139, 25);
            label23.TabIndex = 0;
            label23.Text = "Check-out Date";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(428, 68);
            label19.Name = "label19";
            label19.Size = new Size(20, 25);
            label19.TabIndex = 0;
            label19.Text = "*";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(428, 154);
            label18.Name = "label18";
            label18.Size = new Size(20, 25);
            label18.TabIndex = 0;
            label18.Text = "*";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(428, 237);
            label17.Name = "label17";
            label17.Size = new Size(20, 25);
            label17.TabIndex = 0;
            label17.Text = "*";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(252, 68);
            label22.Name = "label22";
            label22.Size = new Size(167, 25);
            label22.TabIndex = 0;
            label22.Text = "Reservation Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(288, 31);
            label1.TabIndex = 17;
            label1.Text = "Reservation Management";
            // 
            // lbTotalReservations
            // 
            lbTotalReservations.AutoSize = true;
            lbTotalReservations.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalReservations.Location = new Point(23, 43);
            lbTotalReservations.Name = "lbTotalReservations";
            lbTotalReservations.Size = new Size(40, 46);
            lbTotalReservations.TabIndex = 0;
            lbTotalReservations.Text = "8";
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(filterByStatus);
            materialCard6.Controls.Add(txtSearch);
            materialCard6.Controls.Add(btRest);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(539, 262);
            materialCard6.Margin = new Padding(16);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(16);
            materialCard6.Size = new Size(750, 78);
            materialCard6.TabIndex = 18;
            // 
            // filterByStatus
            // 
            filterByStatus.AllowDrop = true;
            filterByStatus.Cursor = Cursors.Hand;
            filterByStatus.DisplayMember = "Anvailable";
            filterByStatus.FlatStyle = FlatStyle.System;
            filterByStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterByStatus.FormattingEnabled = true;
            filterByStatus.Items.AddRange(new object[] { "Cancelled", "Checked-In", "Checked-Out", "Reserved" });
            filterByStatus.Location = new Point(487, 23);
            filterByStatus.Name = "filterByStatus";
            filterByStatus.Size = new Size(119, 36);
            filterByStatus.Sorted = true;
            filterByStatus.TabIndex = 4;
            filterByStatus.Text = "All Statuses";
            // 
            // txtSearch
            // 
            txtSearch.AlwaysActive = false;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Location = new Point(23, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(444, 36);
            txtSearch.StateActive.Border.Color1 = Color.Fuchsia;
            txtSearch.StateActive.Border.Rounding = 8F;
            txtSearch.StateNormal.Border.Color1 = Color.Blue;
            txtSearch.StateNormal.Border.Rounding = 8F;
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Search by Reservaion ID, Customer, Room ...";
            // 
            // btRest
            // 
            btRest.AutoSize = false;
            btRest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btRest.Cursor = Cursors.Hand;
            btRest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btRest.Depth = 0;
            btRest.HighEmphasis = true;
            btRest.Icon = null;
            btRest.Location = new Point(625, 23);
            btRest.Margin = new Padding(4, 6, 4, 6);
            btRest.MouseState = MaterialSkin.MouseState.HOVER;
            btRest.Name = "btRest";
            btRest.NoAccentTextColor = Color.Empty;
            btRest.Size = new Size(103, 36);
            btRest.TabIndex = 5;
            btRest.Text = "Rest";
            btRest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btRest.UseAccentColor = false;
            btRest.UseVisualStyleBackColor = true;
            // 
            // materialCard7
            // 
            materialCard7.BackColor = Color.FromArgb(255, 255, 255);
            materialCard7.Controls.Add(dgvReservations);
            materialCard7.Depth = 0;
            materialCard7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard7.Location = new Point(539, 357);
            materialCard7.Margin = new Padding(16);
            materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard7.Name = "materialCard7";
            materialCard7.Padding = new Padding(16);
            materialCard7.Size = new Size(750, 513);
            materialCard7.TabIndex = 19;
            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReservations.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReservations.Dock = DockStyle.Fill;
            dgvReservations.EnableHeadersVisualStyles = false;
            dgvReservations.Location = new Point(16, 16);
            dgvReservations.MultiSelect = false;
            dgvReservations.Name = "dgvReservations";
            dgvReservations.ReadOnly = true;
            dgvReservations.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Lime;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvReservations.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.ScrollBars = ScrollBars.Horizontal;
            dgvReservations.Size = new Size(718, 481);
            dgvReservations.TabIndex = 8;
            dgvReservations.SelectionChanged += dgvReservations_SelectionChanged;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(lbTotalCheckedOut);
            materialCard3.Controls.Add(label9);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(1001, 124);
            materialCard3.Margin = new Padding(16);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(16);
            materialCard3.Size = new Size(288, 106);
            materialCard3.TabIndex = 20;
            // 
            // lbTotalCheckedOut
            // 
            lbTotalCheckedOut.AutoSize = true;
            lbTotalCheckedOut.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalCheckedOut.ForeColor = Color.Fuchsia;
            lbTotalCheckedOut.Location = new Point(23, 43);
            lbTotalCheckedOut.Name = "lbTotalCheckedOut";
            lbTotalCheckedOut.Size = new Size(64, 46);
            lbTotalCheckedOut.TabIndex = 0;
            lbTotalCheckedOut.Text = "+3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 20);
            label9.Name = "label9";
            label9.Size = new Size(200, 23);
            label9.TabIndex = 0;
            label9.Text = "Checked Out / Cancelled";
            // 
            // lbTotalRoom
            // 
            lbTotalRoom.AutoSize = true;
            lbTotalRoom.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalRoom.Location = new Point(23, 20);
            lbTotalRoom.Name = "lbTotalRoom";
            lbTotalRoom.Size = new Size(146, 23);
            lbTotalRoom.TabIndex = 0;
            lbTotalRoom.Text = "Total Reservatoins";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lbTotalReservations);
            materialCard1.Controls.Add(lbTotalRoom);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(18, 124);
            materialCard1.Margin = new Padding(16);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(16);
            materialCard1.Size = new Size(288, 106);
            materialCard1.TabIndex = 21;
            // 
            // ReservationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard2);
            Controls.Add(materialCard5);
            Controls.Add(label2);
            Controls.Add(materialCard4);
            Controls.Add(label1);
            Controls.Add(materialCard6);
            Controls.Add(materialCard7);
            Controls.Add(materialCard3);
            Controls.Add(materialCard1);
            Name = "ReservationControl";
            Size = new Size(1307, 900);
            Load += ReservationControl_Load;
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            materialCard8.ResumeLayout(false);
            materialCard8.PerformLayout();
            materialCard6.ResumeLayout(false);
            materialCard7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label15;
        private Label label14;
        private Krypton.Toolkit.KryptonMaskedTextBox txtRoomId;
        private Label label10;
        private Label label12;
        private Label label13;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label lbTotalReservedStatus;
        private Label label5;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private Label lbTotalCheckedIn;
        private Label label7;
        private Label label11;
        private Label label2;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private ComboBox cbRoomSelection;
        private Krypton.Toolkit.KryptonButton btCheckOut;
        private MaterialSkin.Controls.MaterialButton btCheckIn;
        private MaterialSkin.Controls.MaterialButton btCancel;
        private MaterialSkin.Controls.MaterialButton btBookRoom;
        private Label label1;
        private Label lbTotalReservations;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private ComboBox filterByStatus;
        private Krypton.Toolkit.KryptonRichTextBox txtSearch;
        private MaterialSkin.Controls.MaterialButton btRest;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Label lbTotalCheckedOut;
        private Label label9;
        private Label lbTotalRoom;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private ComboBox cbCuctomerSelection;
        private Krypton.Toolkit.KryptonDateTimePicker checkInDate;
        private ComboBox cbReservationStatus;
        private Label label22;
        private Krypton.Toolkit.KryptonDateTimePicker checkOutDate;
        private Label label23;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private Label lbNight;
        private Label label24;
        private Label lbTotalPayment;
        private Label label25;
        private Label label19;
        private Label label18;
        private Label label17;
        private DataGridView dgvReservations;
    }
}
