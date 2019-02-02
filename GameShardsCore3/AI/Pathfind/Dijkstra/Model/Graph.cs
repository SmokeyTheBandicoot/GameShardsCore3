using GameShardsCore3.AI.Pathfind.Dijkstra.Common;
using GameShardsCore3.AI.Pathfind.Dijkstra.InterfaceModel;
using GameShardsCore3.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.AI.Pathfind.Dijkstra.Model {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 0)]
    /// <summary>
    /// Represents the graph, which is just a collection of nodes and edges
    /// </summary>
    public class Graph {
        public List<Node> Vertexes { get; }
        public List<Edge> Edges { get; }

        public event EventHandler OnGraphInvalidated;
        public delegate void OnGraphInvalidatedEventHandler(GraphEventArgs e);

        public Graph(List<Node> v, List<Edge> e) {
            Vertexes = v;
            Edges = e;
        }

        public Graph(List<INode> v, List<IEdge> e) {
            for (int x = 0; x < v.Count; x++) {
                Vertexes.Add(new Node(v[x].ID, v[x].Name));
            }

            for (int x = 0; x < e.Count; x++) {
                Edges.Add(new Edge(e[x].ID, e[x].Source, e[x].Destination, e[x].Weight));
            }
        }

        //Adds a node and invalidates the graph, as Dijkstra has to be computated again
        public void AddNode(Node n) {
            Vertexes.Add(n);
            OnGraphInvalidated(this, new GraphEventArgs(GraphEventArgs.GraphInvalidationReason.OnNodes));
        }

        public void AddNode(INode v) {
            Vertexes.Add(new Node(v.ID, v.Name));
            OnGraphInvalidated(this, new GraphEventArgs(GraphEventArgs.GraphInvalidationReason.OnNodes));
        }

        //Adds an edge and invalidates the graph, as Dijkstra has to be computated again
        public void AddEdge(Edge e) {
            Edges.Add(e);
            OnGraphInvalidated(this, new GraphEventArgs(GraphEventArgs.GraphInvalidationReason.OnEdges));
        }

        public void AddEdge(IEdge e) {
            Edges.Add(new Edge(e.ID, e.Source, e.Destination, e.Weight));
            OnGraphInvalidated(this, new GraphEventArgs(GraphEventArgs.GraphInvalidationReason.OnEdges));
        }

        /// <summary>
        /// Builds a weighted graph from a matrix of double.
        /// The Name and ID of the nodes are in a formatted string. The formatted string should have two parameters, {0} and {1} in it
        /// If it fails (not enough parameters) than it will default back to "Node_{0}; {1}" (x is 0 and y is 1)
        /// <example>FromMatrix(mat, "{0}_{1}", {0}...{1}" will create the generic x, y node with ID = X_Y and name X...Y</example>
        /// </summary>
        /// <param name="mat">Matrix the graph should be build upon</param>
        /// <param name="FormatID">Format string for the ID of the nodes</param>
        /// <param name="FormatName">Format string for the name of the nodes</param>
        public void FromMatrix(double[,] mat, string FormatID = "Node_{0}; {1}", string FormatName = "Node_{0}; {1}") {

            Vertexes.Clear();
            Edges.Clear();

            int cache_W = mat.GetUpperBound(0);
            int cache_H = mat.GetUpperBound(1);

            Node[,] nodes = new Node[cache_W, cache_H];

            if (mat == null) return;

            for (int x = 0; x <= cache_H; x++) {
                for (int y = 0; y < cache_W; y++) {

                    try {
                        nodes[x, y] = new Node(String.Format(FormatID, x, y), String.Format(FormatName, x, y));
                    } catch (Exception ex) {
                        nodes[x, y] = new Node(String.Format("Node_{0}; {1}", x, y), String.Format("Node_{0}; {1}", x, y));
                    }

                    Vertexes.Add(nodes[x, y]);

                    //First element of the matrix: no edges to add
                    if (x == 0 && y == 0) {
                        continue;
                    }

                    //Top row of the matrix
                    //Add edge with the node on the left
                    if (x > 0 && y == 0) {
                        Edges.Add(new Edge("Edge_" + Edges.Count.ToString(), nodes[x - 1, y], nodes[x, y], mat[x, y]));
                        Edges.Add(new Edge("Edge_" + Edges.Count.ToString(), nodes[x, y], nodes[x - 1, y], mat[x - 1, y]));
                        continue;
                    }

                    //Left columns
                    //Add edge to the top
                    if (x == 0 && y > 0) {
                        Edges.Add(new Edge("Edge_" + Edges.Count.ToString(), nodes[x, y-1], nodes[x, y], mat[x, y]));
                        Edges.Add(new Edge("Edge_" + Edges.Count.ToString(), nodes[x, y], nodes[x, y - 1], mat[x, y - 1]));
                    }

                    //Other elements (should always be true at this point)
                    //Add edge both to nodes on the top and on the left
                    if (x > 0 && y > 0) {
                        Edges.Add(new Edge("Edge_" + Edges.Count.ToString(), nodes[x, y - 1], nodes[x, y], mat[x, y]));
                        Edges.Add(new Edge("Edge_" + Edges.Count.ToString(), nodes[x - 1, y], nodes[x, y], mat[x, y]));

                        Edges.Add(new Edge("Edge_" + Edges.Count.ToString(), nodes[x, y], nodes[x, y - 1], mat[x, y - 1]));
                        Edges.Add(new Edge("Edge_" + Edges.Count.ToString(), nodes[x, y], nodes[x - 1, y], mat[x - 1, y]));
                    }
                }
            }
        }
    }
}
