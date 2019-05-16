using System;
using System.Windows.Forms;

namespace Linear_Track_GUI
{
    public partial class FeederWin : Form
    {
        public FeederWin()
        {
            InitializeComponent();
        }

        private void close2_Click(object sender, EventArgs e)
        {
            LinearTrackGui.sendMessage("22");
            fill2.Show();
        }

        private void close4_Click(object sender, EventArgs e)
        {
            LinearTrackGui.sendMessage("44");
            fill4.Show();
        }

        private void fill2_Click(object sender, EventArgs e)
        {
            LinearTrackGui.sendMessage("2");
            fill2.Hide();
        }

        private void fill4_Click(object sender, EventArgs e)
        {
            LinearTrackGui.sendMessage("4");
            fill4.Hide();    
        }

        private void closeFill_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
