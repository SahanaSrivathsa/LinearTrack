using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linear_Track_GUI
{
    public partial class NewRat : Form
    {
        public NewRat()
        {
            InitializeComponent();
        }

        private void newRatNo_TextChanged(object sender, EventArgs e)
        {
            LinearTrackGui.newRatNo = newRatNo.Text;


        }

        private void newRatAge_TextChanged(object sender, EventArgs e)
        {
            LinearTrackGui.newRatAge = newRatAge.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
