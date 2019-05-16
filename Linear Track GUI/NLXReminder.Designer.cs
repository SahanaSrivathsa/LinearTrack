namespace Linear_Track_GUI
{
    partial class NLXReminder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IP_address = new System.Windows.Forms.TextBox();
            this.notRecordingButton = new System.Windows.Forms.Button();
            this.ConfirmNLX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirm Cheetah is Open";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP Address:";
            // 
            // IP_address
            // 
            this.IP_address.Location = new System.Drawing.Point(152, 46);
            this.IP_address.Name = "IP_address";
            this.IP_address.Size = new System.Drawing.Size(113, 20);
            this.IP_address.TabIndex = 6;
            this.IP_address.Text = "localhost";
            // 
            // notRecordingButton
            // 
            this.notRecordingButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.notRecordingButton.Location = new System.Drawing.Point(166, 97);
            this.notRecordingButton.Name = "notRecordingButton";
            this.notRecordingButton.Size = new System.Drawing.Size(113, 37);
            this.notRecordingButton.TabIndex = 8;
            this.notRecordingButton.Text = "Not Recording";
            this.notRecordingButton.UseVisualStyleBackColor = false;
            this.notRecordingButton.Click += new System.EventHandler(this.notRecordingButton_Click);
            // 
            // ConfirmNLX
            // 
            this.ConfirmNLX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConfirmNLX.Location = new System.Drawing.Point(34, 97);
            this.ConfirmNLX.Name = "ConfirmNLX";
            this.ConfirmNLX.Size = new System.Drawing.Size(113, 37);
            this.ConfirmNLX.TabIndex = 7;
            this.ConfirmNLX.Text = "Confirm";
            this.ConfirmNLX.UseVisualStyleBackColor = false;
            this.ConfirmNLX.Click += new System.EventHandler(this.ConfirmNLX_Click);
            // 
            // NLXReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 146);
            this.Controls.Add(this.notRecordingButton);
            this.Controls.Add(this.ConfirmNLX);
            this.Controls.Add(this.IP_address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NLXReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NLXReminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IP_address;
        private System.Windows.Forms.Button notRecordingButton;
        private System.Windows.Forms.Button ConfirmNLX;
    }
}