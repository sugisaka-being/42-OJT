﻿using ShinobiSHift_Game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static ShinobiLeap_Game.StartForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ShinobiLeap_Game
{
    public partial class PlayForm : Form
    {
        private int score = 0;
        private bool isOnCeiling = false;
        List<Barrier> barriers = new List<Barrier>();
        private Timer moveTimer;
        private Random rnd = new Random();
        private Bitmap background;
        private Timer PlayerTimer;
        private Bitmap playerRun1;
        private Bitmap playerRun2;
        private Bitmap barriar;
        private ParallaxLayer farLayer;
        private ParallaxLayer midLayer;
        private bool isRun1 = true;

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
            background = new Bitmap(Path.Combine(Application.StartupPath, "Images", "back.png"));
            farLayer = new ParallaxLayer(Path.Combine(Application.StartupPath, "Images", "far.png"), 1);
            midLayer = new ParallaxLayer(Path.Combine(Application.StartupPath, "Images", "mid.png"), 3);
            playerRun1 = new Bitmap(Path.Combine(Application.StartupPath, "Images", "ninjarun1.png"));
            playerRun2 = new Bitmap(Path.Combine(Application.StartupPath, "Images", "ninjarun2.png"));
            Player.BackColor = Color.Transparent; // 透明に設定

            this.Paint += PlayForm_Paint;

        }

        public static class ImageCache
        {
            public static readonly Image BarrierImage = new Bitmap(Path.Combine(Application.StartupPath, "Images", "barriar.png"));
        }

        private void PlayForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // 動かない背景の描画（中央揃え）
            int bgY = this.ClientSize.Height - background.Height;
            g.DrawImage(background, 0, bgY, this.ClientSize.Width, background.Height);

            // パララックスレイヤーの描画（順序重要）
            farLayer.Draw(g, this.Height - 40, this.Width);
            midLayer.Draw(g, this.Height - 40, this.Width);
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
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
            PlayerTimer = new Timer();
            PlayerTimer.Interval = 80;
            PlayerTimer.Tick += AnimatePlayer;
            PlayerTimer.Start();
            moveTimer.Start();
            PlayBGM.URL = @"BGM\PlayTheme1.mp3";//何の曲を流すか
            PlayBGM.settings.setMode("loop", true); // ループ再生
            PlayBGM.settings.volume = 1;//音量
        }

        private void AnimatePlayer(object sender, EventArgs e)
        {
            Image currentFrame = isRun1 ? playerRun1 : playerRun2;

            Player.Image = isOnCeiling ? GetFlippedImage(currentFrame) : currentFrame;

            isRun1 = !isRun1;

        }

        private Image GetFlippedImage(Image img)
        {
            Image flipped = (Image)img.Clone();
            flipped.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return flipped;
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
                PlayBGM.Ctlcontrols.stop();// BGMを止める
            }

            if (score >= 20000)
            {
                allTimerStop();
                int score = int.Parse(ScoreRecord.Text);
                this.Hide();   // 現在のフォームを隠す
                ClearForm clearForm = new ClearForm(score);
                clearForm.Show();
                PlayBGM.Ctlcontrols.stop();// BGMを止める
            }

            //背景の位置を更新
            farLayer.Update();
            midLayer.Update();
            Invalidate(); // 再描画
        }

        private void space(object sender, KeyEventArgs e)
        {
            PlayMotionSE1.URL = @"SE\PlayMotionSE1.mp3";//何のSEを流すか
            PlayMotionSE1.settings.setMode("loop", false); // 1回だけ流す
            PlayMotionSE1.settings.volume = 10;//音量

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

            PlayerTimer.Stop();
            PlayerTimer.Dispose();
            PlayerTimer = null;
        }

        public void ShinobiShiftInAction_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 終了を実行
        }
    }
}