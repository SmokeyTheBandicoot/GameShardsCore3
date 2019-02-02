using GameShardsCore3.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.AI.Pathfind.Dijkstra.Common {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1,0,0)]
    /// <summary>
    /// Class which contains info about Graph events
    /// </summary>
    public class GraphEventArgs : EventArgs {

        public GraphInvalidationReason InvalidationReason { get; set; }

        public GraphEventArgs(GraphInvalidationReason reason) {
            this.InvalidationReason = reason;
        }

        public enum GraphInvalidationReason {
            OnNodes,
            OnEdges
        }
    }
}
