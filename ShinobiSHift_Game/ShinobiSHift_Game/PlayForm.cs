using ShinobiSHift_Game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static ShinobiLeap_Game.StartForm;

namespace ShinobiLeap_Game
{
    public partial class PlayForm : Form
    {
        private int score = 0;
        private bool isOnCeiling = false;
        List<Barrier> barriers = new List<Barrier>();
        Barrier barrier;
        private Timer moveTimer;
        private Random rnd = new Random();
        private Bitmap background;
        private ParallaxLayer farLayer;
        private ParallaxLayer midLayer;

        public PlayForm()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 10; // 1秒ごと変更可能
            timer1.Tick += Timer1_Tick;
            this.KeyPreview = true;
            this.FormClosing += ShinobiShiftInAction_FormClosing;
            this.DoubleBuffered = true;
            // 画像読み込み
            background = new Bitmap(Path.Combine("back.png"));
            farLayer = new ParallaxLayer(Path.Combine("far.png"), 1);
            midLayer = new ParallaxLayer(Path.Combine("mid.png"), 3);

            this.Paint += PlayForm_Paint;
            this.FormClosed += PlayFormClosed;

        }

        private void PlayForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawImage(background, 0, 0, this.Width, background.Height);

            // パララックスレイヤーの描画
            farLayer.Draw(g, this.Height, Width);
            midLayer.Draw(g, this.Height - 50, Width);
        }

        private void PlayFormClosed(object sender, FormClosedEventArgs e)
        {
            background.Dispose();
            farLayer.Dispose();
            midLayer.Dispose();
        }
        private void ShinobiLeapInAction_Load(object sender, EventArgs e)
        {
            timer1.Start(); // フォーム表示と同時にタイマー開始
            moveTimer = new Timer();
            moveTimer.Interval = 30;
            moveTimer.Tick += CreateBarrier;
            moveTimer.Tick += MoveBarrier;
            moveTimer.Start();
        }

        private void CreateBarrier(object sender, EventArgs e)
        {
            if (barriers.Count == 0)
            {
                while (barriers.Count <= 10)
                {
                    int a = rnd.Next(2) == 0 ? 0 : 250;
                    barriers.Add(new Barrier(1600 + (barriers.Count * 400), a, 100, 100, this));
                }
            }
            else
            {
                while (barriers.Count <= 10)
                {
                    int a = rnd.Next(2) == 0 ? 0 : 250;
                    barriers.Add(new Barrier(400 + (barriers.Count * 400), a, 100, 100, this));
                }
            }
        }

        private void MoveBarrier(object sender, EventArgs e)
        {
            for (int i = barriers.Count - 1; i >= 0; i--)
            {
                var b = barriers[i];
                if (b.PictureBox == null) continue; // PictureBoxがnullの場合はスキップ

                b.PictureBox.Left -= 30;//ここで速さを変更

                if (b.PictureBox.Right < 0)
                {
                    this.Controls.Remove(barriers[i].PictureBox);
                    barriers.RemoveAt(i);//リストから障害物を削除
                }
            }
        }
        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            score += 8; // 1回ごとに8点加算 → 1秒で800点
            ScoreRecord.Text = score.ToString();

            if (barriers.Any(x => Player.Bounds.IntersectsWith(x.PictureBox.Bounds)))//【消さない方がいい】Playerと障害物の衝突判定
            {
                allTimerStop();
                int score = int.Parse(ScoreRecord.Text);
                GameOverForm gameOverForm = new GameOverForm(score);//スコアをGameOverフォームに渡してる
                gameOverForm.Show();
                this.Hide();
            }

            if (score >= 20000)
            {
                allTimerStop();
                int score = int.Parse(ScoreRecord.Text);
                this.Hide();   // 現在のフォームを隠す
                ClearForm clearForm = new ClearForm(score);
                clearForm.Show();
            }

            //背景の位置を更新
            farLayer.Update();
            midLayer.Update();
            Invalidate(); // 再描画
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

        public void ShinobiShiftInAction_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 終了を実行
        }
    }
}