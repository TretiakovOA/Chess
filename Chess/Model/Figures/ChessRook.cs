namespace Chess.Model
{
    public class ChessRook : ChessFigure
    {
        public ChessRook(Color color, ChessBoard board, bool isFirst) : base(color)
        {
            if (color == Color.WHITE)
            {
                CurrentField = isFirst ?
                    board.GetField(1, 'A') : 
                    board.GetField(1, 'H');
            }
            else
            {
                CurrentField = isFirst ?
                    board.GetField(8, 'A') : 
                    board.GetField(8, 'H');
            }
        }

        public override void Move()
        {
            
        }

        public override char GetSymbol(Color color)
        {
            return color == Color.WHITE ? '\u2656' : '\u265c';
        }
    }
}
