using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static ShinobiLeap_Game.StartForm;

namespace ShinobiLeap_Game
{
    public partial class ClearForm : Form
    {
        int finalScore;
        public ClearForm(int score)
        {
            InitializeComponent();
            finalScore = score;
            this.FormClosing += ShinobiShiftClear_FormClosing;
        }

        private void ShinobiLeapClear_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);
            ClearRecord.Text = $"Score：{finalScore}";
            ClearBGM.URL = @"BGM\ClearTheme1.mp3";//何の曲を流すか
            ClearBGM.settings.setMode("loop", false); // 1回しか流さない
            ClearBGM.settings.volume = 1;//音量
            Player.Image = new Bitmap(Path.Combine(Application.StartupPath, "Images", "ninja.png"));
            Player.BackColor = Color.Transparent; // 透明に設定
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearClickSE1.URL = @"SE\ShinobiLeapClickSE1.mp3";//何のSEを流すか
            ClearClickSE1.settings.setMode("loop", false); // 1回だけ流す
            ClearClickSE1.settings.volume = 1;//音量

            PlayForm InActionForm = new PlayForm();
            // 新しいフォームを表示
            InActionForm.Show();
            // 現在のフォームを閉じる
            this.Hide();
            ClearBGM.Ctlcontrols.stop();// BGMを止める
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearClickSE1.URL = @"SE\ShinobiLeapClickSE1.mp3";//何のSEを流すか
            ClearClickSE1.settings.setMode("loop", false); // 1回だけ流す
            ClearClickSE1.settings.volume = 1;//音量

            // 新しいフォームを作成
            StartForm StartForm = new StartForm();
            // 新しいフォームを表示
            StartForm.Show();
            // 現在のフォームを閉じる
            this.Hide();
            ClearBGM.Ctlcontrols.stop();// BGMを止める
        }

        public void ShinobiShiftClear_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 終了を実行
        }
    }
}