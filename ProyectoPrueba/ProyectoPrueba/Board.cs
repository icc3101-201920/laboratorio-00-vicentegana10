using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    public class Board
    {
        
        private List<CombatCard> meleeCards;
        private List<CombatCard> rangeCards;
        private List<CombatCard> longRangeCards;
        private SpecialCard specialMeleeCards;
        private SpecialCard specialRangeCards;
        private SpecialCard specialLongRangeCards;
        private List<SpecialCard> captainCards;
        private List<SpecialCard> weatherCards;

        public List<CombatCard> MeleeCards { get => meleeCards; set => meleeCards = value; }
        public List<CombatCard> RangeCards { get => rangeCards; set => rangeCards = value; }
        public List<CombatCard> LongRangeCards { get => longRangeCards; set => longRangeCards = value; }
        public SpecialCard SpecialMeleeCards { get => specialMeleeCards; set => specialMeleeCards = value; }
        public SpecialCard SpecialRangeCards { get => specialRangeCards; set => specialRangeCards = value; }
        public SpecialCard SpecialLongRangeCards { get => specialLongRangeCards; set => specialLongRangeCards = value; }
        public List<SpecialCard> CaptainCards { get => captainCards; set => captainCards = value; }
        public List<SpecialCard> WeatherCards { get => weatherCards; set => weatherCards = value; }

        public void AddComnatCard(int playerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddSpecialCard(int playerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
        public void DestroyCombatCards()
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialCards()
        {
            throw new NotImplementedException();
        }
        public int GetMeleeAttackPoints()
        {
            throw new NotImplementedException();
        }
        public int GetRangeAttackPoints()
        {
            throw new NotImplementedException();
        }
        public int GetLongRangeAttackPoints()
        {
            throw new NotImplementedException();
        }

        public Board(List<CombatCard> meleeCards, List<CombatCard> rangeCards, List<CombatCard> longRangeCards, SpecialCard specialMeleeCards, SpecialCard specialRangeCards, SpecialCard specialLongRangeCards, List<SpecialCard> captainCards, List<SpecialCard> weatherCards)
        {
            this.meleeCards = meleeCards;
            this.rangeCards = rangeCards;
            this.longRangeCards = longRangeCards;
            this.specialMeleeCards = specialMeleeCards;
            this.specialRangeCards = specialRangeCards;
            this.specialLongRangeCards = specialLongRangeCards;
            this.captainCards = captainCards;
            this.weatherCards = weatherCards;
        }
    }
}
