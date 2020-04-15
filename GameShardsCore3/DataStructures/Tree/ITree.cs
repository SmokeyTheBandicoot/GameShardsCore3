using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.DataStructures.Tree {

    public abstract class ITree<T> {

        public abstract class Position {

            /// <summary>
            /// Returns the element stored in the position
            /// </summary>
            /// <returns></returns>
            public abstract T Element();

            public abstract override bool Equals(object obj);

            public abstract override int GetHashCode();

            public abstract override string ToString();

        }

        /// <summary>
        /// Returns the position representing the tree's root
        /// </summary>
        /// <returns></returns>
        public abstract Position Root { get; }

        /// <summary>
        /// Returns the position representing the parent of Child
        /// </summary>
        /// <param name="Child"></param>
        /// <returns></returns>
        public abstract Position GetParent(Position Child);

        /// <summary>
        /// Generates an interation of positions representing the children of Parent
        /// </summary>
        /// <param name="Parent"></param>
        /// <returns></returns>
        public abstract IEnumerable<Position> GetChildren(Position Parent);

        /// <summary>
        /// Returns the number of children that Parent has
        /// </summary>
        /// <param name="Parent"></param>
        /// <returns></returns>
        public abstract int ChildrenCount(Position Parent);

        /// <summary>
        /// Returns the total number of elements in the tree
        /// </summary>
        /// <returns></returns>
        public abstract int Count { get; }

        /* - Concrete methods implemented in this class - */
        /// <summary>
        /// Returns true if Node is the root of the tree
        /// </summary>
        /// <param name="Node"></param>
        /// <returns></returns>
        public bool IsRoot(Position Node) {
            return this.Root == Node;
        }

        /// <summary>
        /// Returns true if Node is a leaf (has 0 children)
        /// </summary>
        /// <param name="Node"></param>
        /// <returns></returns>
        public bool IsLeaf(Position Node) {
            return this.ChildrenCount(Node) == 0;
        }

        /// <summary>
        /// Returns true if the Tree is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() {
            return this.Count == 0;
        }

        /// <summary>
        /// Returns the number of levels (nodes) separating Node from Root
        /// </summary>
        /// <param name="Node"></param>
        /// <returns></returns>
        public int Depth(Position Node) {
            if (IsRoot(Node)) return 0;
            else return 1 + Depth(GetParent(Node));
        }

        /// <summary>
        /// Returns the height of the subtree rooted at Position p
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        protected int Height(Position p) {
            if (IsLeaf(p)) return 0;
            else {
                int max = 0;
                foreach (Position child in GetChildren(p)) {
                    int newHeight = Height(child);
                    if (newHeight > max) max = newHeight;
                }
                return 1 + max;
            }
        }

        /// <summary>
        /// Returns the height of the subtree rooted at Node.
        /// If Node is null, returns the height of the entire tree
        /// </summary>
        /// <param name="Node"></param>
        /// <returns></returns>
        public int GetHeight(Position Node = null) {
            if (Node == null) Node = Root;
            return Height(Node);
        }

        /// <summary>
        /// Generates an iteration of the tree's elements
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetElements() {
            foreach (Position p in GetPositions())
                yield return p.Element();
        }

        /// <summary>
        /// Generate an iteration of the tree's positions
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Position> GetPositions() {
            return PreOrder();
        }

        /// <summary>
        /// Generate a preorder iteration of positions in the tree.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Position> PreOrder() {
            if (!IsEmpty())
                foreach (Position p in SubtreePreorder(Root))
                    yield return p;
        }

        /// <summary>
        /// Generate a preorder iteration of positions in subtree rooted at Node
        /// </summary>
        /// <param name="Node"></param>
        /// <returns></returns>
        protected IEnumerable<Position> SubtreePreorder(Position Node) {
            yield return Node;
            foreach (Position child in GetChildren(Node))
                foreach (Position other in SubtreePreorder(child))
                    yield return other;
        }

        /// <summary>
        /// Generates a post order iteration of positions in the tree
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Position> PostOrder() {
            if (!IsEmpty())
                foreach (Position p in SubtreePostorder(Root))
                    yield return p;
        }

        /// <summary>
        /// Generates a post order iteration of positions in the subtree rooted at p
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        protected IEnumerable<Position> SubtreePostorder(Position p) {
            foreach (Position child in GetChildren(p))
                foreach (Position other in SubtreePostorder(child))
                    yield return other;
            yield return p;
        }

        /// <summary>
        /// Generates a breadth-first iteration of the positions of the tree
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Position> BreadthFirst() {
            if (!IsEmpty()) {
                Queue<Position> fringe = new Queue<Position>();
                fringe.Enqueue(Root);
                while (fringe.Count > 0) {
                    Position p = fringe.Dequeue();
                    yield return p;
                    foreach (Position child in GetChildren(p))
                        fringe.Enqueue(child);
                }
            }

        }

        /// <summary>
        /// Generates an enumeration of positions from position to root
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public IEnumerable<Position> PathToRoot(Position position) {
            if (IsEmpty()) yield break;
            while (position != null) {
                yield return position;
                position = GetParent(position);
            }
        }
    }
}
