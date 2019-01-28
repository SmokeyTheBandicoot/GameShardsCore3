using GameShardsCore3.AI.Pathfind.Dijkstra.Model;
using GameShardsCore3.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.AI.Pathfind.Dijkstra.InterfaceModel {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    public interface IEdge {

        string ID { get; set; }
        Node Source { get; set; }
        Node Destination { get; set; }
        double Weight { get; set; }
    }
}
