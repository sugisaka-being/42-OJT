using System;
using System.Drawing;
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
            ClearRecord.Text = $"Score；{finalScore}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayForm InActionForm = new PlayForm();
            // 新しいフォームを表示
            InActionForm.Show();
            // 現在のフォームを閉じる
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            StartForm StartForm = new StartForm();
            // 新しいフォームを表示
            StartForm.Show();
            // 現在のフォームを閉じる
            this.Hide();
        }

        public void ShinobiShiftClear_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 終了を実行
        }
    }
}