using System;
using System.Windows.Forms;

namespace Linear_Track_GUI
{
    public partial class NLXReminder : Form
    {
        #region Private Members
        public static MNetCom.MNetComClient mNetComClient;
        private LinearTrackGui _gui;
        #endregion

        public NLXReminder(LinearTrackGui gui)
        {
            _gui = gui;
            mNetComClient = LinearTrackGui.mNetComClient;
            InitializeComponent();
        }


        private void ConfirmNLX_Click(object sender, EventArgs e)
        {

            if (mNetComClient.ConnectToServer(this.IP_address.Text))
            {
                var isNlxConnected = mNetComClient.AreWeConnected();
                if (!isNlxConnected)
                {
                    MessageBox.Show(this, "Connection to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                }
                else
                {
                    MessageBox.Show(this, "Connected to Server", "NetCom Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);

                }
             
                this.IP_address.Enabled = false;
                Close();
            }
            else
            {
                MessageBox.Show(this, "Connection to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void notRecordingButton_Click(object sender, EventArgs e)
        {
            LinearTrackGui.recordingStatus = false;
            Close();
            _gui.disable_NLX();

        }
    }
}
