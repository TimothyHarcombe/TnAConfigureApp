using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TnAConfigureProgram
{
    public partial class Restore : Form
    {
        Form opener;

        public Restore(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Restore_Load(object sender, EventArgs e)
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string resSubFolder = @"Box Sync\Tna\TnA Configs\Backup after Removing Config Text Files";

            var pathDir = Path.Combine(userProfile, resSubFolder);

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
            comboBoxGateWay.ResetText();
            comboBoxGateWay.Items.Clear();

            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string resSubFolder = @"Box Sync\Tna\TnA Configs\Backup after Removing Config Text Files";

            var pathDir = Path.Combine(userProfile, resSubFolder);

            if (Directory.Exists(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text))
            {
                string[] files = Directory.GetFiles(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text);

                foreach (string file in files)
                {
                    comboBoxGateWay.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void RegionAndRefresh()
        {
            comboBoxGateWay.ResetText();
            comboBoxGateWay.Items.Clear();
            comboBoxSite.ResetText();
            comboBoxSite.Items.Clear();
            comboBoxGateWay.ResetText();
            comboBoxGateWay.Items.Clear();

            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string resSubFolder = @"Box Sync\Tna\TnA Configs\Backup after Removing Config Text Files";

            var pathDir = Path.Combine(userProfile, resSubFolder);

            if (Directory.Exists(pathDir + "\\" + comboBoxRegion.Text))
            {
                string[] files = Directory.GetDirectories(pathDir + "\\" + comboBoxRegion.Text);

                foreach (string file in files)
                {
                    comboBoxSite.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string SubFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";
            string resSubFolder = @"Box Sync\Tna\TnA Configs\Backup after Removing Config Text Files";

            var pathDir = Path.Combine(userProfile, SubFolders);
            var pathResDir = Path.Combine(userProfile, resSubFolder);

            if (string.IsNullOrEmpty(comboBoxRegion.Text) || string.IsNullOrEmpty(comboBoxSite.Text))
            {
                MessageBox.Show("Make sure that the following field are filled in, in order to restore the data: \n\n* Region\n* Site", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(comboBoxGateWay.Text))
            {
                DialogResult areYouSure = MessageBox.Show("You are about to Restore this Site. Are you sure you want to Continue?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (areYouSure == DialogResult.Yes)
                {

                    if (!Directory.Exists(pathDir + "\\" + comboBoxRegion.Text))
                    {
                        Directory.CreateDirectory(pathDir + "\\" + comboBoxRegion.Text);
                        Directory.Move(pathResDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text, pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text);
                    }
                    else
                    {
                        List<string> Dirs = Directory.GetFiles(pathResDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text, "*.*", SearchOption.AllDirectories).ToList();

                        foreach (var file in Dirs)
                        {
                            FileInfo moveFile = new FileInfo(file);
                            if (new FileInfo(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + moveFile.Name).Exists == false)
                            {
                                moveFile.MoveTo(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + moveFile.Name);
                            }
                        }
                        //Directory.Delete(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text);
                    }

                    MessageBox.Show("Site Restored", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (areYouSure == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                DialogResult areYouSure = MessageBox.Show("You are about to Restore this GateWay. Are you sure you want to Continue?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (areYouSure == DialogResult.Yes)
                {
                    if (!Directory.Exists(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text))
                    {
                        Directory.CreateDirectory(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text);
                        File.Move(pathResDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxGateWay.Text, pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxGateWay.Text);

                        comboBoxGateWay.ResetText();
                        comboBoxGateWay.Items.Clear();

                        string[] files = Directory.GetFiles(pathResDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text);
                        foreach (string file in files)
                        {
                            comboBoxGateWay.Items.Add(Path.GetFileName(file));
                        }
                    }
                    else
                    {
                        File.Move(pathResDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxGateWay.Text, pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxGateWay.Text);

                        comboBoxGateWay.ResetText();
                        comboBoxGateWay.Items.Clear();

                        string[] files = Directory.GetFiles(pathResDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text);
                        foreach (string file in files)
                        {
                            comboBoxGateWay.Items.Add(Path.GetFileName(file));
                        }
                    }

                    MessageBox.Show("GateWay Restored", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (areYouSure == DialogResult.No)
                {
                    return;
                }
            }
        }       
    }
}
