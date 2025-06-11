namespace ShinobiLeap_Game
{
    partial class ClearForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClearForm));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Player = new System.Windows.Forms.PictureBox();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.ClearBGM = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearRecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.ScorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClearBGM)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(283, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 50);
            this.button2.TabIndex = 13;
            this.button2.Text = "ReStart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(637, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 50);
            this.button1.TabIndex = 12;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_Click);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Fuchsia;
            this.Player.Location = new System.Drawing.Point(158, 262);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(82, 76);
            this.Player.TabIndex = 11;
            this.Player.TabStop = false;
            // 
            // ScorePanel
            // 
            this.ScorePanel.BackColor = System.Drawing.Color.White;
            this.ScorePanel.Controls.Add(this.ClearBGM);
            this.ScorePanel.Location = new System.Drawing.Point(0, 334);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(1200, 30);
            this.ScorePanel.TabIndex = 10;
            // 
            // ClearBGM
            // 
            this.ClearBGM.Enabled = true;
            this.ClearBGM.Location = new System.Drawing.Point(953, -16);
            this.ClearBGM.Name = "ClearBGM";
            this.ClearBGM.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ClearBGM.OcxState")));
            this.ClearBGM.Size = new System.Drawing.Size(219, 43);
            this.ClearBGM.TabIndex = 15;
            this.ClearBGM.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(334, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 150);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nice run!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearRecord
            // 
            this.ClearRecord.AutoSize = true;
            this.ClearRecord.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearRecord.ForeColor = System.Drawing.Color.White;
            this.ClearRecord.Location = new System.Drawing.Point(498, 141);
            this.ClearRecord.Name = "ClearRecord";
            this.ClearRecord.Size = new System.Drawing.Size(99, 39);
            this.ClearRecord.TabIndex = 14;
            this.ClearRecord.Text = "label3";
            // 
            // ClearForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 361);
            this.Controls.Add(this.ClearRecord);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.label1);
            this.Name = "ClearForm";
            this.Text = "ShinobiLeap";
            this.Load += new System.EventHandler(this.ShinobiLeapClear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ScorePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClearBGM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClearRecord;
        private AxWMPLib.AxWindowsMediaPlayer ClearBGM;
    }
}