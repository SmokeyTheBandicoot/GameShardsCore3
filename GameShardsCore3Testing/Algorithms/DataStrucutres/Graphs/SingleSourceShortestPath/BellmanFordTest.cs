using System;
using System.Windows.Forms;
using GameShardsCore3.DataStructures.Graph;
using GameShardsCore3.DataStructures.Tree;
using GameShardsCore3.Algorithms.DataStructures.Graphs.SingleSourceShortestPath;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Collections.Generic;

namespace GameShardsCore3Testing.Algorithms.DataStrucutres.Graphs.SingleSourceShortestPath {

    [TestClass]
    public class BellmanFordTest {

        public BellmanFordTest() {
            //
            // TODO: aggiungere qui la logica del costruttore
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Ottiene o imposta il contesto del test che fornisce
        ///le informazioni e le funzionalità per l'esecuzione del test corrente.
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void ExecuteTest() {
            IGraph<string, string> graph = new AdjacencyMapGraph<string, string>();
            IVertex<string> A = graph.addVertex("A");
            IVertex<string> B = graph.addVertex("B");
            IVertex<string> C = graph.addVertex("C");
            IVertex<string> D = graph.addVertex("D");
            IVertex<string> E = graph.addVertex("E");
            IVertex<string> F = graph.addVertex("F");
            IVertex<string> G = graph.addVertex("G");
            IVertex<string> H = graph.addVertex("H");
            IVertex<string> I = graph.addVertex("I");
            IVertex<string> J = graph.addVertex("J");
            IVertex<string> K = graph.addVertex("K");
            IVertex<string> L = graph.addVertex("L");
            IVertex<string> M = graph.addVertex("M");
            IVertex<string> N = graph.addVertex("N");

            graph.addEdge(A, B, "1", 3);
            graph.addEdge(C, B, "2", 3);
            graph.addEdge(A, E, "3", 2);
            graph.addEdge(A, I, "4", 5);
            graph.addEdge(I, E, "5", 3);
            graph.addEdge(E, D, "6", 4);
            graph.addEdge(D, C, "7", 2);
            graph.addEdge(C, G, "8", 5);
            graph.addEdge(D, F, "9", 3);
            graph.addEdge(F, G, "10", 3);
            graph.addEdge(G, H, "11", 4);
            graph.addEdge(H, F, "12", 2);
            graph.addEdge(E, M, "13", 1);
            graph.addEdge(E, J, "14", 5);
            graph.addEdge(M, N, "15", 5);
            graph.addEdge(M, J, "16", 2);
            graph.addEdge(M, F, "17", 3);
            graph.addEdge(M, K, "18", 2);
            graph.addEdge(J, K, "19", 3);
            graph.addEdge(K, L, "20", 1);

            BellmanFordAlgorithm<string, string> d = new BellmanFordAlgorithm<string, string>(graph);
            d.Execute(A);

            StringBuilder sb = new StringBuilder();
            foreach (IVertex<string> v in d.getPredecessors().Keys) {
                if (d.getPredecessors()[v] != null)
                    sb.Append(v.ToString() + " from " + d.getPredecessors()[v].ToString() + Environment.NewLine);
                else
                    sb.Append(v.ToString() + " from <null> (start)" + Environment.NewLine);
            }

            var tree = d.getSpanningForest()[0];
            var pos = tree.PositionContaining(K);
            // MessageBox.Show(pos.ToString());
            List<IVertex<string>> path = new List<IVertex<string>>();

            foreach (var p in tree.PathToRoot(pos)) {
                path.Add(p.Element());
            }
            // MessageBox.Show(path.Count.ToString());

            string res = "";

            foreach (var vert in path) {
                res += vert.ToString() + " -> ";
            }

            /*
            MessageBox.Show(res.ToString());
            MessageBox.Show(sb.ToString());
            MessageBox.Show(d.getSpanningForest()[0].ToString());
            */
        }
    }
}
