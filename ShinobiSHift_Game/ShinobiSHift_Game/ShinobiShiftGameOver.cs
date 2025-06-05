using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ShinobiSHift_Game.ShinobiShiftBooting;

namespace ShinobiSHift_Game
{
    public partial class ShinobiShiftGameOver : Form
    {
        int finalScore;

        public ShinobiShiftGameOver(int score)
        {
            InitializeComponent();
            finalScore = score;//スコアをプレイ画面から受け取ってる
        }

        private void ShinobiShiftGameOver_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            ShinobiShiftInAction InActionForm = new ShinobiShiftInAction();

            // 新しいフォームを表示
            InActionForm.Show();

            // 現在のフォームを閉じる
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            ShinobiShiftBooting StartForm = new ShinobiShiftBooting();

            // 新しいフォームを表示
            StartForm.Show();

            // 現在のフォームを閉じる
            this.Hide();
        }
    }
}
