using GameShardsCore3.DataStructures.Graph;
using GameShardsCore3.DataStructures.Tree;
using GameShardsCore3.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShardsCore3.Algorithms.DataStructures.Graphs.SingleSourceShortestPath {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 0)]
    public class BellmanFordAlgorithm<Vertex, Edge> {

        private IGraph<Vertex, Edge> graph;
        private Dictionary<IVertex<Vertex>, double> distanceMap;
        private Dictionary<IVertex<Vertex>, IVertex<Vertex>> predecessors;

        public List<Tree<IVertex<Vertex>>> getSpanningForest() {
            if (distanceMap == null)
                throw new InvalidOperationException("Bellman-Ford algorithm must be executed on the graph first");

            List<Tree<IVertex<Vertex>>> forest = new List<Tree<IVertex<Vertex>>>();
            Dictionary<IVertex<Vertex>, bool> visited = new Dictionary<IVertex<Vertex>, bool>();
                
            // Very computationally-complex code, possibly O(n^3)
            while (visited.Count < predecessors.Count) {
                foreach (var vert in predecessors.Keys) {

                    if (visited.ContainsKey(vert)) continue; // Skip the already processed element

                    // A new tree of the forest must be created
                    if (predecessors[vert] == null) {
                        // Creates a new tree and sets its root
                        Tree<IVertex<Vertex>> tree = new Tree<IVertex<Vertex>>();
                        tree.Insert(null, vert);
                        forest.Add(tree);
                        visited.Add(vert, true);
                        break;
                    }

                    // Previously created trees might contain the element
                    foreach (var tree in forest) {
                        var position = tree.PositionContaining(predecessors[vert]);
                        if (position != null) {
                            // An element has been found in this tree that is the predecessor of vert
                            visited.Add(vert, true);
                            tree.Insert(position, vert);
                            break;
                        }
                    }
                }
            }

            return forest;
        }

        public BellmanFordAlgorithm(IGraph<Vertex, Edge> graph) {
            this.graph = graph;
            distanceMap = new Dictionary<IVertex<Vertex>, double>();
            predecessors = new Dictionary<IVertex<Vertex>, IVertex<Vertex>>();
        }

        public Dictionary<IVertex<Vertex>, IVertex<Vertex>> getPredecessors() {
            if (predecessors != null)
                return predecessors;
            throw new InvalidOperationException("Bellman-Ford Algorithm has not been executed yet on this graph");
        }

        /// <summary>
        /// Returns a dictionary(vertex, double) containing the double distance from source to vertex
        /// </summary>
        /// <returns></returns>
        public Dictionary<IVertex<Vertex>, double> getDistanceMap() {
            if (distanceMap != null)
                return distanceMap;
            throw new InvalidOperationException("Bellman-Ford Algorithm has not been executed yet on this graph");
        }

        /// <summary>
        /// Returns an enumeration of Graph's vertices of the vertices that are less than or equal than MaxDistance away from source
        /// </summary>
        /// <param name="MaxDistance"></param>
        /// <returns></returns>
        public IEnumerable<IVertex<Vertex>> getReacheable(double MaxDistance) {
            if (distanceMap == null)
                 throw new InvalidOperationException("Bellman-Ford Algorithm has not been executed yet on this graph");
            foreach (KeyValuePair<IVertex<Vertex>, double> kvp in distanceMap) {
                if (kvp.Value <= MaxDistance) yield return kvp.Key;
            }
        }

        /// <summary>
        /// Executes the BellMan-Ford algorithm on the graph
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public bool Execute(IVertex<Vertex> source) {

            distanceMap = new Dictionary<IVertex<Vertex>, double>();
            predecessors = new Dictionary<IVertex<Vertex>, IVertex<Vertex>>();

            foreach (IVertex<Vertex> vertex in graph.getVertices()) {
                predecessors.Add(vertex, source);
                distanceMap.Add(vertex, double.PositiveInfinity);
            }
            distanceMap[source] = 0;
            predecessors[source] = null;

            for (int i = 1; i <= graph.getVertexCount(); i++) {
                bool relaxed = false;

                foreach (IEdge<Edge> edge in graph.getEdges()) {
                    List<IVertex<Vertex>> endpoints = graph.getEndpoints(edge);
                    IVertex<Vertex> src, dst;

                    src = endpoints[0];
                    dst = endpoints[1];

                    if (distanceMap[dst] > distanceMap[src] + edge.getWeight()) {
                        distanceMap[dst] = distanceMap[src] + edge.getWeight();
                        predecessors[dst] = src;
                        relaxed = true;
                    }
                }

                if (!relaxed)
                    break;
            }

            foreach (IEdge<Edge> edge in graph.getEdges()) {
                List<IVertex<Vertex>> endpoints = graph.getEndpoints(edge);
                IVertex<Vertex> src, dst;

                src = endpoints[0];
                dst = endpoints[1];

                if (distanceMap[dst] > distanceMap[src] + edge.getWeight())
                    return false;
            }

            return true;
        }

    }

}
