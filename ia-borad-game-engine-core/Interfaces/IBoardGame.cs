using IABoardGameEngine.Core.ValueObjects;

namespace IABoardGameEngine.Core.Interfaces
{
    public interface IBoardGame
    {
        BoardMovementResult PerformMovement(BoardState state, BoardMovement movement);
        BoardGameResult EvaluateWinner(BoardState state);
        BoardState CreateNewBoard();
    }
}