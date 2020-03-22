using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class AmountOfSubstanceUnit : UnitOfMeasure {
        public AmountOfSubstanceUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public AmountOfSubstanceUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static AmountOfSubstanceUnit Mole {
            get {
                return new AmountOfSubstanceUnit("Mole", 1, "mol");
            }
        }
    }
}
