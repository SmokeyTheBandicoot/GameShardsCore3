using GameShardsCore3.Physics.Measurement.Measures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class TemperatureUnit : UnitOfMeasure {

        public TemperatureUnit(string name, double ratio, string symbol, double offset) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public TemperatureUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension, double offset) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public double offset { get; }

        public static TemperatureUnit Kelvin {
            get {
                return new TemperatureUnit("Kelvin", 1, "K", 0);
            }
        }

        public static TemperatureUnit Celsius {
            get {
                return new TemperatureUnit("Celsius", 1, "°C", -273.15);
            }
        }

        public static TemperatureUnit Fahrenheit {
            get {
                return new TemperatureUnit("Fahrenheit", 5 / (double)9, "°F", -459.67);
            }
        }

        public static TemperatureUnit Rankine {
            get {
                return new TemperatureUnit("Rankine", 5 / (double)9, "°R", 0);
            }
        }

        public static TemperatureUnit Reaumur {
            get {
                return new TemperatureUnit("Reaumur", 5 / (double)4, "°r", -218.52);
            }
        }

        public static TemperatureUnit PlanckTemperature {
            get {
                return new TemperatureUnit("PlanckTemperature", 7.058E-33, "Tp", 0);
            }
        }

        public static Temperature AmbientTemperature(TemperatureUnit TemperatureUnit) {
            return UnitConverter.ConvertMeasure(new Temperature(20, Celsius), TemperatureUnit);
        }
    }
}
