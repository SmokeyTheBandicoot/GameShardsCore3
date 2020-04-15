using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.DataStructures.List;

namespace GameShardsCore3.DataStructures.PriorityQueue {

    public class UnsortedPriorityQueue<K, V> : IPriorityQueue<K, V> where K : IComparable<K> {

        PositionalList<Item> data;

        public UnsortedPriorityQueue() {
            data = new PositionalList<IPriorityQueue<K, V>.Item>();
        }

        /// <summary>
        /// Returns the position of the minimum key
        /// </summary>
        /// <returns></returns>
        public PositionalList<Item>.Position FindMin() {
            if (IsEmpty()) throw new InvalidOperationException("The Priority Queue is empty");
            PositionalList<Item>.Position small = data.First();
            PositionalList<Item>.Position walk = data.After(small);
            while (walk != null) {
                if (walk.element() < small.element())
                    small = walk;
                walk = data.After(walk);
            }
            return small;
        }
        
        /// <summary>
        /// Adds a key-value pair
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public override void Add(K key, V value) {
            data.AddLast(new Item(key, value));
        }

        public override int Length() {
            return data.size;
        }

        /// <summary>
        /// Returns but does not remove the key-value pair with minimum key
        /// </summary>
        /// <returns></returns>
        public override (K, V) Min() {
            PositionalList<Item>.Position p = FindMin();
            Item item = p.element();
            return(item.key, item.value);
        }

        /// <summary>
        /// Removes and returns the key-value pair with the minimum key
        /// </summary>
        /// <returns></returns>
        public override (K, V) RemoveMin() {
            var p = FindMin();
            var item = data.Remove(p);
            return (item.key, item.value);
        }
    }
}
