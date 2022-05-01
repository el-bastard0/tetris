using CommandLine;

namespace ElBastard0.Tetris.Options
{
    internal class CliOptions
    {
        private int? _startPopulation;

        [Option('w', "width", Default = 30, HelpText = "Game field width")]
        public int Width { get; set; }

        [Option('h', "height", Default = 43, HelpText = "Game field height")]
        public int Height { get; set; }

        [Option('r', "refresh", Default = 100, HelpText = "Refresh cycle in ms")]
        public int Refresh { get; set; }
    }
}
