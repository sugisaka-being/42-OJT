using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ShinobiLeap_Game.PlayForm;

namespace ShinobiLeap_Game
{
    public class Barrier
    {
        public PictureBox PictureBox { get; private set; }

        public Barrier(int x, int y, int width, int height, Control parent)
        {
            PictureBox = new PictureBox
            {
                Location = new Point(x, y),
                Size = new Size(width, height),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = ImageCache.BarrierImage,
                BackColor = Color.Transparent
            };
            parent.Controls.Add(PictureBox);
        }
    }
}
