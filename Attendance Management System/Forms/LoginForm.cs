using Attendance_Management_System.Forms;
using Attendance_Management_System.Login;
using Attendance_Management_System.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Attendance_Management_System
{

    public partial class LoginForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public LoginForm()
        {
            InitializeComponent();
            pnlTop.MouseDown += pnlTop_MouseDown;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            var users = User.Users.FirstOrDefault(u => u.Username == txtUsername.Text &&
            PasswordHelper.VerifyPassword(txtPassword.Text, u.Password));
            if (users != null)
            {
                var mainForm = new MainForm();
                mainForm.Show();
                Hide();
            }

        }

        private void cbViewPassword_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (e.Checked)
            {



                txtPassword.Font = txtUsername.Font;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.Font = new Font(txtPassword.Font.FontFamily, 9.75F, txtPassword.Font.Style);
                txtPassword.PasswordChar = '●';

            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t = new text();
            t.Show();
            Hide();
        }
    }
}
