using System;
using System.Windows.Forms;

namespace TnAConfigureProgram
{
    public partial class About : Form
    {
        Form opener;

        public About(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
