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
            this.Pacman = new System.Windows.Forms.Button();
            this.Asteroids = new System.Windows.Forms.Button();
            this.Pong = new System.Windows.Forms.Button();
            this.Battleship = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pacman
            // 
            this.Pacman.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pacman.BackgroundImage = global::Arcade.Properties.Resources.froggy;
            this.Pacman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pacman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pacman.Location = new System.Drawing.Point(418, 222);
            this.Pacman.Margin = new System.Windows.Forms.Padding(2);
            this.Pacman.Name = "Pacman";
            this.Pacman.Size = new System.Drawing.Size(109, 117);
            this.Pacman.TabIndex = 0;
            this.Pacman.UseVisualStyleBackColor = false;
            this.Pacman.Click += new System.EventHandler(this.Pacman_Click);
            // 
            // Asteroids
            // 
            this.Asteroids.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Asteroids.BackgroundImage = global::Arcade.Properties.Resources.ship;
            this.Asteroids.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Asteroids.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Asteroids.Location = new System.Drawing.Point(292, 343);
            this.Asteroids.Margin = new System.Windows.Forms.Padding(2);
            this.Asteroids.Name = "Asteroids";
            this.Asteroids.Size = new System.Drawing.Size(112, 119);
            this.Asteroids.TabIndex = 1;
            this.Asteroids.UseVisualStyleBackColor = false;
            this.Asteroids.Click += new System.EventHandler(this.Asteroids_Click);
            // 
            // Pong
            // 
            this.Pong.BackColor = System.Drawing.Color.Transparent;
            this.Pong.BackgroundImage = global::Arcade.Properties.Resources.pongmainmenu1;
            this.Pong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pong.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Pong.Location = new System.Drawing.Point(292, 222);
            this.Pong.Margin = new System.Windows.Forms.Padding(2);
            this.Pong.Name = "Pong";
            this.Pong.Size = new System.Drawing.Size(112, 117);
            this.Pong.TabIndex = 2;
            this.Pong.UseVisualStyleBackColor = false;
            this.Pong.Click += new System.EventHandler(this.Pong_Click);
            // 
            // Battleship
            // 
            this.Battleship.BackgroundImage = global::Arcade.Properties.Resources.battleshipmainmenu1;
            this.Battleship.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Battleship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Battleship.Location = new System.Drawing.Point(418, 343);
            this.Battleship.Margin = new System.Windows.Forms.Padding(2);
            this.Battleship.Name = "Battleship";
            this.Battleship.Size = new System.Drawing.Size(109, 119);
            this.Battleship.TabIndex = 3;
            this.Battleship.UseVisualStyleBackColor = true;
            this.Battleship.Click += new System.EventHandler(this.Battleship_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(366, 580);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(89, 34);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Arcade.Properties.Resources.MainMenuTheme;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(250, -8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 648);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Arcade.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 640);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Battleship);
            this.Controls.Add(this.Asteroids);
            this.Controls.Add(this.Pacman);
            this.Controls.Add(this.Pong);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Pacman;
        private System.Windows.Forms.Button Asteroids;
        private System.Windows.Forms.Button Pong;
        private System.Windows.Forms.Button Battleship;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

