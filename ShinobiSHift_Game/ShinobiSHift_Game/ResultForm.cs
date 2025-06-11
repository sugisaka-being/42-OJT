using ShinobiLeap_Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ShinobiLeap_Game.StartForm;

namespace ShinobiSHift_Game
{
    public partial class ResultForm : Form
    {
        int finalScore;
        public ResultForm(int score)
        {
            InitializeComponent();
            finalScore = score;//スコアをプレイ画面から受け取ってる
            this.FormClosing += Result_FormClosing;
            this.Load += ResultForm_Load;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);

            ResultRecord2.Text = $"Score: {finalScore}";
           
         }

        private void button2_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            EndlessForm endlessForm = new EndlessForm();

            // 新しいフォームを表示

            endlessForm.Show();

            // 現在のフォームを閉じる// 現在のフォームを隠すのか終了するのか迷う
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            StartForm StartForm = new StartForm();

            // 新しいフォームを表示
            StartForm.Show();

            // 現在のフォームを閉じる// 現在のフォームを隠すのか終了するのか迷う
            this.Hide();
        }
        public void Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 終了を実行
        }
    }
}