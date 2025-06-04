using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinobiSHift_Game
{
    public class Obstacle
    {
        public PictureBox PictureBox { get; private set; }

        public Obstacle(int x, int y, int width, int height, Control parent)
        {
            PictureBox = new PictureBox
            {
                Location = new Point(x, y),
                Size = new Size(width, height),
                BackColor = Color.White
            };
            parent.Controls.Add(PictureBox);
        }
    }
}
