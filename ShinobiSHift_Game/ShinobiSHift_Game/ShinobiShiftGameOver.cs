using System;
using System.Drawing;
using System.Windows.Forms;
using static ShinobiSHift_Game.ShinobiShiftBooting;

namespace ShinobiSHift_Game
{
    public partial class ShinobiLeapGameOver : Form
    {
        int finalScore;

        public ShinobiLeapGameOver(int score)
        {
            InitializeComponent();
            finalScore = score;//スコアをプレイ画面から受け取ってる
            this.FormClosing += ShinobiShiftGameOver_FormClosing;
        }

        private void ShinobiShiftGameOver_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);

            GameOverRecord.Text = $"Score；{finalScore}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            ShinobiShiftInAction InActionForm = new ShinobiShiftInAction();

            // 新しいフォームを表示
            InActionForm.Show();

            // 現在のフォームを閉じる// 現在のフォームを隠すのか終了するのか迷う
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            ShinobiShiftBooting StartForm = new ShinobiShiftBooting();

            // 新しいフォームを表示
            StartForm.Show();

            // 現在のフォームを閉じる// 現在のフォームを隠すのか終了するのか迷う
            this.Hide();
        }

        public void ShinobiShiftGameOver_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 終了を実行
        }
    }
}