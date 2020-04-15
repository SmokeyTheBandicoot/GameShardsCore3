using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.DataStructures.List;

namespace GameShardsCore3.DataStructures.PriorityQueue {

    public class SortedPriorityQueue<K, V> : IPriorityQueue<K, V> where K : IComparable<K> {

        PositionalList<Item> data;

        public SortedPriorityQueue() {
            data = new PositionalList<IPriorityQueue<K, V>.Item>();
        }
        
        /// <summary>
        /// Adds a new key-value pair
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public override void Add(K key, V value) {
            Item newest = new IPriorityQueue<K, V>.Item(key, value);
            PositionalList<IPriorityQueue<K, V>.Item>.Position walk = data.Last();
            while (walk != null && newest < walk.element())
                walk = data.Before(walk);
            if (walk == null)
                data.AddFirst(newest);
            else data.AddAfter(walk, newest);


        }

        public override int Length() {
            return data.Count;
        }

        /// <summary>
        /// Returns but does not remove the key-value pair in front of the Queue
        /// </summary>
        /// <returns></returns>
        public override (K, V) Min() {
            if (IsEmpty()) throw new InvalidOperationException("The Priority Queue is empty");
            PositionalList<Item>.Position p = data.First();
            Item item = p.element();
            return (item.key, item.value);
        }

        /// <summary>
        /// Removes and returns the key-value pair in front of the Queue
        /// </summary>
        /// <returns></returns>
        public override (K, V) RemoveMin() {
            if (IsEmpty()) throw new InvalidOperationException("The Priority Queue is empty");
            Item item = data.Remove(data.First());
            return (item.key, item.value);
        }

    }
}
