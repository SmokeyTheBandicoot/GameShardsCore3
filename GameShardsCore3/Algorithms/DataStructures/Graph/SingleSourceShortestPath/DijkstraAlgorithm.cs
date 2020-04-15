using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Attributes;
using GameShardsCore3.DataStructures.Graph;
using GameShardsCore3.DataStructures.Tree;
using static GameShardsCore3.Core.LibLanguage.LibLanguageManager;

namespace GameShardsCore3.Algorithms.DataStructures.Graphs.SingleSourceShortestPath {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(2, 0, 0)]
    /// <summary>
    /// Class which computes the Dijkstra algorithm on a IGraph instance
    /// </summary>
    public class DijkstraAlgorithm<Vertex, Edge> {

        private IGraph<Vertex, Edge> graph;

        private HashSet<IVertex<Vertex>> SettledNodes;
        private HashSet<IVertex<Vertex>> UnsettledNodes;
        private Dictionary<IVertex<Vertex>, IVertex<Vertex>> Predecessors;
        private Dictionary<IVertex<Vertex>, double> Distance;
        private List<IVertex<Vertex>> AdjacentNodes;

        public DijkstraAlgorithm(IGraph<Vertex, Edge> graph) {
            this.graph = graph;
        }

        public Dictionary<IVertex<Vertex>, IVertex<Vertex>> getPredecessors() {
            if (Predecessors != null)
                return Predecessors;
            throw new InvalidOperationException("Dijkstra Algorithm has not been executed yet on this graph");
        }

        public Dictionary<IVertex<Vertex>, double> getDistanceMap() {
            if (Distance != null)
                return Distance;
            throw new InvalidOperationException("Dijkstra Algorithm has not been executed yet on this graph");
        }

        [Tested()]
        public void Execute(IVertex<Vertex> source) {

            //Creation of new HashSets
            SettledNodes = new HashSet<IVertex<Vertex>>();
            UnsettledNodes = new HashSet<IVertex<Vertex>>();
            Distance = new Dictionary<IVertex<Vertex>, double>();
            Predecessors = new Dictionary<IVertex<Vertex>, IVertex<Vertex>>();
            AdjacentNodes = new List<IVertex<Vertex>>();

            //Setup
            Distance.Add(source, 0);
            UnsettledNodes.Add(source);

            while (UnsettledNodes.Count > 0) {
                IVertex<Vertex> node = GetMinimum(UnsettledNodes);
                SettledNodes.Add(node);
                UnsettledNodes.Remove(node);
                FindMinimalDistances(node);
            }

        }

        public ITree<IVertex<Vertex>> getShortestSpanningTree(IVertex<Vertex> source) {
            this.Execute(source);
            throw new NotImplementedException();
        }

        private void buildTreeFromPredecessors() {

        }

        private void FindMinimalDistances(IVertex<Vertex> node) {
            AdjacentNodes.Clear();
            AdjacentNodes.AddRange(GetNeighbors(node));

            foreach (IVertex<Vertex> target in AdjacentNodes) {

                if (GetShortestDistance(target) > GetShortestDistance(node) + GetDistance(node, target)) {

                    //Replace distance value
                    if (Distance.ContainsKey(target)) {
                        Distance.Remove(target);
                    }
                    Distance.Add(target, GetShortestDistance(node));

                    //Replace predecessor value
                    if (Predecessors.ContainsKey(target)) {
                        Predecessors.Remove(target);
                    }
                    Predecessors.Add(target, node);

                    UnsettledNodes.Add(target);
                }

            }
        }

        private double GetDistance(IVertex<Vertex> node, IVertex<Vertex> target) {
            foreach (IEdge<Edge> edge in graph.getEdges()) {
                List<IVertex<Vertex>> endpoints = graph.getEndpoints(edge);
                if (endpoints[0].Equals(node) && endpoints[1].Equals(target)) {
                    return edge.getWeight();
                }
            }
            throw new Exception(LangManager.GetString("exception_graph_structure", CurrentCulture));
        }

        private List<IVertex<Vertex>> GetNeighbors(IVertex<Vertex> node) {
            List<IVertex<Vertex>> neighbors = new List<IVertex<Vertex>>();
            foreach (IEdge<Edge> edge in graph.getEdges()) {
                List<IVertex<Vertex>> endpoints = graph.getEndpoints(edge);
                if (endpoints[0].Equals(node) && !IsSettled(endpoints[1])) {
                    neighbors.Add(endpoints[1]);
                }
            }
            return neighbors;
        }

        private IVertex<Vertex> GetMinimum(ISet<IVertex<Vertex>> vertices) {
            IVertex<Vertex> minimum = null;
            foreach (IVertex<Vertex> vertex in vertices) {
                if (minimum == null) {
                    minimum = vertex;
                }
                else {
                    if (GetShortestDistance(vertex) < GetShortestDistance(minimum)) {
                        minimum = vertex;
                    }
                }
            }
            return minimum;
        }

        private bool IsSettled(IVertex<Vertex> vertex) {
            return SettledNodes.Contains(vertex);
        }

        private double GetShortestDistance(IVertex<Vertex> destination) {
            if (Distance.ContainsKey(destination)) {
                return Distance[destination];
            }
            else {
                return double.PositiveInfinity;
            }
        }


        /// <summary>
        /// returns the path from source to selected target. Nothing/Null if no path is found
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public List<IVertex<Vertex>> GetPath(IVertex<Vertex> target) {

            List<IVertex<Vertex>> path = new List<IVertex<Vertex>>();
            IVertex<Vertex> _step = target;

            if (!Predecessors.ContainsKey(_step)) {
                return null;
            }

            path.Add(_step);

            while (Predecessors.ContainsKey(_step)) {
                _step = Predecessors[_step];
                path.Add(_step);
            }

            path.Reverse();
            return path;
        }

        /// <summary>
        /// Returns the distance  of a path of nodes. If the path is the shortest one (calculated with dijkstra), then it is the
        /// shortest distance between source and target
        /// </summary>
        /// <param name="Path">Path to calculate the distance of. Usually is:
        /// [Pseudocode]
        /// graph.Execute(SourceNode)
        /// MinDistanceBetweenSourceAndTarget = GetPath(TargetNode)</param>
        /// <returns>Returns the path distance. If path is null, returns -1</returns>
        public double GetPathDistance(List<IVertex<Vertex>> Path) {

            if (Path == null) return -1;

            if (Path.Count == 1) {
                return 0;
            }

            double d = 0;

            for (int x = Path.Count - 1; x >= 0; x--) {

                //Finished path
                if (x == 0) break;

                foreach (IEdge<Edge> edge in graph.getEdges()) {
                    List<IVertex<Vertex>> endpoints = graph.getEndpoints(edge);
                    if (endpoints[1].Equals(Path[x]) && endpoints[0].Equals(Path[x - 1])) {
                        d += edge.getWeight();
                        continue;
                    }
                }
            }

            return d;
        }
    }
}
