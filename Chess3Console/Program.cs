using System;

namespace Chess3Console
{
    class Program
    {
        static void Main()
        {
            bool state;
            ChessFigures[] figures = new ChessFigures[5];

            figures[0] = new King(4, 4);
            figures[1] = new Queen(1, 1);
            figures[2] = new Bishop(4, 4);
            figures[3] = new Knight(1, 1);
            figures[4] = new Rook(4, 4);

            foreach (var figure in figures)
            {
                state = figure.Move(5, 5);
                Console.WriteLine(state ? "YES" : "NO");
            }
        }
    }

    class ChessFigures
    {
        public int x1;
        public int y1;

        public ChessFigures(int newX, int newY)
        {
            x1 = newX;
            y1 = newY;
        }

        public virtual bool Move(int newX, int newY)
        {
            return false;
        }
    }

    class King : ChessFigures
    {
        public King(int x1, int y1) : base(x1, y1)
        {

        }

        public override bool Move(int newX, int newY)
        {
            if (Math.Abs(x1 - newX) <= 1 && Math.Abs(y1 - newY) <= 1)
            {
                x1 = newX;
                y1 = newY;
                return true;
            }
            else
                return false;
        }
    }

    class Queen : ChessFigures
    {
        public Queen(int x1, int y1) : base(x1, y1)
        {

        }

        public override bool Move(int newX, int newY)
        {
            if (x1 == newX || y1 == newY ||
                     Math.Abs(x1 - newX) == Math.Abs(y1 - newY))
            {
                x1 = newX;
                y1 = newY;
                return true;
            }
            else
                return false;
        }
    }

    class Bishop : ChessFigures
    {
        public Bishop(int x1, int y1) : base(x1, y1)
        {

        }

        public override bool Move(int newX, int newY)
        {
            if (Math.Abs(x1 - newX) == Math.Abs(y1 - newY))
            {
                x1 = newX;
                y1 = newY;
                return true;
            }
            else
                return false;
        }
    }

    class Knight : ChessFigures
    {
        public Knight(int x1, int y1) : base(x1, y1)
        {

        }

        public override bool Move(int newX, int newY)
        {
            if ((Math.Abs(x1 - newX) == 2 && Math.Abs(y1 - newY) == 1) ||
                    (Math.Abs(x1 - newX) == 1 && Math.Abs(y1 - newY) == 2))
            {
                x1 = newX;
                y1 = newY;
                return true;
            }
            else
                return false;
        }
    }

    class Rook : ChessFigures
    {
        public Rook(int x1, int y1) : base(x1, y1)
        {

        }

        public override bool Move(int newX, int newY)
        {
            if (x1 == newX || y1 == newY)
            {
                x1 = newX;
                y1 = newY;
                return true;
            }
            else
                return false;
        }
    }
}