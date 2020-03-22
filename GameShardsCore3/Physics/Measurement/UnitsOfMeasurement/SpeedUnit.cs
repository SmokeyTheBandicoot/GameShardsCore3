using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class SpeedUnit : UnitOfMeasure {

        public SpeedUnit(string name, double ratio, string symbol) : base(name: name, ratio: ratio, symbol: symbol) {
        }

        public SpeedUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(name: name, ratio: ratio, dimension: dimension) {
        }

        public static SpeedUnit MeterPerSecond {
            get {
                return new SpeedUnit("MeterPerSecond", 1, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static SpeedUnit MeterPerMinute {
            get {
                return new SpeedUnit("MeterPerMinute", 60, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static SpeedUnit MeterPerHour {
            get {
                return new SpeedUnit("MeterPerHour", 3600, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 1 }, { TimeUnit.Hour, -1 } });
            }
        }

        public static SpeedUnit KilometerPerHour {
            get {
                return new SpeedUnit("KilometerPerHour", 3.6, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Kilometer, 1 }, { TimeUnit.Hour, -1 } });
            }
        }

        public static SpeedUnit KilometerPerMinute {
            get {
                return new SpeedUnit("KilometerPerMinute", 0.06, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Kilometer, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static SpeedUnit KilometerPerSecond {
            get {
                return new SpeedUnit("KilometerPerSecond", 0.001, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Kilometer, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static SpeedUnit FootPerHour {
            get {
                return new SpeedUnit("FootPerHour", 11811.02362205, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Foot, 1 }, { TimeUnit.Hour, -1 } });
            }
        }

        public static SpeedUnit FootPerMinute {
            get {
                return new SpeedUnit("FootPerMinute", 196.8503937008, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Foot, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static SpeedUnit FootPerSecond {
            get {
                return new SpeedUnit("FootPerSecond", 3.280839895013, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Foot, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static SpeedUnit YardPerHour {
            get {
                return new SpeedUnit("YardPerHour", 3937.007874016, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Yard, 1 }, { TimeUnit.Hour, -1 } });
            }
        }

        public static SpeedUnit YardPerMinute {
            get {
                return new SpeedUnit("YardPerMinute", 65.61679790026, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Yard, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static SpeedUnit YardPerSecond {
            get {
                return new SpeedUnit("YardPerSecond", 1.093613298338, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Yard, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static SpeedUnit MilePerHour {
            get {
                return new SpeedUnit("MilePerHour", 2.236936292054, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Mile, 1 }, { TimeUnit.Hour, -1 } });
            }
        }

        public static SpeedUnit MilePerMinute {
            get {
                return new SpeedUnit("MilePerMinute", 0.03728227153424, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Mile, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static SpeedUnit MilePerSecond {
            get {
                return new SpeedUnit("MilePerSecond", 0.0006213711922373, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Mile, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static SpeedUnit Knot {
            get {
                return new SpeedUnit("Knot", 1.943844492441, "kt");
            }
        }

        public static SpeedUnit UKKnot {
            get {
                return new SpeedUnit("Knot", 1.942602569416, "UKkt");
            }
        }

        public static SpeedUnit SpeedOfLight {
            get {
                return new SpeedUnit("SpeedOfLight", 0.000000003335640951982, "c");
            }
        }

        public static SpeedUnit FirstCosmicVelocity {
            get {
                return new SpeedUnit("FirstCosmicVelocity", 0.000126582278481, "fcv");
            }
        }

        public static SpeedUnit SecondCosmicVelocity {
            get {
                return new SpeedUnit("SecondCosmicVelocity", 0.00008928571428571, "scv");
            }
        }

        public static SpeedUnit ThirdCosmicVelocity {
            get {
                return new SpeedUnit("ThirdCosmicVelocity", 0.00005998800239952, "tcv");
            }
        }

        public static SpeedUnit EarthVelocity {
            get {
                return new SpeedUnit("EarthVelocity", 0.00003359650596338, "V⊕");
            }
        }

        public static SpeedUnit SpeedOfSoundWater {
            get {
                return new SpeedUnit("SpeedOfSoundWater", 0.0006744452687665, "vsH2O");
            }
        }

        public static SpeedUnit SpeedOfSoundAir {
            get {
                return new SpeedUnit("SpeedOfSoundAir", 0.0029154518950437317, "vsAIR");
            }
        }

        public static SpeedUnit MachSTP {
            get {
                return new SpeedUnit("MachSTP", 0.00291036088475, "MachSTP");
            }
        }

        public static SpeedUnit Mach {
            get {
                return new SpeedUnit("Mach", 0.0033892974122, "Mach");
            }
        }

    }
}
