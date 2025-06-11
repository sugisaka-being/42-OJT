using System;
using System.Drawing;
using System.Windows.Forms;
using static ShinobiLeap_Game.StartForm;

namespace ShinobiLeap_Game
{
    public partial class RuleForm : Form
    {
        public RuleForm()
        {
            InitializeComponent();
            this.KeyDown += ShinobiLeap_KeyDown;
            this.FormClosing += ShinobiShiftRule_FormClosing;
        }

        private void ShinobiLeapRule_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);
            RuleBGM.URL = @"BGM\RuleTheme1.mp3";//何の曲を流すか
            RuleBGM.settings.setMode("loop", true); // ループ再生
            RuleBGM.settings.volume = 1;//音量
        }

        private void ShinobiLeap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // Spaceキーが押されたら
            {
                RuleClickSE1.URL = @"SE\ShinobiLeapClickSE1.mp3";//何のSEを流すか
                RuleClickSE1.settings.setMode("loop", false); // 1回だけ流す
                RuleClickSE1.settings.volume = 1;//音量

                // BGMを止める
                RuleBGM.Ctlcontrols.stop();

                // 新しいフォームを作成
                PlayForm InactionForm = new PlayForm();

                // 新しいフォームを作成い
                InactionForm.Show();

                // 現在のフォームを閉じる（hideだと隠れているだけでApplication.Run()をコーディングしているBootingを閉じないとアプリケーションは終了しない）
                this.Hide();
            }
        }

        public void ShinobiShiftRule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 終了を実行
        }
    }
}