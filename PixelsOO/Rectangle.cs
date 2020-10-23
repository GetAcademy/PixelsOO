using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PixelsOO
{
    class Rectangle
    {
        public Sprite Sprite { get; }

        public Rectangle(int x, int y, int width, int height, ConsoleColor color)
        {
            var pixels = new Pixel[width * height];
            for (var i = 0; i < pixels.Length; i++)
            {
                var pX = x + i % width;
                var pY = y + i / width;
                pixels[i] = new Pixel(pX, pY, color);
            }
            Sprite = new Sprite(pixels);
        }

        public void Show()
        {
            Sprite.Show();
        }

        public void Move(int dx, int dy)
        {
            Sprite.Move(dx, dy);
        }

        public void Flip()
        {
            Sprite.Flip();
        }
    }
}
