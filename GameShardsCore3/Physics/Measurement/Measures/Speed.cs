using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Physics.Measurement.UnitsOfMeasurement;

namespace GameShardsCore3.Physics.Measurement.Measures {
    public class Speed : Measure {
        public Speed(double v, SpeedUnit u) : base(value: v, scale: u) { }
    }
}
