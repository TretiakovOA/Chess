using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Model
{
    public class ChessRoque: ChessMove
    {
        public ChessField KingResultField { get; private set; }
        public bool IsLongRoque { get; private set; }
    }
}
