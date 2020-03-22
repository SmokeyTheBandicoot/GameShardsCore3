using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Physics.Measurement.UnitsOfMeasurement;
using GameShardsCore3.Physics.Measurement;

namespace GameShardsCore3.Physics.Measurement {
    public class Mass : Measure {
        public Mass(double value, MassUnit scale) : base(value: value, scale: scale) { }
    }
}
