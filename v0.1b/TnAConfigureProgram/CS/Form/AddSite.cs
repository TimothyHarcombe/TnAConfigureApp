using System;
using System.IO;
using System.Windows.Forms;

namespace TnAConfigureProgram
{
    public partial class AddSite : Form
    {
        Form opener;

        public AddSite(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSite_Load(object sender, EventArgs e)
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            DirectoryInfo dirs = new DirectoryInfo(pathDir);
            DirectoryInfo[] folders = dirs.GetDirectories();
            comboBoxRegion.DataSource = folders;
        }         

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegionAndRefresh();
        }       

        private void buttonSiteCreate_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            if (string.IsNullOrEmpty(comboBoxRegion.Text) || string.IsNullOrEmpty(textBoxSiteName.Text))
            {
                MessageBox.Show("Please make sure the following areas are filled in: \n\n\t* Region\n\t* Site Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (!Directory.Exists(pathDir + "\\" + comboBoxRegion.Text + "\\" + textBoxSiteName.Text))
                {
                    Directory.CreateDirectory(pathDir + "\\" + comboBoxRegion.Text + "\\" + textBoxSiteName.Text);
                    MessageBox.Show("Directory Created.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Directory Already Exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                textBoxSiteName.Clear();
                RegionAndRefresh();
            }            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            if (string.IsNullOrEmpty(comboBoxRegion.Text) || string.IsNullOrEmpty(comboBoxSite.Text) || string.IsNullOrEmpty(textBoxGatewayArea.Text))
            {
                MessageBox.Show("Please make sure the following areas are filled in: \n\n\t* Region\n\t* Site\n\t* GateWay Area Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrEmpty(textBoxLU.Text) || string.IsNullOrEmpty(textBoxIPAddress.Text) || string.IsNullOrEmpty(textBoxSubMask.Text) 
                || string.IsNullOrEmpty(textBoxBL.Text) || string.IsNullOrEmpty(textBoxDefaultGateway.Text) || string.IsNullOrEmpty(textBoxFirefly.Text))
            {
                MessageBox.Show("Please make sure the following areas are filled in: \n\n\t* My LU\n\t* My IP\n\t* Sub Netmask\n\t* Host IP\n\t* Router IP\n\t* FireFly IP", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (!File.Exists(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text +"\\" + textBoxGatewayArea.Text))
                {
                    File.Create(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + textBoxGatewayArea.Text).Dispose();
                    using (TextWriter wr = new StreamWriter(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + textBoxGatewayArea.Text, true))
                    {
                        wr.WriteLine(textBoxLU.Text);
                        wr.WriteLine(textBoxIPAddress.Text);
                        wr.WriteLine(textBoxSubMask.Text);
                        wr.WriteLine(textBoxBL.Text);
                        wr.WriteLine(textBoxDefaultGateway.Text);
                        wr.WriteLine(textBoxFirefly.Text);
                        wr.Close();
                    }

                    textBoxGatewayArea.Clear();

                    MessageBox.Show("Configuration Created.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Configuration Already Exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }      

        private void RegionAndRefresh()
        {
            comboBoxSite.ResetText();
            comboBoxSite.Items.Clear();

            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            if (Directory.Exists(pathDir + "\\" + comboBoxRegion.Text))
            {
                string[] files = Directory.GetDirectories(pathDir + "\\" + comboBoxRegion.Text);

                foreach (string file in files)
                {
                    comboBoxSite.Items.Add(Path.GetFileName(file));
                }
            }
        }        
    }    
}
