using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class CoefficientOfThermalExpansionUnit : UnitOfMeasure {

        public CoefficientOfThermalExpansionUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public CoefficientOfThermalExpansionUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static CoefficientOfThermalExpansionUnit ReciprocalKelvin {
            get {
                return new CoefficientOfThermalExpansionUnit("ReciprocalKelvin", 1, new Dictionary<UnitOfMeasure, int> { { TemperatureUnit.Kelvin, -1} });
            }
        }

        public static CoefficientOfThermalExpansionUnit ReciprocalCelsius {
            get {
                return new CoefficientOfThermalExpansionUnit("ReciprocalKelvin", 1, new Dictionary<UnitOfMeasure, int> { { TemperatureUnit.Celsius, -1 } });
            }
        }

        public static CoefficientOfThermalExpansionUnit ReciprocalFahrenheit {
            get {
                return new CoefficientOfThermalExpansionUnit("ReciprocalFahrenheit", 5 / (double)9, new Dictionary<UnitOfMeasure, int> { { TemperatureUnit.Fahrenheit, -1 } });
            }
        }

        public static CoefficientOfThermalExpansionUnit ReciprocalRankine {
            get {
                return new CoefficientOfThermalExpansionUnit("ReciprocalRankine", 5 / (double)9, new Dictionary<UnitOfMeasure, int> { { TemperatureUnit.Rankine, -1 } });
            }
        }

        public static CoefficientOfThermalExpansionUnit ReciprocalReaumur {
            get {
                return new CoefficientOfThermalExpansionUnit("ReciprocalReaumur", 1.25, new Dictionary<UnitOfMeasure, int> { { TemperatureUnit.Reaumur, -1 } });
            }
        }
    }
}
