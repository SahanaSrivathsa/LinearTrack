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
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.ratSelection = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
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
            this.notesBox.Location = new System.Drawing.Point(228, 378);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(205, 91);
            this.notesBox.TabIndex = 0;
            this.notesBox.TextChanged += new System.EventHandler(this.notesBox_TextChanged);
            // 
            // expBox
            // 
            this.expBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.expBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expBox.ForeColor = System.Drawing.Color.White;
            this.expBox.Location = new System.Drawing.Point(228, 303);
            this.expBox.Multiline = true;
            this.expBox.Name = "expBox";
            this.expBox.Size = new System.Drawing.Size(165, 33);
            this.expBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(224, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Experimenter:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(224, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumPurple;
            this.label3.Location = new System.Drawing.Point(540, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Laps";
            // 
            // lapNum
            // 
            this.lapNum.AutoSize = true;
            this.lapNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.lapNum.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapNum.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lapNum.Location = new System.Drawing.Point(31, 45);
            this.lapNum.Name = "lapNum";
            this.lapNum.Size = new System.Drawing.Size(42, 47);
            this.lapNum.TabIndex = 5;
            this.lapNum.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.lapNum);
            this.panel1.Location = new System.Drawing.Point(513, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 101);
            this.panel1.TabIndex = 6;
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusButton.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.plusButton.Location = new System.Drawing.Point(513, 159);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(58, 47);
            this.plusButton.TabIndex = 7;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plus_button);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minusButton.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.minusButton.Location = new System.Drawing.Point(570, 159);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(58, 47);
            this.minusButton.TabIndex = 8;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minus_button);
            // 
            // ratSelection
            // 
            this.ratSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ratSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratSelection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ratSelection.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratSelection.ForeColor = System.Drawing.Color.White;
            this.ratSelection.FormattingEnabled = true;
            this.ratSelection.Location = new System.Drawing.Point(12, 77);
            this.ratSelection.Name = "ratSelection";
            this.ratSelection.Size = new System.Drawing.Size(130, 26);
            this.ratSelection.TabIndex = 9;
            this.ratSelection.SelectedIndexChanged += new System.EventHandler(this.combo_choice);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Font = new System.Drawing.Font("Consolas", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.timer.Location = new System.Drawing.Point(213, 64);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(225, 82);
            this.timer.TabIndex = 10;
            this.timer.Text = "00:00";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.startButton.Location = new System.Drawing.Point(233, 159);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(88, 44);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.start_button_click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.stopButton.Location = new System.Drawing.Point(345, 159);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(88, 44);
            this.stopButton.TabIndex = 12;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stop_button_click);
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.saveButton.Location = new System.Drawing.Point(509, 352);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 46);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_button_click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label6.Location = new System.Drawing.Point(19, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Rat Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label7.Location = new System.Drawing.Point(19, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label8.Location = new System.Drawing.Point(13, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Training Session";
            // 
            // ratAge
            // 
            this.ratAge.AutoSize = true;
            this.ratAge.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratAge.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ratAge.Location = new System.Drawing.Point(44, 38);
            this.ratAge.Name = "ratAge";
            this.ratAge.Size = new System.Drawing.Size(0, 22);
            this.ratAge.TabIndex = 17;
            // 
            // ratSession
            // 
            this.ratSession.AutoSize = true;
            this.ratSession.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratSession.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ratSession.Location = new System.Drawing.Point(71, 112);
            this.ratSession.Name = "ratSession";
            this.ratSession.Size = new System.Drawing.Size(0, 23);
            this.ratSession.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ratAge);
            this.panel2.Controls.Add(this.ratSession);
            this.panel2.Location = new System.Drawing.Point(8, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 152);
            this.panel2.TabIndex = 19;
            // 
            // recording_time
            // 
            this.recording_time.Interval = 1000;
            this.recording_time.Tick += new System.EventHandler(this.increment_time);
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.ForeColor = System.Drawing.Color.BlueViolet;
            this.selectButton.Location = new System.Drawing.Point(26, 109);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(85, 28);
            this.selectButton.TabIndex = 20;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.choose_rat);
            // 
            // ratSelectionLabel
            // 
            this.ratSelectionLabel.AutoSize = true;
            this.ratSelectionLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratSelectionLabel.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.ratSelectionLabel.Location = new System.Drawing.Point(35, 77);
            this.ratSelectionLabel.Name = "ratSelectionLabel";
            this.ratSelectionLabel.Size = new System.Drawing.Size(0, 23);
            this.ratSelectionLabel.TabIndex = 21;
            // 
            // LinearTrackGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(653, 492);
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
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expBox);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LinearTrackGui";
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
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.ComboBox ratSelection;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
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
    }
}

