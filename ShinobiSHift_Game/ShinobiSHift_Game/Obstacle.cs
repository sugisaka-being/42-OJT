using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinobiSHift_Game
{
    public class Obstacle
    {
        public PictureBox barrier { get; private set; }

        public PictureBox CreateObstacle(int x, int y, int width, int height, Control parent)
        {

            barrier = new PictureBox();
            barrier.Size = new Size(50, 50);
            barrier.Location = new Point(x, y);
            barrier.BackColor = Color.White;
            parent.Controls.Add(barrier);

            return barrier;
        }
    }
}
