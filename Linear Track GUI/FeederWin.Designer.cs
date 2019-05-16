namespace Linear_Track_GUI
{
    partial class FeederWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeederWin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close2 = new System.Windows.Forms.Button();
            this.close4 = new System.Windows.Forms.Button();
            this.fill2 = new System.Windows.Forms.Button();
            this.fill4 = new System.Windows.Forms.Button();
            this.closeFill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Feeder Control";
            // 
            // close2
            // 
            this.close2.BackColor = System.Drawing.Color.Red;
            this.close2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close2.Location = new System.Drawing.Point(307, 79);
            this.close2.Name = "close2";
            this.close2.Size = new System.Drawing.Size(58, 31);
            this.close2.TabIndex = 2;
            this.close2.Text = "STOP";
            this.close2.UseVisualStyleBackColor = false;
            this.close2.Click += new System.EventHandler(this.close2_Click);
            // 
            // close4
            // 
            this.close4.BackColor = System.Drawing.Color.Red;
            this.close4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close4.Location = new System.Drawing.Point(307, 407);
            this.close4.Name = "close4";
            this.close4.Size = new System.Drawing.Size(58, 31);
            this.close4.TabIndex = 3;
            this.close4.Text = "STOP";
            this.close4.UseVisualStyleBackColor = false;
            this.close4.Click += new System.EventHandler(this.close4_Click);
            // 
            // fill2
            // 
            this.fill2.BackColor = System.Drawing.Color.Azure;
            this.fill2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fill2.Location = new System.Drawing.Point(307, 79);
            this.fill2.Name = "fill2";
            this.fill2.Size = new System.Drawing.Size(58, 31);
            this.fill2.TabIndex = 4;
            this.fill2.Text = "Fill 2";
            this.fill2.UseVisualStyleBackColor = false;
            this.fill2.Click += new System.EventHandler(this.fill2_Click);
            // 
            // fill4
            // 
            this.fill4.BackColor = System.Drawing.Color.Azure;
            this.fill4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fill4.Location = new System.Drawing.Point(307, 406);
            this.fill4.Name = "fill4";
            this.fill4.Size = new System.Drawing.Size(58, 31);
            this.fill4.TabIndex = 5;
            this.fill4.Text = "Fill 4";
            this.fill4.UseVisualStyleBackColor = false;
            this.fill4.Click += new System.EventHandler(this.fill4_Click);
            // 
            // closeFill
            // 
            this.closeFill.BackColor = System.Drawing.Color.Honeydew;
            this.closeFill.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeFill.Location = new System.Drawing.Point(535, 478);
            this.closeFill.Name = "closeFill";
            this.closeFill.Size = new System.Drawing.Size(121, 37);
            this.closeFill.TabIndex = 6;
            this.closeFill.Text = "Done Filling";
            this.closeFill.UseVisualStyleBackColor = false;
            this.closeFill.Click += new System.EventHandler(this.closeFill_Click);
            // 
            // FeederWin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(668, 541);
            this.ControlBox = false;
            this.Controls.Add(this.closeFill);
            this.Controls.Add(this.fill4);
            this.Controls.Add(this.fill2);
            this.Controls.Add(this.close4);
            this.Controls.Add(this.close2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FeederWin";
            this.ShowIcon = false;
            this.Text = "FeederWin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close2;
        private System.Windows.Forms.Button close4;
        private System.Windows.Forms.Button fill2;
        private System.Windows.Forms.Button fill4;
        private System.Windows.Forms.Button closeFill;
    }
}