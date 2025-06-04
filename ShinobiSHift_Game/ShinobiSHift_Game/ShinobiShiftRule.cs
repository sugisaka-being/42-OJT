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
    public partial class ShinobiShiftRule : Form
    {
        public ShinobiShiftRule()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += ShinobiShiftRule_KeyDown;

            timer1 = new Timer();
            timer1.Interval = 1000; // 1秒ごと
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //下のコードはタイマーの動作確認
            Console.WriteLine("タイマー動作中: " + DateTime.Now);
        }

        private void ShinobiShiftRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey && !timer1.Enabled)
            {
                timer1.Start();
            }
        }

        private void ShinobiShiftRule_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);
        }
    }
}
