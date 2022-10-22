using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConwayLife
{
    internal class Point
    {
        public enum CellState
        {
            Alive,
            Dead
        }

        private int x, y;

        public int X 
        { 
            get => x; 

            set
            {
                if (value >= 0) x = value;
                else throw new ArgumentException("The X coorinate can't be less than zero");
            }
        }
        public int Y
        {
            get => y;

            set
            {
                if (value >= 0) y = value;
                else throw new ArgumentException("The Y coorinate can't be less than zero");
            }
        }

        public CellState State;

        public Point(int x, int y)
        {
            this.State = CellState.Dead;

            this.X = x;
            this.Y = y;
        }
    }
}
