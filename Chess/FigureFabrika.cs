using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessLibrary;

namespace Chess
{
    class PieceMaker
    {
        static public ChessFigures Make(string _name, int x, int y)
        {
            ChessFigures figures = null;
            switch (_name.Replace("White_", "").Remove(_name.Length - 2))
            {
                case "King":
                    figures = new King(x, y);
                    //figures.Move();
                    break;
                case "Queen":
                    figures = new Queen(x, y);
                    break;
                case "Bishop":
                    figures = new Bishop(x, y);
                    break;
                case "Knight":
                    figures = new Knight(x, y);
                    break;
                case "Rook":
                    figures = new Rook(x, y);
                    break;
                case "Pawn":
                    figures = new Pawn(x, y);
                    break;


                default: throw (new Exception("Unknown piece code."));
            }

            return figures;
        }

        static public ChessFigures Make(int pieceCode, int x, int y)
        {
            return Make(pieceCode.ToString(), x, y);
        }
    }
}
