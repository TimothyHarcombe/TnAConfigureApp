using System;
using System.Windows.Forms;
using System.IO;

namespace TnAConfigureProgram
{
    public partial class LifeLoc : Form
    {
        Form opener;

        public LifeLoc(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void LifeLoc_Load(object sender, EventArgs e)
        {
            DriveInfo[] allFlash = DriveInfo.GetDrives();
            foreach (DriveInfo usb in allFlash)
            {
                if (usb.DriveType == DriveType.Removable)
                {
                    string type = "";
                    double size = usb.TotalSize;
                    double totalSize;
                    const string TEXT_TAB = "  ===>  ";             
                    
                    if (size > 1073741824)
                    {
                        totalSize = size / 1073741824;
                        size = Math.Round(totalSize, 2);
                        type = "GB";
                    }
                    else if (size > 1048576)
                    {
                        totalSize = usb.TotalSize / 1048576;
                        size = Math.Round(totalSize, 2);
                        type = "MB";
                    }
                    else if (size >= 1024)
                    {
                        totalSize = usb.TotalSize / 1024;
                        size = Math.Round(totalSize, 2);
                        type = "KB";
                    }
                    
                    if (usb.IsReady == true)
                    {             
                        string info = usb.Name + " " + usb.VolumeLabel + TEXT_TAB + size + type + " (" + usb.DriveFormat + ")";
                        comboBoxUSBDevice.Items.Add(usb.Name);                         
                        richTextBoxDeviceInfo.Text = info;
                        
                    }                    
                }                           
            }
        }        

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLeftArrow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxUSBDevice.Text))
            {
                MessageBox.Show("Please select a USB Device.", "Warning");
                return;
            }
            else
            {            
                string fSystem;
                string dLetter;
                string dL;
                string dLC;

                dLetter = comboBoxUSBDevice.SelectedItem.ToString();
                dL = dLetter.Substring(0, 2);
                dLC = dLetter.Substring(0, 3);

                if (radioButtonFAT.Checked == true)
                {
                    fSystem = radioButtonFAT.Text;
                }
                else if (radioButtonFAT32.Checked == true)
                {
                    fSystem = radioButtonFAT32.Text;
                }
                else if (radioButtonEXFAT.Checked == true)
                {
                    fSystem = radioButtonEXFAT.Text;
                }
                else if (radioButtonNTFS.Checked == true)
                {
                    fSystem = radioButtonNTFS.Text;
                }
                else if (radioButtonUDF.Checked == true)
                {
                    fSystem = radioButtonUDF.Text;
                }
                else
                {
                    MessageBox.Show("Please select a File System to format.");
                    return;
                }

                DialogResult areYouSure = MessageBox.Show("Are you sure you want to format this usb drive and load the Left Arrow Firmware", "Warning", MessageBoxButtons.YesNo);

                if (areYouSure == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;

                    FlashManager format = new FlashManager();
                    format.FormatFlash(dL, fSystem, "Left_Arrow");

                    FlashManager xcopy = new FlashManager();
                    xcopy.FlashFileCopyLeft(dLC);

                    Cursor = Cursors.Default;
                }
                else if (areYouSure == DialogResult.No)
                {
                    return;
                }

                MessageBox.Show("Format Completed and Left Arrow Firmware loaded");
            }
        }

        private void buttonRightArrow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxUSBDevice.Text))
            {
                MessageBox.Show("Please select a USB Device.", "Warning");
                return;
            }
            else
            {
                string fSystem;
                string dLetter;
                string dL;
                string dLC;

                dLetter = comboBoxUSBDevice.SelectedItem.ToString();
                dL = dLetter.Substring(0, 2);
                dLC = dLetter.Substring(0, 3);

                if (radioButtonFAT.Checked == true)
                {
                    fSystem = radioButtonFAT.Text;
                }
                else if (radioButtonFAT32.Checked == true)
                {
                    fSystem = radioButtonFAT32.Text;
                }
                else if (radioButtonEXFAT.Checked == true)
                {
                    fSystem = radioButtonEXFAT.Text;
                }
                else if (radioButtonNTFS.Checked == true)
                {
                    fSystem = radioButtonNTFS.Text;
                }
                else if (radioButtonUDF.Checked == true)
                {
                    fSystem = radioButtonUDF.Text;
                }
                else
                {
                    MessageBox.Show("Please select a File System to format.");
                    return;
                }

                DialogResult areYouSure = MessageBox.Show("Are you sure you want to format this usb drive and load the Right Arrow Firmware", "Warning", MessageBoxButtons.YesNo);

                if (areYouSure == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;

                    FlashManager format = new FlashManager();
                    format.FormatFlash(dL, fSystem, "Right_Arrow");

                    FlashManager xcopy = new FlashManager();
                    xcopy.FlashFileCopyRight(dLC);

                    Cursor = Cursors.Default;
                }
                else if (areYouSure == DialogResult.No)
                {
                    return;
                }

                MessageBox.Show("Format Completed and Right Arrow Firmware loaded");
            }
        }

        private void buttonFormat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxUSBDevice.Text))
            {
                MessageBox.Show("Please select a USB Device.", "Warning");
                return;
            }
            else
            {
                string fSystem;
                string dLetter;
                string dL;

                dLetter = comboBoxUSBDevice.SelectedItem.ToString();
                dL = dLetter.Substring(0, 2);

                if (radioButtonFAT.Checked == true)
                {
                    fSystem = radioButtonFAT.Text;
                }
                else if (radioButtonFAT32.Checked == true)
                {
                    fSystem = radioButtonFAT32.Text;
                }
                else if (radioButtonEXFAT.Checked == true)
                {
                    fSystem = radioButtonEXFAT.Text;
                }
                else if (radioButtonNTFS.Checked == true)
                {
                    fSystem = radioButtonNTFS.Text;
                }
                else if (radioButtonUDF.Checked == true)
                {
                    fSystem = radioButtonUDF.Text;
                }
                else
                {
                    MessageBox.Show("Please select a File System to format.");
                    return;
                }

                DialogResult areYouSure = MessageBox.Show("Are you sure you want to format this usb drive", "Warning", MessageBoxButtons.YesNo);

                if (areYouSure == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;

                    FlashManager format = new FlashManager();
                    format.FormatFlash(dL, fSystem, "New_Volume");

                    Cursor = Cursors.Default;
                }
                else if (areYouSure == DialogResult.No)
                {
                    return;
                }

                MessageBox.Show("Format Completed");                
            }
        }       
    }
}

