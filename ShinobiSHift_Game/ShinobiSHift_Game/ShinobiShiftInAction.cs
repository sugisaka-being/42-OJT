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


namespace ShinobiSHift_Game
{
    public partial class ShinobiShiftInAction : Form
    {
        private int score = 0;

        public ShinobiShiftInAction()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Interval = 10; // 1秒ごと変更可能
            timer1.Tick += Timer1_Tick;

            // フォームのロード時にタイマーを開始
            this.Load += ShinobiShiftInAction_Load;
        }

        private void ShinobiShiftInAction_Load(object sender, EventArgs e)
        {
            timer1.Start(); // フォーム表示と同時にタイマー開始
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            score += 5; // 1回ごとに5点加算 → 1秒で500点

            ScoreRecord.Text = score.ToString();
        }
    }
}
