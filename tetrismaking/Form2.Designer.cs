namespace tetrismaking
{
    partial class Form2
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
            this.SuspendLayout();
            // 
            // invalidatetimer
            // 
            this.invalidatetimer.Enabled = true;
            this.invalidatetimer.Interval = 1;
            this.invalidatetimer.Tick += new System.EventHandler(this.invalidatetimer_Tick);
            // 
            // gravitytimer
            // 
            this.gravitytimer.Enabled = true;
            this.gravitytimer.Interval = 1000;
            this.gravitytimer.Tick += new System.EventHandler(this.gravitytimer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 660);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer invalidatetimer;
        private System.Windows.Forms.Timer gravitytimer;
    }
}