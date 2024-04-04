using System;
using System.Windows.Forms;

namespace STM_BTComm
{
    public partial class HelpPopUp : Form
    {
        public HelpPopUp()
        {
            InitializeComponent();
        }

        private void okConfirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
