namespace Chess.Model
{
    public class ChessKnight : ChessFigure
    {
        public ChessKnight(Color color, ChessBoard board, bool isFirst) : base(color)
        {
            if (color == Color.WHITE)
            {
                CurrentField = isFirst ?
                    board.GetField(1, 'B') : 
                    board.GetField(1, 'G');
            }
            else
            {
                CurrentField = isFirst ?
                    board.GetField(8, 'B') : 
                    board.GetField(8, 'G');
            }
        }

        public override void Move()
        {
            
        }

        public override char GetSymbol(Color color)
        {
            return color == Color.WHITE ? '\u2658' : '\u265e';
        }
    }
}
