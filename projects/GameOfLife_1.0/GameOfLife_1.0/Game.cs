using System;
using System.Threading;

namespace GameOfLife_1._0
{
    class Game
    {
        private int _rows, _columns;
        private bool[,] _cells;
        public bool[,] Cells { get { return _cells; } }

        public Game(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;

            _cells = new bool[_rows, _columns];

            // init cells in a random way
            var random = new Random();
            for (int y = 0; y < _columns; y++)
            {
                for (int x = 0; x < _rows; x++) 
                {
                    _cells[x, y] = random.Next(1,5) > 2 ? true : false;
                }
            }
        }

        public void GotoNextGeneration()
        {
            var cellsSnapshot = GetCellsSnapshot();

            for (int y = 0; y < _columns; y++) 
            {
                for (int x = 0; x < _rows; x++)
                {
                    var neighborCount = GetNeighborCount(x, y, cellsSnapshot);
                    var isAlive = cellsSnapshot[x, y];

                    _cells[x, y] = GetWillLive(isAlive, neighborCount);
                }
            }
        }

        private bool[,] GetCellsSnapshot()
        {
            var result = new bool[_rows, _columns];

            for (int y = 0; y < _columns; y++) 
            {
                for (int x = 0; x < _rows; x++)
                {
                    result[x, y] = _cells[x, y];
                }
            }

            return result;
        }

        private int GetNeighborCount(int x, int y, bool[,] cells)
        {
            var result = 0;

            // (X-1, Y-1) ( X , Y-1) (X+1, Y-1)
            // (X-1,  Y ) ( X ,  Y ) (X+1,  Y )
            // (X-1, Y+1) ( X , Y+1) (X+1, Y+1)

            if ((x > 0 && y > 0) && cells[x - 1, y - 1]) result++;
            if ((y > 0) && cells[x, y - 1]) result++;
            if ((x < (_rows - 1) && y > 0) && cells[x + 1, y - 1]) result++;

            if ((x > 0) && cells[x - 1, y]) result++;
            if (x < (_rows - 1) && cells[x + 1, y] ) result++;

            if ((x > 0 && y < (_columns-1)) && cells[x - 1, y + 1]) result++;
            if ((y < (_columns - 1)) && cells[x, y + 1]) result++;
            if ((x < (_rows - 1) && y < (_columns-1)) && cells[x + 1, y + 1]) result++;

            return result;
        }

        private bool GetWillLive(bool isAlive, int neighborCount)
        {
            var result = false;

            // Any live cell with fewer than two live neighbours dies, as if caused by under-population.
            // Any live cell with two or three live neighbours lives on to the next generation.
            // Any live cell with more than three live neighbours dies, as if by over-population.
            // Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

            if (isAlive)
            {
                switch (neighborCount)
                {
                    case 0:
                    case 1:
                        result = false;
                        break;
                    case 2:
                    case 3:
                        result = true;
                        break;
                    default:
                        result = false;
                        break;
                }
            }
            else
            {
                if (neighborCount == 3)
                    result = true;
            }

            return result;
        }

       
    }
}
