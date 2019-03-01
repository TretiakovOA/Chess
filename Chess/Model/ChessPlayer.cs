using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    public class ChessPlayer
    {
        public ChessFigure[] Figures { get; private set; }
        public List<ChessMove> PreviousMoves { get; private set; }

        public ChessPlayer(Color color, ChessBoard board)
        {
            PreviousMoves = new List<ChessMove>();
            Figures = new ChessFigure[16];
            Figures[0] = new ChessKing(color, board);
            Figures[1] = new ChessQueen(color, board);
            Figures[2] = new ChessBishop(color, board, true);
            Figures[3] = new ChessBishop(color, board, false);
            Figures[4] = new ChessKnight(color, board, true);
            Figures[5] = new ChessKnight(color, board, false);
            Figures[6] = new ChessRook(color, board, true);
            Figures[7] = new ChessRook(color, board, false);
            Figures[8] = new ChessPawn(color, board, 'A');
            Figures[9] = new ChessPawn(color, board, 'B');
            Figures[10] = new ChessPawn(color, board, 'C');
            Figures[11] = new ChessPawn(color, board, 'D');
            Figures[12] = new ChessPawn(color, board, 'E');
            Figures[13] = new ChessPawn(color, board, 'F');
            Figures[14] = new ChessPawn(color, board, 'G');
            Figures[15] = new ChessPawn(color, board, 'H');
        }

        public void Move(ChessFigure figure, ChessField toField)
        {

        }
        public void FinishGame(bool toDraw)
        {

        }
    }
}
