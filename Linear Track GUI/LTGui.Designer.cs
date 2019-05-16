namespace Linear_Track_GUI
{
    partial class LinearTrackGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinearTrackGui));
            this.notesBox = new System.Windows.Forms.TextBox();
            this.expBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lapNum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ratSelection = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ratAge = new System.Windows.Forms.Label();
            this.ratSession = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recording_time = new System.Windows.Forms.Timer(this.components);
            this.selectButton = new System.Windows.Forms.Button();
            this.ratSelectionLabel = new System.Windows.Forms.Label();
            this.feeder_btn = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.acquireButton = new System.Windows.Forms.Button();
            this.stopPostSleep = new System.Windows.Forms.Button();
            this.startPostSleep = new System.Windows.Forms.Button();
            this.stopPreSleep = new System.Windows.Forms.Button();
            this.startPreSleep = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notesBox
            // 
            this.notesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.notesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesBox.ForeColor = System.Drawing.Color.White;
            this.notesBox.Location = new System.Drawing.Point(175, 332);
            this.notesBox.Margin = new System.Windows.Forms.Padding(2);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(246, 74);
            this.notesBox.TabIndex = 0;
            this.notesBox.TextChanged += new System.EventHandler(this.notesBox_TextChanged);
            // 
            // expBox
            // 
            this.expBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.expBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expBox.ForeColor = System.Drawing.Color.White;
            this.expBox.Location = new System.Drawing.Point(175, 268);
            this.expBox.Margin = new System.Windows.Forms.Padding(2);
            this.expBox.Multiline = true;
            this.expBox.Name = "expBox";
            this.expBox.Size = new System.Drawing.Size(246, 27);
            this.expBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(172, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Experimenter:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(172, 307);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(19, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Laps";
            // 
            // lapNum
            // 
            this.lapNum.AutoSize = true;
            this.lapNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lapNum.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapNum.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lapNum.Location = new System.Drawing.Point(25, 38);
            this.lapNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lapNum.Name = "lapNum";
            this.lapNum.Size = new System.Drawing.Size(35, 37);
            this.lapNum.TabIndex = 5;
            this.lapNum.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.lapNum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(482, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 82);
            this.panel1.TabIndex = 6;
            // 
            // ratSelection
            // 
            this.ratSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ratSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ratSelection.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratSelection.ForeColor = System.Drawing.Color.White;
            this.ratSelection.FormattingEnabled = true;
            this.ratSelection.Location = new System.Drawing.Point(11, 57);
            this.ratSelection.Margin = new System.Windows.Forms.Padding(2);
            this.ratSelection.Name = "ratSelection";
            this.ratSelection.Size = new System.Drawing.Size(98, 22);
            this.ratSelection.TabIndex = 9;
            this.ratSelection.SelectedIndexChanged += new System.EventHandler(this.combo_choice);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Consolas", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.timer.Location = new System.Drawing.Point(203, 93);
            this.timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(183, 66);
            this.timer.TabIndex = 10;
            this.timer.Text = "00:00";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.startButton.Location = new System.Drawing.Point(199, 168);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(66, 36);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.start_button_click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Gainsboro;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.saveButton.Location = new System.Drawing.Point(479, 357);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 37);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.save_button_click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Location = new System.Drawing.Point(14, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rat Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label7.Location = new System.Drawing.Point(14, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label8.Location = new System.Drawing.Point(10, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Training Session";
            // 
            // ratAge
            // 
            this.ratAge.AutoSize = true;
            this.ratAge.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratAge.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ratAge.Location = new System.Drawing.Point(33, 31);
            this.ratAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ratAge.Name = "ratAge";
            this.ratAge.Size = new System.Drawing.Size(0, 18);
            this.ratAge.TabIndex = 17;
            // 
            // ratSession
            // 
            this.ratSession.AutoSize = true;
            this.ratSession.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratSession.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ratSession.Location = new System.Drawing.Point(53, 91);
            this.ratSession.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ratSession.Name = "ratSession";
            this.ratSession.Size = new System.Drawing.Size(0, 19);
            this.ratSession.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ratAge);
            this.panel2.Controls.Add(this.ratSession);
            this.panel2.Location = new System.Drawing.Point(6, 136);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 137);
            this.panel2.TabIndex = 19;
            // 
            // recording_time
            // 
            this.recording_time.Interval = 1000;
            this.recording_time.Tick += new System.EventHandler(this.increment_time);
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.selectButton.Location = new System.Drawing.Point(28, 89);
            this.selectButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(64, 23);
            this.selectButton.TabIndex = 20;
            this.selectButton.Text = "SELECT";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.choose_rat);
            // 
            // ratSelectionLabel
            // 
            this.ratSelectionLabel.AutoSize = true;
            this.ratSelectionLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratSelectionLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ratSelectionLabel.Location = new System.Drawing.Point(26, 63);
            this.ratSelectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ratSelectionLabel.Name = "ratSelectionLabel";
            this.ratSelectionLabel.Size = new System.Drawing.Size(0, 19);
            this.ratSelectionLabel.TabIndex = 21;
            // 
            // feeder_btn
            // 
            this.feeder_btn.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feeder_btn.ForeColor = System.Drawing.Color.BlueViolet;
            this.feeder_btn.Location = new System.Drawing.Point(456, 279);
            this.feeder_btn.Name = "feeder_btn";
            this.feeder_btn.Size = new System.Drawing.Size(140, 45);
            this.feeder_btn.TabIndex = 22;
            this.feeder_btn.Text = "FEEDERS";
            this.feeder_btn.UseVisualStyleBackColor = true;
            this.feeder_btn.Click += new System.EventHandler(this.feeder_btn_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.stopButton.FlatAppearance.BorderSize = 0;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.stopButton.Location = new System.Drawing.Point(337, 168);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(66, 36);
            this.stopButton.TabIndex = 12;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stop_button_click);
            // 
            // recordButton
            // 
            this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.recordButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.recordButton.Location = new System.Drawing.Point(482, 200);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(83, 47);
            this.recordButton.TabIndex = 46;
            this.recordButton.Text = "RECORD";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // acquireButton
            // 
            this.acquireButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acquireButton.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acquireButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.acquireButton.Location = new System.Drawing.Point(482, 136);
            this.acquireButton.Name = "acquireButton";
            this.acquireButton.Size = new System.Drawing.Size(83, 48);
            this.acquireButton.TabIndex = 45;
            this.acquireButton.Text = "ACQUIRE";
            this.acquireButton.UseVisualStyleBackColor = true;
            this.acquireButton.Click += new System.EventHandler(this.acquireButton_Click);
            // 
            // stopPostSleep
            // 
            this.stopPostSleep.AllowDrop = true;
            this.stopPostSleep.AutoSize = true;
            this.stopPostSleep.BackColor = System.Drawing.Color.MistyRose;
            this.stopPostSleep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopPostSleep.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopPostSleep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.stopPostSleep.Location = new System.Drawing.Point(305, 43);
            this.stopPostSleep.Name = "stopPostSleep";
            this.stopPostSleep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stopPostSleep.Size = new System.Drawing.Size(122, 29);
            this.stopPostSleep.TabIndex = 57;
            this.stopPostSleep.Text = "Stop Post-Sleep";
            this.stopPostSleep.UseVisualStyleBackColor = false;
            this.stopPostSleep.Visible = false;
            this.stopPostSleep.Click += new System.EventHandler(this.stopPostSleep_Click);
            // 
            // startPostSleep
            // 
            this.startPostSleep.AutoSize = true;
            this.startPostSleep.BackColor = System.Drawing.Color.Honeydew;
            this.startPostSleep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startPostSleep.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPostSleep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.startPostSleep.Location = new System.Drawing.Point(169, 43);
            this.startPostSleep.Name = "startPostSleep";
            this.startPostSleep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startPostSleep.Size = new System.Drawing.Size(124, 29);
            this.startPostSleep.TabIndex = 56;
            this.startPostSleep.Text = "Start Post-Sleep";
            this.startPostSleep.UseVisualStyleBackColor = false;
            this.startPostSleep.Visible = false;
            this.startPostSleep.Click += new System.EventHandler(this.startPostSleep_Click);
            // 
            // stopPreSleep
            // 
            this.stopPreSleep.AutoSize = true;
            this.stopPreSleep.BackColor = System.Drawing.Color.MistyRose;
            this.stopPreSleep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopPreSleep.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopPreSleep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.stopPreSleep.Location = new System.Drawing.Point(305, 43);
            this.stopPreSleep.Name = "stopPreSleep";
            this.stopPreSleep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stopPreSleep.Size = new System.Drawing.Size(122, 29);
            this.stopPreSleep.TabIndex = 55;
            this.stopPreSleep.Text = "Stop Pre-Sleep";
            this.stopPreSleep.UseVisualStyleBackColor = false;
            this.stopPreSleep.Click += new System.EventHandler(this.stopPreSleep_Click);
            // 
            // startPreSleep
            // 
            this.startPreSleep.AutoSize = true;
            this.startPreSleep.BackColor = System.Drawing.Color.Honeydew;
            this.startPreSleep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startPreSleep.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPreSleep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.startPreSleep.Location = new System.Drawing.Point(169, 43);
            this.startPreSleep.Name = "startPreSleep";
            this.startPreSleep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startPreSleep.Size = new System.Drawing.Size(124, 29);
            this.startPreSleep.TabIndex = 54;
            this.startPreSleep.Text = "Start Pre-Sleep";
            this.startPreSleep.UseVisualStyleBackColor = false;
            this.startPreSleep.Click += new System.EventHandler(this.startPreSleep_Click);
            // 
            // LinearTrackGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(617, 428);
            this.Controls.Add(this.stopPostSleep);
            this.Controls.Add(this.startPostSleep);
            this.Controls.Add(this.stopPreSleep);
            this.Controls.Add(this.startPreSleep);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.acquireButton);
            this.Controls.Add(this.feeder_btn);
            this.Controls.Add(this.ratSelectionLabel);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.ratSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expBox);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LinearTrackGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linear Track Training";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LT_Gui_FormClosing);
            this.Load += new System.EventHandler(this.LinearTrackGui_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.TextBox expBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lapNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ratSelection;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ratAge;
        private System.Windows.Forms.Label ratSession;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer recording_time;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label ratSelectionLabel;
        private System.Windows.Forms.Button feeder_btn;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button acquireButton;
        private System.Windows.Forms.Button stopPostSleep;
        private System.Windows.Forms.Button startPostSleep;
        private System.Windows.Forms.Button stopPreSleep;
        private System.Windows.Forms.Button startPreSleep;
    }
}

