using System;
using System.Windows.Forms;
using System.IO;

namespace TnAConfigureProgram
{
    public partial class ChangeSiteInfo : Form
    {
        Form opener;

        public ChangeSiteInfo(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeSiteInfo_Load(object sender, EventArgs e)
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

        private void comboBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGWOldName.ResetText();
            comboBoxGWOldName.Items.Clear();

            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            if (Directory.Exists(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text))
            {
                string[] files = Directory.GetFiles(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text);

                foreach (string file in files)
                {
                    comboBoxGWOldName.Items.Add(Path.GetFileName(file));
                }
            }
        }        

        private void comboBoxGWOldName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            if (string.IsNullOrEmpty(comboBoxRegion.Text) || string.IsNullOrEmpty(comboBoxSite.Text))
            {
                MessageBox.Show("Please select the directorty for the GateWays.", "Warning");
                return;
            }
            else if (string.IsNullOrEmpty(comboBoxGWOldName.Text))
            {
                MessageBox.Show("Please select a GateWay.", "Warning");
                return;
            }
            else
            {
                if (!Directory.Exists(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxGWOldName.Text))
                {
                    string[] lines = File.ReadAllLines(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxGWOldName.Text);
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
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string subFolders = @"Box Sync\Tna\TnA Configs\TnA Config Text Files";

            var pathDir = Path.Combine(userProfile, subFolders);

            if (string.IsNullOrEmpty(pathDir + "\\" + comboBoxRegion.Text) | string.IsNullOrEmpty(comboBoxGWOldName.Text))
            {
                MessageBox.Show("Please make sure the following areas are filled in: \n\n\t* GateWay Area Name\n\t* Select GateWay", "Warning");
                return;
            }
            else
            {
                if (!File.Exists(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + textBoxGateWayName.Text))
                {
                    if (string.IsNullOrEmpty(textBoxGateWayName.Text))
                    {
                        string[] lines = File.ReadAllLines(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxGWOldName.Text);
                        lines[0] = textBoxLU.Text;
                        lines[1] = textBoxIPAdd.Text;
                        lines[2] = textBoxSub.Text;
                        lines[3] = textBoxBL.Text;
                        lines[4] = textBoxDFGate.Text;
                        lines[5] = textBoxFireFly.Text;
                        File.WriteAllLines(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxGWOldName.Text, lines);
                    }
                    else
                    {
                        File.Delete(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + comboBoxGWOldName.Text);
                        File.Create(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + textBoxGateWayName.Text).Dispose();
                        using (TextWriter wr = new StreamWriter(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text + "\\" + textBoxGateWayName.Text, true))
                        {
                            wr.WriteLine(textBoxLU.Text);
                            wr.WriteLine(textBoxIPAdd.Text);
                            wr.WriteLine(textBoxSub.Text);
                            wr.WriteLine(textBoxBL.Text);
                            wr.WriteLine(textBoxDFGate.Text);
                            wr.WriteLine(textBoxFireFly.Text);
                            wr.Close();
                        }
                    }

                    MessageBox.Show("Configuration Updated.", "Message");
                }
                else
                {
                    MessageBox.Show("Failed to Update.", "Error");
                }
            }            
            textBoxGateWayName.Clear();
            comboBoxGWOldName.ResetText();
            comboBoxGWOldName.Items.Clear();
            
            string[] files = Directory.GetFiles(pathDir + "\\" + comboBoxRegion.Text + "\\" + comboBoxSite.Text);
            foreach (string file in files)
            {
                comboBoxGWOldName.Items.Add(Path.GetFileName(file));
            }
        }        
    }
}
