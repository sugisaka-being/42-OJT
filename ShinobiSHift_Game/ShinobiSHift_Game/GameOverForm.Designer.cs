namespace ShinobiLeap_Game
{
    partial class GameOverForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.GameOverBGM = new AxWMPLib.AxWindowsMediaPlayer();
            this.Player = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GameOverRecord = new System.Windows.Forms.Label();
            this.GameOverClickSE1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.ScorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverClickSE1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 150);
            this.label1.TabIndex = 1;
            this.label1.Text = "Try again...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScorePanel
            // 
            this.ScorePanel.BackColor = System.Drawing.Color.White;
            this.ScorePanel.Controls.Add(this.GameOverClickSE1);
            this.ScorePanel.Controls.Add(this.GameOverBGM);
            this.ScorePanel.Location = new System.Drawing.Point(0, 334);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(1200, 30);
            this.ScorePanel.TabIndex = 3;
            // 
            // GameOverBGM
            // 
            this.GameOverBGM.Enabled = true;
            this.GameOverBGM.Location = new System.Drawing.Point(953, -13);
            this.GameOverBGM.Name = "GameOverBGM";
            this.GameOverBGM.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("GameOverBGM.OcxState")));
            this.GameOverBGM.Size = new System.Drawing.Size(219, 43);
            this.GameOverBGM.TabIndex = 9;
            this.GameOverBGM.Visible = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Fuchsia;
            this.Player.Location = new System.Drawing.Point(158, 262);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(82, 76);
            this.Player.TabIndex = 5;
            this.Player.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(645, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(291, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "ReStart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GameOverRecord
            // 
            this.GameOverRecord.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverRecord.ForeColor = System.Drawing.Color.White;
            this.GameOverRecord.Location = new System.Drawing.Point(515, 145);
            this.GameOverRecord.MaximumSize = new System.Drawing.Size(200, 0);
            this.GameOverRecord.Name = "GameOverRecord";
            this.GameOverRecord.Size = new System.Drawing.Size(200, 37);
            this.GameOverRecord.TabIndex = 8;
            this.GameOverRecord.Text = "2000\r\n";
            // 
            // GameOverClickSE1
            // 
            this.GameOverClickSE1.Enabled = true;
            this.GameOverClickSE1.Location = new System.Drawing.Point(726, -13);
            this.GameOverClickSE1.Name = "GameOverClickSE1";
            this.GameOverClickSE1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("GameOverClickSE1.OcxState")));
            this.GameOverClickSE1.Size = new System.Drawing.Size(219, 43);
            this.GameOverClickSE1.TabIndex = 10;
            this.GameOverClickSE1.Visible = false;
            // 
            // GameOverForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 361);
            this.Controls.Add(this.GameOverRecord);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.label1);
            this.Name = "GameOverForm";
            this.Text = "ShinobiLeap";
            this.Load += new System.EventHandler(this.ShinobiLeapGameOver_Load);
            this.ScorePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverClickSE1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label GameOverRecord;
        private AxWMPLib.AxWindowsMediaPlayer GameOverBGM;
        private AxWMPLib.AxWindowsMediaPlayer GameOverClickSE1;
    }
}