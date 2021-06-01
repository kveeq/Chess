using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLibrary
{
    public class ChessFigures
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

    public class King : ChessFigures
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

    public class Queen : ChessFigures
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

    public class Bishop : ChessFigures
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

    public class Knight : ChessFigures
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

    public class Rook : ChessFigures
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


    public class Pawn : ChessFigures
    {
        public Pawn(int newX, int newY) : base(newX, newY)
        {

        }

        public override bool Move(int newX, int newY)
        {
            return ((x1 == newX && y1 == 2 && y1 + 2 >= newY) ||
                    (x1 == newX && y1 + 1 == newY));
        }

    }
}
