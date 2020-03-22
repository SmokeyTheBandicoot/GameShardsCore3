using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class ElectricConductanceUnit : UnitOfMeasure {
        public ElectricConductanceUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public ElectricConductanceUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static ElectricConductanceUnit Mho {
            get {
                return new ElectricConductanceUnit("Mho", 1, "℧"); // the symbol is ℧, an upside-down omega (omega is symbol of resistance). Alternatively: Ω^-1
            }
        }

        public static ElectricConductanceUnit Siemen {
            get {
                return new ElectricConductanceUnit("Siemen", 1, "S");
            }
        }

        public static ElectricConductanceUnit AmpereVolt {
            get {
                return new ElectricConductanceUnit("AmpereVolt", 1, new Dictionary<UnitOfMeasure, int> { { ElectricCurrentUnit.Ampere, 1 } , { ElectricVoltageUnit.Volt, 1 } });
            }
        }

        public static ElectricConductanceUnit GemMho {
            get { 
                return new ElectricConductanceUnit("GemMho", 1000000, "Gem℧");
            }
        }

        public static ElectricConductanceUnit StatMho {
            get {
                return new ElectricConductanceUnit("StatMho", 899000000000, "stat℧");
            }
        }

        public static ElectricConductanceUnit QuantizedHallConductance {
            get {
                return new ElectricConductanceUnit("QuantizedHallConductance", 25812.80562652, "QHC℧");
            }
        }
    }
}
