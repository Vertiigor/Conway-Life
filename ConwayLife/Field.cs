using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConwayLife
{
    internal class Field
    {
        public Point[,] Points { get; private set; }
        private int cellSize;

        public int CellSize
        {
            get => cellSize; 

            set
            {
                if (value > 0) cellSize = value;
                else throw new ArgumentException("Cell size cannot be equal zero or less");
            }
        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public Field(int cellSize, int width, int height, int density)
        {
            this.cellSize = cellSize;

            this.Width = width / cellSize;
            this.Height = height / cellSize;

            this.Points = new Point[Width, Height];

            Random(density);
        }

        public void Update()
        {
            Point[,] newPoints = new Point[Width, Height];

            for (int x = 0; x < Width; x++)
            {
                for (var y = 0; y < Height; y++)
                {
                    newPoints[x, y] = new Point(x, y);
                }
            }

            for (int x = 0; x < Width; x++)
            {
                for (var y = 0; y < Height; y++)
                {
                    var count = CountNeighbors(Points[x, y]);
                    if (count == 3 && Points[x, y].State == Point.CellState.Dead)
                    {
                        newPoints[x, y].State = Point.CellState.Alive;
                    }
                    else if((count < 2 || count > 3) && Points[x, y].State == Point.CellState.Alive)
                    {
                        newPoints[x, y].State = Point.CellState.Dead;
                    }
                    else
                    {
                        newPoints[x, y] = Points[x, y];
                    }
                }
            }

            Points = newPoints;
        }

        private int CountNeighbors(Point point)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (var j = -1; j < 2; j++)
                {
                    int col = (point.X + i + Width) % Width;
                    int row = (point.Y + j + Height) % Height;

                    bool selfCheck = point.X == col && point.Y == row;

                    if (Points[col, row].State == Point.CellState.Alive && !selfCheck)
                        count++;
                }
            }

            return count;
        }

        public void Clear()
        {
            for(int x = 0; x < Width; x++)
            {
                for(var y = 0; y < Height; y++)
                {
                    Points[x, y].State = Point.CellState.Dead;
                }
            }
        }

        public void Random(int density)
        {
            Random rnd = new Random();

            for(int x = 0; x < Width; x++)
            {
                for(var y = 0; y < Height; y++)
                {
                    Points[x, y] = new Point(x, y);
                    
                    Points[x, y].State = rnd.Next(density) == 0 ? Point.CellState.Alive : Point.CellState.Dead;
                }
            }
        }
    }
}
