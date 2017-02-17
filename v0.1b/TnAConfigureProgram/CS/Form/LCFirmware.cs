using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace TnAConfigureProgram
{
    public partial class LCFirmware : Form
    {
        Form opener;

        public LCFirmware(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
            nic_adpt();
        }

        public List<string> nic_adpt()
        {
            List<String> values = new List<String>();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                values.Add(nic.Name);
                comboBoxNicAdapter.Items.Add(nic.Name);
            }
            return values;
        }

        private void LCFirmware_Load(object sender, EventArgs e)
        {
            buttonRegionAndRefresh();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxNicAdapter.Text) || string.IsNullOrEmpty(textBoxIPAdd.Text) || string.IsNullOrEmpty(textBoxLCIP.Text) || string.IsNullOrEmpty(comboBoxLCFirm.Text))
            {
                MessageBox.Show("Please make sure the following fields are filled in: \n\t* Network Index\n\t* Your IP Address\n\t* LC Ip Address\n\t*LC Firmware", "Warning");
                return;
            }
            else
            {
                NetworkManagement setIp = new NetworkManagement();
                setIp.setIP(comboBoxNicAdapter.Text, textBoxIPAdd.Text, "255.255.255.0");

                string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                string subFolders = @"Box Sync\Tna\TnA Configs\Programs\LC prog\Firmware\";

                var path = Path.Combine(userProfile, subFolders, comboBoxLCFirm.Text);

                UdpClient udp = new UdpClient();
                udp.Connect(textBoxLCIP.Text, 69);
                Byte[] sdata = Encoding.ASCII.GetBytes(path);
                udp.Send(sdata, sdata.Length);
                udp.Close();

                var dhcp = new NetworkManagement();
                dhcp.setDHCP(comboBoxNicAdapter.Text);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxNicAdapter.Text) || string.IsNullOrEmpty(textBoxIPAdd.Text) || string.IsNullOrEmpty(textBoxLCIP.Text) || string.IsNullOrEmpty(comboBoxLCFirm.Text))
            {
                MessageBox.Show("Please make sure the following fields are filled in: \n\t* Network Index\n\t* Your IP Address\n\t* LC Ip Address\n\t*LC Firmware", "Warning");
                return;
            }
            else
            {
                NetworkManagement setIp = new NetworkManagement();
                setIp.setIP(comboBoxNicAdapter.Text, textBoxIPAdd.Text, "255.255.255.0");

                ProcessStartInfo startLC = new ProcessStartInfo("iexplore.exe", textBoxLCIP.Text + "/mpfsupload");
                Process.Start(startLC);

                var dhcp = new NetworkManagement();
                dhcp.setDHCP(comboBoxNicAdapter.Text);
            }
        }

        private void buttonAddFirmList_Click(object sender, EventArgs e)
        {
            //Add_New_Firmware add = new Add_New_Firmware(this);
            //add.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            buttonRegionAndRefresh();
        }

        private void buttonRegionAndRefresh()
        {
            //    comboBoxLCFirm.ResetText();
            //    comboBoxLCFirm.Items.Clear();

            //    string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            //    string subFolders = @"Box Sync\Tna\TnA Configs\Programs\LC prog\Firmware";

            //    var pathDir = Path.Combine(userProfile, subFolders);

            //    if (Directory.Exists(pathDir))
            //    {
            //        string[] files = Directory.GetFiles(pathDir, "*.hex");

            //        foreach (string file in files)
            //        {
            //            comboBoxLCFirm.Items.Add(Path.GetFileName(file));
            //        }
            //}
        }
    }
}
