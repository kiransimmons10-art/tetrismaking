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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.invalidatetimer = new System.Windows.Forms.Timer(this.components);
            this.gravitytimer = new System.Windows.Forms.Timer(this.components);
            this.displaylabel = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            this.display2label = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.leaderboardlabel = new System.Windows.Forms.Label();
            this.namebutton = new System.Windows.Forms.Button();
            this.nextuplabel = new System.Windows.Forms.Label();
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
            // displaylabel
            // 
            this.displaylabel.Font = new System.Drawing.Font("Castellar", 40.25F);
            this.displaylabel.ForeColor = System.Drawing.Color.White;
            this.displaylabel.Location = new System.Drawing.Point(111, 42);
            this.displaylabel.Name = "displaylabel";
            this.displaylabel.Size = new System.Drawing.Size(234, 100);
            this.displaylabel.TabIndex = 0;
            this.displaylabel.Text = "SCORE";
            this.displaylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.displaylabel.Visible = false;
            this.displaylabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // scorelabel
            // 
            this.scorelabel.Font = new System.Drawing.Font("Castellar", 40.25F);
            this.scorelabel.ForeColor = System.Drawing.Color.White;
            this.scorelabel.Location = new System.Drawing.Point(111, 142);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(234, 100);
            this.scorelabel.TabIndex = 1;
            this.scorelabel.Text = "SCORE";
            this.scorelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scorelabel.Visible = false;
            // 
            // display2label
            // 
            this.display2label.Font = new System.Drawing.Font("Castellar", 25.25F);
            this.display2label.ForeColor = System.Drawing.Color.White;
            this.display2label.Location = new System.Drawing.Point(85, 242);
            this.display2label.Name = "display2label";
            this.display2label.Size = new System.Drawing.Size(277, 52);
            this.display2label.TabIndex = 2;
            this.display2label.Text = "ENTER NAME";
            this.display2label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.display2label.Visible = false;
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.Color.Black;
            this.namebox.Font = new System.Drawing.Font("Castellar", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.ForeColor = System.Drawing.Color.White;
            this.namebox.Location = new System.Drawing.Point(164, 312);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(120, 32);
            this.namebox.TabIndex = 3;
            this.namebox.Visible = false;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // leaderboardlabel
            // 
            this.leaderboardlabel.Font = new System.Drawing.Font("Castellar", 14.25F);
            this.leaderboardlabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.leaderboardlabel.Location = new System.Drawing.Point(134, 389);
            this.leaderboardlabel.Name = "leaderboardlabel";
            this.leaderboardlabel.Size = new System.Drawing.Size(222, 270);
            this.leaderboardlabel.TabIndex = 4;
            this.leaderboardlabel.Text = "label1";
            this.leaderboardlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.leaderboardlabel.Visible = false;
            this.leaderboardlabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // namebutton
            // 
            this.namebutton.BackColor = System.Drawing.Color.Black;
            this.namebutton.Font = new System.Drawing.Font("Castellar", 15.25F);
            this.namebutton.ForeColor = System.Drawing.Color.White;
            this.namebutton.Location = new System.Drawing.Point(171, 349);
            this.namebutton.Name = "namebutton";
            this.namebutton.Size = new System.Drawing.Size(103, 37);
            this.namebutton.TabIndex = 5;
            this.namebutton.Text = "Enter";
            this.namebutton.UseVisualStyleBackColor = false;
            this.namebutton.Visible = false;
            this.namebutton.Click += new System.EventHandler(this.namebutton_Click);
            // 
            // nextuplabel
            // 
            this.nextuplabel.AutoSize = true;
            this.nextuplabel.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextuplabel.ForeColor = System.Drawing.Color.White;
            this.nextuplabel.Location = new System.Drawing.Point(369, 101);
            this.nextuplabel.Name = "nextuplabel";
            this.nextuplabel.Size = new System.Drawing.Size(62, 13);
            this.nextuplabel.TabIndex = 6;
            this.nextuplabel.Text = "NEXT UP";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(443, 660);
            this.Controls.Add(this.nextuplabel);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.namebutton);
            this.Controls.Add(this.leaderboardlabel);
            this.Controls.Add(this.display2label);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.displaylabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer invalidatetimer;
        private System.Windows.Forms.Timer gravitytimer;
        private System.Windows.Forms.Label displaylabel;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label display2label;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label leaderboardlabel;
        private System.Windows.Forms.Button namebutton;
        private System.Windows.Forms.Label nextuplabel;
    }
}