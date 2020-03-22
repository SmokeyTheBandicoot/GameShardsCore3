using GameShardsCore3.Physics.Measurement.UnitsOfMeasurement;

namespace GameShardsCore3.Physics.Measurement.Measures {
    public class Time : Measure {
        public Time(TimeUnit u, double v) : base(value: v, scale: u) { }
    }
}
