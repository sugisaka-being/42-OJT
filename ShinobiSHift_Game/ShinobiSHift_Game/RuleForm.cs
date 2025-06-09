using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ShinobiLeap_Game.StartForm;

namespace ShinobiLeap_Game
{
    public partial class RuleForm : Form
    {
        public RuleForm()
        {
            InitializeComponent();
            this.KeyDown += ShinobiLeap_KeyDown;
            this.FormClosing += ShinobiShiftRule_FormClosing;
        }

        private void ShinobiLeapRule_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);
        }

        private void ShinobiLeap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) // Shiftキーが押されたら
            { 
                // 新しいフォームを作成
                PlayForm InactionForm = new PlayForm();

                // 新しいフォームを作成い
                InactionForm.Show();

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


