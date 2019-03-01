using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    public class ChessMove
    {
        public Color Color { get; private set; }
        public int MoveNumber { get; private set; }
        public ChessFigure MovingFigure { get; private set; }
        public ChessFigure KilledFigure { get; private set; } = null;
        public ChessField InitialField { get; private set; }
        public ChessField ResultField { get; private set; }
        public bool IsRoque { get; private set; }
        public bool IsFinal { get; private set; }

    }
}
