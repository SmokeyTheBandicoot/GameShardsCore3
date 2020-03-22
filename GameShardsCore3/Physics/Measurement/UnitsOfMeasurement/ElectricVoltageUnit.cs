using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {

    public class ElectricVoltageUnit : UnitOfMeasure {
        public ElectricVoltageUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public ElectricVoltageUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static ElectricCurrentUnit Volt {
            get {
                return new ElectricCurrentUnit("Volt", 1, "V");
            }
        }
    }
}
