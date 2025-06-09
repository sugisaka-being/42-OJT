namespace ShinobiSHift_Game
{
    partial class ExitForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.notExitButton = new System.Windows.Forms.Button();
            this.ExitText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(12, 157);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "yes";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // notExitButton
            // 
            this.notExitButton.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notExitButton.ForeColor = System.Drawing.Color.Black;
            this.notExitButton.Location = new System.Drawing.Point(97, 157);
            this.notExitButton.Name = "notExitButton";
            this.notExitButton.Size = new System.Drawing.Size(75, 23);
            this.notExitButton.TabIndex = 1;
            this.notExitButton.Text = "no";
            this.notExitButton.UseVisualStyleBackColor = true;
            this.notExitButton.Click += new System.EventHandler(this.notExitButton_Click);
            // 
            // ExitText
            // 
            this.ExitText.AutoSize = true;
            this.ExitText.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitText.ForeColor = System.Drawing.Color.White;
            this.ExitText.Location = new System.Drawing.Point(41, 69);
            this.ExitText.Name = "ExitText";
            this.ExitText.Size = new System.Drawing.Size(108, 20);
            this.ExitText.TabIndex = 2;
            this.ExitText.Text = "終了しますか？";
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(184, 261);
            this.Controls.Add(this.ExitText);
            this.Controls.Add(this.notExitButton);
            this.Controls.Add(this.exitButton);
            this.Name = "ExitForm";
            this.Text = "ShinobiShift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button notExitButton;
        private System.Windows.Forms.Label ExitText;
    }
}