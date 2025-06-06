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
            this.FormClosing += ShinobiShiftInAction_FormClosing;
        }

        private void ShinobiShiftInAction_Load(object sender, EventArgs e)
        {
            timer1.Start(); // フォーム表示と同時にタイマー開始



            for (int i = 0; i < 3; i++)
            {
                barriers.Add(new Barrier(1100 + (i * 400), 0, 200, 100, this));
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
                timer1.Stop();
                ShinobiShiftGameOver gameOverForm = new ShinobiShiftGameOver(score);//スコアをGameOverフォームに渡してる
                gameOverForm.Show();
                this.Close();// 現在のフォームを隠すのか終了するのか迷う

            }

            if (score >= 20000)
            {
                timer1.Stop(); // タイマー停止
                this.Close();   // 現在のフォームを隠すのか終了するのか迷う

                ShinobiShiftClear clearForm = new ShinobiShiftClear();
                clearForm.Show();
            }
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

        public void ShinobiShiftInAction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // 一旦キャンセル

            // 終了確認用のフォームをモーダルで表示
            using (var confirm = new ExitForm())
            {
                if (confirm.ShowDialog() == DialogResult.OK)
                {
                    Application.Exit(); // 終了を実行
                }
            }
        }


        /*  private void ShinobiShiftInAction_Load(object sender, EventArgs e)
          {
              //障害物を生成してフィールドに格納
              var obstacle = new Obstacle(1100, 0, 100, 100, this);

          }*/
    }
}










