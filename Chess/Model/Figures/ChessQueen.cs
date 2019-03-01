namespace Chess.Model
{
    public class ChessQueen : ChessFigure
    {
        public ChessQueen(Color color, ChessBoard board) : base(color)
        {
            CurrentField = color == Color.WHITE ? 
                board.GetField(1, 'D') : 
                board.GetField(8, 'D');
        }

        public override void Move()
        {
            
        }

        public override char GetSymbol(Color color)
        {
            return color == Color.WHITE ? '\u2655' : '\u265b';
        }
    }
}
