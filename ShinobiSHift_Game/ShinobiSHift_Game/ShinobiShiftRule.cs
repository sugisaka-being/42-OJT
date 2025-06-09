using System;
using System.Drawing;
using System.Windows.Forms;
using static ShinobiSHift_Game.ShinobiShiftBooting;

namespace ShinobiSHift_Game
{
    public partial class ShinobiShiftRule : Form
    {
        private bool isInternalNavigation = false;

        public ShinobiShiftRule()
        {
            InitializeComponent();
            this.KeyDown += ShinobiShift_KeyDown;
            this.FormClosing += ShinobiShiftRule_FormClosing;
        }

        private void ShinobiShiftRule_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);
        }

        private void ShinobiShift_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // Shiftキーが押されたら
            {
                // 新しいフォームを作成
                ShinobiShiftInAction InactionForm = new ShinobiShiftInAction();

                // 新しいフォームを作成い
                InactionForm.Show();

                isInternalNavigation = true; // ← 遷移中フラグ
                // 現在のフォームを閉じる（hideだと隠れているだけでApplication.Run()をコーディングしているBootingを閉じないとアプリケーションは終了しない）
                this.Hide();
            }
        }

        public void ShinobiShiftRule_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 終了を実行
        }
    }
}