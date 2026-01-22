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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rulesbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.Black;
            this.startbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startbutton.Font = new System.Drawing.Font("Castellar", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.startbutton.Location = new System.Drawing.Point(197, 439);
            this.startbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(310, 103);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "START";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(651, 418);
            this.label2.TabIndex = 2;
            // 
            // rulesbutton
            // 
            this.rulesbutton.BackColor = System.Drawing.Color.Black;
            this.rulesbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rulesbutton.Font = new System.Drawing.Font("Castellar", 25.25F, System.Drawing.FontStyle.Bold);
            this.rulesbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rulesbutton.Location = new System.Drawing.Point(536, 467);
            this.rulesbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rulesbutton.Name = "rulesbutton";
            this.rulesbutton.Size = new System.Drawing.Size(175, 75);
            this.rulesbutton.TabIndex = 4;
            this.rulesbutton.Text = "RULES";
            this.rulesbutton.UseVisualStyleBackColor = false;
            this.rulesbutton.Click += new System.EventHandler(this.rulesbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(724, 554);
            this.Controls.Add(this.rulesbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startbutton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rulesbutton;
    }
}

