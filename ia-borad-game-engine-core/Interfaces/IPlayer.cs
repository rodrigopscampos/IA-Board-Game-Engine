using IABoardGameEngine.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace IABoardGameEngine.Core.Interfaces
{
    public interface IPlayer
    {
        BoardMovement MakeMovement(BoardState boardState);
    }
}
