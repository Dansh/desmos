using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesmosApp
{
    class GraphGrid
    {

        private Bitmap bmp;
        private PictureBox pictureBox;
        private int zeroX;
        private int zeroY;

        public PictureBox PictureBox 
        {
            get
            {
                return pictureBox;
            }
        }

        public int ZeroX         
        {
            get
            {
                return zeroX;
            }
        }

        public int ZeroY
        {
            get
            {
                return zeroY;
            }
        }


        public GraphGrid(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            bmp = pictureBox.Image as Bitmap;            
            this.zeroX = pictureBox.Size.Width / 2;
            this.zeroY = pictureBox.Size.Height / 2;
        }

        
        public void Clean()
        {
            pictureBox.Image = Properties.Resources.white;
            bmp = pictureBox.Image as Bitmap;
        }

        public void DrawPixel(int x, int y, Color color)
        {
            x += zeroX;
            y += zeroY;
            if (y > 0 && y < pictureBox.Size.Height)
            {                
                bmp.SetPixel(x, pictureBox.Size.Height - y, color);
                if (x > 0)
                {
                    bmp.SetPixel(x - 1, pictureBox.Size.Height - y, color);
                }
                if (x < pictureBox.Size.Width - 1)
                {
                    bmp.SetPixel(x + 1, pictureBox.Size.Height - y, color);
                }
                if (y > 2) // if y = 1.1 the int value for the pixel is 1 and thats not good
                {
                    bmp.SetPixel(x, pictureBox.Size.Height - y + 1, color);
                }
                if (y < pictureBox.Size.Height - 1)
                {
                    bmp.SetPixel(x, pictureBox.Size.Height - y - 1, color);
                }
            }
            
            
        }

        public void DrawGrid()
        {
            Graphics g = Graphics.FromImage(bmp);

            for (int i = pictureBox.Size.Width / 10; i < pictureBox.Size.Width; i += pictureBox.Size.Width / 10)
            {
                for (int j = 0; j < pictureBox.Size.Height; j++)
                {
                    if (i == pictureBox.Size.Width / 2) // pixel in middle column
                    {
                        bmp.SetPixel(i + 1, j, Color.Black);
                        bmp.SetPixel(i - 1, j, Color.Black);
                        if (j % 50 == 0)
                        {
                            RectangleF rectf = new RectangleF(i + 5, j + 2, 90, 50);
                            g.DrawString((250 - j).ToString(), new Font("Tahoma", 8), Brushes.Black, rectf); // fix
                        }
                    }
                    bmp.SetPixel(i, j, Color.Black);
                }
            }

            for (int j = pictureBox.Size.Height / 10; j < pictureBox.Size.Height; j += pictureBox.Size.Height / 10)
            {
                for (int i = 0; i < pictureBox.Size.Width; i++)
                {
                    if (j == pictureBox.Size.Height / 2) // pixel in middle row
                    {
                        bmp.SetPixel(i, j + 1, Color.Black);
                        bmp.SetPixel(i, j - 1, Color.Black);
                        if (i % 50 == 0 && 250 - i != 0)
                        {
                            RectangleF rectf = new RectangleF(i + 2, j + 5, 90, 50);
                            g.DrawString((i - 250).ToString(), new Font("Tahoma", 8), Brushes.Black, rectf); // fix
                        }
                    }
                    bmp.SetPixel(i, j, Color.Black);
                }
            }
            g.Flush();
        }
    }
}
