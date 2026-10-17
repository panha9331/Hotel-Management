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
        private void InitializeComponent()
        {
            comboBox2 = new ComboBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            label18 = new Label();
            internalSearchableExceptionTreeView1 = new Krypton.Toolkit.InternalSearchableExceptionTreeView();
            materialCard6 = new MaterialSkin.Controls.MaterialCard();
            comboBox1 = new ComboBox();
            kryptonRichTextBox1 = new Krypton.Toolkit.KryptonRichTextBox();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            kryptonListBox1 = new Krypton.Toolkit.KryptonListBox();
            materialCard7 = new MaterialSkin.Controls.MaterialCard();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label17 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            label8 = new Label();
            label9 = new Label();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            label3 = new Label();
            lbTotalRoom = new Label();
            label2 = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            label4 = new Label();
            label5 = new Label();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            label6 = new Label();
            label7 = new Label();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            label16 = new Label();
            label15 = new Label();
            kryptonMaskedTextBox3 = new Krypton.Toolkit.KryptonMaskedTextBox();
            kryptonMaskedTextBox2 = new Krypton.Toolkit.KryptonMaskedTextBox();
            kryptonMaskedTextBox1 = new Krypton.Toolkit.KryptonMaskedTextBox();
            label14 = new Label();
            txtRoomId = new Krypton.Toolkit.KryptonMaskedTextBox();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            label1 = new Label();
            materialCard6.SuspendLayout();
            materialCard7.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard5.SuspendLayout();
            materialCard4.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.AllowDrop = true;
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.DisplayMember = "Anvailable";
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Female (F)", "Male (M)", "Other (N)" });
            comboBox2.Location = new Point(29, 261);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(326, 36);
            comboBox2.Sorted = true;
            comboBox2.TabIndex = 4;
            comboBox2.Text = "Male (M)";
            // 
            // kryptonButton1
            // 
            kryptonButton1.ButtonStyle = Krypton.Toolkit.ButtonStyle.Gallery;
            kryptonButton1.Cursor = Cursors.Hand;
            kryptonButton1.Location = new Point(200, 496);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(158, 36);
            kryptonButton1.StateCommon.Border.Rounding = 4F;
            kryptonButton1.TabIndex = 3;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "UPDATE";
            // 
            // materialButton4
            // 
            materialButton4.AutoSize = false;
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Cursor = Cursors.Hand;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(200, 550);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(158, 36);
            materialButton4.TabIndex = 5;
            materialButton4.Text = "Clear";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Cursor = Cursors.Hand;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(35, 550);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(158, 36);
            materialButton3.TabIndex = 5;
            materialButton3.Text = "Delete";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = true;
            materialButton3.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(197, 18);
            label18.Name = "label18";
            label18.Size = new Size(118, 28);
            label18.TabIndex = 5;
            label18.Text = "FULL NAME";
            // 
            // internalSearchableExceptionTreeView1
            // 
            internalSearchableExceptionTreeView1.BackColor = Color.Transparent;
            internalSearchableExceptionTreeView1.Location = new Point(1026, 497);
            internalSearchableExceptionTreeView1.Margin = new Padding(4, 5, 4, 5);
            internalSearchableExceptionTreeView1.Name = "internalSearchableExceptionTreeView1";
            internalSearchableExceptionTreeView1.Size = new Size(8, 8);
            internalSearchableExceptionTreeView1.TabIndex = 14;
            // 
            // materialCard6
            // 
            materialCard6.BackColor = Color.FromArgb(255, 255, 255);
            materialCard6.Controls.Add(comboBox1);
            materialCard6.Controls.Add(kryptonRichTextBox1);
            materialCard6.Controls.Add(materialButton2);
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
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DisplayMember = "Anvailable";
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Female (F)", "Male (M)", "Other (N)" });
            comboBox1.Location = new Point(586, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(119, 36);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 4;
            comboBox1.Text = "All Gender";
            // 
            // kryptonRichTextBox1
            // 
            kryptonRichTextBox1.AlwaysActive = false;
            kryptonRichTextBox1.Cursor = Cursors.IBeam;
            kryptonRichTextBox1.Location = new Point(23, 22);
            kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            kryptonRichTextBox1.Size = new Size(557, 36);
            kryptonRichTextBox1.StateActive.Border.Color1 = Color.Red;
            kryptonRichTextBox1.StateActive.Border.Rounding = 8F;
            kryptonRichTextBox1.StateNormal.Border.Color1 = Color.FromArgb(128, 255, 128);
            kryptonRichTextBox1.StateNormal.Border.Rounding = 8F;
            kryptonRichTextBox1.TabIndex = 1;
            kryptonRichTextBox1.Text = "Search by ID, Full Name, Phone...";
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Cursor = Cursors.Hand;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(714, 22);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(103, 36);
            materialButton2.TabIndex = 5;
            materialButton2.Text = "Rest";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // kryptonListBox1
            // 
            kryptonListBox1.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridHeaderRowList;
            kryptonListBox1.BorderStyle = Krypton.Toolkit.PaletteBorderStyle.GridHeaderColumnCustom2;
            kryptonListBox1.Cursor = Cursors.Hand;
            kryptonListBox1.Items.AddRange(new object[] { "C001\t\t\t\t\t\t     Moeurn Panha\t\t      Male\t\t\t 087655117\t\tmoeurn.panha.dev@gmail.com", "C001\t\t\t\t\t\t     Moeurn Panha\t\t      Male\t\t\t 087655117\t\tmoeurn.panha.dev@gmail.com", "C001\t\t\t\t\t\t     Moeurn Panha\t\t      Male\t\t\t 087655117\t\tmoeurn.panha.dev@gmail.com", "C001\t\t\t\t\t\t     Moeurn Panha\t\t      Male\t\t\t 087655117\t\tmoeurn.panha.dev@gmail.com", "C001\t\t\t\t\t\t     Moeurn Panha\t\t      Male\t\t\t 087655117\t\tmoeurn.panha.dev@gmail.com", "C001\t\t\t\t\t\t     Moeurn Panha\t\t      Male\t\t\t 087655117\t\tmoeurn.panha.dev@gmail.com" });
            kryptonListBox1.Location = new Point(452, 414);
            kryptonListBox1.Name = "kryptonListBox1";
            kryptonListBox1.Size = new Size(837, 458);
            kryptonListBox1.StateCheckedNormal.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonListBox1.StateCheckedPressed.Item.Back.Color1 = Color.FromArgb(255, 128, 255);
            kryptonListBox1.StateCheckedPressed.Item.Border.Color1 = Color.FromArgb(192, 255, 255);
            kryptonListBox1.StateCheckedPressed.Item.Border.Rounding = 4F;
            kryptonListBox1.StateCheckedPressed.Item.Content.ShortText.Color1 = Color.FromArgb(128, 255, 128);
            kryptonListBox1.StateCheckedPressed.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonListBox1.StateCommon.Border.Color1 = Color.FromArgb(128, 255, 255);
            kryptonListBox1.StateCommon.Border.Rounding = 8F;
            kryptonListBox1.StateCommon.Item.Content.AdjacentGap = 5;
            kryptonListBox1.StateCommon.Item.Content.Padding = new Padding(-1, 5, -1, 5);
            kryptonListBox1.StateCommon.Item.Content.ShortText.Color1 = Color.DarkViolet;
            kryptonListBox1.StateCommon.Item.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidInside;
            kryptonListBox1.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonListBox1.TabIndex = 15;
            // 
            // materialCard7
            // 
            materialCard7.BackColor = Color.FromArgb(255, 255, 255);
            materialCard7.Controls.Add(label21);
            materialCard7.Controls.Add(label20);
            materialCard7.Controls.Add(label19);
            materialCard7.Controls.Add(label18);
            materialCard7.Controls.Add(label17);
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
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(663, 16);
            label21.Name = "label21";
            label21.Size = new Size(69, 28);
            label21.TabIndex = 5;
            label21.Text = "EMAIL";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(501, 16);
            label20.Name = "label20";
            label20.Size = new Size(79, 28);
            label20.TabIndex = 5;
            label20.Text = "PHONE";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(369, 16);
            label19.Name = "label19";
            label19.Size = new Size(87, 28);
            label19.TabIndex = 5;
            label19.Text = "GENDER";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(19, 16);
            label17.Name = "label17";
            label17.Size = new Size(140, 28);
            label17.TabIndex = 5;
            label17.Text = "CUSTOMER ID";
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Cursor = Cursors.Hand;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(35, 496);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(158, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "Add Customer";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(label8);
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Lime;
            label8.Location = new Point(21, 41);
            label8.Name = "label8";
            label8.Size = new Size(64, 46);
            label8.TabIndex = 0;
            label8.Text = "+3";
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
            materialCard1.Controls.Add(label3);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 41);
            label3.Name = "label3";
            label3.Size = new Size(40, 46);
            label3.TabIndex = 0;
            label3.Text = "8";
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
            materialCard2.Controls.Add(label4);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(21, 41);
            label4.Name = "label4";
            label4.Size = new Size(40, 46);
            label4.TabIndex = 0;
            label4.Text = "2";
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
            materialCard5.Controls.Add(label6);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(21, 41);
            label6.Name = "label6";
            label6.Size = new Size(40, 46);
            label6.TabIndex = 0;
            label6.Text = "3";
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
            materialCard4.Controls.Add(comboBox2);
            materialCard4.Controls.Add(kryptonButton1);
            materialCard4.Controls.Add(materialButton4);
            materialCard4.Controls.Add(materialButton3);
            materialCard4.Controls.Add(materialButton1);
            materialCard4.Controls.Add(label16);
            materialCard4.Controls.Add(label15);
            materialCard4.Controls.Add(kryptonMaskedTextBox3);
            materialCard4.Controls.Add(kryptonMaskedTextBox2);
            materialCard4.Controls.Add(kryptonMaskedTextBox1);
            materialCard4.Controls.Add(label14);
            materialCard4.Controls.Add(txtRoomId);
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
            // kryptonMaskedTextBox3
            // 
            kryptonMaskedTextBox3.Cursor = Cursors.IBeam;
            kryptonMaskedTextBox3.Location = new Point(32, 434);
            kryptonMaskedTextBox3.Name = "kryptonMaskedTextBox3";
            kryptonMaskedTextBox3.Size = new Size(326, 38);
            kryptonMaskedTextBox3.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonMaskedTextBox3.StateActive.Border.Rounding = 8F;
            kryptonMaskedTextBox3.StateActive.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonMaskedTextBox3.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonMaskedTextBox3.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonMaskedTextBox3.StateNormal.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonMaskedTextBox3.TabIndex = 4;
            kryptonMaskedTextBox3.Text = "e.g. example@gmail.com";
            // 
            // kryptonMaskedTextBox2
            // 
            kryptonMaskedTextBox2.Cursor = Cursors.IBeam;
            kryptonMaskedTextBox2.Location = new Point(32, 347);
            kryptonMaskedTextBox2.Name = "kryptonMaskedTextBox2";
            kryptonMaskedTextBox2.Size = new Size(326, 38);
            kryptonMaskedTextBox2.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonMaskedTextBox2.StateActive.Border.Rounding = 8F;
            kryptonMaskedTextBox2.StateActive.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonMaskedTextBox2.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonMaskedTextBox2.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonMaskedTextBox2.StateNormal.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonMaskedTextBox2.TabIndex = 4;
            kryptonMaskedTextBox2.Text = "e.g. 09999XXXX";
            // 
            // kryptonMaskedTextBox1
            // 
            kryptonMaskedTextBox1.Cursor = Cursors.IBeam;
            kryptonMaskedTextBox1.Location = new Point(29, 178);
            kryptonMaskedTextBox1.Name = "kryptonMaskedTextBox1";
            kryptonMaskedTextBox1.Size = new Size(326, 38);
            kryptonMaskedTextBox1.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            kryptonMaskedTextBox1.StateActive.Border.Rounding = 8F;
            kryptonMaskedTextBox1.StateActive.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonMaskedTextBox1.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonMaskedTextBox1.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonMaskedTextBox1.StateNormal.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonMaskedTextBox1.TabIndex = 4;
            kryptonMaskedTextBox1.Text = "e.g. Moeurn Panha";
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
            // txtRoomId
            // 
            txtRoomId.Cursor = Cursors.IBeam;
            txtRoomId.Location = new Point(27, 95);
            txtRoomId.Name = "txtRoomId";
            txtRoomId.Size = new Size(328, 38);
            txtRoomId.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            txtRoomId.StateActive.Border.Rounding = 8F;
            txtRoomId.StateActive.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtRoomId.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomId.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtRoomId.StateNormal.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtRoomId.TabIndex = 4;
            txtRoomId.Text = "C001";
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
            Controls.Add(internalSearchableExceptionTreeView1);
            Controls.Add(materialCard6);
            Controls.Add(kryptonListBox1);
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
            materialCard7.PerformLayout();
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
        private ComboBox comboBox2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private Label label18;
        private Krypton.Toolkit.InternalSearchableExceptionTreeView internalSearchableExceptionTreeView1;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private Krypton.Toolkit.KryptonListBox kryptonListBox1;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label17;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Label label8;
        private Label label9;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label label3;
        private Label lbTotalRoom;
        private Label label2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private Label label4;
        private Label label5;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private Label label6;
        private Label label7;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private Label label16;
        private Label label15;
        private Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBox1;
        private Label label14;
        private Krypton.Toolkit.KryptonMaskedTextBox txtRoomId;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label11;
        private Label label1;
        private Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBox3;
        private Krypton.Toolkit.KryptonMaskedTextBox kryptonMaskedTextBox2;
        private ComboBox comboBox1;
    }
}
