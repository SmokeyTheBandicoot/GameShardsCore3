using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement {
    public abstract class Measure {
        internal double value { get; set; }
        internal UnitOfMeasure scale { get; }

        public Measure(double value, UnitOfMeasure scale) {
            this.value = value;
            this.scale = scale;
        }

        public Measure() {
            value = 0.0;
            scale = null;
        }

    }
}
