using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card

{
    public class Deck
    {
        
        private List<CombatCard> combatCards;

        private List<SpecialCard> specialCards;

        public List<CombatCard> CombatCards { get => combatCards; set => combatCards = value; }
        public List<SpecialCard> SpecialCards { get => specialCards; set => specialCards = value; }

        public void AddCombatCard(CombatCard combatCard)
        {
            throw new NotImplementedException();
        }

        public void AddSpecialCard(SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
               public void DestroyCombatCard(int cardId)
        {
            throw new NotImplementedException();
        }        public void DestroySpecialCard(int cardId)
        {
            throw new NotImplementedException();
        }        public void Shuffle()
        {
            throw new NotImplementedException();
        }

        public Deck(List<CombatCard> combatCards, List<SpecialCard> specialCards)
        {
            this.combatCards = combatCards;
            this.specialCards = specialCards;
        }
    }
}
