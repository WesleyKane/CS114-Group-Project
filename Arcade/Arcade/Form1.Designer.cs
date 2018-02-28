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
            this.SuspendLayout();
            // 
            // Pacman
            // 
            this.Pacman.Location = new System.Drawing.Point(215, 156);
            this.Pacman.Name = "Pacman";
            this.Pacman.Size = new System.Drawing.Size(152, 107);
            this.Pacman.TabIndex = 0;
            this.Pacman.Text = "Pacman";
            this.Pacman.UseVisualStyleBackColor = true;
            this.Pacman.Click += new System.EventHandler(this.Pacman_Click);
            // 
            // Asteroids
            // 
            this.Asteroids.Location = new System.Drawing.Point(487, 156);
            this.Asteroids.Name = "Asteroids";
            this.Asteroids.Size = new System.Drawing.Size(149, 107);
            this.Asteroids.TabIndex = 1;
            this.Asteroids.Text = "Asteroids";
            this.Asteroids.UseVisualStyleBackColor = true;
            this.Asteroids.Click += new System.EventHandler(this.Asteroids_Click);
            // 
            // Pong
            // 
            this.Pong.Location = new System.Drawing.Point(215, 306);
            this.Pong.Name = "Pong";
            this.Pong.Size = new System.Drawing.Size(152, 108);
            this.Pong.TabIndex = 2;
            this.Pong.Text = "Pong";
            this.Pong.UseVisualStyleBackColor = true;
            this.Pong.Click += new System.EventHandler(this.Pong_Click);
            // 
            // Battleship
            // 
            this.Battleship.Location = new System.Drawing.Point(487, 306);
            this.Battleship.Name = "Battleship";
            this.Battleship.Size = new System.Drawing.Size(149, 104);
            this.Battleship.TabIndex = 3;
            this.Battleship.Text = "Battleship";
            this.Battleship.UseVisualStyleBackColor = true;
            this.Battleship.Click += new System.EventHandler(this.Battleship_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(88, 611);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(119, 42);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 719);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Battleship);
            this.Controls.Add(this.Pong);
            this.Controls.Add(this.Asteroids);
            this.Controls.Add(this.Pacman);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Pacman;
        private System.Windows.Forms.Button Asteroids;
        private System.Windows.Forms.Button Pong;
        private System.Windows.Forms.Button Battleship;
        private System.Windows.Forms.Button Exit;
    }
}

