using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ShinobiSHift_Game.ShinobiShiftBooting;

namespace ShinobiSHift_Game
{
    public partial class ShinobiShiftInAction : Form
    {
        private int score = 0;
        private bool isOnCeiling = false;
        private PictureBox barrier;//【テスト用　不要なら削除OK】障害物の生成用変数(Playerの上の赤い四角)
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes

        public ShinobiShiftInAction()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Interval = 10; // 1秒ごと変更可能
            timer1.Tick += Timer1_Tick;

            // フォームのロード時にタイマーを開始
            this.Load += ShinobiShiftInAction_Load;

            this.KeyPreview = true;
        }

        private void ShinobiShiftInAction_Load(object sender, EventArgs e)
        {
            timer1.Start(); // フォーム表示と同時にタイマー開始
<<<<<<< Updated upstream
            Addbarrier(); //【テスト用　不要なら削除OK】障害物の生成呼び出し(Playerの上の赤い四角)
=======
>>>>>>> Stashed changes
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            score += 5; // 1回ごとに5点加算 → 1秒で500点

            ScoreRecord.Text = score.ToString();
<<<<<<< Updated upstream

            if (Player.Bounds.IntersectsWith(barrier.Bounds))//【消さない方がいい】Playerと障害物の衝突判定
            {
                timer1.Stop();
                ShinobiShiftGameOver gameOverForm = new ShinobiShiftGameOver(score);//スコアをGameOverフォームに渡してる
                gameOverForm.Show();
                this.Hide();

            }
=======
>>>>>>> Stashed changes
        }

        private void shift(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {

                isOnCeiling = !isOnCeiling;

                if (isOnCeiling)
                {
                    Player.Location = new Point(playerX, ceilingY);
                    Player.Size = new Size(49, 62);
                }
                else
                {
                    Player.Location = new Point(playerX, groundY);
                    Player.Size = new Size(49, 62);
                }
            }
        }
<<<<<<< Updated upstream

        private void Addbarrier()//【テスト用　不要なら削除OK】障害物の生成メソッド(Playerの上の赤い四角)
        {

            barrier = new PictureBox();
            barrier.Size = new Size(50, 50);
            barrier.Location = new Point(playerX, 0);
            barrier.BackColor = Color.Red;
            this.Controls.Add(barrier);
        }
=======
>>>>>>> Stashed changes
    }
}
