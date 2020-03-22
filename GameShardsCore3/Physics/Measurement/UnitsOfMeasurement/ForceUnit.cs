using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class ForceUnit : UnitOfMeasure {

        public ForceUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public ForceUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static ForceUnit Newton {
            get {
                return new ForceUnit("Newton", 1, "N");
            }
        }

        public static ForceUnit Dyne {
            get {
                return new ForceUnit("Dyne", 100000, "dyn");
            }
        }

        public static ForceUnit JoulePerMeter {
            get {
                return new ForceUnit("JoulePerMeter", 100000, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.Joule, 1 }, { LengthUnit.Meter, 1 } });
            }
        }

        public static ForceUnit GramForce {
            get {
                return new ForceUnit("GramForce", 101.9716212978, "gf");
            }
        }

        public static ForceUnit KiloGramForce {
            get {
                return new ForceUnit("KiloGramForce", 0.1019716212978, "Kgf");
            }
        }

        public static ForceUnit ShortTonForce {
            get {
                return new ForceUnit("ShortTonForce", 0.0001124044715499, "STf");
            }
        }

        public static ForceUnit LongTonForce {
            get {
                return new ForceUnit("LongTonForce", 0.0001003611353125, "LTf");
            }
        }

        public static ForceUnit MetricTonForce {
            get {
                return new ForceUnit("MetricTonForce", 0.0001019716212978, "MTf");
            }
        }

        public static ForceUnit PoundForce {
            get {
                return new ForceUnit("PoundForce", 0.2248089431, "lbf");
            }
        }

        public static ForceUnit OunceForce {
            get {
                return new ForceUnit("OunceForce", 3.5969430896, "ozf");
            }
        }

        public static ForceUnit Poundal {
            get {
                return new ForceUnit("Poundal", 7.23301385121, "pdl");
            }
        }

        public static ForceUnit PoundFootPerSqSecond {
            get {
                return new ForceUnit("PoundFootPerSquareSecond", 7.23301385121, new Dictionary<UnitOfMeasure, int> { { MassUnit.Pound, 1 }, { LengthUnit.Foot, 1 }, {TimeUnit.Second, -2 } });
            }
        }

        public static ForceUnit Pond {
            get {
                return new ForceUnit("Pond", 101.9716212978, "p");
            }
        }

        public static ForceUnit Sthene {
            get {
                return new ForceUnit("Sthene", 0.001, "sn");
            }
        }

        public static ForceUnit GraveForce {
            get {
                return new ForceUnit("GraveForce", 0.1019716212978, "grf");
            }
        }

        public static ForceUnit AtomicUnitOfForce {
            get {
                return new ForceUnit("AtomicUnitOfForce", 12137804.11081, "a.u.f");
            }
        }

    }
}
