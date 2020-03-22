using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.DataStructures.Graph {
    
    public interface IGraph<Vertex, Edge> {

        public int getVertexCount();
        public int getEdgeCount();

        public IEnumerable<IVertex<Vertex>> getVertices();
        public IEnumerable<IEdge<Edge>> getEdges();
        public IEdge<Edge> getEdge(IVertex<Vertex> source, IVertex<Vertex> destination, bool directedSearch = true);

        public int inDegree(IVertex<Vertex> v);
        public int outDegree(IVertex<Vertex> v);

        public IEnumerable<IEdge<Edge>> incomingEdges(IVertex<Vertex> vertex);
        public IEnumerable<IEdge<Edge>> outgoingEdges(IVertex<Vertex> vertex);

        public List<IVertex<Vertex>> getEndpoints(IEdge<Edge> edge);
        public IVertex<Vertex> getOpposite(IVertex<Vertex> source, IEdge<Edge> edge);

    }
}
