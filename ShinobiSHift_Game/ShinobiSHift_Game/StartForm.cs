using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShinobiSHift_Game;

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
            StartBGM.URL = @"BGM\StartTheme1.mp3";//何の曲を流すか
            StartBGM.settings.setMode("loop", true); // ループ再生
            StartBGM.settings.volume = 1;//音量
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartClickSE1.URL = @"SE\ShinobiLeapClickSE1.mp3";//何のSEを流すか
            StartClickSE1.settings.setMode("loop", false); // 1回だけ流す
            StartClickSE1.settings.volume = 1;//音量

            // BGMを止める
            StartBGM.Ctlcontrols.stop();

            // 新しいフォームを作成
            SelectForm selectForm = new SelectForm();

            // 新しいフォームを表示
            selectForm.Show();

            // 現在のフォームを閉じる
            this.Hide();
        }
        
    

        public void ShinobiShiftBooting_FormClosing(object sender, FormClosingEventArgs e)
        {
             Application.Exit(); // 終了を実行
        }
    }
}