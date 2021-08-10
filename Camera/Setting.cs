using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camera
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            this.textBoxImgPath.Text = Properties.Settings.Default.IMG_PATH.ToString().Trim();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string imgPath = this.textBoxImgPath.Text;
            if (string.IsNullOrEmpty(imgPath))
            {
                MessageBox.Show("File name can't null or empty!!", "Alert!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Properties.Settings.Default.IMG_PATH = imgPath.Trim();
                Properties.Settings.Default.Save();
                MessageBox.Show("Success!!", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void buttonFilePathOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBoxImgPath.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
