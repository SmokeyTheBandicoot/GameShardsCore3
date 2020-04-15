using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.DataStructures.PriorityQueue {
    
    public class AdaptableHeapPriorityQueue<K, V> : HeapPriorityQueue<K, V> where K : IComparable<K> {

        protected new List<Locator> data;

        public class Locator : Item {

            public int index { get; set; }
            public new K key { get; set; }
            public new V value { get; set; }

            public Locator(K key, V value, int index) : base(key, value) {
                this.index = index;
            }

        }

        public AdaptableHeapPriorityQueue() : base() { }

        protected new void swap(int i, int j) {
            base.swap(i, j);
            data[i].index = i;
            data[j].index = j;
        }

        protected void bubble(int j) {
            if (j > 0 && data[j] < data[parent(j)])
                upHeap(j);
            else downHeap(j);
        }

        /// <summary>
        /// Adds a new Key-Value pair
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public new Locator Add(K key, V value) {
            Locator token = new Locator(key, value, data.Count);
            data.Add(token);
            upHeap(data.Count - 1);
            return token;
        }

        /// <summary>
        /// Updates the Key-Value pair for the specified locator
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="newKey"></param>
        /// <param name="newVal"></param>
        public void Update(Locator loc, K newKey, V newVal) {
            int j = loc.index;
            if (!(0 <= j && j < Length() && data[j] == loc))
                throw new InvalidOperationException("The locator is invalid");
            loc.key = newKey;
            loc.value = newVal;
            bubble(j);
        }

        /// <summary>
        /// Removes and returns the key-value pair identified by the locator loc
        /// </summary>
        /// <param name="loc"></param>
        /// <returns></returns>
        public (K, V) Remove(Locator loc) {
            int j = loc.index;
            if (!(0 <= j && j < Length() && data[j] == loc))
                throw new InvalidOperationException("The locator is invalid");
            if (j == data.Count - 1)
                data.RemoveAt(j);
            else {
                swap(j, data.Count - 1);
                data.RemoveAt(j);
                bubble(j);
            }
            return (loc.key, loc.value);
        }

    }

}