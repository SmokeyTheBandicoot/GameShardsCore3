using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.DataStructures.PriorityQueue;
using GameShardsCore3.DataStructures.Graph;

namespace GameShardsCore3.Algorithms.DataStructures.Graph.MinimumSpanningTree {
    
    public class PrimJarnikAlgorithm<Vertex, Edge> {

        Dictionary<Vertex, double> d;
        List<Edge> tree;
        AdaptableHeapPriorityQueue<,> pq;
        Dictionary<Vertex, AdaptableHeapPriorityQueue<>.Locator> pqlocator;

        public void Execute(IGraph<Vertex, Edge> graph) {

            foreach (Vertex v in graph.getVertices()) {
                if (d.Count == 0)
                    d[v] = 0;
                else
                    d[v] = double.PositiveInfinity;
            }

            while (!pq.IsEmpty()) {
                (var key, var value) = pq.RemoveMin();
                (var u, var edge) = value;
                pqlocator.Remove(u);

                if (edge != null)
                    tree.Add(edge);
                foreach (Edge link in graph.incomingEdges(u)) {
                    Vertex v = graph.getOpposite(u, link);
                }
            }

        }
        


    }
}
