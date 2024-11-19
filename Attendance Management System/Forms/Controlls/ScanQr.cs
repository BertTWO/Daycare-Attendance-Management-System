using Attendance_Management_System.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Attendance_Management_System.Forms.Controlls
{
    public partial class ScanQr : UserControl
    {
        public ScanQr()
        {
            InitializeComponent();
        }
        QrHelper qrHelper;
        private void btnScan_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            qrHelper = new QrHelper(pbxCamera);
            qrHelper.OnQrCodeScanned += HandleQrCodeScanned;
            qrHelper.StartScanning();
        }

        private void HandleQrCodeScanned(string result)
        {
            Invoke((MethodInvoker)(() =>
            {
                txtResultID.Text = result;
                txtResultID.BorderColorIdle = Color.Green;
            }));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

            qrHelper.Dispose();
            pbxCamera.Image = null;
            btnStop.Enabled = false;
            txtResultID.Text = null;
        }

        private void ScanQr_Load(object sender, EventArgs e)
        {

        }

        private void ScanQr_Leave(object sender, EventArgs e)
        {
            qrHelper.Dispose();
        }
    }
}
