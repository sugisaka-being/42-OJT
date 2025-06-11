using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ShinobiSHift_Game
{
    public class ParallaxLayer
    {
        private Bitmap image;
        private int x;
        private int speed;

        public ParallaxLayer(string imagePath, int scrollSpeed)
        {
            image = new Bitmap(imagePath);
            speed = scrollSpeed;
            x = 0;
        }

        public void Update()//位置を更新するメソッド
        {
            int margin = 500;
            x -= speed;
            if (x <= -image.Width - margin)
            {
                x += image.Width;
            }
        }

        public void Draw(Graphics g, int canvasHeight, int canvasWidth)//描画メソッド
        {
            int y = canvasHeight - image.Height;

            for (int i = 0; i < 3; i++) //3枚描画
            {
                g.DrawImage(image, x + i * image.Width, y);
            }
        }
        public void Dispose() => image.Dispose();
    }

}
