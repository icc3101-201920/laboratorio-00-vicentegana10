using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public class Player
    {
        private int lifePoints;
        private int attackPoints;
        private Deck deck;
        private Hand hand;
        private Board board;
        private SpecialCard captain;

        public int LifePoints { get => lifePoints; set => lifePoints = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public Deck Deck { get => deck; set => deck = value; }
        public Hand Hand { get => hand; set => hand = value; }
        public SpecialCard Captain { get => captain; set => captain = value; }


        public void DrawCard()
        {
            throw new NotImplementedException();
        }
        
        public void PlayCard(int cardId)
        {
            throw new NotImplementedException();
        }
        public void ChangeCard(int cardId)
        {
            throw new NotImplementedException();
        }
        public void FirstHand()
        {
            throw new NotImplementedException();
        }
        public void ChooseCaptainCard(SpecialCard captainCard)
        {
            throw new NotImplementedException();
        }

        public Player(int lifePoints, int attackPoints, Deck deck, Hand hand, Board board, SpecialCard captain)
        {
            this.lifePoints = lifePoints;
            this.attackPoints = attackPoints;
            this.deck = deck;
            this.hand = hand;
            this.board = board;
            this.captain = captain;
        }
    }

}
