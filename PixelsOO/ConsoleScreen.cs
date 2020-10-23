using System;
using System.Collections.Generic;
using System.Text;

namespace PixelsOO
{
    class ConsoleScreen
    {
        private Sprite[] _sprites;

        public ConsoleScreen(Sprite[] sprites)
        {
            _sprites = sprites;
        }

        public void Show()
        {
            Console.Clear();
            foreach (var sprite in _sprites)
            {
                sprite.Show();
            }
            Console.CursorTop = 20;
        }
    }
}
