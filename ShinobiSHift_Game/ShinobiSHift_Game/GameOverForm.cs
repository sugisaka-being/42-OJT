using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static ShinobiLeap_Game.StartForm;

namespace ShinobiLeap_Game
{
    public partial class GameOverForm : Form
    {
        int finalScore;

        public GameOverForm(int score)
        {
            InitializeComponent();
            finalScore = score;//スコアをプレイ画面から受け取ってる
            this.FormClosing += ShinobiShiftGameOver_FormClosing;
        }

        private void ShinobiLeapGameOver_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);

            GameOverRecord.Text = $"Score：{finalScore}";
            GameOverBGM.URL = @"BGM\GameOverTheme1.mp3";//何の曲を流すか
            GameOverBGM.settings.setMode("loop", false); // 1回しか流さない
            GameOverBGM.settings.volume = 1;//音量
            Player.Image = new Bitmap(Path.Combine(Application.StartupPath, "Images", "ninja.png"));
            Player.BackColor = Color.Transparent; // 透明に設定
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameOverClickSE1.URL = @"SE\ShinobiLeapClickSE1.mp3";//何のSEを流すか
            GameOverClickSE1.settings.setMode("loop", false); // 1回だけ流す
            GameOverClickSE1.settings.volume = 1;//音量

            // 新しいフォームを作成
            PlayForm InActionForm = new PlayForm();

            // 新しいフォームを表示
            InActionForm.Show();

            // 現在のフォームを閉じる// 現在のフォームを隠すのか終了するのか迷う
            this.Hide();

            // BGMを止める
            GameOverBGM.Ctlcontrols.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameOverClickSE1.URL = @"SE\ShinobiLeapClickSE1.mp3";//何のSEを流すか
            GameOverClickSE1.settings.setMode("loop", false); // 1回だけ流す
            GameOverClickSE1.settings.volume = 1;//音量

            // 新しいフォームを作成
            StartForm StartForm = new StartForm();

            // 新しいフォームを表示
            StartForm.Show();

            // 現在のフォームを閉じる// 現在のフォームを隠すのか終了するのか迷う
            this.Hide();

            // BGMを止める
            GameOverBGM.Ctlcontrols.stop();
        }

        public void ShinobiShiftGameOver_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 終了を実行
        }
    }
}