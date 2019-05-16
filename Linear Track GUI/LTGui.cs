using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;


namespace Linear_Track_GUI
{
    public partial class LinearTrackGui : Form
    {
        private static readonly SerialPort serialPort = new SerialPort();
        private readonly Form reminderWindow;
        public BackgroundWorker felix = new BackgroundWorker();
        public bool ratWasChosen = false;
        public bool selectedRat = false;
        private bool SessionHasBegun;
        public double lapcnt;
        public int laps = 0;
        private int _elapsed_time;
        private string run_time;
        private List<string> ratName = new List<string>();
        private List<string> age = new List<string>();
        private List<string> session = new List<string>();
        private Dictionary<string, string> name_to_age = new Dictionary<string, string>();
        private Dictionary<string, int> name_to_session = new Dictionary<string, int>();
        private dynamic chosenRat;
        private bool _exiting;
        private bool saved = false;
        public bool newSesh { get; set; } = false;
        private readonly Form ExitConfirm = new exitConfirm();
        public static MNetCom.MNetComClient mNetComClient;
        public static bool recordingStatus = true;
        public static string newRatNo;
        public static string newRatAge;

        private WindowsFormsSection NeuralynxWindow { get; }

        public LinearTrackGui()
        {
            CsvFiles.openLTreader();
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM3";
            serialPort.ReadTimeout = 10000;
            serialPort.Encoding = Encoding.UTF8;
            serialPort.DiscardNull = true;
            serialPort.WriteBufferSize = 10000;
            serialPort.Open();

            serialPort.DiscardInBuffer();
            serialPort.DiscardOutBuffer();
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
            mNetComClient = new MNetCom.MNetComClient();

            InitializeComponent();
            reminderWindow = new NLXReminder(this);
            confirm();
            //reminderWindow.Show();
            //this.Focus();  
            
            foreach (var rat in ratName) this.ratSelection.Items.Add(rat);
            this.ratSelection.Items.Add("New Rat");
        }

        public void confirm()
        {
            reminderWindow.StartPosition = FormStartPosition.CenterParent;
            reminderWindow.ShowDialog();
            //modeWindow.StartPosition = FormStartPosition.CenterParent;
            //modeWindow.ShowDialog();
        }

        private void LinearTrackGui_Load(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
            startButton.Hide();
            stopButton.Hide();
        }

        public void listen_to_arduino(object sender, DoWorkEventArgs e)
            //The "listener" that is the mediator between the worker (Felix) and the updater
        {
            try
            {
                var changedData = serialPort.ReadTo("\n");
                e.Result = changedData;
            }
            catch (Exception)
            {
            }
        }
        public static void sendMessage(string button) //handles messages to be sent to the UNO for filling/cleaning
        {
            switch (button)
            {
                case "2":
                    try
                    {
                        serialPort.Write(new[] { 'X' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "4":
                    try
                    {
                        serialPort.Write(new[] { 'Y' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "22":
                    try
                    {
                        serialPort.Write(new[] { 'x' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "44":
                    try
                    {
                        serialPort.Write(new[] { 'y' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
            }
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
                startPreSleep.Show();
                stopPreSleep.Show();
                startButton.Show();
                stopButton.Show();
                selectedRat = true;
                saveButton.Enabled = true;
                ratSelection.Hide();
                if (ratSelection.Text == "New Rat")
                {
                    var rat_entry = new NewRat();
                    rat_entry.ShowDialog();
                    ratName.Add(newRatNo);
                    name_to_age.Add(newRatNo,newRatAge);
                    name_to_session.Add(newRatNo,0);

                    chosenRat = newRatNo;
                    ratSelectionLabel.Text = newRatNo;
                }
                else
                {
                    ratSelectionLabel.Text = $"{ratName[ratSelection.SelectedIndex]}";
                    chosenRat = ratName[ratSelection.SelectedIndex];
                    
                }
                ratAge.Text = name_to_age[chosenRat];
                ratSession.Text = name_to_session[chosenRat].ToString();
            }
        }

        private void start_button_click(object sender, EventArgs e)
        {
            if (selectedRat)
            {
                recording_time.Enabled = true;
                SessionHasBegun = true;
                updateTime();
                if (recordButton.BackColor != Color.AliceBlue && recordingStatus == true)
                {
                    MessageBox.Show(this, "Check if Cheetah is Recording Session", "Cheetah Recording",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    return;
                }
                string reply = "";
                if (!(mNetComClient.SendCommand("-PostEvent \"StartLT\" 0 0", ref reply)) && recordingStatus == true)
                {
                    MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    String[] parsedReplyString = reply.Split(' ');
                    if (0 < parsedReplyString.GetLength(0))
                    {
                        if (parsedReplyString[0].Equals("-1"))
                        {
                            MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }

                }
                startButton.ForeColor = Color.AliceBlue;
                startPreSleep.Visible = false;
                stopPreSleep.Visible = false;
                startButton.Enabled = false;
                //Background worker for arduino 
                felix.DoWork += listen_to_arduino;
                felix.RunWorkerCompleted += run_worker_completed;
                felix.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show(this, "Select Rat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                //var ratWindow = new SelectRatWindow();
                //ratWindow.StartPosition = FormStartPosition.CenterParent;
                //ratWindow.ShowDialog();

            }

            try //sends a message to the UNO to reinitialize variables
            {
                var message = new char[1] {'L'};
                serialPort.Write(message, 0, 1);
            }
            catch (Exception)
            {

            }
        }

        public void run_worker_completed(object sender, RunWorkerCompletedEventArgs e)
            //The updater that updates the GUI with the new info and writes to the Timestamp CSV
        {

            if (!e.Cancelled && (e.Error == null) && (e.Result != null) && SessionHasBegun)
            {
                var messageType = e.Result.ToString().Substring(0, 1);
                
                    if (messageType == "c")
                    {
                        lapcnt++;
                        lapNum.Text = lapcnt.ToString();

                    }
            }
            if (!felix.IsBusy)
                felix.RunWorkerAsync();

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



        private void stop_button_click(object sender, EventArgs e)
        {
            startButton.ForeColor = Color.FromArgb(192, 255, 192);
            recording_time.Enabled = false;
            run_time = timer.Text;
            _elapsed_time = 0;
            string reply = "";
            if (!(mNetComClient.SendCommand("-PostEvent \"StopLT\" 0 0", ref reply)) && recordingStatus == true)
            {
                MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                String[] parsedReplyString = reply.Split(' ');
                if (0 < parsedReplyString.GetLength(0))
                {
                    if (parsedReplyString[0].Equals("-1"))
                    {
                        MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }

            }
            stopButton.Enabled = false;
            startButton.Enabled = false;
            startPostSleep.Visible = true;
            stopPostSleep.Visible = true;
        }

        public void disable_NLX()
        {
            startPreSleep.Visible = false;
            stopPreSleep.Visible = false;
            recordButton.Enabled = false;
            acquireButton.Enabled = false;
        }
        private void save_button_click(object sender, EventArgs e)
        {
            recording_time.Enabled = false;
            saveButton.Hide();

            CsvFiles.openTrainingReview($"{chosenRat}");
            CsvFiles.trainingCsv.Write(
                $"{name_to_session[chosenRat]},{DateTime.Now},{run_time},{this.lapNum.Text},{expBox.Text},{notesBox.Text}\n");
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

        private void feeder_btn_Click(object sender, EventArgs e)
        {
                var fill_feeders = new FeederWin();
                fill_feeders.StartPosition = FormStartPosition.CenterParent;
                fill_feeders.ShowDialog();
            
    }

        private void acquireButton_Click(object sender, EventArgs e)
        {
            string reply = "";
            if (acquireButton.BackColor == Color.AliceBlue)
            {
                mNetComClient.SendCommand("-StopAcquisition", ref reply);
                acquireButton.BackColor = Color.FromArgb(40, 40, 40);
                recordButton.BackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                mNetComClient.SendCommand("-StartAcquisition", ref reply);
                acquireButton.BackColor = Color.AliceBlue;
            }
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            string reply = "";
            if (recordButton.BackColor == Color.AliceBlue)
            {
                mNetComClient.SendCommand("-StopRecording", ref reply);
                recordButton.BackColor = Color.FromArgb(40, 40, 40);
            }
            else
            {
                mNetComClient.SendCommand("-StartRecording", ref reply);
                recordButton.BackColor = Color.AliceBlue;

            }
        }

        private void startPostSleep_Click(object sender, EventArgs e)
        {
            _elapsed_time = 0;
            recording_time.Enabled = true;
            updateTime();
            startPostSleep.ForeColor = Color.GhostWhite;
            startPostSleep.BackColor = Color.SeaGreen;
            string reply = "";
            if (!(mNetComClient.SendCommand("-PostEvent \"StartSleepPost\" 0 0", ref reply)))
            {
                MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                String[] parsedReplyString = reply.Split(' ');
                if (0 < parsedReplyString.GetLength(0))
                {
                    if (parsedReplyString[0].Equals("-1"))
                    {
                        MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }

            }
        }

        private void stopPostSleep_Click(object sender, EventArgs e)
        {
            recording_time.Enabled = false;
            stopPostSleep.ForeColor = Color.GhostWhite;
            string reply = "";
            if (!(mNetComClient.SendCommand("-PostEvent \"StopSleepPost\" 0 0", ref reply)))
            {
                MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                String[] parsedReplyString = reply.Split(' ');
                if (0 < parsedReplyString.GetLength(0))
                {
                    if (parsedReplyString[0].Equals("-1"))
                    {
                        MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }

            }
        }

        private void startPreSleep_Click(object sender, EventArgs e)
        {
            if (recordButton.BackColor != Color.AliceBlue)
            {
                MessageBox.Show(this, "Cheetah Recording", "Check if Cheetah is Recording Session", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            _elapsed_time = 0;
            recording_time.Enabled = true;
            updateTime();
            startPreSleep.ForeColor = Color.GhostWhite;
            startPreSleep.BackColor = Color.SeaGreen;
            string reply = "";
            //mNetComClient.SendCommand("-PostEvent \"StartSleepPre\" 0 0", ref reply);
            if (!(mNetComClient.SendCommand("-PostEvent \"StartSleepPre\" 0 0", ref reply)))
            {
                MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                String[] parsedReplyString = reply.Split(' ');
                if (0 < parsedReplyString.GetLength(0))
                {
                    if (parsedReplyString[0].Equals("-1"))
                    {
                        MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }

            }
        }

        private void stopPreSleep_Click(object sender, EventArgs e)
        {
            recording_time.Enabled = false;
            _elapsed_time = 0;
            stopPreSleep.ForeColor = Color.GhostWhite;
            string reply = "";
            if (!(mNetComClient.SendCommand("-PostEvent \"StopSleepPre\" 0 0", ref reply)))
            {
                MessageBox.Show(this, "Send command to server failed", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                String[] parsedReplyString = reply.Split(' ');
                if (0 < parsedReplyString.GetLength(0))
                {
                    if (parsedReplyString[0].Equals("-1"))
                    {
                        MessageBox.Show(this, "Cheetah could not process your command.", "NetCom Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }

            }
        }
    }
}
