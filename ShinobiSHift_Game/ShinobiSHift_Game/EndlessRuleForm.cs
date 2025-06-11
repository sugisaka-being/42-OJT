using ShinobiLeap_Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinobiSHift_Game
{
    public partial class EndlessRuleForm : Form
    {
        public EndlessRuleForm()
        {
            InitializeComponent();
            this.KeyDown += ShinobiLeap_KeyDown;
            this.FormClosing += EndlessRule_FormClosing;
            this.Load += ShinobiLeapRule_Load;
        }

        public static int playerX = 158;
        public static int groundY = 272;
        public static int ceilingY = 0;

        private void ShinobiLeapRule_Load(object sender, EventArgs e)
        {
            Player2.Location = new Point(playerX, groundY);
            Player2.Size = new Size(49, 62);
            Player2.Image = new Bitmap(Path.Combine(Application.StartupPath, "Images", "ninja.png"));
            Player2.BackColor = Color.Transparent; // 透明に設定
        }

        private void ShinobiLeap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // Spaceキーが押されたら
            {
                // 新しいフォームを作成
                EndlessForm endlessForm = new EndlessForm();

                // 新しいフォームを作成い
                endlessForm.Show();

                // 現在のフォームを閉じる（hideだと隠れているだけでApplication.Run()をコーディングしているBootingを閉じないとアプリケーションは終了しない）
                this.Hide();
            }
        }

            public void EndlessRule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 終了を実行
        }
    }
}


