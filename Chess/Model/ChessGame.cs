namespace Chess.Model
{
    public class ChessGame
    {
        public ChessBoard Board { get; private set; }
        public ChessPlayer WhitePlayer { get; private set; }
        public ChessPlayer BlackPlayer { get; private set; }
        public int CurrentMoveNumber { get; private set; }
        public Result Result { get; private set; }

        public ChessGame()
        {
            Board = new ChessBoard();
            WhitePlayer = new ChessPlayer(Color.WHITE, Board);
            BlackPlayer = new ChessPlayer(Color.BLACK, Board);
            Result = Result.UNFINISHED;
            CurrentMoveNumber = 1;
        }
    }
}
