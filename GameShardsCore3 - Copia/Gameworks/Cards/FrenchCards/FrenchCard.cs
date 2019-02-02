using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Gameworks.Cards.FrenchCards;

namespace GameShardsCore3.Gameworks.Cards {

    public class FrenchCard : Card<FrenchSeed, FrenchValue, FrenchCategory> {

        public FrenchCard(FrenchSeed seed, FrenchValue value, bool Covered = false) {
            this.Seed = seed;
            this.Value = value;
            this.Covered = Covered;
        }

        public override FrenchCategory Category {
            get {
                switch (Value) {
                    case FrenchValue.Ace:
                        return FrenchCategory.Ace();
                    case var n when (n > FrenchValue.Two && n < FrenchValue.Ten):
                        return FrenchCategory.Number();
                    case var n when (n > FrenchValue.Jack && n < FrenchValue.King):
                        return FrenchCategory.Figure();
                    case FrenchValue.Joker:
                        return FrenchCategory.Joker();
                    default:
                        return null;
                }
            }
        }

        public override Card<FrenchSeed, FrenchValue, FrenchCategory> Cover() {
            return new FrenchCard(Seed, Value, true);
        }
    }


}
