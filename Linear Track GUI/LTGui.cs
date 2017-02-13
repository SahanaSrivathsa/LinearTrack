using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Linear_Track_GUI
{
    public partial class LinearTrackGui : Form
    {
        public bool ratWasChosen = false;
        public bool selectedRat = false;
        public int laps = 0;
        private int _elapsed_time;
        private List<string> ratName = new List<string>();
        private List<string> age = new List<string>();
        private List<string> session = new List<string>();
        private Dictionary<string, string> name_to_age = new Dictionary<string, string>();
        private Dictionary<string, int> name_to_session = new Dictionary<string, int>();
        private dynamic chosenRat;
        private bool _exiting;
        private bool saved = false;
        private readonly Form ExitConfirm = new exitConfirm();

        public LinearTrackGui()
        {
            CsvFiles.openLTreader();
            while (!CsvFiles.LTreader.EndOfStream)
                //this reads the LTtraining.csv file and makes a dictionary for the ages and for the session number
            {
                var line = CsvFiles.LTreader.ReadLine();
                var vals = line.Split(',');
                name_to_age.Add(vals[0], vals[1]);
                name_to_session.Add(vals[0], int.Parse(vals[2]));
                ratName.Add(vals[0]);
            }
            CsvFiles.closeLTreader();
            this.Focus();  //////////////////////////////////////////
            InitializeComponent();
            foreach (var rat in ratName) this.ratSelection.Items.Add(rat);
        }

        private void LinearTrackGui_Load(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
        }

        private void combo_choice(object sender, EventArgs e)
        {
            ratWasChosen = true;
        }

        private void choose_rat(object sender, EventArgs e)
        {
            if (ratWasChosen)
            {
                selectButton.Hide();
                selectedRat = true;
                saveButton.Enabled = true;
                ratSelection.Hide();
                ratSelectionLabel.Text = $"{ratName[ratSelection.SelectedIndex]}";
                chosenRat = ratName[ratSelection.SelectedIndex];
                ratAge.Text = name_to_age[chosenRat];
                ratSession.Text = name_to_session[chosenRat].ToString();
            }
        }

        private void start_button_click(object sender, EventArgs e)
        {
            if (selectedRat)
            {
                recording_time.Enabled = true;
                updateTime();
            }

        }

        private void increment_time(object sender, EventArgs e) //Allows the timer to tick up
        {
            _elapsed_time += 1;
            updateTime();

        }

        private void updateTime() //Displays the current length of the session
        {
            var mins_ones = (_elapsed_time/60)%10;
            var mins_tens = (_elapsed_time/60)/10;
            var secs_ones = (_elapsed_time%60)%10;
            var secs_tens = (_elapsed_time%60)/10;
            timer.Text = $"{mins_tens}{mins_ones}:{secs_tens}{secs_ones}";
        }

        private void plus_button(object sender, EventArgs e)
        {
            laps++;
            lapNum.Text = ($"{laps}");
        }

        private void minus_button(object sender, EventArgs e)
        {
            laps--;
            lapNum.Text = ($"{laps}");
        }

        private void stop_button_click(object sender, EventArgs e)
        {
            recording_time.Enabled = false;
        }

        private void save_button_click(object sender, EventArgs e)
        {
            recording_time.Enabled = false;
            saveButton.Hide();

            CsvFiles.openTrainingReview($"{chosenRat}");
            CsvFiles.trainingCsv.Write(
                $"{name_to_session[chosenRat]},{DateTime.Now},{this.timer.Text},{this.lapNum.Text},{expBox.Text},{notesBox.Text}\n");
            CsvFiles.openLTwriter();
            foreach (var ratname in name_to_age.Keys)
            {
                if (ratname == chosenRat)
                {
                    name_to_session[ratname]++;
                }
                CsvFiles.LTwriter.Write($"{ratname},{name_to_age[ratname]},{name_to_session[ratname]}\n");
            }
            CsvFiles.closeWriter();
            CsvFiles.closeTraining();
            saved = true;
        }


        private void notesBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LT_Gui_FormClosing(object sender, FormClosingEventArgs e)
            //Opens the exitConfirm form to ensure that you are purposefully exiting the GUI
        {
            if (!_exiting)
            {
                _exiting = true;
                ExitConfirm.StartPosition = FormStartPosition.CenterParent;
                ExitConfirm.ShowDialog();
                e.Cancel = true;
                _exiting = false;
            }
        }
    }
}
