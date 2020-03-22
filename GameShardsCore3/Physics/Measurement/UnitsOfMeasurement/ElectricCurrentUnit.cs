using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {

    public class ElectricCurrentUnit : UnitOfMeasure {

        public ElectricCurrentUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public ElectricCurrentUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static ElectricCurrentUnit Ampere {
            get {
                return new ElectricCurrentUnit("Ampere", 1, "A");
            }
        }

        public static ElectricCurrentUnit MilliAmpere {
            get {
                return new ElectricCurrentUnit("MilliAmpere", 1000, "mA");
            }
        }

        public static ElectricCurrentUnit Biot {
            get {
                return new ElectricCurrentUnit("Biot", 0.1, "Bi");
            }
        }

        public static ElectricCurrentUnit StatAmpere {
            get {
                return new ElectricCurrentUnit("StatAmpere", 2997924536.843, "statA");
            }
        }

        public static ElectricCurrentUnit PlanckCurrent {
            get {
                return new ElectricCurrentUnit("PlanckCurrent", 2.874471815804E-26, "PC");
            }
        }
    }
}
