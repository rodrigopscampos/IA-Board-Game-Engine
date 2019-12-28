using IABoardGameEngine.Core.Interfaces;
using System;

namespace IABoardGameEngine.Core
{
    public class BoardEngine : IBoardEngine
    {
        readonly IGameSettings _gameSettings;
        readonly IBoardGame _boardGame;
        readonly IPlayer _player1;
        readonly IPlayer _player2;

        public BoardEngine(
            IGameSettings gameSettings,
            IBoardGame boardGame,
            IPlayer player1,
            IPlayer player2)
        {
            _gameSettings = gameSettings;
            _boardGame = boardGame;
            _player1 = player1;
            _player2 = player2;
        }

        /// <summary>
        /// Runs the battle between the players
        /// </summary>
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
