namespace ShinobiSHift_Game
{
    partial class ResultForm
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
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.Player = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultRecord = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultRecord2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // ScorePanel
            // 
            this.ScorePanel.BackColor = System.Drawing.Color.White;
            this.ScorePanel.Location = new System.Drawing.Point(0, 334);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(1200, 30);
            this.ScorePanel.TabIndex = 14;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Fuchsia;
            this.Player.Location = new System.Drawing.Point(158, 262);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(82, 76);
            this.Player.TabIndex = 15;
            this.Player.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 150);
            this.label1.TabIndex = 16;
            this.label1.Text = "Try again...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultRecord
            // 
            this.ResultRecord.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultRecord.ForeColor = System.Drawing.Color.White;
            this.ResultRecord.Location = new System.Drawing.Point(489, 143);
            this.ResultRecord.MaximumSize = new System.Drawing.Size(200, 0);
            this.ResultRecord.Name = "ResultRecord";
            this.ResultRecord.Size = new System.Drawing.Size(200, 0);
            this.ResultRecord.TabIndex = 19;
            this.ResultRecord.Text = "2000\r\n";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(291, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 50);
            this.button2.TabIndex = 18;
            this.button2.Text = "ReStart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(645, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultRecord2
            // 
            this.ResultRecord2.AutoSize = true;
            this.ResultRecord2.BackColor = System.Drawing.Color.Black;
            this.ResultRecord2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Italic);
            this.ResultRecord2.ForeColor = System.Drawing.Color.White;
            this.ResultRecord2.Location = new System.Drawing.Point(489, 145);
            this.ResultRecord2.Name = "ResultRecord2";
            this.ResultRecord2.Size = new System.Drawing.Size(34, 39);
            this.ResultRecord2.TabIndex = 20;
            this.ResultRecord2.Text = "0";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 361);
            this.Controls.Add(this.ResultRecord2);
            this.Controls.Add(this.ResultRecord);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ScorePanel);
            this.Name = "ResultForm";
            this.Text = "ShinobiLeap";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ResultRecord;
        private System.Windows.Forms.Label ResultRecord2;
    }
}