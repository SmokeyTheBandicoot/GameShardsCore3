using GameShardsCore3.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.AI.Pathfind.Dijkstra.Model {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    /// <summary>
    /// Represents a Graph edge, which connects two nodes
    /// </summary>
    public class Edge {

        public string ID { get; set; }
        public Node Source { get; set; }
        public Node Destination { get; set; }
        public double Weight { get; set; }

        public Edge(string ID, Node Source, Node Destination, double Weight) {
            this.ID = ID;
            this.Source = Source;
            this.Destination = Destination;
            this.Weight = Weight;
        }

        public override string ToString() {
            return Source.ToString() + " --> " + Destination.ToString() + " (" + Weight.ToString() + ")";
        }

    }
}
