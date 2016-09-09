using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Management;
using System.Net.Sockets;
using System.Text;

namespace TnAConfigureProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            
            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    richTextBoxNICAdapters.AppendText("Index:\t[" + (uint)objMO["Index"] + "]\t(" + (string)objMO["Description"] + ")\n");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonConfigureGateway_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIndex.Text))
            {
                MessageBox.Show("Please select a Network Adapter.", "Warning");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxSelectSite.Text))
            {
                MessageBox.Show("Please select a directory for the configuration files.", "Warning");
                return;
            }
            else if (string.IsNullOrEmpty(comboBoxGWArea.Text))
            {
                MessageBox.Show("Please select GateWay Area.", "Warning");
                return;
            }            
            else
            {
                int index;
                index = int.Parse(textBoxIndex.Text);

                NetworkManagement setIp = new NetworkManagement();
                setIp.setIP(index, "100.100.100.103", "255.255.255.0");

                Telnet();

                var dhcp = new NetworkManagement();
                dhcp.setDHCP();
            }
        }

        private void buttonConfigureSagem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIndex.Text))
            {
                MessageBox.Show("Please select a Network Adapter.", "Warning");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxMATM.Text))
            {
                MessageBox.Show("Please select a directory of the MATM program.", "Warning");
                return;
            }
            else
            {
                int index;
                index = int.Parse(textBoxIndex.Text);
                NetworkManagement setIp = new NetworkManagement();
                setIp.setIP(index, "134.1.32.213", "255.255.255.0");

                ProcessStartInfo start = new ProcessStartInfo();

                var path = textBoxMATM.Text;
                start.FileName = path;
                start.WindowStyle = ProcessWindowStyle.Normal;
                start.CreateNoWindow = true;
                int exitCode;

                using (Process prog = Process.Start(start))
                {
                    prog.WaitForExit();
                    exitCode = prog.ExitCode;
                }

                var dhcp = new NetworkManagement();
                dhcp.setDHCP();
            }            
        }

        private void addNewSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSite add = new AddSite(this);
            add.Show();
        }

        private void changeSiteInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSiteInfo chg = new ChangeSiteInfo(this);
            chg.Show();
        }

        private void decommissionedGateWayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecomGateWay dcg = new DecomGateWay(this);
            dcg.Show();
        }

        private void aboutTnAConfigureProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abt = new About(this);
            abt.Show();
        }

        private void buttonSelectSiteBrowse_Click(object sender, EventArgs e)
        {
            comboBoxGWArea.ResetText();
            comboBoxGWArea.Items.Clear();

            FolderBrowserDialog d1 = new FolderBrowserDialog();

            if (d1.ShowDialog() == DialogResult.OK)
            {
                textBoxSelectSite.Text = d1.SelectedPath;
                string[] files = Directory.GetFiles(textBoxSelectSite.Text);
                foreach (string file in files)
                {
                    comboBoxGWArea.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void buttonMATMBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog f1 = new OpenFileDialog();

            if (f1.ShowDialog() == DialogResult.OK)
            {
                textBoxMATM.Text = f1.FileName;
            }
        }

        public void Telnet()
         {
            
            byte[] data = new byte[1024];
            string line, stringData;

            int counter = 0;

            TcpClient server;

            try
            {
                server = new TcpClient("100.100.100.100", 23);
            }
            catch (SocketException)
            {
                MessageBox.Show("Unable to connect to Gateway.", "Error");
                return;
            }

            StreamReader file = new StreamReader(textBoxSelectSite.Text + "\\" + comboBoxGWArea.Text);
            NetworkStream ns = server.GetStream();
            int recv = ns.Read(data, 0, data.Length);
            stringData = Encoding.ASCII.GetString(data, 0, recv);
            Console.WriteLine(stringData);
            byte[] space = Encoding.ASCII.GetBytes(Environment.NewLine);
            ns.Write(space, 0, space.Length);
            ns.Flush();

            while ((line = file.ReadLine()) != null)
            {
                try
                {
                    counter++;
                    byte[] lines = Encoding.ASCII.GetBytes(line + Environment.NewLine);
                    ns.Write(lines, 0, lines.Length);
                    ns.Flush();
                    data = new byte[1024];
                    recv = ns.Read(data, 0, data.Length);
                    stringData = Encoding.ASCII.GetString(data, 0, recv);
                    Console.WriteLine(stringData);
                }
                catch (Exception)
                {
                    return;
                }
            }
            ns.Close();
            server.Close();
            MessageBox.Show("GateWay has been configured..", "Message");
        }        
    }
}
