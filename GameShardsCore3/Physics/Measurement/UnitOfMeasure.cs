using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Symbol for Earth:            

// Symbol for SUN:              ʘ
// Symbol for Multiplication:   
// Symbol for Square:           
// Symbol for Cubic:            

namespace GameShardsCore3.Physics.Measurement {
    public abstract class UnitOfMeasure {

        internal double ratio { get; }
        internal string name { get; }
        internal string symbol { get; }
        internal Dictionary<UnitOfMeasure, int> dimension { get; }

        protected UnitOfMeasure(double ratio, string name, Dictionary<UnitOfMeasure, int> dimension) {
            this.ratio = ratio;
            this.name = name;
            this.symbol = null;
            this.dimension = dimension;
        }

        protected UnitOfMeasure(double ratio, string name, string symbol) {
            this.ratio = ratio;
            this.name = name;
            this.symbol = symbol;
            this.dimension = null;
        }

        public bool isPrimitive() {
            return dimension != null;
        }

    }
}
