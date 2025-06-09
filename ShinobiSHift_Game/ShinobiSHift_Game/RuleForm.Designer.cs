namespace ShinobiLeap_Game
{
    partial class RuleForm
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.PictureBox();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(492, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prologue";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Fuchsia;
            this.Player.Location = new System.Drawing.Point(158, 262);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(82, 76);
            this.Player.TabIndex = 4;
            this.Player.TabStop = false;
            // 
            // ScorePanel
            // 
            this.ScorePanel.BackColor = System.Drawing.Color.White;
            this.ScorePanel.Location = new System.Drawing.Point(0, 334);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(1200, 30);
            this.ScorePanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(222, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(823, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "2125年...彼は重力を操るスーツ《AG LEAP》を纏う、唯一のエージェント。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(291, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(674, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "操作は、SPACEキーひとつ。君は天井も走ることができる。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(333, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(563, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "迫りくる障害物を避け、スコア20000を目指せ。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(952, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 43);
            this.label5.TabIndex = 9;
            this.label5.Text = "-SPACEで開始-";
            // 
            // RuleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "RuleForm";
            this.Text = "ShinobiLeap";
            this.Load += new System.EventHandler(this.ShinobiLeapRule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}