using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.DataStructures.List {

    public class DoublyLinkedBase<T> where T : class {

        public Node header;
        public Node trailer;
        public int size = 0;

        public class Node {

            public T element { get; set; }
            public Node prev { get; set; }
            public Node next { get; set; }

            public Node(T element, Node prev, Node next) {
                this.element = element;
                this.prev = prev;
                this.next = next;
            }

        }

        public DoublyLinkedBase() {
            header = new Node(null, null, null);
            trailer = new Node(null, null, null);
            header.next = trailer;
            trailer.prev = header;
            size = 0;
        }

        public int Count { get { return size; } }

        public bool IsEmpty() { return size == 0; }

        /// <summary>
        /// Adds an element in between two existing nodes
        /// </summary>
        /// <param name="Element"></param>
        /// <param name="Predecessor"></param>
        /// <param name="Successor"></param>
        /// <returns></returns>
        public Node InsertBetween(T Element, Node Predecessor, Node Successor) {
            Node newest = new Node(Element, Predecessor, Successor);
            Predecessor.next = newest;
            Successor.prev = newest;
            size++;
            return newest;
        }

        /// <summary>
        /// Removes a node and returns the element it contained
        /// </summary>
        /// <param name="Node"></param>
        /// <returns></returns>
        public T Remove(Node Node) {
            Node predecessor = Node.prev;
            Node successor = Node.next;
            predecessor.next = successor.prev;
            successor.prev = successor.next;
            size--;
            T element = Node.element;
            Node.prev = Node.next = null;
            Node.element = null;
            return element;
        }
    }

}
