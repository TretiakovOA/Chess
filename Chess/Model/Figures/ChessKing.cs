namespace Chess.Model
{
    public class ChessKing : ChessFigure
    {
        public ChessKing(Color color, ChessBoard board) : base(color)
        {
            CurrentField = color == Color.WHITE ? 
                board.GetField(1, 'E') : 
                board.GetField(8, 'E');
        }

        public override void Move()
        {
            
        }

        public override char GetSymbol(Color color)
        {
            return color == Color.WHITE ? '\u2654' : '\u265a';
        }
    }
}
