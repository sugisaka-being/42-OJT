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
    public partial class ShinobiShiftBooting : Form
    {
        public ShinobiShiftBooting()
        {
            InitializeComponent();
        }

        public static int playerX = 158;
        public static int groundY = 272;
        public static int ceilingY = 0;

        private void ShinobiShiftBooting_Load(object sender, EventArgs e)
        {
            Player.Location = new Point(playerX, groundY);
            Player.Size = new Size(49, 62);
        }
    }
}

