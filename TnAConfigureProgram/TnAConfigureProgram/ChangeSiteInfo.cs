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
            
        }

        private void buttonGatewayBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d1 = new FolderBrowserDialog();

            if (d1.ShowDialog() == DialogResult.OK)
            {
                textBoxGatewayArea.Text = d1.SelectedPath;
                string[] files = Directory.GetFiles(textBoxGatewayArea.Text);
                foreach (string file in files)
                {
                    comboBoxGWOldName.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxGatewayArea.Text))
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
                if (!Directory.Exists(textBoxGatewayArea.Text + "\\" + comboBoxGWOldName.Text))
                {
                    string[] lines = File.ReadAllLines(textBoxGatewayArea.Text + "\\" + comboBoxGWOldName.Text);
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
            if (string.IsNullOrEmpty(textBoxGatewayArea.Text) | string.IsNullOrEmpty(comboBoxGWOldName.Text))
            {
                MessageBox.Show("Please make sure the following areas are filled in: \n\n\t* GateWay Area Name\n\t* Select GateWay", "Warning");
                return;
            }
            else
            {
                if (!File.Exists(textBoxGatewayArea.Text + "\\" + textBoxGateWayName.Text))
                {
                    if (string.IsNullOrEmpty(textBoxGateWayName.Text))
                    {
                        string[] lines = File.ReadAllLines(textBoxGatewayArea.Text + "\\" + comboBoxGWOldName.Text);
                        lines[0] = textBoxLU.Text;
                        lines[1] = textBoxIPAdd.Text;
                        lines[2] = textBoxSub.Text;
                        lines[3] = textBoxBL.Text;
                        lines[4] = textBoxDFGate.Text;
                        lines[5] = textBoxFireFly.Text;
                        File.WriteAllLines(textBoxGatewayArea.Text + "\\" + comboBoxGWOldName.Text, lines);
                    }
                    else
                    {
                        File.Delete(textBoxGatewayArea.Text + "\\" + comboBoxGWOldName.Text);
                        File.Create(textBoxGatewayArea.Text + "\\" + textBoxGateWayName.Text).Dispose();
                        using (TextWriter wr = new StreamWriter(textBoxGatewayArea.Text + "\\" + textBoxGateWayName.Text, true))
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
            
            string[] files = Directory.GetFiles(textBoxGatewayArea.Text);
            foreach (string file in files)
            {
                comboBoxGWOldName.Items.Add(Path.GetFileName(file));
            }
        }
    }
}
