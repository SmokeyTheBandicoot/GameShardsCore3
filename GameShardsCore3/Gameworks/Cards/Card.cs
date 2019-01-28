using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Gameworks.Cards {

    public abstract class Card<S, V, C> : ICard {

        public S Seed { get; set; }
        public V Value { get; set; }
        public abstract C Category { get; }
        public bool Covered { get; set; }
        public abstract Card<S, V, C> Cover();

    }

}
