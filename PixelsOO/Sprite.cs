using System;
using System.Collections.Generic;
using System.Text;

namespace PixelsOO
{
    class Sprite
    {
        private Pixel[] _pixels;

        public Sprite(Pixel[] pixels)
        {
            _pixels = pixels;
        }

        public void Show()
        {
            foreach (var pixel in _pixels)
            {
                pixel.Show();
            }
        }

        public void Flip()
        {
            foreach (var pixel in _pixels)
            {
                pixel.Flip();
            }
        }

        public void Move(int dx, int dy)
        {
            foreach (var pixel in _pixels)
            {
                pixel.Move(dx, dy);
            }
        }
    }
}
