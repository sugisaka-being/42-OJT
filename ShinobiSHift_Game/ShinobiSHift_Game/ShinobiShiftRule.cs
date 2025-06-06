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
            if (e.Shift) // Shiftキーが押されたら
            {
                // 新しいフォームを作成
                ShinobiShiftInAction InactionForm = new ShinobiShiftInAction();

                // 新しいフォームを作成
                InactionForm.Show();

                isInternalNavigation = true; // ← 遷移中フラグ
                // 現在のフォームを閉じる（hideだと隠れているだけでApplication.Run()をコーディングしているBootingを閉じないとアプリケーションは終了しない）
                this.Close();
            }
        }

        public void ShinobiShiftRule_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isInternalNavigation && e.CloseReason == CloseReason.UserClosing)
            {
                //e.Cancel = true; // 一旦キャンセル

                // 終了確認用のフォームをモーダルで表示
                using (var confirm = new ExitForm())
                {
                    if (confirm.ShowDialog() == DialogResult.OK)
                    {
                        Application.Exit(); // 終了を実行
                    }
                }
            }
        }
    }
}

