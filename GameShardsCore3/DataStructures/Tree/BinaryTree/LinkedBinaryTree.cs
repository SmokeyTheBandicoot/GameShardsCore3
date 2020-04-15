using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.DataStructures.Tree.BinaryTree {

    public class LinkedBinaryTree<T> : IBinaryTree<T> {

        private int size = 0;
        private Node root = null;

        public class Node {
            public T element { get; set; }
            public Node parent { get; set; }
            public Node left { get; set; }
            public Node right { get; set; }

            public Node(T element, Node parent = null, Node left = null, Node right = null) {
                this.element = element;
                this.parent = parent;
                this.left = left;
                this.right = right;
            }


        }

        public new class Position : ITree<T>.Position {

            public Node Node { get; set; }
            public LinkedBinaryTree<T> container { get; }

            public Position(LinkedBinaryTree<T> container, Node Node) {
                this.Node = Node;
                this.container = container;
            }

            public override bool Equals(object obj) {
                return obj.GetType() == this.GetType() && this.Node == ((Position)obj).Node;
            }

            public override T Element() {
                return this.Node.element;
            }

            public override int GetHashCode() {
                int hash = 13;
                hash = (hash * 7) + Node.GetHashCode();
                return hash;
            }

            public override string ToString() {
                return Node.ToString();
            }
        }

        /// <summary>
        /// Returns associated node if the position is valid
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        private Node validate(ITree<T>.Position pos) {
            if (pos.GetType() != typeof(Position))
                throw new ArgumentException("For this tree you need a Position of type LinkedBinaryTree<T>.Position");
            Position p = (Position)pos;
            if (p.container != this)
                throw new ArgumentException("The position is not part of this data structure");
            if (p.Node.parent == p.Node) // Convention for deprecated nodes
                throw new ArgumentException("The position is no longer valid");
            return p.Node;
        }

        /// <summary>
        /// Returns position instance for a given node, or null if node is null
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private Position makePosition(Node node) {
            if (node != null) return new Position(this, node);
            else return null;
        }

        public LinkedBinaryTree() {
            root = null;
            size = 0;
        }

        public override int Count { get { return size; } }

        public override ITree<T>.Position Root { get { return makePosition(root); } }

        public override ITree<T>.Position GetParent(ITree<T>.Position Child) {
            Node node = validate(Child);
            return makePosition(node.parent);

        }

        public override ITree<T>.Position Left(ITree<T>.Position Parent) {
            Node node = validate(Parent);
            return makePosition(node.left);
        }

        public override ITree<T>.Position Right(ITree<T>.Position Parent) {
            Node node = validate(Parent);
            return makePosition(node.right);
        }

        public override int ChildrenCount(ITree<T>.Position Parent) {
            Node node = validate(Parent);
            int count = 0;
            if (node.left != null) count++;
            if (node.right != null) count++;
            return count;
        }

        public ITree<T>.Position AddRoot(T element) {
            if (root != null)
                throw new InvalidOperationException("The root for this tree already exists");
            size += 1;
            root = new Node(element);
            return makePosition(root);
        }

        /// <summary>
        /// Adds a new node at the left of Parent, if Parent.Left is null
        /// </summary>
        /// <param name="Parent"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public ITree<T>.Position AddLeft(Position Parent, T element) {
            Node node = validate(Parent);
            if (node.left != null)
                throw new InvalidOperationException("There is already a node at the left of Parent");
            size++;
            node.left = new Node(element, node);
            return makePosition(node.left);
        }

        /// <summary>
        /// Adds a new node at the lefrightt of Parent, if Parent.Right is null
        /// </summary>
        /// <param name="Parent"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public ITree<T>.Position AddRight(Position Parent, T element) {
            Node node = validate(Parent);
            if (node.right != null)
                throw new InvalidOperationException("There is already a node at the right of Parent");
            size++;
            node.right = new Node(element, node);
            return makePosition(node.right);
        }

        /// <summary>
        /// Replaces the element at position Parent with newElement, returning the old element
        /// </summary>
        /// <param name="Node"></param>
        /// <param name="newElement"></param>
        /// <returns></returns>
        public T Replace(Position Node, T newElement) {
            Node node = validate(Node);
            T old = node.element;
            node.element = newElement;
            return old;
        }

        /// <summary>
        /// Removes the node at position Node, and replaces it with its child
        /// if only one of the two children is present, otherwise throws an exception
        /// </summary>
        /// <param name="Node"></param>
        /// <returns></returns>
        public T Remove(Position Node) {
            Node node = validate(Node);
            if (ChildrenCount(Node) == 2)
                throw new InvalidOperationException("The node has 2 children, thus it cannot be eliminated. Remove at least one child");
            Node child = null;
            if (node.left != null) child = node.left;
            else if (node.right != null) child = node.right;
            // Child's granparent becomes parent
            if (child != null)
                child.parent = node.parent;
            // Child becomes root
            if (node == root)
                root = child;
            else {
                Node parent = node.parent;
                if (node == parent.left)
                    parent.left = child;
                else
                    parent.right = child;
            }
            size -= 1;
            node.parent = node;
            return node.element;
        }

        /// <summary>
        /// Attaches two LinkedBinaryTrees, Left and Right, to the left and the right
        /// respectively of a leaf position
        /// </summary>
        /// <param name="Node"></param>
        /// <param name="Left"></param>
        /// <param name="Right"></param>
        public void Attach(Position Node, LinkedBinaryTree<T> Left, LinkedBinaryTree<T> Right) {
            Node node = validate(Node);
            if (!IsLeaf(Node))
                throw new InvalidOperationException("The position Node is not a leaf");
            size += Left.size + Right.size;

            if (!Left.IsEmpty()) {
                Left.root.parent = node;
                node.left = Left.root;
                Left.root = null;
                Left.size = 0;
            }
            if (!Right.IsEmpty()) {
                Right.root.parent = node;
                node.right = Right.root;
                Right.root = null;
                Right.size = 0;
            }
        }

        /// <summary>
        /// Attaches a LinkedBinaryTrees to the left or the right of a node
        /// </summary>
        /// <param name="Node"></param>
        /// <param name="Left"></param>
        /// <param name="Right"></param>
        public void Attach(Position Node, LinkedBinaryTree<T> Subtree, bool left = true) {
            Node node = validate(Node);
            if ((node.left != null && left == true) || (node.right != null && left == false))
                throw new InvalidOperationException("The side of the node where the subtree had to be attached is not null");
            size += Subtree.size;

            if (!Subtree.IsEmpty()) {
                Subtree.root.parent = node;

                if (left) node.left = Subtree.root;
                else node.right = Subtree.root;

                Subtree.root = null;
                Subtree.size = 0;
            }

        }
    }
}
