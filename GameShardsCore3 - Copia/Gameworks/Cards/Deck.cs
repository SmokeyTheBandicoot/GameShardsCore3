using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Exceptions;
using GameShardsCore3.Mathematics.Random;
using static GameShardsCore3.Core.LibLanguage.LibLanguageManager;

namespace GameShardsCore3.Gameworks.Cards {

    public class Deck : List<ICard> {

        /// <summary>
        /// Shuffles the deck by iterating from the first card to the last and swapping it with another card at a 
        /// random index in the deck.
        /// </summary>
        public void ShuffleSwap() {
            for (int i = 0; i < Count; i++) {
                int c = (int)(TrueRNG.RandomDiscreteUniform(0, Count - 1));
                Swap(i, c);
            }
        }

        /// <summary>
        /// Swaps a card with another at the specified index
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        public void Swap(int index1, int index2) {
            if (index1 > Count - 1 || index2 > Count - 1) throw new ArgumentOutOfRangeException(LangManager.GetString("exception_argument_oor", CurrentCulture));

            ICard c1 = this[index1];
            ICard c2 = this[index2];

            RemoveAt(index2);
            Insert(index2, c1);

            RemoveAt(index1);
            Insert(index1, c2);
        }

        /// <summary>
        /// Returns and removes the top card
        /// </summary>
        /// <returns></returns>
        public ICard Pop() {
            if (Count == 0) throw new DeckEmptyException(LangManager.GetString("deck_empty_exception", CurrentCulture));
            ICard temp = Top();
            RemoveAt(Count - 1);
            return temp;
        }

        /// <summary>
        /// Returns the top card
        /// </summary>
        /// <returns></returns>
        public ICard Top() {
            if (Count == 0) return null;
            return this[Count - 1];
        }

        /// <summary>
        /// Counts how many cards are covered in the deck
        /// </summary>
        /// <returns></returns>
        public int CountCovered() {
            if (Count == 0) return 0;
            int x = 0;
            foreach (ICard c in this) {
                if (c.Covered) x++;
            }
            return x;
        }

        /// <summary>
        /// Returns how manu uncovered cards are in the deck
        /// </summary>
        /// <returns></returns>
        public int CountUncovered() {
            if (Count == 0) return 0;
            return Count - CountCovered();
        }

    }

}
