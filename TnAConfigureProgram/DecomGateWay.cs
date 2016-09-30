using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            string movSubFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";
            string savSubFolder = @"Box Sync\Tna\TnA Configs\Backup after Removing Config Text Files";

            var pathMovDir = Path.Combine(userProfile, movSubFolders);
            var pathSavDir = Path.Combine(userProfile, savSubFolder);

            if (string.IsNullOrEmpty(comboBoxRegion.Text) || string.IsNullOrEmpty(comboBoxSite.Text))
            {
                MessageBox.Show("Please select a Region and/or Site.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrEmpty(comboBoxRemGate.Text))
            {
                MessageBox.Show("Please select a GateWay.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult areYouSure = MessageBox.Show("You are about to Decommission this GateWay. You will loose the configuration file. Are you sure you want to Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (areYouSure == DialogResult.Yes)
                {

                    if (!Directory.Exists(pathSavDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text))
                    {
                        Directory.CreateDirectory(pathSavDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text);
                        File.Move(pathMovDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxRemGate.Text, pathSavDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxRemGate.Text);

                        comboBoxRemGate.ResetText();
                        comboBoxRemGate.Items.Clear();

                        string[] files = Directory.GetFiles(pathMovDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text);
                        foreach (string file in files)
                        {
                            comboBoxRemGate.Items.Add(Path.GetFileName(file));
                        }
                    }
                    else
                    {
                        File.Move(pathMovDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxRemGate.Text, pathSavDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxRemGate.Text);

                        comboBoxRemGate.ResetText();
                        comboBoxRemGate.Items.Clear();

                        string[] files = Directory.GetFiles(pathMovDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text);
                        foreach (string file in files)
                        {
                            comboBoxRemGate.Items.Add(Path.GetFileName(file));
                        }
                    }

                    MessageBox.Show("If you have removed the wrong GateWay please refer back to the Restore Site/GateWay Tab.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string movSubFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";
            string savSubFolder = @"Box Sync\Tna\TnA Configs\Backup after Removing Config Text Files";

            var pathMovDir = Path.Combine(userProfile, movSubFolders);
            var pathSavDir = Path.Combine(userProfile, savSubFolder);

            if (string.IsNullOrEmpty(comboBoxRegion.Text) || string.IsNullOrEmpty(comboBoxDecomSite.Text))
            {
                MessageBox.Show("Please select a Region and/or Site.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult areYouSure = MessageBox.Show("You are about to Decommission this Site, you will loose all configuration files. Are you sure you want to Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (areYouSure == DialogResult.Yes)
                {

                    if (!Directory.Exists(pathSavDir + "\\" + comboBoxRegion.Text))
                    {
                        Directory.CreateDirectory(pathSavDir + "\\" + comboBoxRegion.Text);
                        Directory.Move(pathMovDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxDecomSite.Text, pathSavDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxDecomSite.Text);
                    }
                    else
                    {
                        List<string> Dirs = Directory.GetFiles(pathMovDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxDecomSite.Text, "*.*", SearchOption.AllDirectories).ToList();

                        foreach (var file in Dirs)
                        {
                            FileInfo moveFile = new FileInfo(file);
                            if (new FileInfo(pathSavDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxDecomSite.Text + "\\" + moveFile.Name).Exists == false)
                            {
                                moveFile.MoveTo(pathSavDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxDecomSite.Text + "\\" + moveFile.Name);
                            }
                        }
                        Directory.Delete(pathMovDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxDecomSite.Text);
                    }

                    MessageBox.Show("If you have removed the wrong Site please refer back to the Restore Site/GateWay Tab.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                             
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
