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
    public partial class ShinobiShiftClear : Form
    {
        public ShinobiShiftClear()
        {
            InitializeComponent();
            this.FormClosing += ShinobiShiftClear_FormClosing;
        }

        private void ShinobiShiftClear_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            ShinobiShiftInAction InActionForm = new ShinobiShiftInAction();

            // 新しいフォームを表示
            InActionForm.Show();

            // 現在のフォームを閉じる
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            ShinobiShiftBooting StartForm = new ShinobiShiftBooting();

            // 新しいフォームを表示
            StartForm.Show();

            // 現在のフォームを閉じる
            this.Close();
        }

        public void ShinobiShiftClear_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
