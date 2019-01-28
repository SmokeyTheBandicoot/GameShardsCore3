using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameShardsCore3.Gameworks.Cards.FrenchCards {

    public class FrenchSeed : ISeed {

        public string name { get; }
        public char symbol { get; }
        public Color color { get; }

        public FrenchSeed(string name, char symbol, Color color) {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.symbol = symbol;
            this.color = color;
        }

        public static FrenchSeed Hearts() {
           return new FrenchSeed("Hearts", '♥', Color.Red);
        }

        public static FrenchSeed Diamonds() {
            return new FrenchSeed("Diamonds", '♦', Color.Red);
        }

        public static FrenchSeed Clubs() {
            return new FrenchSeed("Clubs", '♣', Color.Black);
        }

        public static FrenchSeed Spades() {
            return new FrenchSeed("Spades", '♠', Color.Black);
        }

        public static FrenchSeed Joker() {
            return new FrenchSeed("Joker", 'J', Color.White);
        }
    }

}
