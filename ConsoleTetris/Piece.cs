namespace ConsoleTetris
{
    internal class Piece : Grid
    {
        public Piece(int size) : base(size, size)
        {
        }

        public Piece(int size, ConsoleColor color, params int[] indexes)
        : this(size)
        {
            foreach (var index in indexes)
            {
                SetColor(color, index);
            }
        }

    }
}
