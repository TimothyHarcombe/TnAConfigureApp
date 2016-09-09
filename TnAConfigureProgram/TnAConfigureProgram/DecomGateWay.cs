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

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d1 = new FolderBrowserDialog();

            if (d1.ShowDialog() == DialogResult.OK)
            {
                textBoxDirSite.Text = d1.SelectedPath;
                string[] files = Directory.GetFiles(textBoxDirSite.Text);
                foreach (string file in files)
                {
                    comboBoxRemGate.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void comboBoxRemGate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(textBoxDirSite.Text + "\\" + comboBoxRemGate.Text);
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
            if (string.IsNullOrEmpty(textBoxDirSite.Text))
            {
                MessageBox.Show("Please select a directory.", "Warning");
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
                    File.Delete(textBoxDirSite.Text + "\\" + comboBoxRemGate.Text);

                    comboBoxRemGate.ResetText();
                    comboBoxRemGate.Items.Clear();

                    string[] files = Directory.GetFiles(textBoxDirSite.Text);
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
    }
}
