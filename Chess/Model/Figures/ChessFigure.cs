using System.Collections.Generic;

namespace Chess.Model
{
    public abstract class ChessFigure
    {
        public Color Color { get; private set; }
        public ChessField CurrentField { get; set; }
        public List<ChessField> FieldsToMove { get; private set; }
        public List<ChessMove> PreviousMoves { get; private set; }
        public bool IsKilled { get; private set; }

        protected ChessFigure(Color color)
        {
            Color = color;
            FieldsToMove = new List<ChessField>();
            PreviousMoves = new List<ChessMove>();
            IsKilled = false;
        }

        public abstract void Move();
        public abstract char GetSymbol(Color color);
    }
}