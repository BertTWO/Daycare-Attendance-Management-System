using Attendance_Management_System.Forms.Controlls;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Attendance_Management_System.Forms
{
    public partial class MainForm : Form
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
            pnlTop.MouseDown += pnlTop_MouseDown;

        }

        bool isAddExpanding = true;
        bool isMsgExpanding = true;


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var ctrlAddStudent = new AddStudent();

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(ctrlAddStudent);


        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btnAddLayout_Click(object sender, EventArgs e)
        {
            timerAdd.Start();
        }
        private void ExpandPanel(FlowLayoutPanel layoutPanel, ref bool isExpanding, Timer timer)
        {
            if (isExpanding)
            {
                layoutPanel.Height += 10;
                if (layoutPanel.Height >= layoutPanel.MaximumSize.Height)
                {
                    isExpanding = false;
                    timer.Stop();
                }
            }
            else
            {
                layoutPanel.Height -= 10;
                if (layoutPanel.Height <= layoutPanel.MinimumSize.Height)
                {
                    isExpanding = true;
                    timer.Stop();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ExpandPanel(LayoutPanel, ref isAddExpanding, timerAdd);
        }

        private void btnScanQr_Click(object sender, EventArgs e)
        {
            ShowScanQrControll();
        }
        private void ShowScanQrControll()
        {

            var scanQr = new ScanQr();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(scanQr);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowScanQrControll();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            timerMsg.Start();
        }

        private void timerMsg_Tick(object sender, EventArgs e)
        {
            ExpandPanel(msgLayoutPanel, ref isMsgExpanding, timerMsg);
        }
    }
}
