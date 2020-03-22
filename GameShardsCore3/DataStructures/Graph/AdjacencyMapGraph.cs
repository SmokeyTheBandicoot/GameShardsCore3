using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.DataStructures.Graph {

    public class AdjacencyMapGraph<Vertex, Edge> : IGraph<Vertex, Edge> {

        private List<IVertex<Vertex>> vertices;
        private List<IEdge<Edge>> edges;

        public AdjacencyMapGraph() {
            vertices = new List<IVertex<Vertex>>();
            edges = new List<IEdge<Edge>>();
        }

        private AdjMapGraphVertex validate(IVertex<Vertex> vertex) {
            if (!(vertex is AdjMapGraphVertex))
                throw new ArgumentException("Invalid Vertex");

            AdjMapGraphVertex vert = (AdjMapGraphVertex)vertex;

            if (vertices.Contains(vert))
                return vert;
            throw new ArgumentException("Vertex does not belong to this graph");

        }

        private AdjMapGraphEdge validate(IEdge<Edge> edge) {
            if (!(edge is AdjMapGraphEdge))
                throw new ArgumentException("Invalid Edge");

            AdjMapGraphEdge e = (AdjMapGraphEdge)edge;

            if (edges.Contains(e))
                return e;
            throw new ArgumentException("Edge does not belong to this graph");
        }

        public IVertex<Vertex> addVertex(Vertex element) {
            IVertex<Vertex> v = new AdjMapGraphVertex(element);
            vertices.Add(v);
            return v;
        }

        public IEdge<Edge> insertEdge(IVertex<Vertex> source, IVertex<Vertex> destination, Edge element, double weight, bool addInverse = false) {

            if (getEdge(source, destination) == null) {
                if (addInverse && getEdge(destination, source) != null)
                    throw new ArgumentException("Destination and source are already connected");
                else {
                    AdjMapGraphEdge edge = new AdjMapGraphEdge(source, destination, element, weight);
                    edges.Add(edge);
                    AdjMapGraphVertex s = validate(source);
                    AdjMapGraphVertex d = validate(destination);
                    s.getOutgoing().Add(destination, edge);

                    if (addInverse)
                        d.getOutgoing().Add(source, edge);

                    return edge;
                }
            } else {
                throw new ArgumentException("Source and destination are already connected");
            }
        }

        public void removeVertex(IVertex<Vertex> vertex) {
            AdjMapGraphVertex v = validate(vertex);
            foreach (IEdge<Edge> e in v.getOutgoing().Values)
                removeEdge(e);
            foreach (IEdge<Edge> e in v.getIncoming().Values)
                removeEdge(e);
            vertices.Remove(v);
        }

        public void removeEdge(IEdge<Edge> edge, bool directed = true) {

            AdjMapGraphEdge e = validate(edge);
            AdjMapGraphVertex v0 = validate(e.getEndpoints()[0]);
            AdjMapGraphVertex v1 = validate(e.getEndpoints()[1]);

            v0.getOutgoing().Remove(v1);
            v1.getIncoming().Remove(v0);

            if (!directed) {
                if (getEdge(v1, v0) == null)
                    throw new ArgumentException("Inverse edge does not exist");
                else {
                    v1.getOutgoing().Remove(v0);
                    v0.getIncoming().Remove(v1);
                }
            }

        }

        public int getVertexCount() {
            return vertices.Count;
        }

        public int getEdgeCount() {
            return edges.Count;
        }

        public IEnumerable<IVertex<Vertex>> getVertices() {
            return vertices;
        }

        public IEnumerable<IEdge<Edge>> getEdges() {
            return edges;
        }

        public IEdge<Edge> getEdge(IVertex<Vertex> source, IVertex<Vertex> destination, bool directedSearch = true) {

            AdjMapGraphVertex src = validate(source);

            if (src.getOutgoing()[destination] != null) return src.getOutgoing()[destination];

            if (directedSearch) {
                AdjMapGraphVertex dst = validate(destination);
                if (dst.getOutgoing()[source] != null) return src.getOutgoing()[source];
            }

            return null;

        }

        public List<IVertex<Vertex>> getEndpoints(IEdge<Edge> edge) {
            AdjMapGraphEdge e = validate(edge);
            return e.getEndpoints();
        }

        public IVertex<Vertex> getOpposite(IVertex<Vertex> source, IEdge<Edge> edge) {
            AdjMapGraphEdge e = validate(edge);
            List<IVertex<Vertex>> endp = e.getEndpoints();
            if (source == endp[0]) return endp[1];
            else if (source == endp[1]) return endp[0];
            else throw new ArgumentException("The Vertex does not belong to this edge");
        }

        public int inDegree(IVertex<Vertex> vertex) {
            return validate(vertex).getIncoming().Count;
        }

        public int outDegree(IVertex<Vertex> vertex) {
            return validate(vertex).getOutgoing().Count;
        }

        public IEnumerable<IEdge<Edge>> incomingEdges(IVertex<Vertex> vertex) {
            return validate(vertex).getIncoming().Values;
        }

        public IEnumerable<IEdge<Edge>> outgoingEdges(IVertex<Vertex> vertex) {
            return validate(vertex).getOutgoing().Values;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.Append("VERTICES:" + Environment.NewLine);
            foreach (IVertex<Vertex> v in vertices) {
                sb.Append("Vertex " + v.getElement() + Environment.NewLine);
            }

            sb.Append("EDGES:" + Environment.NewLine);
            foreach (IEdge<Edge> e in edges)
                if (e is AdjMapGraphEdge) {
                    AdjMapGraphEdge edge = validate(e);
                    sb.Append(edge.getEndpoints()[0].ToString() + "\t\t ----[" + e.getElement() + "]---- \t\t" + edge.getEndpoints()[1].ToString());
                }


            return sb.ToString();
        }



        public class AdjMapGraphVertex : IVertex<Vertex> {

            private Vertex element;
            private Dictionary<IVertex<Vertex>, IEdge<Edge>> incoming, outgoing;

            public AdjMapGraphVertex(Vertex element) {

                this.element = element;

                outgoing = new Dictionary<IVertex<Vertex>, IEdge<Edge>>();
                incoming = new Dictionary<IVertex<Vertex>, IEdge<Edge>>();

            }

            public Vertex getElement() {
                return element;
            }

            public IDictionary<IVertex<Vertex>, IEdge<Edge>> getIncoming() {
                return incoming;
            }

            public IDictionary<IVertex<Vertex>, IEdge<Edge>> getOutgoing() {
                return outgoing;
            }

        }

        public class AdjMapGraphEdge : IEdge<Edge> {

            private Edge element;
            private double weight;
            private List<IVertex<Vertex>> endpoints;

            public AdjMapGraphEdge(IVertex<Vertex> source, IVertex<Vertex> destination, Edge element, double weight) {
                this.element = element;
                this.weight = weight;
                endpoints = new List<IVertex<Vertex>>();
                endpoints.Add(source);
                endpoints.Add(destination);
            }

            public Edge getElement() {
                return element;
            }

            public List<IVertex<Vertex>> getEndpoints() {
                return endpoints;
            }

            public double getWeight() {
                return this.weight;
            }

        }



    }

}
