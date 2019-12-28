using IABoardGameEngine.Core.Interfaces;

namespace IABoardGameEngine.Core.ValueObjects
{
    public class BoardMovement
    {
        public IPlayer Player { get; }
        public BoardSquare From { get; }
        public BoardSquare To { get; }
    }
}