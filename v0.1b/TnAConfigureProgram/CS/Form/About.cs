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
    }
}
