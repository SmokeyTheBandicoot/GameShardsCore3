using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Physics.Measurement.UnitsOfMeasurement;

namespace GameShardsCore3.Physics.Measurement.Measures {
    public class Acceleration : Measure {
        public Acceleration(double value, UnitOfMeasure scale) : base(value, scale) {
        }
    }
}
