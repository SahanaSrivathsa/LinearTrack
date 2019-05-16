using System;
using System.Windows.Forms;

namespace Linear_Track_GUI
{
    public partial class exitConfirm : Form
    {
        public exitConfirm()
        {
            InitializeComponent();
        }

        private void exitConfirm_Load(object sender, EventArgs e)
        {
        }
        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void RejectButtonClick(object sender, EventArgs e)
        {
            Close();
        }

    }
}
