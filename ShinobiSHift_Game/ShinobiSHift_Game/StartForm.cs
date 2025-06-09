using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinobiLeap_Game
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.FormClosing += ShinobiShiftBooting_FormClosing;
        }

        public static int playerX = 158;
        public static int groundY = 272;
        public static int ceilingY = 0;

        private void StartForm_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            RuleForm RuleForm = new RuleForm();

            // 新しいフォームを表示
            RuleForm.Show();

            // 現在のフォームを閉じる
            this.Hide();
        }

        public void ShinobiShiftBooting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 終了を実行
        }
    }
}
