using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinobiLeap_Game
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //動作確認用           
            Application.Run(new StartForm());
           // Application.Run(new ShinobiLeapRule());
            //Application.Run(new ShinobiLeapInAction());
            //Application.Run(new ShinobiLeapGameOver());
            //Application.Run(new ShinobiLeapClear());

        }
    }
}
