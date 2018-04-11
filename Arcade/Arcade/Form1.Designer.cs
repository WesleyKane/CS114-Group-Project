namespace Arcade
{
    partial class MainMenu
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
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.AsteroidsButton = new System.Windows.Forms.PictureBox();
            this.FroggerButton = new System.Windows.Forms.PictureBox();
            this.PongButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsteroidsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FroggerButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PongButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(197, 662);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(89, 34);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox5.Location = new System.Drawing.Point(255, 399);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(179, 140);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // AsteroidsButton
            // 
            this.AsteroidsButton.Image = global::Arcade.Properties.Resources.AsteroidsMenuImage;
            this.AsteroidsButton.Location = new System.Drawing.Point(54, 399);
            this.AsteroidsButton.Name = "AsteroidsButton";
            this.AsteroidsButton.Size = new System.Drawing.Size(182, 140);
            this.AsteroidsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AsteroidsButton.TabIndex = 9;
            this.AsteroidsButton.TabStop = false;
            this.AsteroidsButton.Click += new System.EventHandler(this.AsteroidsButton_Click);
            // 
            // FroggerButton
            // 
            this.FroggerButton.Image = global::Arcade.Properties.Resources.FroggerMenuImage1;
            this.FroggerButton.Location = new System.Drawing.Point(255, 242);
            this.FroggerButton.Name = "FroggerButton";
            this.FroggerButton.Size = new System.Drawing.Size(179, 140);
            this.FroggerButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FroggerButton.TabIndex = 8;
            this.FroggerButton.TabStop = false;
            this.FroggerButton.Click += new System.EventHandler(this.FroggerButton_Click);
            // 
            // PongButton
            // 
            this.PongButton.Image = global::Arcade.Properties.Resources.pongMenuImage2;
            this.PongButton.Location = new System.Drawing.Point(54, 242);
            this.PongButton.Name = "PongButton";
            this.PongButton.Size = new System.Drawing.Size(182, 140);
            this.PongButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PongButton.TabIndex = 7;
            this.PongButton.TabStop = false;
            this.PongButton.Click += new System.EventHandler(this.PongButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Arcade.Properties.Resources.MainMenuGif2;
            this.pictureBox2.Location = new System.Drawing.Point(21, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(455, 328);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Arcade.Properties.Resources.MainMenuTheme;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 720);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 737);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.AsteroidsButton);
            this.Controls.Add(this.FroggerButton);
            this.Controls.Add(this.PongButton);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsteroidsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FroggerButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PongButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PongButton;
        private System.Windows.Forms.PictureBox FroggerButton;
        private System.Windows.Forms.PictureBox AsteroidsButton;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

