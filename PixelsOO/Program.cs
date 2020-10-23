using System;
using System.Collections.Generic;

namespace PixelsOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Clear();

            var rectangle1 = new Rectangle(10, 4, 60, 7, ConsoleColor.DarkCyan);
            var rectangle2 = new Rectangle(14, 8, 60, 7, ConsoleColor.White);
            var rectangle3 = new Rectangle(18, 12, 60, 7, ConsoleColor.Green);

            var screen = new ConsoleScreen(new []
            {
                rectangle3.Sprite,
                rectangle2.Sprite,
                rectangle1.Sprite,
            });

            var start = DateTime.Now;
            screen.Show();
            var end = DateTime.Now;
            var spent = end - start;
            Console.WriteLine(spent);


            //rectangle1.Show();
            //rectangle2.Show();
            //rectangle3.Flip();
            //rectangle3.Show();

            //var sprite = new Sprite(
            //    new[]
            //    {
            //        new Pixel(5, 10, ConsoleColor.Blue),
            //        new Pixel(10, 5, ConsoleColor.Red),
            //    });

            //sprite.Show();
            //sprite.Move(20,0);
            //sprite.Show();

            //Console.CursorTop = 20;
        }
    }
}
