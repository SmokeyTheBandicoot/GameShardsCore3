using GameShardsCore3.Physics.Measurement.UnitsOfMeasurement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.Measures {
    public class Force : Measure {
        public Force(double v, ForceUnit u) : base(value: v, scale: u) { }
    }
}
