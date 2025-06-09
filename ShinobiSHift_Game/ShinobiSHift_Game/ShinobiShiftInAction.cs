using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static ShinobiSHift_Game.ShinobiShiftBooting;

namespace ShinobiSHift_Game
{
    public partial class ShinobiShiftInAction : Form
    {
        private int score = 0;
        private bool isOnCeiling = false;
        List<Barrier> barriers = new List<Barrier>();
        Barrier barrier;
        private Timer moveTimer;

        public ShinobiShiftInAction()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 10; // 1秒ごと変更可能
            timer1.Tick += Timer1_Tick;
            this.KeyPreview = true;
        }

        private void ShinobiShiftInAction_Load(object sender, EventArgs e)
        {
            timer1.Start(); // フォーム表示と同時にタイマー開始
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int a = rnd.Next(2) == 0 ? 0 : 250;
                barriers.Add(new Barrier(1100 + (i * 400), a, 100, 100, this));
            }

            moveTimer = new Timer();
            moveTimer.Interval = 30;
            moveTimer.Tick += MoveBarrier;
            moveTimer.Start();
        }

        private void MoveBarrier(object sender, EventArgs e)
        {
            for (int i = barriers.Count - 1; i >= 0; i--)
            {
                var b = barriers[i];
                if (b.PictureBox == null) continue; // PictureBoxがnullの場合はスキップ

                b.PictureBox.Left -= 15;

                if (b.PictureBox.Right < 0)
                {
                    this.Controls.Remove(barriers[i].PictureBox);
                    barriers.RemoveAt(i);//リストから障害物を削除
                }
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            score += 5; // 1回ごとに5点加算 → 1秒で500点
            ScoreRecord.Text = score.ToString();

            if (barriers.Any(x => Player.Bounds.IntersectsWith(x.PictureBox.Bounds)))//【消さない方がいい】Playerと障害物の衝突判定
            {
                allTimerStop();
                ShinobiLeapGameOver gameOverForm = new ShinobiLeapGameOver(score);//スコアをGameOverフォームに渡してる
                gameOverForm.Show();
                this.Hide();
            }

            if (score >= 20000)
            {
                allTimerStop();
                this.Hide();   // 現在のフォームを隠す
                ShinobiShiftClear clearForm = new ShinobiShiftClear();
                clearForm.Show();
            }
        }

        private void space(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
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

        private void allTimerStop()//【消さない方がいい】タイマーを停止し、リソースを開放する
        {
            timer1.Stop();
            timer1.Dispose();
            timer1 = null;

            moveTimer.Stop();
            moveTimer.Dispose();
            moveTimer = null;
        }
    }
}










