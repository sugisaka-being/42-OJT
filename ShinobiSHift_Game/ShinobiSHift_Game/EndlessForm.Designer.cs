namespace ShinobiSHift_Game
{
    partial class EndlessForm
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.ScoreRecord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.ScorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Fuchsia;
            this.Player.Location = new System.Drawing.Point(158, 276);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(49, 62);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 6;
            this.Player.TabStop = false;
            // 
            // ScorePanel
            // 
            this.ScorePanel.BackColor = System.Drawing.Color.White;
            this.ScorePanel.Controls.Add(this.ScoreRecord);
            this.ScorePanel.Controls.Add(this.label1);
            this.ScorePanel.Location = new System.Drawing.Point(0, 334);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(1200, 30);
            this.ScorePanel.TabIndex = 7;
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
            // EndlessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 361);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.Player);
            this.Name = "EndlessForm";
            this.Text = "ShinobiLeap";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ScorePanel.ResumeLayout(false);
            this.ScorePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Panel ScorePanel;
        internal System.Windows.Forms.TextBox ScoreRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}