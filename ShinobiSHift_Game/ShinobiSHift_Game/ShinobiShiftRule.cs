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
            this.KeyDown += ShinobiShift_KeyDown;
        }

        private void ShinobiShiftRule_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);
        }

        private void ShinobiShift_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift) // Shiftキーが押されたら
            {
                // 新しいフォームを作成
                ShinobiShiftInAction InactionForm = new ShinobiShiftInAction();

                // 新しいフォームを作成
                InactionForm.Show();

                // 現在のフォームを閉じる
                this.Hide();
            }
        }
    }
}

