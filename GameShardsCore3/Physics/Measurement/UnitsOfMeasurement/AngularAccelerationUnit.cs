using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class AngularAccelerationUnit : UnitOfMeasure {
        public AngularAccelerationUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public AngularAccelerationUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static AngularAccelerationUnit RadiantPerSquaredSecond {
            get {
                return new AngularAccelerationUnit("RadiantPerSquaredSecond", 1, new Dictionary<UnitOfMeasure, int> { {PlaneAngleUnit.Radiant, 1 }, { TimeUnit.Second, -2 } });
            }
        }

        public static AngularAccelerationUnit RadiantPerSquaredMinute {
            get {
                return new AngularAccelerationUnit("RadiantPerSquaredMinute", 3600, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Radiant, 1 }, { TimeUnit.Minute, -2 } });
            }
        }

        public static AngularAccelerationUnit RevolutionPerSquaredSecond {
            get {
                return new AngularAccelerationUnit("RevolutionPerSquaredSecond", 0.1591549431, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Revolution, 1 }, { TimeUnit.Second, -2 } });
            }
        }

        public static AngularAccelerationUnit RevolutionPerMinutePerSecond {
            get {
                return new AngularAccelerationUnit("RevolutionPerMinutePerSecond", 9.549296586, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Revolution, 1 }, { TimeUnit.Second, -1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static AngularAccelerationUnit RevolutionPerSquaredMinute {
            get {
                return new AngularAccelerationUnit("RevolutionPerSquaredMinute", 572.9577952, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Revolution, 1 }, { TimeUnit.Minute, -2 } });
            }
        }
    }
}
