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
    public partial class ClearForm : Form
    {
        public ClearForm()
        {
            InitializeComponent();
        }

        private void ShinobiLeapClear_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            PlayForm InActionForm = new PlayForm();

            // 新しいフォームを表示
            InActionForm.Show();

            // 現在のフォームを閉じる
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            StartForm StartForm = new StartForm();

            // 新しいフォームを表示
            StartForm.Show();

            // 現在のフォームを閉じる
            this.Hide();
        }
    }
}
