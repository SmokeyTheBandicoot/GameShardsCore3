using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.DataStructures.PriorityQueue {
    
    public abstract class IPriorityQueue<K, V> where K : IComparable<K> {
        
        public class Item {

            public K key { get; }
            public V value { get; }

            public Item (K key, V value) {
                this.key = key;
                this.value = value;
            }

            public static bool operator <(Item i1, Item i2) {
                return i1.key.CompareTo(i2.key) > 0;
            }

            public static bool operator >(Item i1, Item i2) {
                return i2.key.CompareTo(i2.key) > 0;
            }

            public override string ToString() {
                return string.Format("{0};{1}", key.ToString(), value.ToString());
            }

        }

        public bool IsEmpty() {
            return this.Length() == 0;
        }

        public abstract int Length();

        public abstract void Add(K key, V value);

        public abstract (K, V) Min();

        public abstract (K, V) RemoveMin();
    }

}
