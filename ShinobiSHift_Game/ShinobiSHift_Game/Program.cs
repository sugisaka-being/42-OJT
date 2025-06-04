using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinobiSHift_Game
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
            Application.Run(new ShinobiShiftBooting());
          //  Application.Run(new ShinobiShiftRule());
            Application.Run(new ShinobiShiftInAction());
           // Application.Run(new ShinobiShiftGameOver());
           // Application.Run(new ShinobiShiftClear());



        }
    }
}
