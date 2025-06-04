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
    public partial class ShinobiShiftInAction : Form
    {
        private bool isOnCeiling = false;

        public ShinobiShiftInAction()
        {
            InitializeComponent();
        }

        private void shift(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.ShiftKey)
            {

                isOnCeiling = !isOnCeiling;

                if (isOnCeiling)
                {
                    Player.Location = new Point(playerX, ceilingY);
                    Player.Size = new Size(49, 62);
                }
                else
                {
                    Player.Location = new Point(playerX, groundY);
                    Player.Size = new Size(49, 62);
                }
            }
        }
    }
}
