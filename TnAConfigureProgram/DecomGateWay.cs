using System;
using System.IO;
using System.Windows.Forms;

namespace TnAConfigureProgram
{
    public partial class DecomGateWay : Form
    {
        Form opener;
        public DecomGateWay(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DecomGateWay_Load(object sender, EventArgs e)
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

        private void comboBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRemGate.ResetText();
            comboBoxRemGate.Items.Clear();

            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            if (Directory.Exists(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text))
            {
                string[] files = Directory.GetFiles(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text);

                foreach (string file in files)
                {
                    comboBoxRemGate.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void comboBoxRemGate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            string[] lines = File.ReadAllLines(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxRemGate.Text);
            if (lines.Length > 0)
                textBoxLU.Text = lines[0];

            if (lines.Length > 1)
                textBoxIPAdd.Text = lines[1];

            if (lines.Length > 2)
                textBoxSub.Text = lines[2];

            if (lines.Length > 3)
                textBoxBL.Text = lines[3];

            if (lines.Length > 4)
                textBoxDFGate.Text = lines[4];

            if (lines.Length > 5)
                textBoxFireFly.Text = lines[5];
        }

        private void buttonDecomGate_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            if (string.IsNullOrEmpty(comboBoxRegion.Text) || string.IsNullOrEmpty(comboBoxSite.Text))
            {
                MessageBox.Show("Please select a Region and/or Site.", "Warning");
                return;
            }
            else if (string.IsNullOrEmpty(comboBoxRemGate.Text))
            {
                MessageBox.Show("Please select a GateWay.", "Warning");
                return;
            }
            else
            {
                DialogResult areYouSure = MessageBox.Show("Are you sure you want to Decommission this GateWay?", "Warning", MessageBoxButtons.YesNo);

                if (areYouSure == DialogResult.Yes)
                {
                    File.Delete(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxRemGate.Text);

                    comboBoxRemGate.ResetText();
                    comboBoxRemGate.Items.Clear();

                    string[] files = Directory.GetFiles(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text);
                    foreach (string file in files)
                    {
                        comboBoxRemGate.Items.Add(Path.GetFileName(file));
                    }
                }
                else if (areYouSure == DialogResult.No)
                {
                    return;
                }                
            }                
        }

        private void buttonDecomSite_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            if (string.IsNullOrEmpty(comboBoxRegion.Text) || string.IsNullOrEmpty(comboBoxDecomSite.Text))
            {
                MessageBox.Show("Please select a Region and/or Site.", "Warning");
                return;
            }
            else
            {
                DialogResult areYouSure = MessageBox.Show("Are you sure you want to Decommission this Site, you will loose all configuration files?", "Warning", MessageBoxButtons.YesNo);

                if (areYouSure == DialogResult.Yes)
                {
                    DirectoryInfo f = new DirectoryInfo(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxDecomSite.Text);

                    foreach (FileInfo file in f.GetFiles())
                    {
                        file.Delete();
                    }

                    Directory.Delete(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxDecomSite.Text);                                                           
                }
                else if (areYouSure == DialogResult.No)
                {
                    return;
                }
                RegionAndRefresh();
            }
        }

        private void RegionAndRefresh()
        {
            comboBoxDecomSite.ResetText();
            comboBoxDecomSite.Items.Clear();
            comboBoxSite.ResetText();
            comboBoxSite.Items.Clear();
            comboBoxRemGate.ResetText();
            comboBoxRemGate.Items.Clear();

            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            if (Directory.Exists(pathDir + "\\" + comboBoxRegion.Text))
            {
                string[] files = Directory.GetDirectories(pathDir + "\\" + comboBoxRegion.Text);

                foreach (string file in files)
                {
                    comboBoxSite.Items.Add(Path.GetFileName(file));
                    comboBoxDecomSite.Items.Add(Path.GetFileName(file));
                }
            }
        }        
    }
}
