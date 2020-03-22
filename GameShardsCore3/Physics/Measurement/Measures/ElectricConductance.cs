using GameShardsCore3.Physics.Measurement.UnitsOfMeasurement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.Measures {
    public class ElectricConductance : Measure {
        public ElectricConductance(double v, ElectricConductanceUnit u) : base(v, u) {
        }
    }
}
