using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public class Game
    {
       
        private Player players;
        private Board boardGame;
        private Player activePlayer;
        private bool endGame;

        public Player Players { get => players; set => players = value; }
        public Board BoardGame { get => boardGame; set => boardGame = value; }
        public Player ActivePlayer { get => activePlayer; set => activePlayer = value; }
        public bool EndGame { get => endGame; set => endGame = value; }

        public bool CheckIfEndGame()
        {
            throw new NotImplementedException();
        }
        public int GetWinner()
        {
            throw new NotImplementedException();
        }
        public void Play()
        {
            throw new NotImplementedException();
        }

        public Game(Player players, Board boardGame, Player activePlayer, bool endGame)
        {
            this.players = players;
            this.boardGame = boardGame;
            this.activePlayer = activePlayer;
            this.endGame = endGame;
        }
    }
}
