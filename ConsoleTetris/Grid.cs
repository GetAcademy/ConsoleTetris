namespace ConsoleTetris
{
    internal class Grid
    {
        private readonly ConsoleColor?[] _cells;
        private readonly int _width;
        private readonly int _height;

        public Grid(int width, int height)
        {
            _height = height;
            _width = width;
            var cellCount = width * height;
            _cells = new ConsoleColor?[cellCount];
        }

        public void SetColor(ConsoleColor color, int index)
        {
            _cells[index] = color;
        }

    }
}
