using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinobiSHift_Game
{
    public partial class ShinobiShiftInAction : Form
    {
        private bool isOnCeiling = false;

        private int playerX = 158;
        private int groundY = 272;
        private int ceilingY = 0;

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
                    Player.Location = new Point(this.playerX, ceilingY);
                }
                else
                {
                    Player.Location = new Point(this.playerX, groundY);                    
                }
            }
        }
    }
}
