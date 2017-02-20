using System;
using System.IO;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Collections.Generic;

namespace TnAConfigureProgram
{
    public partial class Form1 : Form
    {     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAndRefreash();
            nic_adpt();

        }
        public List<string> nic_adpt()
        {
            List<string> values = new List<string>();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                values.Add(nic.Name);
                comboBoxNICAdapter.Items.Add(nic.Name);
            }
            return values;
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

        private void restoreSiteGateWayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore rst = new Restore(this);
            rst.Show();
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
            if (string.IsNullOrEmpty(comboBoxNICAdapter.Text))
            {
                MessageBox.Show("Please select a Network Adapter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {                
                NetworkManagement setIp = new NetworkManagement();
                setIp.setIP(comboBoxNICAdapter.Text, "134.1.32.213", "255.255.255.0");

                var path = new ProgramFinder();
                path.ProgramStarter(@"Box Sync\Tna\TnA Configs\Programs\Bio-reader\BESBiometrics\Program\MA_Tools_3.4.4\MATM_Express\MATerminalManagement.exe");

                var dhcp = new NetworkManagement();
                dhcp.setDHCP(comboBoxNICAdapter.Text);
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
            if (string.IsNullOrEmpty(comboBoxNICAdapter.Text) || string.IsNullOrEmpty(comboBoxSelectSite.Text) || string.IsNullOrEmpty(comboBoxGWArea.Text))
            {
                MessageBox.Show("Please make sure the following area are filled in: \n\n* Network Adapter\n* Site\n* GateWay Area", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Cursor = Cursors.WaitCursor;

                NetworkManagement setIP = new NetworkManagement();
                setIP.setIP(comboBoxNICAdapter.Text, "100.100.100.103", "255.255.255.0");

                CS.Class.Telnet tel = new CS.Class.Telnet();
                tel.Gateway(comboBoxRegion.Text, comboBoxSelectSite.Text, comboBoxGWArea.Text);

                NetworkManagement setDHCP = new NetworkManagement();
                setDHCP.setDHCP(comboBoxNICAdapter.Text);

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
    }
}
