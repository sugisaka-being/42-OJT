﻿namespace ShinobiLeap_Game
{
    partial class PlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.PlayBGM = new AxWMPLib.AxWindowsMediaPlayer();
            this.ScoreRecord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayMotionSE1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.ScorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayMotionSE1)).BeginInit();
            this.SuspendLayout();
            // 
            // ScorePanel
            // 
            this.ScorePanel.BackColor = System.Drawing.Color.White;
            this.ScorePanel.Controls.Add(this.PlayMotionSE1);
            this.ScorePanel.Controls.Add(this.PlayBGM);
            this.ScorePanel.Controls.Add(this.ScoreRecord);
            this.ScorePanel.Controls.Add(this.label1);
            this.ScorePanel.Location = new System.Drawing.Point(0, 334);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(1200, 30);
            this.ScorePanel.TabIndex = 6;
            // 
            // PlayBGM
            // 
            this.PlayBGM.Enabled = true;
            this.PlayBGM.Location = new System.Drawing.Point(953, -13);
            this.PlayBGM.Name = "PlayBGM";
            this.PlayBGM.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PlayBGM.OcxState")));
            this.PlayBGM.Size = new System.Drawing.Size(219, 43);
            this.PlayBGM.TabIndex = 7;
            this.PlayBGM.Visible = false;
            // 
            // ScoreRecord
            // 
            this.ScoreRecord.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreRecord.Location = new System.Drawing.Point(99, 3);
            this.ScoreRecord.Name = "ScoreRecord";
            this.ScoreRecord.Size = new System.Drawing.Size(100, 22);
            this.ScoreRecord.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score :";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Fuchsia;
            this.Player.Location = new System.Drawing.Point(158, 276);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(49, 62);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 5;
            this.Player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(350, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 145);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(1069, 193);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 145);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(520, 172);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(308, 166);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(895, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(145, 145);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // PlayMotionSE1
            // 
            this.PlayMotionSE1.Enabled = true;
            this.PlayMotionSE1.Location = new System.Drawing.Point(728, -13);
            this.PlayMotionSE1.Name = "PlayMotionSE1";
            this.PlayMotionSE1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PlayMotionSE1.OcxState")));
            this.PlayMotionSE1.Size = new System.Drawing.Size(219, 43);
            this.PlayMotionSE1.TabIndex = 8;
            this.PlayMotionSE1.Visible = false;
            // 
            // PlayForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 361);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.Player);
            this.Name = "PlayForm";
            this.Text = "ShinobiLeap";
            this.Load += new System.EventHandler(this.ShinobiLeapInAction_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.space);
            this.ScorePanel.ResumeLayout(false);
            this.ScorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayMotionSE1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;

        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.TextBox ScoreRecord;
        private AxWMPLib.AxWindowsMediaPlayer PlayBGM;
        private AxWMPLib.AxWindowsMediaPlayer PlayMotionSE1;
    }
}