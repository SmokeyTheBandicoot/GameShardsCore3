using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Gameworks.Cards.FrenchCards {
    public class FrenchCategory : ICardCategory {

        public string name { get; }

        private FrenchCategory(string name) {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public static FrenchCategory Ace() {
            return new FrenchCategory("Ace");
        }

        public static FrenchCategory Number() {
            return new FrenchCategory("Number");
        }

        public static FrenchCategory Figure() {
            return new FrenchCategory("Figure");
        }

        public static FrenchCategory Joker() {
            return new FrenchCategory("Joker");
        }

    }
}
