using ShinobiLeap_Game;
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

namespace ShinobiSHift_Game  
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
            this.FormClosing += Select_FormClosing;
            this.Load += SelectForm_Load;
        }        

        public static int playerX = 158;
        public static int groundY = 272;
        public static int ceilingY = 0;

        private void SelectForm_Load(object sender, EventArgs e)
        {
            Player2.Location = new Point(playerX, groundY);
            Player2.Size = new Size(49, 62);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            EndlessRuleForm EndlessRuleForm = new EndlessRuleForm();

            // 新しいフォームを表示
            EndlessRuleForm.Show();

            // 現在のフォームを閉じる
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 新しいフォームを作成
            RuleForm RuleForm = new RuleForm();

            // 新しいフォームを表示
            RuleForm.Show();

            // 現在のフォームを閉じる
            this.Hide();
        }
        public void Select_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 終了を実行
        }


    }
}
