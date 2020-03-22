using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class ElectricCapacitanceUnit : UnitOfMeasure {

        public ElectricCapacitanceUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public ElectricCapacitanceUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static ElectricCapacitanceUnit Farad {
            get {
                return new ElectricCapacitanceUnit("Farad", 1, "F");
            }
        }

        public static ElectricCapacitanceUnit CoulombPerVolt {
            get {
                return new ElectricCapacitanceUnit("CoulombPerVolt", 1, "C/V");
            }
        }

        public static ElectricCapacitanceUnit EMUofCapacitance {
            get {
                return new ElectricCapacitanceUnit("EMUofCapacitance", 0.000000001, "EMUofCapacitance");
            }
        }

        public static ElectricCapacitanceUnit StatFarad {
            get {
                return new ElectricCapacitanceUnit("StatFarad", 898755178736.5, "stF");
            }
        }

        public static ElectricCapacitanceUnit AbFarad {
            get {
                return new ElectricCapacitanceUnit("AbFarad", 0.000000001, "abF");
            }
        }

        public static ElectricCapacitanceUnit ESUofCapacitance {
            get {
                return new ElectricCapacitanceUnit("ESUofCapacitance", 898755178736.5, "ESUofCapacitance");
            }
        }
    }
}
