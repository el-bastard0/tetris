using CommandLine;
using ElBastard0.Tetris.Models;
using ElBastard0.Tetris.Options;
using System.Text;

namespace ElBastard0.Tetris
{
    internal static class Program
    {
        static Program()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<CliOptions>(args)
                .WithParsed(o =>
                {
                    RunGame(o.Width, o.Height, o.Refresh);
                });
        }

        private static void RunGame(int width, int height, int refresh)
        {
            IGame<bool> game = new Game(width: width, heigth: height);
            game.PrintGameField();
        }
    }
}