namespace Chess.Model
{
    public class ChessBishop : ChessFigure
    {
        public ChessBishop(Color color, ChessBoard board, bool isFirst) : base(color)
        {
            if (color == Color.WHITE)
            {
                CurrentField = isFirst ?
                    board.GetField(1, 'C') : 
                    board.GetField(1, 'F');
            }
            else
            {
                CurrentField = isFirst ?
                    board.GetField(8, 'C') : 
                    board.GetField(8, 'F');
            }
        }

        public override void Move()
        {
            
        }

        public override char GetSymbol(Color color)
        {
            return color == Color.WHITE ? '\u2657' : '\u265d';
        }
    }
}
