using GameShardsCore3.AI.Pathfind.Dijkstra.Model;
using GameShardsCore3.Attributes;
using System;

namespace GameShardsCore3.AI.Pathfind.Dijkstra.InterfaceModel {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    public interface INode : IEquatable<INode> {

        string Name { get; set; }
        string ID { get; set; }
        bool Equals(Object obj);

    }
}
