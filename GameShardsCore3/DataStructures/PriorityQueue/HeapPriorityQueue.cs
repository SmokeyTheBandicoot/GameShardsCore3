using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.DataStructures.PriorityQueue {

    public class HeapPriorityQueue<K, V> : IPriorityQueue<K, V> where K : IComparable<K> {

        protected List<Item> data;

        protected int parent(int j) { return (j - 1) / 2; }

        protected int left (int j) { return 2 * j + 1; }

        protected int right (int j) { return 2 * j + 2; }

        protected bool hasLeft (int j) { return left(j) < data.Count; }

        protected bool hasRight (int j) { return right(j) < data.Count; }

        protected void swap(int i, int j) { (data[i], data[j]) = (data[j], data[i]); }

        protected void upHeap(int j) {
            int parent = this.parent(j);
            if (j > 0 && data[j] < data[parent]) {
                swap(j, parent);
                upHeap(parent);
            }
        }

        protected void downHeap(int j) {
            if (hasLeft(j)) {
                int _left = left(j);
                int smallChild = _left;
                if (hasRight(j)) {
                    int _right = right(j);
                    if (data[_right] < data[_left])
                        smallChild = _right;
                }
                if (data[smallChild] < data[j]) {
                    swap(j, smallChild);
                    downHeap(smallChild);
                }
            }
        }

        public HeapPriorityQueue() {
            data = new List<IPriorityQueue<K, V>.Item>();
        }

        public override void Add(K key, V value) {
            data.Add(new Item(key, value));
            upHeap(data.Count - 1);
        }

        public override int Length() {
            return data.Count;
        }

        public override (K, V) Min() {
            if (IsEmpty())
                throw new InvalidOperationException("The queue is empty");
            Item item = data[0];
            return (item.key, item.value);
        }

        public override (K, V) RemoveMin() {
            if (IsEmpty())
                throw new InvalidOperationException("The piority queue is empty");
            Item item = data[0];
            swap(0, data.Count - 1);
            data.Remove(item);
            downHeap(0);
            return (item.key, item.value);
        }
    }
}
