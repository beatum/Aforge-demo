using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Controls;
using AForge.Video.DirectShow;
using System.Configuration;
using System.IO;

namespace Camera
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Device collection
        private FilterInfoCollection videoDevices = null;
        //Captrue device;
        private VideoCaptureDevice captrueDevice = null;
        //Captrue index
        private int deviceIndex = 0;
        //Current device names
        private String selectedDeviceName = null;

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.videoDevices = Function.Functions.loadCamerasList();
            if (this.videoDevices.Count <= 0) {
                MessageBox.Show("No Camera device found!!","Alert!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
        }

        //Start
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.videoDevices == null)
            {
                this.videoDevices = Function.Functions.loadCamerasList();
            }
            DeviceList deviceList = new DeviceList(this.videoDevices);
            DialogResult dialogResult = deviceList.ShowDialog();
            if (dialogResult != DialogResult.OK) {
                return;
            }
            deviceList.Dispose();
            string selectedDeviceName = deviceList.deviceName;
            toolStripStatusLabel1.Text = "Device Name:" + selectedDeviceName;
            this.deviceIndex = deviceList.deviceIndex;
            this.videoSourcePlayer1.Visible = true;
            this.captrueDevice = new VideoCaptureDevice(this.videoDevices[this.deviceIndex].MonikerString);
            this.videoSourcePlayer1.VideoSource = this.captrueDevice;
            this.videoSourcePlayer1.Start();
            this.buttonCaptrue.Enabled = true;
        }

        //Stop 
        private void stopDevice()
        {
            this.buttonCaptrue.Enabled = false;
            this.videoSourcePlayer1.SignalToStop();
            this.videoDevices = null;
            this.captrueDevice = null;
            this.deviceIndex = -1;
            toolStripStatusLabel1.Text = "Device Name:";
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.stopDevice();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.stopDevice();
        }

        private void buttonCaptrue_Click(object sender, EventArgs e)
        {
            if (this.captrueDevice == null) {
                return;
            }

            String filePath = Properties.Settings.Default.IMG_PATH.ToString();
            if (!Directory.Exists(filePath)) {
                MessageBox.Show("Directory\"" + filePath +"\"" + "does not found!!", "Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Bitmap bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
                string fileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-ff") + ".jpg";
                bitmap.Save(filePath + "\\" + fileName, ImageFormat.Jpeg);
                bitmap.Dispose();
                MessageBox.Show("Success", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show("Error:" + ex.Message, "Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.ShowDialog();
            setting.Dispose();
        }
    }
}
