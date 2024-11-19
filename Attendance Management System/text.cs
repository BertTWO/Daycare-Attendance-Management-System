using Attendance_Management_System.Login;
using Attendance_Management_System.Model;
using System;
using System.Windows.Forms;

namespace Attendance_Management_System
{
    public partial class text : Form
    {
        public text()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var HashedPassword = PasswordHelper.HashPassword(textBox2.Text);

            User.Users.Add(new User { Username = textBox1.Text, Password = HashedPassword });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            Hide();
        }
    }
}
