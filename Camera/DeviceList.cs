using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Controls;
using AForge.Video.DirectShow;


namespace Camera
{
    public partial class DeviceList : Form
    {
        public DeviceList(FilterInfoCollection dev)
        {
            InitializeComponent();
            this.devices = dev;
        }

        private FilterInfoCollection devices = null;
        public string deviceName = null;
        public int deviceIndex = -1;
        private void DeviceList_Load(object sender, EventArgs e)
        {
            if (this.devices.Count <= 0)
            {
                this.comboBoxDeviceList.Enabled = false;
            }
            else {
                this.comboBoxDeviceList.Enabled = true;
            }

            for (int i = 0; i < this.devices.Count; i++) {
                comboBoxDeviceList.Items.Add(this.devices[i].Name);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            String deviceNameOfSelected = this.comboBoxDeviceList.Text;
            if (deviceNameOfSelected == "" || deviceNameOfSelected == null)
            {
                MessageBox.Show("you must selected a camera device of you need!!", "Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.None;
                return;
            }
            else {
                this.deviceName = this.comboBoxDeviceList.Text.Trim();
                this.deviceIndex = this.comboBoxDeviceList.SelectedIndex;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
