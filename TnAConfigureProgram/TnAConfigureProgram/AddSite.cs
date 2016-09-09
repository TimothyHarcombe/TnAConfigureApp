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

        private void buttonSiteBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d1 = new FolderBrowserDialog();

            if (d1.ShowDialog() == DialogResult.OK)
            {
                textBoxSiteDirectory.Text = d1.SelectedPath;
            }
        }

        private void buttonSiteCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSiteDirectory.Text) | string.IsNullOrEmpty(textBoxSiteName.Text))
            {
                MessageBox.Show("Please make sure the following areas are filled in: \n\n\t* Site Directory\n\t* Site Name", "Warning");
                return;
            }
            else
            {
                if (!Directory.Exists(textBoxSiteDirectory.Text + "\\" + textBoxSiteName.Text))
                {
                    Directory.CreateDirectory(textBoxSiteDirectory.Text + "\\" + textBoxSiteName.Text);
                    MessageBox.Show("Directory Created.", "Message");
                }
                else
                {
                    MessageBox.Show("Directory Already Exists.", "Message");
                }

                textBoxSiteName.Clear();
            }            
        }

        private void buttonGatewayBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d2 = new FolderBrowserDialog();

            if (d2.ShowDialog() == DialogResult.OK)
            {
                textBoxGatewayDirectory.Text = d2.SelectedPath;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxGatewayDirectory.Text) | string.IsNullOrEmpty(textBoxGatewayArea.Text))
            {
                MessageBox.Show("Please make sure the following areas are filled in: \n\n\t* GateWay Directory\n\t* GateWay Area Name", "Warning");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxLU.Text) | string.IsNullOrEmpty(textBoxIPAddress.Text) | string.IsNullOrEmpty(textBoxSubMask.Text) 
                | string.IsNullOrEmpty(textBoxBL.Text) | string.IsNullOrEmpty(textBoxDefaultGateway.Text) | string.IsNullOrEmpty(textBoxFirefly.Text))
            {
                MessageBox.Show("Please make sure the following areas are filled in: \n\n\t* My LU\n\t* My IP\n\t* Sub Netmask\n\t* Host IP\n\t* Router IP\n\t* FireFly IP", "Warning");
                return;
            }
            else
            {
                if (!File.Exists(textBoxGatewayDirectory.Text + "\\" + textBoxGatewayArea.Text))
                {
                    File.Create(textBoxGatewayDirectory.Text + "\\" + textBoxGatewayArea.Text).Dispose();
                    using (TextWriter wr = new StreamWriter(textBoxGatewayDirectory.Text + "\\" + textBoxGatewayArea.Text, true))
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

                    MessageBox.Show("Configuration Created.", "Message");
                }
                else
                {
                    MessageBox.Show("Configuration Already Exists.", "Message");
                }
            }            
        }
    }
}
