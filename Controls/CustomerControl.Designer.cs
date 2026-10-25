using System;
using System.Windows.Forms;

namespace Hotel_Management.Controls
{
    public partial class CustomerControl : UserControl
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            cbGender = new ComboBox();
            btUpdateCustomer = new Krypton.Toolkit.KryptonButton();
            btClear = new MaterialSkin.Controls.MaterialButton();
            btDeleteCustomer = new MaterialSkin.Controls.MaterialButton();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            filterByGender = new ComboBox();
            txtSearch = new Krypton.Toolkit.KryptonRichTextBox();
            btFilterRest = new MaterialSkin.Controls.MaterialButton();
            materialCard7 = new MaterialSkin.Controls.MaterialCard();
            dgvCustomers = new DataGridView();
            btAddCustomer = new MaterialSkin.Controls.MaterialButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            lbTotalCustomerThisMonth = new Label();
            label9 = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lbTotalCustomer = new Label();
            lbTotalRoom = new Label();
            label2 = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            lbTotalMale = new Label();
            label5 = new Label();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            lbTotalFemale = new Label();
            label7 = new Label();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            label16 = new Label();
            label15 = new Label();
            txtEmail = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtPhone = new Krypton.Toolkit.KryptonMaskedTextBox();
            txtCustomerName = new Krypton.Toolkit.KryptonMaskedTextBox();
            label14 = new Label();
            txtCustomerId = new Krypton.Toolkit.KryptonMaskedTextBox();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            label1 = new Label();
            materialCard6.SuspendLayout();
            materialCard7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            materialCard3.SuspendLayout();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard5.SuspendLayout();
            materialCard4.SuspendLayout();
            SuspendLayout();
            // 
            // cbGender
            // 
            cbGender.AllowDrop = true;
            cbGender.Cursor = Cursors.Hand;
            cbGender.DisplayMember = "Anvailable";
            cbGender.FlatStyle = FlatStyle.System;
            cbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            cbGender.Location = new Point(29, 261);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(326, 36);
            cbGender.Sorted = true;
            cbGender.TabIndex = 4;
            cbGender.Text = "Male";
            // 
            // btUpdateCustomer
            // 
            btUpdateCustomer.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            btUpdateCustomer.Cursor = Cursors.Hand;
            btUpdateCustomer.Location = new Point(200, 496);
            btUpdateCustomer.Name = "btUpdateCustomer";
            btUpdateCustomer.Size = new Size(158, 36);
            btUpdateCustomer.StateCommon.Border.Rounding = 4F;
            btUpdateCustomer.TabIndex = 3;
            btUpdateCustomer.Values.DropDownArrowColor = Color.Empty;
            btUpdateCustomer.Values.Text = "UPDATE";
            btUpdateCustomer.Click += btUpdateCustomer_Click;
            // 
            // btClear
            // 
            btClear.AutoSize = false;
            btClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btClear.Cursor = Cursors.Hand;
            btClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btClear.Depth = 0;
            btClear.HighEmphasis = true;
            btClear.Icon = null;
            btClear.Location = new Point(200, 550);
            btClear.Margin = new Padding(4, 6, 4, 6);
            btClear.MouseState = MaterialSkin.MouseState.HOVER;
            btClear.Name = "btClear";
            btClear.NoAccentTextColor = Color.Empty;
            btClear.Size = new Size(158, 36);
            btClear.TabIndex = 5;
            btClear.Text = "Clear";
            btClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btClear.UseAccentColor = false;
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btDeleteCustomer
            // 
            btDeleteCustomer.AutoSize = false;
            btDeleteCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btDeleteCustomer.Cursor = Cursors.Hand;
            btDeleteCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btDeleteCustomer.Depth = 0;
            btDeleteCustomer.HighEmphasis = true;
            btDeleteCustomer.Icon = null;
            btDeleteCustomer.Location = new Point(35, 550);
            btDeleteCustomer.Margin = new Padding(4, 6, 4, 6);
            btDeleteCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            btDeleteCustomer.Name = "btDeleteCustomer";
            btDeleteCustomer.NoAccentTextColor = Color.Empty;
            btDeleteCustomer.Size = new Size(158, 36);
            btDeleteCustomer.TabIndex = 5;
            btDeleteCustomer.Text = "Delete";
            btDeleteCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btDeleteCustomer.UseAccentColor = true;
            btDeleteCustomer.UseVisualStyleBackColor = true;
            btDeleteCustomer.Click += btDeleteCustomer_Click;
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(filterByGender);
            materialCard6.Controls.Add(txtSearch);
            materialCard6.Controls.Add(btFilterRest);
            materialCard6.Depth = 0;
            materialCard6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard6.Location = new Point(452, 264);
            materialCard6.Margin = new Padding(16);
            materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard6.Name = "materialCard6";
            materialCard6.Padding = new Padding(16);
            materialCard6.Size = new Size(837, 78);
            materialCard6.TabIndex = 7;
            // 
            // filterByGender
            // 
            filterByGender.AllowDrop = true;
            filterByGender.Cursor = Cursors.Hand;
            filterByGender.DisplayMember = "Anvailable";
            filterByGender.FlatStyle = FlatStyle.System;
            filterByGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterByGender.FormattingEnabled = true;
            filterByGender.Items.AddRange(new object[] { "All Gender", "Female", "Male", "Other" });
            filterByGender.Location = new Point(586, 23);
            filterByGender.Name = "filterByGender";
            filterByGender.Size = new Size(119, 36);
            filterByGender.Sorted = true;
            filterByGender.TabIndex = 4;
            filterByGender.Text = "All Gender";
            filterByGender.SelectedIndexChanged += filterByGender_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.AlwaysActive = false;
            txtSearch.Cursor = Cursors.IBeam;
            txtSearch.Location = new Point(23, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(557, 36);
            txtSearch.StateActive.Border.Color1 = Color.Red;
            txtSearch.StateActive.Border.Rounding = 8F;
            txtSearch.StateNormal.Border.Color1 = Color.FromArgb(128, 255, 128);
            txtSearch.StateNormal.Border.Rounding = 8F;
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Search by ID, Full Name, Phone...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // btFilterRest
            // 
            btFilterRest.AutoSize = false;
            btFilterRest.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btFilterRest.Cursor = Cursors.Hand;
            btFilterRest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btFilterRest.Depth = 0;
            btFilterRest.HighEmphasis = true;
            btFilterRest.Icon = null;
            btFilterRest.Location = new Point(714, 22);
            btFilterRest.Margin = new Padding(4, 6, 4, 6);
            btFilterRest.MouseState = MaterialSkin.MouseState.HOVER;
            btFilterRest.Name = "btFilterRest";
            btFilterRest.NoAccentTextColor = Color.Empty;
            btFilterRest.Size = new Size(103, 36);
            btFilterRest.TabIndex = 5;
            btFilterRest.Text = "Rest";
            btFilterRest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btFilterRest.UseAccentColor = false;
            btFilterRest.UseVisualStyleBackColor = true;
            btFilterRest.Click += btFilterRest_Click;
            // 
            // materialCard7
            // 
            materialCard7.BackColor = Color.FromArgb(255, 255, 255);
            materialCard7.Controls.Add(dgvCustomers);
            materialCard7.Depth = 0;
            materialCard7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard7.Location = new Point(452, 359);
            materialCard7.Margin = new Padding(16);
            materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard7.Name = "materialCard7";
            materialCard7.Padding = new Padding(16);
            materialCard7.Size = new Size(837, 513);
            materialCard7.TabIndex = 8;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Cursor = Cursors.Hand;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle5;
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.Location = new Point(16, 16);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Lime;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.ScrollBars = ScrollBars.Horizontal;
            dgvCustomers.Size = new Size(805, 481);
            dgvCustomers.TabIndex = 7;
            // 
            // btAddCustomer
            // 
            btAddCustomer.AutoSize = false;
            btAddCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btAddCustomer.Cursor = Cursors.Hand;
            btAddCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btAddCustomer.Depth = 0;
            btAddCustomer.HighEmphasis = true;
            btAddCustomer.Icon = null;
            btAddCustomer.Location = new Point(35, 496);
            btAddCustomer.Margin = new Padding(4, 6, 4, 6);
            btAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            btAddCustomer.Name = "btAddCustomer";
            btAddCustomer.NoAccentTextColor = Color.Empty;
            btAddCustomer.Size = new Size(158, 36);
            btAddCustomer.TabIndex = 5;
            btAddCustomer.Text = "Add Customer";
            btAddCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btAddCustomer.UseAccentColor = false;
            btAddCustomer.UseVisualStyleBackColor = true;
            btAddCustomer.Click += btAddCustomer_Click;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(lbTotalCustomerThisMonth);
            materialCard3.Controls.Add(label9);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(1001, 126);
            materialCard3.Margin = new Padding(16);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(16);
            materialCard3.Size = new Size(288, 106);
            materialCard3.TabIndex = 9;
            // 
            // lbTotalCustomerThisMonth
            // 
            lbTotalCustomerThisMonth.AutoSize = true;
            lbTotalCustomerThisMonth.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalCustomerThisMonth.ForeColor = Color.Lime;
            lbTotalCustomerThisMonth.Location = new Point(21, 41);
            lbTotalCustomerThisMonth.Name = "lbTotalCustomerThisMonth";
            lbTotalCustomerThisMonth.Size = new Size(64, 46);
            lbTotalCustomerThisMonth.TabIndex = 0;
            lbTotalCustomerThisMonth.Text = "+3";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(21, 18);
            label9.Name = "label9";
            label9.Size = new Size(135, 23);
            label9.TabIndex = 0;
            label9.Text = "New This Month";
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lbTotalCustomer);
            materialCard1.Controls.Add(lbTotalRoom);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(18, 126);
            materialCard1.Margin = new Padding(16);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(16);
            materialCard1.Size = new Size(288, 106);
            materialCard1.TabIndex = 10;
            // 
            // lbTotalCustomer
            // 
            lbTotalCustomer.AutoSize = true;
            lbTotalCustomer.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalCustomer.Location = new Point(21, 41);
            lbTotalCustomer.Name = "lbTotalCustomer";
            lbTotalCustomer.Size = new Size(40, 46);
            lbTotalCustomer.TabIndex = 0;
            lbTotalCustomer.Text = "8";
            // 
            // lbTotalRoom
            // 
            lbTotalRoom.AutoSize = true;
            lbTotalRoom.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalRoom.Location = new Point(21, 18);
            lbTotalRoom.Name = "lbTotalRoom";
            lbTotalRoom.Size = new Size(132, 23);
            lbTotalRoom.TabIndex = 0;
            lbTotalRoom.Text = "Total Customers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 63);
            label2.Name = "label2";
            label2.Size = new Size(494, 23);
            label2.TabIndex = 5;
            label2.Text = "Maintain customer profiles, contact info, and booking eligibility.";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(lbTotalMale);
            materialCard2.Controls.Add(label5);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(349, 126);
            materialCard2.Margin = new Padding(16);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(16);
            materialCard2.Size = new Size(288, 106);
            materialCard2.TabIndex = 11;
            // 
            // lbTotalMale
            // 
            lbTotalMale.AutoSize = true;
            lbTotalMale.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalMale.ForeColor = Color.Blue;
            lbTotalMale.Location = new Point(21, 41);
            lbTotalMale.Name = "lbTotalMale";
            lbTotalMale.Size = new Size(40, 46);
            lbTotalMale.TabIndex = 0;
            lbTotalMale.Text = "2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 18);
            label5.Name = "label5";
            label5.Size = new Size(133, 23);
            label5.TabIndex = 0;
            label5.Text = "Male Customers";
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(lbTotalFemale);
            materialCard5.Controls.Add(label7);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(681, 126);
            materialCard5.Margin = new Padding(16);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(16);
            materialCard5.Size = new Size(288, 106);
            materialCard5.TabIndex = 12;
            // 
            // lbTotalFemale
            // 
            lbTotalFemale.AutoSize = true;
            lbTotalFemale.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalFemale.ForeColor = Color.Red;
            lbTotalFemale.Location = new Point(21, 41);
            lbTotalFemale.Name = "lbTotalFemale";
            lbTotalFemale.Size = new Size(40, 46);
            lbTotalFemale.TabIndex = 0;
            lbTotalFemale.Text = "3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(21, 18);
            label7.Name = "label7";
            label7.Size = new Size(150, 23);
            label7.TabIndex = 0;
            label7.Text = "Female Customers";
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(cbGender);
            materialCard4.Controls.Add(btUpdateCustomer);
            materialCard4.Controls.Add(btClear);
            materialCard4.Controls.Add(btDeleteCustomer);
            materialCard4.Controls.Add(btAddCustomer);
            materialCard4.Controls.Add(label16);
            materialCard4.Controls.Add(label15);
            materialCard4.Controls.Add(txtEmail);
            materialCard4.Controls.Add(txtPhone);
            materialCard4.Controls.Add(txtCustomerName);
            materialCard4.Controls.Add(label14);
            materialCard4.Controls.Add(txtCustomerId);
            materialCard4.Controls.Add(label10);
            materialCard4.Controls.Add(label12);
            materialCard4.Controls.Add(label13);
            materialCard4.Controls.Add(label11);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(18, 264);
            materialCard4.Margin = new Padding(16);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(16);
            materialCard4.Size = new Size(390, 608);
            materialCard4.TabIndex = 13;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(29, 406);
            label16.Name = "label16";
            label16.Size = new Size(128, 25);
            label16.TabIndex = 0;
            label16.Text = "Email Address";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(29, 319);
            label15.Name = "label15";
            label15.Size = new Size(139, 25);
            label15.TabIndex = 0;
            label15.Text = "Phone Number";
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Location = new Point(32, 434);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 38);
            txtEmail.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtEmail.StateActive.Border.Rounding = 8F;
            txtEmail.StateActive.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtEmail.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtEmail.StateNormal.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtEmail.TabIndex = 4;
            txtEmail.Text = "e.g. example@gmail.com";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtPhone
            // 
            txtPhone.Cursor = Cursors.IBeam;
            txtPhone.Location = new Point(32, 347);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(326, 38);
            txtPhone.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtPhone.StateActive.Border.Rounding = 8F;
            txtPhone.StateActive.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtPhone.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtPhone.StateNormal.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtPhone.TabIndex = 4;
            txtPhone.Text = "e.g. 09999XXXX";
            txtPhone.Enter += txtPhone_Enter;
            txtPhone.Leave += txtPhone_Leave;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Cursor = Cursors.IBeam;
            txtCustomerName.Location = new Point(29, 178);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(326, 38);
            txtCustomerName.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtCustomerName.StateActive.Border.Rounding = 8F;
            txtCustomerName.StateActive.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtCustomerName.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtCustomerName.StateNormal.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtCustomerName.TabIndex = 4;
            txtCustomerName.Text = "e.g. Moeurn Panha";
            txtCustomerName.Enter += txtCustomerName_Enter;
            txtCustomerName.Leave += txtCustomerName_Leave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(29, 235);
            label14.Name = "label14";
            label14.Size = new Size(74, 25);
            label14.TabIndex = 0;
            label14.Text = "Gender";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Cursor = Cursors.IBeam;
            txtCustomerId.Location = new Point(27, 95);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(328, 38);
            txtCustomerId.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtCustomerId.StateActive.Border.Rounding = 8F;
            txtCustomerId.StateActive.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtCustomerId.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerId.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtCustomerId.StateNormal.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtCustomerId.TabIndex = 4;
            txtCustomerId.Text = "101";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(26, 152);
            label10.Name = "label10";
            label10.Size = new Size(96, 25);
            label10.TabIndex = 0;
            label10.Text = "Full Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 46);
            label12.Name = "label12";
            label12.Size = new Size(291, 20);
            label12.TabIndex = 3;
            label12.Text = "-----------------------------------------------";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(21, 69);
            label13.Name = "label13";
            label13.Size = new Size(116, 25);
            label13.TabIndex = 0;
            label13.Text = "Customer ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(21, 18);
            label11.Name = "label11";
            label11.Size = new Size(235, 28);
            label11.TabIndex = 0;
            label11.Text = "Register New Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(265, 31);
            label1.TabIndex = 6;
            label1.Text = "Customer Management";
            // 
            // CustomerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard6);
            Controls.Add(materialCard7);
            Controls.Add(materialCard3);
            Controls.Add(materialCard1);
            Controls.Add(label2);
            Controls.Add(materialCard2);
            Controls.Add(materialCard5);
            Controls.Add(materialCard4);
            Controls.Add(label1);
            Name = "CustomerControl";
            Size = new Size(1307, 900);
            Load += CustomerControl_Load;
            materialCard6.ResumeLayout(false);
            materialCard7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbGender;
        private Krypton.Toolkit.KryptonButton btUpdateCustomer;
        private MaterialSkin.Controls.MaterialButton btClear;
        private MaterialSkin.Controls.MaterialButton btDeleteCustomer;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private Krypton.Toolkit.KryptonRichTextBox txtSearch;
        private MaterialSkin.Controls.MaterialButton btFilterRest;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialButton btAddCustomer;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Label lbTotalCustomerThisMonth;
        private Label label9;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lbTotalCustomer;
        private Label lbTotalRoom;
        private Label label2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label lbTotalMale;
        private Label label5;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private Label lbTotalFemale;
        private Label label7;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private Label label16;
        private Label label15;
        private Krypton.Toolkit.KryptonMaskedTextBox txtCustomerName;
        private Label label14;
        private Krypton.Toolkit.KryptonMaskedTextBox txtCustomerId;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label11;
        private Label label1;
        private Krypton.Toolkit.KryptonMaskedTextBox txtEmail;
        private Krypton.Toolkit.KryptonMaskedTextBox txtPhone;
        private ComboBox filterByGender;
        private DataGridView dgvCustomers;
    }
}
