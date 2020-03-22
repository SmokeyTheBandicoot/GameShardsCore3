using GameShardsCore3.DataStructures.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.AI.Pathfind {

    public class BellmanFordAlgorithm<Vertex, Edge> {

        private IGraph<Vertex, Edge> graph;
        private Dictionary<IVertex<Vertex>, double> distanceMap;
        private Dictionary<IVertex<Vertex>, IVertex<Vertex>> predecessors;

        public BellmanFordAlgorithm(IGraph<Vertex, Edge> graph) {
            this.graph = graph;
            distanceMap = new Dictionary<IVertex<Vertex>, double>();
            predecessors = new Dictionary<IVertex<Vertex>, IVertex<Vertex>>();
        }

        public bool Execute(IVertex<Vertex> source) {

            distanceMap.Clear();
            predecessors.Clear();

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
