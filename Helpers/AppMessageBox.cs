
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel_Management.Helpers {
    public enum MessageType {
        Success,
        Error,
        Warning,
        Information,
        Confirmation
    }

    public static class AppMessageBox {
        public static void Show(
            IWin32Window owner,
            string title,
            string message,
            MessageType type) {
            using (var form = new MessageBoxForm(
                title, message, type, false)) {
                form.ShowDialog(owner);
            }
        }

        public static bool Confirm(
            IWin32Window owner,
            string title,
            string message,
            MessageType type = MessageType.Confirmation) {
            using (var form = new MessageBoxForm(
                title, message, type, true)) {
                return form.ShowDialog(owner) == DialogResult.Yes;
            }
        }
    }

    internal class MessageBoxForm : Form {
        private Color themeColor;
        private string iconText;
        private bool isConfirmation;

        public MessageBoxForm(
            string title,
            string message,
            MessageType type,
            bool confirmation) {
            isConfirmation = confirmation;

            // Dynamic theme
            switch (type) {
                case MessageType.Success:
                    themeColor = Color.FromArgb(34, 197, 94);
                    iconText = "✓";
                    break;

                case MessageType.Error:
                    themeColor = Color.FromArgb(239, 68, 68);
                    iconText = "✕";
                    break;

                case MessageType.Warning:
                    themeColor = Color.FromArgb(245, 158, 11);
                    iconText = "!";
                    break;

                case MessageType.Information:
                    themeColor = Color.FromArgb(59, 130, 246);
                    iconText = "i";
                    break;

                default:
                    themeColor = Color.FromArgb(99, 102, 241);
                    iconText = "?";
                    break;
            }

            BuildUI(title, message);
        }

        private void BuildUI(string title, string message) {
            // Form settings
            Text = title;
            Size = new Size(450, 245);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            BackColor = Color.White;
            Font = new Font("Segoe UI", 10);

            // Top color line
            Panel topLine = new Panel();
            topLine.Dock = DockStyle.Top;
            topLine.Height = 6;
            topLine.BackColor = themeColor;
            Controls.Add(topLine);

            // Icon
            Label lblIcon = new Label();
            lblIcon.Text = iconText;
            lblIcon.Size = new Size(55, 55);
            lblIcon.Location = new Point(25, 35);
            lblIcon.BackColor = themeColor;
            lblIcon.ForeColor = Color.White;
            lblIcon.Font = new Font("Segoe UI", 25,
                FontStyle.Bold);
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(lblIcon);

            // Title
            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Location = new Point(95, 35);
            lblTitle.Size = new Size(310, 35);
            lblTitle.Font = new Font("Segoe UI", 15,
                FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
            Controls.Add(lblTitle);

            // Message
            Label lblMessage = new Label();
            lblMessage.Text = message;
            lblMessage.Location = new Point(95, 78);
            lblMessage.Size = new Size(310, 65);
            lblMessage.Font = new Font("Segoe UI", 10);
            lblMessage.ForeColor = Color.FromArgb(75, 85, 99);
            Controls.Add(lblMessage);

            // Buttons
            Button btnOK = CreateButton(
                isConfirmation ? "Yes, Continue" : "OK",
                themeColor);

            btnOK.Location = new Point(285, 160);
            btnOK.DialogResult = isConfirmation
                ? DialogResult.Yes
                : DialogResult.OK;

            Controls.Add(btnOK);

            if (isConfirmation) {
                Button btnCancel = CreateButton(
                    "Cancel", Color.FromArgb(107, 114, 128));

                btnCancel.Location = new Point(175, 160);
                btnCancel.DialogResult = DialogResult.No;

                Controls.Add(btnCancel);

                CancelButton = btnCancel;
            }

            AcceptButton = btnOK;
        }

        private Button CreateButton(string text, Color color) {
            Button btn = new Button();

            btn.Text = text;
            btn.Size = new Size(110, 38);
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 9,
                FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            return btn;
        }
    }
}
