namespace tetrismaking
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.returnbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Castellar", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(20, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 530);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnbutton
            // 
            this.returnbutton.BackColor = System.Drawing.Color.Black;
            this.returnbutton.Font = new System.Drawing.Font("Castellar", 25.25F);
            this.returnbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnbutton.Location = new System.Drawing.Point(132, 494);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(199, 67);
            this.returnbutton.TabIndex = 1;
            this.returnbutton.Text = "RETURN";
            this.returnbutton.UseVisualStyleBackColor = false;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(457, 573);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Rules";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnbutton;
    }
}