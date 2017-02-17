using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TnAConfigureProgram
{
    public partial class Add_New_Firmware : Form
    {
        Form opener;

        public Add_New_Firmware(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            comboBoxBin.Refresh();
            comboBoxBin.Items.Clear();
            comboBoxHex.Refresh();
            comboBoxHex.Items.Clear();

            FolderBrowserDialog ofd = new FolderBrowserDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxFirmLocation.Text = ofd.SelectedPath;

                if (Directory.Exists(textBoxFirmLocation.Text))
                {
                    {
                        string[] hex = Directory.GetFiles(textBoxFirmLocation.Text, "*.hex");
                        string[] bin = Directory.GetFiles(textBoxFirmLocation.Text, "*.bin");

                        foreach (string hexFile in hex)
                        {
                            comboBoxHex.Items.Add(Path.GetFileName(hexFile));
                        }

                        foreach (string binFile in bin)
                        {
                            comboBoxBin.Items.Add(Path.GetFileName(binFile));
                        }
                    }
                }
            }
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxHex.Text) && string.IsNullOrEmpty(comboBoxBin.Text))
            {
                string message = "Please select a file to save to \nthe firmware folder.";
                labelMessages(message);
            }
            else if (string.IsNullOrEmpty(comboBoxBin.Text))
            {
                string message = ".hex file has been saved.";
                string userProfile = textBoxFirmLocation.Text + "\\" + comboBoxHex.Text;
                string boxProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string boxsubFolders = @"Box Sync\Tna\TnA Configs\Programs\LC prog\Firmware\";

                var dBox = Path.Combine(boxProfile, boxsubFolders);

                FlashManager box = new FlashManager();
                box.Xcopy(userProfile, dBox);
                labelMessages(message);
            }
            else if (string.IsNullOrEmpty(comboBoxHex.Text))
            {
                string message = ".bin file has been saved.";
                string userProfile = textBoxFirmLocation.Text + "\\" + comboBoxBin.Text;
                string boxProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string boxsubFolders = @"Box Sync\Tna\TnA Configs\Programs\LC prog\Firmware\";

                var dBox = Path.Combine(boxProfile, boxsubFolders);

                FlashManager box = new FlashManager();
                box.Xcopy(userProfile, dBox);
                labelMessages(message);
            }
            else
            {
                string message = ".hex file has been saved. \n.bin file has been saved.";
                string userProfile = textBoxFirmLocation.Text + "\\" + comboBoxHex.Text;
                string userProfile2 = textBoxFirmLocation.Text + "\\" + comboBoxBin.Text;
                string boxProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string boxsubFolders = @"Box Sync\Tna\TnA Configs\Programs\LC prog\Firmware\";

                var dBox = Path.Combine(boxProfile, boxsubFolders);

                FlashManager box = new FlashManager();
                box.Xcopy(userProfile, dBox);
                box.Xcopy(userProfile2, dBox);
                labelMessages(message);
            }
        }

        private void labelMessages(string message)
        {
            StringBuilder labMessage = new StringBuilder();

            labMessage.Append(message);
            labMessage.Append(Environment.NewLine);
            labelMessage.Text = labMessage.ToString();
        }
    }
}
