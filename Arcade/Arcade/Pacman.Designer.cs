namespace Arcade
{
    partial class Pacman
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
			this.PushMe = new System.Windows.Forms.Button();
			this.title = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// PushMe
			// 
			this.PushMe.Location = new System.Drawing.Point(256, 407);
			this.PushMe.Name = "PushMe";
			this.PushMe.Size = new System.Drawing.Size(75, 23);
			this.PushMe.TabIndex = 0;
			this.PushMe.Text = "Push Me";
			this.PushMe.UseVisualStyleBackColor = true;
			this.PushMe.Click += new System.EventHandler(this.PushMe_Click);
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Location = new System.Drawing.Point(253, 64);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(126, 13);
			this.title.TabIndex = 1;
			this.title.Text = "You have clicked 0 times";
			// 
			// Pacman
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 529);
			this.Controls.Add(this.title);
			this.Controls.Add(this.PushMe);
			this.Name = "Pacman";
			this.Text = "Pacman";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button PushMe;
		private System.Windows.Forms.Label title;
	}
}