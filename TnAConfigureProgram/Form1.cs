using System;
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
            LoadAndRefreash();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void lCFirmwareUploaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LCFirmware lc = new LCFirmware(this);
            lc.Show();
        }

        private void lifeLocTesterFirmwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LifeLoc lL = new LifeLoc(this);
            lL.Show();
        }

        private void sagemConfigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIndex.Text))
            {
                MessageBox.Show("Please select a Network Adapter.", "Warning");
                return;
            }            
            else
            {
                int index;
                index = int.Parse(textBoxIndex.Text);
                NetworkManagement setIp = new NetworkManagement();
                setIp.setIP(index, "134.1.32.213", "255.255.255.0");

                var path = new ProgramFinder();
                path.ProgramStarter(@"Box Sync\Tna\TnA Configs\Programs\Bio-reader\BESBiometrics\Program\MA_Tools_3.4.4\MATM_Express\MATerminalManagement.exe");
                                
                var dhcp = new NetworkManagement();
                dhcp.setDHCP();
            }
        }

        private void rabitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = new ProgramFinder();
            path.ProgramStarter(@"Box Sync\Tna\TnA Configs\Programs\Rabit\Rfu.exe");           
        }

        private void shroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = new ProgramFinder();
            path.ProgramStarter(@"Box Sync\Tna\TnA Configs\Programs\Shroom\Shroom.exe");
        }

        private void uDPToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = new ProgramFinder();
            path.ProgramStarter(@"Box Sync\Tna\TnA Configs\Programs\UDP Download\UDPDownload.exe");
        }

        private void dBConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteBatch eBatch = new ExecuteBatch();
            eBatch.ExecuteBatchCommand();
        }

        private void lCReaderFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = new ProgramFinder();
            path.ProgramStarter(@"Box Sync\Tna\TnA Configs\Programs\LC prog\Stanley Ethernet Discoverer.exe");
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSelectSite.ResetText();
            comboBoxSelectSite.Items.Clear();

            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            if (Directory.Exists(pathDir + "\\" + comboBoxRegion.Text))
            {
                string[] files = Directory.GetDirectories(pathDir + "\\" + comboBoxRegion.Text);

                foreach (string file in files)
                {
                    comboBoxSelectSite.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void comboBoxSelectSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGWArea.ResetText();
            comboBoxGWArea.Items.Clear();

            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            if (Directory.Exists(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSelectSite.Text))
            {
                string[] files = Directory.GetFiles(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSelectSite.Text);

                foreach (string file in files)
                {
                    comboBoxGWArea.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void buttonConfigureGateway_Click(object sender, EventArgs e)
        {         
            if (string.IsNullOrEmpty(textBoxIndex.Text))
            {
                MessageBox.Show("Please select a Network Adapter.", "Warning");
                return;
            }
            else if (string.IsNullOrEmpty(comboBoxSelectSite.Text))
            {
                MessageBox.Show("Please select a Site for the area of the GateWay.", "Warning");
                return;
            }
            else if (string.IsNullOrEmpty(comboBoxGWArea.Text))
            {
                MessageBox.Show("Please select GateWay Area.", "Warning");
                return;
            }
            else
            {
                Cursor = Cursors.WaitCursor;

                int index;
                index = int.Parse(textBoxIndex.Text);

                NetworkManagement setIp = new NetworkManagement();
                setIp.setIP(index, "100.100.100.103", "255.255.255.0");

                Telnet();

                var dhcp = new NetworkManagement();
                dhcp.setDHCP();

                Cursor = Cursors.Default;
            }            
        }

        public void LoadAndRefreash()
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            DirectoryInfo dirs = new DirectoryInfo(pathDir);
            DirectoryInfo[] folders = dirs.GetDirectories();
            comboBoxRegion.DataSource = folders;
        }

        public void Telnet()
         {
            StringBuilder richMessage = new StringBuilder();
            StringBuilder labMessage = new StringBuilder();

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
                labMessage.Append("ERROR...");
                labMessage.Append(Environment.NewLine);
                labelMessage.Text = labMessage.ToString();

                richMessage.Append("Unable to connect to Gateway.");
                richMessage.Append(Environment.NewLine);
                richTextBoxMessage.Text = richMessage.ToString();
                return;
            }

            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            StreamReader file = new StreamReader(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSelectSite.Text + "\\" + comboBoxGWArea.Text);
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
            labMessage.Append("Message...");
            labMessage.Append(Environment.NewLine);
            labelMessage.Text = labMessage.ToString();

            richMessage.Append("Gateway has been configured.");
            richMessage.Append(Environment.NewLine);
            richTextBoxMessage.Text = richMessage.ToString();
        }        
    }
}
