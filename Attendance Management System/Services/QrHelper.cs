using AForge.Video;
using AForge.Video.DirectShow;
using QRCoder;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ZXing;

namespace Attendance_Management_System.Services
{
    internal class QrHelper : IDisposable
    {
        private FilterInfoCollection cameraDevice;
        private VideoCaptureDevice videoSource;
        private PictureBox pbxCamera;

        public event Action<string> OnQrCodeScanned;

        public QrHelper(PictureBox pbxCamera)
        {
            this.pbxCamera = pbxCamera;
        }

        public static Image GenerateQr(string qrData)
        {
            try
            {
                using (QRCodeGenerator generator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = generator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {

                        return qrCode.GetGraphic(20);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("QR CodeHelper Error\n" + ex.Message);
            }
        }

        public void StartScanning()
        {
            try
            {
                cameraDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (cameraDevice.Count > 0)
                {
                    videoSource = new VideoCaptureDevice(cameraDevice[0].MonikerString);
                    videoSource.NewFrame += VideoSource_NewFrame;
                    videoSource.Start();
                }
                else
                {
                    throw new Exception("No camera devices found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting QR scanning: {ex.Message}");
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                using (Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone())
                {

                    pbxCamera.Invoke((MethodInvoker)(() => pbxCamera.Image = (Bitmap)bitmap.Clone()));


                    BarcodeReader reader = new BarcodeReader();
                    var result = reader.Decode(bitmap);

                    if (result != null)
                    {


                        OnQrCodeScanned?.Invoke(result.Text);
                        Dispose();

                        Thread.Sleep(50);
                        StartScanning();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing video frame: {ex.Message}");
            }
        }


        public void StopScanning()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.NewFrame -= VideoSource_NewFrame;
                videoSource = null;
            }
        }

        public void Dispose()
        {
            StopScanning();
        }
    }
}
