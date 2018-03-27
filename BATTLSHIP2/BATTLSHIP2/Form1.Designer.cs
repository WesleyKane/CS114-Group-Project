﻿namespace BATTLSHIP2
{
    partial class BattleShip
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
            this.playerScore = new System.Windows.Forms.Label();
            this.enemyScore = new System.Windows.Forms.Label();
            this.enemyMoves = new System.Windows.Forms.Label();
            this.roundsText = new System.Windows.Forms.Label();
            this.helpText = new System.Windows.Forms.Label();
            this.w1 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.enemyLocationList = new System.Windows.Forms.ComboBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.enemyPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyPositionPicker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.Location = new System.Drawing.Point(385, 143);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(55, 38);
            this.playerScore.TabIndex = 0;
            this.playerScore.Text = "00";
            // 
            // enemyScore
            // 
            this.enemyScore.AutoSize = true;
            this.enemyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyScore.Location = new System.Drawing.Point(975, 143);
            this.enemyScore.Name = "enemyScore";
            this.enemyScore.Size = new System.Drawing.Size(55, 38);
            this.enemyScore.TabIndex = 1;
            this.enemyScore.Text = "00";
            // 
            // enemyMoves
            // 
            this.enemyMoves.AutoSize = true;
            this.enemyMoves.BackColor = System.Drawing.Color.Transparent;
            this.enemyMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyMoves.ForeColor = System.Drawing.Color.White;
            this.enemyMoves.Location = new System.Drawing.Point(975, 47);
            this.enemyMoves.Name = "enemyMoves";
            this.enemyMoves.Size = new System.Drawing.Size(59, 38);
            this.enemyMoves.TabIndex = 2;
            this.enemyMoves.Text = "A1";
            // 
            // roundsText
            // 
            this.roundsText.AutoSize = true;
            this.roundsText.BackColor = System.Drawing.Color.Transparent;
            this.roundsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsText.ForeColor = System.Drawing.Color.White;
            this.roundsText.Location = new System.Drawing.Point(511, 238);
            this.roundsText.Name = "roundsText";
            this.roundsText.Size = new System.Drawing.Size(119, 32);
            this.roundsText.TabIndex = 3;
            this.roundsText.Text = "Rounds";
            // 
            // helpText
            // 
            this.helpText.AutoSize = true;
            this.helpText.BackColor = System.Drawing.Color.Transparent;
            this.helpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpText.ForeColor = System.Drawing.Color.LightGreen;
            this.helpText.Location = new System.Drawing.Point(58, 717);
            this.helpText.Name = "helpText";
            this.helpText.Size = new System.Drawing.Size(448, 29);
            this.helpText.TabIndex = 4;
            this.helpText.Text = "1) Click on 3 Different Buttons to Start";
            // 
            // w1
            // 
            this.w1.Location = new System.Drawing.Point(113, 299);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(87, 86);
            this.w1.TabIndex = 5;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = true;
            this.w1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // w2
            // 
            this.w2.Location = new System.Drawing.Point(215, 299);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(87, 86);
            this.w2.TabIndex = 6;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = true;
            this.w2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(215, 504);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(87, 86);
            this.y2.TabIndex = 7;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = true;
            this.y2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(215, 400);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(87, 86);
            this.x2.TabIndex = 8;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(113, 400);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(87, 86);
            this.x1.TabIndex = 9;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = true;
            this.x1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(113, 504);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(87, 86);
            this.y1.TabIndex = 10;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = true;
            this.y1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // z1
            // 
            this.z1.Location = new System.Drawing.Point(113, 606);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(87, 86);
            this.z1.TabIndex = 11;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = true;
            this.z1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // z2
            // 
            this.z2.Location = new System.Drawing.Point(215, 606);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(87, 86);
            this.z2.TabIndex = 12;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = true;
            this.z2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // w3
            // 
            this.w3.Location = new System.Drawing.Point(317, 299);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(87, 86);
            this.w3.TabIndex = 13;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = true;
            this.w3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // y4
            // 
            this.y4.Location = new System.Drawing.Point(419, 504);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(87, 86);
            this.y4.TabIndex = 14;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = true;
            this.y4.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(419, 400);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(87, 86);
            this.x4.TabIndex = 15;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = true;
            this.x4.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // w4
            // 
            this.w4.Location = new System.Drawing.Point(419, 299);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(87, 86);
            this.w4.TabIndex = 16;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = true;
            this.w4.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // z3
            // 
            this.z3.Location = new System.Drawing.Point(317, 606);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(87, 86);
            this.z3.TabIndex = 17;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = true;
            this.z3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(317, 504);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(87, 86);
            this.y3.TabIndex = 18;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = true;
            this.y3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(317, 400);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(87, 86);
            this.x3.TabIndex = 19;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = true;
            this.x3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // z4
            // 
            this.z4.Location = new System.Drawing.Point(419, 606);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(87, 86);
            this.z4.TabIndex = 20;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = true;
            this.z4.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(764, 504);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(87, 86);
            this.c2.TabIndex = 21;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(764, 400);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(87, 86);
            this.b2.TabIndex = 22;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(764, 606);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(87, 86);
            this.d2.TabIndex = 23;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = true;
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(662, 606);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(87, 86);
            this.d1.TabIndex = 24;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(662, 504);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(87, 86);
            this.c1.TabIndex = 25;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(662, 400);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(87, 86);
            this.b1.TabIndex = 26;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(764, 299);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(87, 86);
            this.a2.TabIndex = 27;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = true;
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(662, 299);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(87, 86);
            this.a1.TabIndex = 28;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // d4
            // 
            this.d4.Location = new System.Drawing.Point(968, 606);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(87, 86);
            this.d4.TabIndex = 29;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = true;
            // 
            // c4
            // 
            this.c4.Location = new System.Drawing.Point(968, 504);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(87, 86);
            this.c4.TabIndex = 30;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(968, 400);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(87, 86);
            this.b4.TabIndex = 31;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // d3
            // 
            this.d3.Location = new System.Drawing.Point(866, 606);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(87, 86);
            this.d3.TabIndex = 32;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(866, 504);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(87, 86);
            this.c3.TabIndex = 33;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(866, 400);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(87, 86);
            this.b3.TabIndex = 34;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // a4
            // 
            this.a4.Location = new System.Drawing.Point(968, 299);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(87, 86);
            this.a4.TabIndex = 35;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = true;
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(866, 299);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(87, 86);
            this.a3.TabIndex = 36;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = true;
            // 
            // enemyLocationList
            // 
            this.enemyLocationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyLocationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyLocationList.FormattingEnabled = true;
            this.enemyLocationList.Location = new System.Drawing.Point(201, 37);
            this.enemyLocationList.Name = "enemyLocationList";
            this.enemyLocationList.Size = new System.Drawing.Size(111, 33);
            this.enemyLocationList.TabIndex = 37;
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.Location = new System.Drawing.Point(340, 37);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(102, 39);
            this.attackButton.TabIndex = 38;
            this.attackButton.Text = "Attack!";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackEnemyPosition);
            // 
            // enemyPlayTimer
            // 
            this.enemyPlayTimer.Interval = 1000;
            this.enemyPlayTimer.Tick += new System.EventHandler(this.enemyAttackPlayer);
            // 
            // enemyPositionPicker
            // 
            this.enemyPositionPicker.Enabled = true;
            this.enemyPositionPicker.Interval = 500;
            this.enemyPositionPicker.Tick += new System.EventHandler(this.enemyPicksPosition);
            // 
            // BattleShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BATTLSHIP2.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1172, 776);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.enemyLocationList);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.helpText);
            this.Controls.Add(this.roundsText);
            this.Controls.Add(this.enemyMoves);
            this.Controls.Add(this.enemyScore);
            this.Controls.Add(this.playerScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BattleShip";
            this.Text = "Battleship";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label enemyScore;
        private System.Windows.Forms.Label enemyMoves;
        private System.Windows.Forms.Label roundsText;
        private System.Windows.Forms.Label helpText;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.ComboBox enemyLocationList;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Timer enemyPlayTimer;
        private System.Windows.Forms.Timer enemyPositionPicker;
    }
}

