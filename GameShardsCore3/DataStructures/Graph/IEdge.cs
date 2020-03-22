using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.DataStructures.Graph {
    
    public interface IEdge<Edge> {

        public Edge getElement();

        public double getWeight();

    }
}
