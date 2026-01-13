namespace tetrismaking
{
    partial class Form1
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
            this.invalidatetimer = new System.Windows.Forms.Timer(this.components);
            this.gravitytimer = new System.Windows.Forms.Timer(this.components);
            this.scorelabel = new System.Windows.Forms.Label();
            this.widesquaretimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // invalidatetimer
            // 
            this.invalidatetimer.Enabled = true;
            this.invalidatetimer.Interval = 1;
            this.invalidatetimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gravitytimer
            // 
            this.gravitytimer.Enabled = true;
            this.gravitytimer.Interval = 1000;
            this.gravitytimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Location = new System.Drawing.Point(0, 0);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(35, 13);
            this.scorelabel.TabIndex = 0;
            this.scorelabel.Text = "label1";
            // 
            // widesquaretimer
            // 
            this.widesquaretimer.Interval = 300;
            this.widesquaretimer.Tick += new System.EventHandler(this.leftrighttimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 562);
            this.Controls.Add(this.scorelabel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer invalidatetimer;
        private System.Windows.Forms.Timer gravitytimer;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Timer widesquaretimer;
    }
}

