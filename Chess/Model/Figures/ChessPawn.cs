namespace Chess.Model
{
    public class ChessPawn : ChessFigure
    {
        public ChessPawn(Color color, ChessBoard board, char position) : base(color)
        {
            CurrentField = color == Color.WHITE ? 
                board.GetField(2, position) : 
                board.GetField(7, position);
        }

        public override void Move()
        {
            
        }

        public override char GetSymbol(Color color)
        {
            return color == Color.WHITE ? '\u2659' : '\u265f';
        }
    }
}
