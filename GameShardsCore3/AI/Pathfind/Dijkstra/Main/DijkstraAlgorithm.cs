using GameShardsCore3.AI.Pathfind.Dijkstra.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Attributes;
using static GameShardsCore3.Core.LibLanguage.LibLanguageManager;

namespace GameShardsCore3.AI.Pathfind.Dijkstra.Main {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 1)]
    /// <summary>
    /// Class which computes the Dijkstra algorithm on a Graph
    /// </summary>
    public class DijkstraAlgorithm {

        public List<Node> nodes { get; }
        public List<Edge> edges { get; }
        private HashSet<Node> SettledNodes;
        private HashSet<Node> UnsettledNodes;
        private Dictionary<Node, Node> Predecessors;
        private Dictionary<Node, double> Distance;
        private List<Node> AdjacentNodes;

        public DijkstraAlgorithm(Graph graph) {
            nodes = graph.Vertexes;
            edges = graph.Edges;
        }

        [Tested()]
        public void Execute(Node Source) {

            //Creation of new HashSets
            SettledNodes = new HashSet<Node>();
            UnsettledNodes = new HashSet<Node>();
            Distance = new Dictionary<Node, double>();
            Predecessors = new Dictionary<Node, Node>();
            AdjacentNodes = new List<Node>();

            //Setup
            Distance.Add(Source, 0);
            UnsettledNodes.Add(Source);

            while (UnsettledNodes.Count > 0) {
                Node node = GetMinimum(UnsettledNodes);
                SettledNodes.Add(node);
                UnsettledNodes.Remove(node);
                FindMinimalDistances(node);
            }

        }


        private void FindMinimalDistances(Node node) {
            AdjacentNodes.Clear();
            AdjacentNodes.AddRange(GetNeighbors(node));

            foreach (Node target in AdjacentNodes) {

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

        private double GetDistance(Node node, Node target) {
            foreach (Edge edge in edges) {
                if (edge.Source.Equals(node) && edge.Destination.Equals(target)) {
                    return edge.Weight;
                }
            }
            throw new Exception(LangManager.GetString("exception_graph_structure", CurrentCulture));
        }

        private List<Node> GetNeighbors(Node node) {
            List<Node> neighbors = new List<Node>();
            foreach (Edge edge in edges) {
                if (edge.Source.Equals(node) && !IsSettled(edge.Destination)) {
                    neighbors.Add(edge.Destination);
                }
            }
            return neighbors;
        }

        private Node GetMinimum(ISet<Node> vertexes) {
            Node minimum = null;
            foreach (Node vertex in vertexes) {
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

        private bool IsSettled(Node vertex) {
            return SettledNodes.Contains(vertex);
        }

        private double GetShortestDistance(Node destination) {
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
        public List<Node> GetPath(Node target) {

            List<Node> path = new List<Node>();
            Node _step = target;

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
        public double GetPathDistance(List<Node> Path) {

            if (Path == null) return -1;

            if (Path.Count == 1) {
                return 0;
            }

            double d = 0;

            for (int x = Path.Count - 1; x >= 0; x--) {

                //Finished path
                if (x == 0) break;

                foreach (Edge edge in edges) {
                    if (edge.Destination.Equals(Path[x]) && edge.Source.Equals(Path[x - 1])) {
                        d += edge.Weight;
                        continue;
                    }
                }
            }

            return d;
        }
    }
}
