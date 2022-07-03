using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using System.Net;
using System.Net.Http;
using System.IO;

namespace JASMINES__CONTACT_TRACING
{
    public partial class F7 : Form
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public F7()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;


        private void F7_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);   
            foreach (FilterInfo filterInfo in filterInfoCollection) 
                cbxDEVICE.Items.Add(filterInfo.Name);
            cbxDEVICE.SelectedIndex = 0;    
        }

        private void BttSTART_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbxDEVICE.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();  
            timer1.Start(); 
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbxCAM.Image = (Bitmap)eventArgs.Frame.Clone(); 
        }

        private void F7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();   
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pbxCAM.Image != null)
            {
                BarcodeReader barcodeReader = new();
                Result result = barcodeReader.Decode((Bitmap)pbxCAM.Image);
                if (result != null)
                {
                    txtQRSCAN.Text = result.ToString(); 
                    timer1.Stop();
                    string infoGathered = result.ToString();
                    StringBuilder sb = new StringBuilder(infoGathered);
                    infoGathered = sb.ToString();
                    string infoShown = infoGathered;
                    StreamWriter write = new StreamWriter(@"C:\Users\John Lloyd\Documents\CT app\List\QR Records.txt", true);
                    write.WriteLine();
                    write.Close();
                    MessageBox.Show("Save in the Qr code folder");
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }
    }
}
