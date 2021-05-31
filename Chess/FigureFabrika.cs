using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessLibrary;

namespace Chess
{
    class FigureFabrika
    {

    }

    class PieceMaker
    {
        static public ChessFigures Make(string pieceCode, int x, int y)
        {
            ChessFigures piece = null;

            switch (pieceCode)
            {
                case "King":
                case "1":
                case "K":
                    piece = new King(x, y);
                    break;

                case "Queen":
                case "2":
                case "Q":
                    piece = new Queen(x, y);
                    break;

                case "Bishop":
                case "3":
                case "B":
                    piece = new Bishop(x, y);
                    break;

                case "Knight":
                case "4":
                case "N":
                    piece = new Knight(x, y);
                    break;

                case "Rook":
                case "5":
                case "R":
                    piece = new Rook(x, y);
                    break;

                case "Pawn":
                case "6":
                case "P":
                    piece = new Pawn(x, y);
                    break;

                default: throw (new Exception("Unknown piece code."));
            }

            return piece;
        }

        static public ChessFigures Make(int pieceCode, int x, int y)
        {
            return Make(pieceCode.ToString(), x, y);
        }
    }
}
