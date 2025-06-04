using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ShinobiSHift_Game.ShinobiShiftBooting;



namespace ShinobiSHift_Game
{
    public partial class ShinobiShiftInAction : Form
    {
        /* Obstacle obstacle;
         public ShinobiShiftInAction()
         {
             InitializeComponent();
             this.Load += ShinobiShiftInAction_Load;*/

        private int score = 0;
        private bool isOnCeiling = false;

        Obstacle obstacle;
        public ShinobiShiftInAction()
        {
            InitializeComponent();
            this.Load += ShinobiShiftInAction_Load;
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
                            //障害物を生成してフィールドに格納
            var obstacle = new Obstacle(1100, 0, 100, 100, this);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            score += 5; // 1回ごとに5点加算 → 1秒で500点

            ScoreRecord.Text = score.ToString();

            if (score >= 20000)
            {
                timer1.Stop(); // タイマー停止（必須）
                this.Hide();   // 現在のフォームを隠す

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

      /*  private void ShinobiShiftInAction_Load(object sender, EventArgs e)
        {
            //障害物を生成してフィールドに格納
            var obstacle = new Obstacle(1100, 0, 100, 100, this);

        }*/
    }

}


    
      


       



