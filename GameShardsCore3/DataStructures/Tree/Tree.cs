using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.DataStructures.Tree {
    public class Tree<T> : ITree<T> {

        private Node root;
        private int size;

        public Tree() {
            this.root = null;
            size = 0;
        }

        public class Node {
            public T Element { get; set; }
            public Node Parent { get; set; }
            public List<Node> Children;

            public Node(T Element, Node Parent = null) {
                this.Element = Element;
                this.Parent = Parent;
                Children = new List<Node>();
            }
        }

        public new class Position : ITree<T>.Position {

            public Tree<T> Container { get; set; }
            public Node Node { get; set; }

            public Position(Tree<T> container, Node node) {
                this.Container = container;
                this.Node = node;
            }

            public override bool Equals(object obj) {
                if (obj != null && obj.GetType() == this.GetType())
                    return Node.Equals(((Position)obj).Node);
                else return false;
            }

            public override int GetHashCode() {
                return Node.GetHashCode();
            }

            public override string ToString() {
                return Node.ToString();
            }

            public override T Element() {
                return Node.Element;
            }
        }

        private Node validate(ITree<T>.Position position) {
            if (position.GetType() != typeof(Position))
                throw new ArgumentException("Position is not of the correct type");
            Position p = (Position)position;
            if (p.Container != this)
                throw new ArgumentException("The position does not belong to this Tree");
            if (p.Node.Parent == p.Node) // Convention for deprecated nodes
                throw new ArgumentException("The position is no longer valid");
            return p.Node;
        }

        private Position makePosition(Node node) {
            if (node == null) return null;
            return new Position(this, node);
        }

        public override ITree<T>.Position Root => makePosition(root);

        public override int Count => size;

        public override int ChildrenCount(ITree<T>.Position Parent) {
            Node node = validate(Parent);
            return node.Children.Count;
        }

        public override IEnumerable<ITree<T>.Position> GetChildren(ITree<T>.Position Parent) {
            Node node = validate(Parent);
            foreach(var child in node.Children) {
                yield return makePosition(child);
            }
        }

        public override ITree<T>.Position GetParent(ITree<T>.Position Child) {
            Node node = validate(Child);
            return makePosition(node.Parent);
        }
    
        public Position Insert(Position parent, T element) {
            if (root == null) {
                root = new Node(element, null);
                size = 1;
                return makePosition(root);
            }
            if (parent == null) {
                throw new ArgumentNullException("Parent cannot be null if the Tree has a root already");
            }
            Node par = validate(parent);
            Node newnode = new Node(element);
            par.Children.Add(newnode);
            newnode.Parent = par;
            size++;
            return makePosition(newnode);
        }

        public T Replace(Position position, T element) {
            Node node = validate(position);
            T old = node.Element;
            node.Element = element;
            return old;
        }

        public T Remove(Position position) {
            Node node = validate(position);
            if (node.Children.Count > 1)
                throw new ArgumentException("Cannot remove a node with more than 1 child");

            if (node.Children.Count == 1) {
                Node child = node.Children[0];
                child.Parent = node.Parent;
                if (node == root)
                    this.root = child;
                else {
                    Node parent = node.Parent;
                    parent.Children.Add(child);
                }    
            }
            node.Parent.Children.Remove(node);
            size--;
            node.Parent = node; // Convention for deprecated nodes
            return node.Element;
        }
        
        public void Attach(Position position, List<Tree<T>> subtrees) {
            Node node = validate(position);

            foreach (var tree in subtrees) {
                if (!tree.IsEmpty()) {
                    size += tree.size;
                    node.Children.Add(tree.root);
                    tree.root = null;
                    tree.root.Parent = node;
                }
            }

        }

        public bool Contains(T element) {
            return GetElements().Contains(element);
        }

        public Position PositionContaining(T element) {
            foreach (Position p in GetPositions()) {
                Node node = p.Node;
                if (node.Element.Equals(element)) return makePosition(node);
            }
            return null;
        }

        public override string ToString() {
            return recurseTree(root, "", "", "--");
        }

        private string recurseTree(Node node, string indent, string result, string separator) {
            if (node == null) return indent + "~null";
            else {
                
                string[] strings = new string[node.Children.Count];
                int i = 0;
                // Recursion
                foreach (var child in node.Children) {
                    strings[i] += Environment.NewLine + recurseTree(child, indent + separator, result, separator); 
                    i++;
                }
                // Node
                result += indent + "(" + node.Element.ToString() + ")";
                // Attach recursion
                foreach (var str in strings) {
                    result += str;
                }
                return result;
            }
        }

    }
}
