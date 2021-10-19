using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_14_21
{
    class GameEngine
    {
        public int CurrentGeneration { get; private set; }
        public bool[,] Field { get; private set; }
        public int Rows { get; private set; }
        public int Colums { get; private set; }

        public GameEngine(int rows, int colums, int density)
        {
            Rows = rows;
            Colums = colums;
            Field = new bool[Colums, Rows];

            Random random = new Random();
            for (int x = 0; x < colums; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    Field[x, y] = random.Next((int)density) == 0;
                }
            }
        }
        public void NextGeneration()
        {
            
            var newField = new bool[Colums, Rows];

            for (int x = 0; x < Colums; x++)
            {
                for (int y = 0; y < Rows; y++)
                {
                    var neighboursCount = CountNeighbours(x, y);
                    var hasLife = Field[x, y];
                    if (!hasLife && neighboursCount == 3)
                    {
                        newField[x, y] = true;
                    }
                    else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
                    {
                        newField[x, y] = false;
                    }
                    else
                    {
                        newField[x, y] = Field[x, y];
                    }
                }
            }
            Field = newField;

            CurrentGeneration++;

        }
        private int CountNeighbours(int x, int y)
        {
            int count = 0;
            for (int i = -1; i < 2; i++)
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + j + Colums) % Colums;
                    var row = (y + i + Rows) % Rows;

                    var isSelfCheking = col == x && row == y;
                    var hasLife = Field[col, row];
                    if (hasLife && !isSelfCheking)
                        count++;
                }

            return count;
        }
        public void SetCellState(int x, int y, bool state)
        {
            Field[x, y] = state;
        }
    }
}
