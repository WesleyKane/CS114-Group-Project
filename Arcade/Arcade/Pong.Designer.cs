namespace Arcade
{
    partial class Pong
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
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Player1Score = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.PictureBox();
            this.B2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Player1.BackColor = System.Drawing.SystemColors.Window;
            this.Player1.Location = new System.Drawing.Point(9, 150);
            this.Player1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(20, 103);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            this.Player1.Click += new System.EventHandler(this.Player1_Click);
            // 
            // Player2
            // 
            this.Player2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Player2.BackColor = System.Drawing.Color.White;
            this.Player2.Location = new System.Drawing.Point(673, 150);
            this.Player2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(20, 103);
            this.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = false;
            // 
            // ball
            // 
            this.ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(350, 194);
            this.ball.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 21);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Player1Score
            // 
            this.Player1Score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player1Score.AutoSize = true;
            this.Player1Score.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Score.ForeColor = System.Drawing.SystemColors.Window;
            this.Player1Score.Location = new System.Drawing.Point(328, 60);
            this.Player1Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(18, 20);
            this.Player1Score.TabIndex = 3;
            this.Player1Score.Text = "0";
            this.Player1Score.Click += new System.EventHandler(this.Player1Score_Click);
            // 
            // Player2Score
            // 
            this.Player2Score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player2Score.AutoSize = true;
            this.Player2Score.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Player2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Score.ForeColor = System.Drawing.SystemColors.Window;
            this.Player2Score.Location = new System.Drawing.Point(375, 60);
            this.Player2Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(18, 20);
            this.Player2Score.TabIndex = 4;
            this.Player2Score.Text = "0";
            this.Player2Score.Click += new System.EventHandler(this.Player2Score_Click);
            // 
            // B1
            // 
            this.B1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.B1.BackColor = System.Drawing.Color.DarkRed;
            this.B1.Location = new System.Drawing.Point(9, 194);
            this.B1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(20, 21);
            this.B1.TabIndex = 5;
            this.B1.TabStop = false;
            // 
            // B2
            // 
            this.B2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.B2.BackColor = System.Drawing.Color.DarkRed;
            this.B2.Location = new System.Drawing.Point(673, 194);
            this.B2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(20, 21);
            this.B2.TabIndex = 6;
            this.B2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 41);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(356, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 460);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(701, 460);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Score;
        private System.Windows.Forms.PictureBox B1;
        private System.Windows.Forms.PictureBox B2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}