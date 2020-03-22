using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class AccelerationUnit : UnitOfMeasure {

        public AccelerationUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public AccelerationUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static AccelerationUnit MeterPerSquareSecond {
            get {
                return new AccelerationUnit("MeterPerSquareSecond", 1, new Dictionary<UnitOfMeasure, int>() { { LengthUnit.Meter, 1 }, { TimeUnit.Second, -2 } });
            }
        }


        public static AccelerationUnit Gal {
            get {
                return new AccelerationUnit("Gal", 100, "Gal");
            }
        }

        public static AccelerationUnit Galileo {
            get {
                return new AccelerationUnit("Galileo", 100, "Gal");
            }
        }

        public static AccelerationUnit MilePerSquareSecond {
            get {
                return new AccelerationUnit("MilePerSquareSecond", 0.0006213711922373, new Dictionary<UnitOfMeasure, int>() { { LengthUnit.Mile, 1 }, { TimeUnit.Second, -2 } });
            }
        }

        public static AccelerationUnit YardPerSquareSecond {
            get {
                return new AccelerationUnit("YardPerSquareSecond", 1.093613298338, new Dictionary<UnitOfMeasure, int>() { { LengthUnit.Yard, 1 }, { TimeUnit.Second, -2 } });
            }
        }

        public static AccelerationUnit FootPerSquareSecond {
            get {
                return new AccelerationUnit("FootPerSquareSecond", 3.280839895013, new Dictionary<UnitOfMeasure, int>() { { LengthUnit.Foot, 1 }, { TimeUnit.Second, -2 } });
            }
        }

        public static AccelerationUnit InchPerSquareSecond {
            get {
                return new AccelerationUnit("InchPerSquareSecond", 39.37007874016, new Dictionary<UnitOfMeasure, int>() { { LengthUnit.Inch, 1 }, { TimeUnit.Second, -2 } });
            }
        }

        public static AccelerationUnit AccelerationOfGravity {
            get {
                return new AccelerationUnit("AccelerationOfGravity", 0.1019716212978, "g");
            }
        }

        public static AccelerationUnit AccelerationOfFreeFallSun {
            get {
                return new AccelerationUnit("AccelerationOfFreeFallSun", 0.003649664327051, "gSUN");
            }
        }

        public static AccelerationUnit AccelerationOfFreeFallMercury {
            get {
                return new AccelerationUnit("AccelerationOfFreeFallMercury", 0.2683463718363, "gMER");
            }
        }

        public static AccelerationUnit AccelerationOfFreeFallVenus {
            get {
                return new AccelerationUnit("AccelerationOfFreeFallVenus", 0.1128004660374, "gVEN");
            }
        }

        public static AccelerationUnit AccelerationOfFreeFallMoon {
            get {
                return new AccelerationUnit("AccelerationOfFreeFallMoon", 0.6165152436384, "gMON");
            }
        }

        public static AccelerationUnit AccelerationOfFreeFallMars {
            get {
                return new AccelerationUnit("AccelerationOfFreeFallMars", 0.2712011204729, "gMAR");
            }
        }

        public static AccelerationUnit AccelerationOfFreeFallJupiter {
            get {
                return new AccelerationUnit("AccelerationOfFreeFallJupiter", 0.04033687551337, "gJUP");
            }
        }

        public static AccelerationUnit AccelerationOfFreeFallSaturn {
            get {
                return new AccelerationUnit("AccelerationOfFreeFallSaturn", 0.09574800121858, "gSAT");
            }
        }

        public static AccelerationUnit AccelerationOfFreeFallUranus {
            get {
                return new AccelerationUnit("AccelerationOfFreeFallUranus", 0.1150921233609, "gURA");
            }
        }

        public static AccelerationUnit AccelerationOfFreeFallNeptune {
            get {
                return new AccelerationUnit("AccelerationOfFreeFallNeptune", 0.0894487906121, "gNEP");
            }
        }

        public static AccelerationUnit AccelerationOfFreeFallPluto {
            get {
                return new AccelerationUnit("AccelerationOfFreeFallPluto", 1.521964496982, "gPLU");
            }
        }

        public static AccelerationUnit AccelerationOfFreeFallHaumea {
            get {
                return new AccelerationUnit("AccelerationOfFreeFallHaumea", 1.586225572682, "gHAU");
            }
        }

    }
}