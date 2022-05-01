namespace ElBastard0.Tetris.Models
{
    internal interface IGame<TField> : IDictionary<int, IList<TField>>
    {
        int Width { get; init; }
        int Height { get; init; }
        void Update(bool print = false);
        void PrintGameField();
    }
}
