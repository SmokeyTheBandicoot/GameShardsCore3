using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.DataStructures.List {

    public class PositionalList<T> : DoublyLinkedBase<T> where T : class {

        public class Position {

            public PositionalList<T> Container { get; }
            public Node Node { get; }
            
            public Position(PositionalList<T> Container, Node Node) {
                this.Container = Container;
                this.Node = Node;
            }

            public T element() {
                return Node.element;
            }

            public override bool Equals(object obj) {
                return this.GetType() == obj.GetType() && ((Position)obj).Node.Equals(this.Node);
            }

            public override int GetHashCode() {
                return base.GetHashCode();
            }

        }

        private Node validate(Position p) {
            if (p.Container != this)
                throw new ArgumentException("The position does not belong to this Positional List");
            if (p.Node.next == null) // Convention for deprecated nodes
                throw new ArgumentException("The position is no longer valid");
            return p.Node;
        }

        private Position makePosition(Node node) {
            if (node == header || node == trailer)
                return null;
            else return new Position(this, node);
        }

        /// <summary>
        /// Returns the first position of the list
        /// </summary>
        /// <returns></returns>
        public Position First() {
            return makePosition(header.next);
        }

        /// <summary>
        /// Returns the last position of the list
        /// </summary>
        /// <returns></returns>
        public Position Last() {
            return makePosition(trailer.prev);
        }

        /// <summary>
        /// Returns the element before the position p, or null if p is first
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Position Before(Position p) {
            Node node = validate(p);
            return makePosition(node.prev);
        }

        /// <summary>
        /// Returns the position after position p, or null if p is last
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Position After(Position p) {
            Node node = validate(p);
            return makePosition(node.next);
        }

        /// <summary>
        /// Returns an iteration on all the elements of the list
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> Elements() {
            Position cursor = First();
            while (cursor != null) {
                yield return cursor.element();
                cursor = After(cursor);
            }
        }

        /// <summary>
        /// Adds an element between two existing nodes and returns the new Position
        /// </summary>
        /// <param name="element"></param>
        /// <param name="predecessor"></param>
        /// <param name="successor"></param>
        /// <returns></returns>
        public Position InsertBetween(T element, Node predecessor, Node successor) {
            Node node = base.InsertBetween(element, predecessor, successor);
            return makePosition(node);
        }

        /// <summary>
        /// Adds an element at the front of the list and returns its position
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public Position AddFirst(T element) {
            return InsertBetween(element, header, header.next);
        }

        /// <summary>
        /// Adds an element at the back of the list and returns its position
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public Position AddLast(T element) {
            return InsertBetween(element, trailer.prev, trailer);
        }

        /// <summary>
        /// Adds an element just before p and returns its position
        /// </summary>
        /// <param name="p"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public Position AddBefore(Position p, T element) {
            Node original = validate(p);
            return InsertBetween(element, original.prev, original);
        }

        /// <summary>
        /// Adds an element just after p and returns its position
        /// </summary>
        /// <param name="p"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public Position AddAfter(Position p, T element) {
            Node original = validate(p);
            return InsertBetween(element, original, original.next);
        }

        /// <summary>
        /// Removes the specified position p
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public T Remove(Position p) {
            Node original = validate(p);
            return base.Remove(original);
        }

        /// <summary>
        /// Replaces the element at Position p with newElement aand returns the old value
        /// </summary>
        /// <param name="p"></param>
        /// <param name="newElement"></param>
        /// <returns></returns>
        public T Replace(Position p, T newElement) {
            Node original = validate(p);
            T old = original.element;
            original.element = newElement;
            return old;//base.Remove(old);
        }

    }

}
