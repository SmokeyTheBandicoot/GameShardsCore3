using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Exceptions;
using GameShardsCore3.Attributes;
using GameShardsCore3.Physics.Measurement.Measures;
using GameShardsCore3.Physics.Measurement.UnitsOfMeasurement;

namespace GameShardsCore3.Physics.Measurement {
    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 0)]
    public sealed class UnitConverter {

        /// <summary>
        /// Dynamically converts a unit of measurement into another type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="measure"></param>
        /// <param name="targetUnit"></param>
        /// <returns></returns>
        [ToTest()]
        public static T ConvertMeasure<T, K>(T measure, K targetUnit) where K: UnitOfMeasure where T: Measure {

            if (measure.scale.GetType() != targetUnit.GetType()) {
                // Conversion is not possible
                throw new IncompatibleArgumentsException("Source Unit of Measurement and Target Unit of Measurement must be of the same Measure type");
            }

            // Use reflection to automatically create an instance of T which has the new converted value as value, and targetUnit as new Unit of Measurement
            return (T)Activator.CreateInstance(typeof(T), measure.value * (targetUnit.ratio / measure.scale.ratio), targetUnit);
        }

        [ToTest()]
        public static Temperature ConvertMeasure(Temperature temp, TemperatureUnit goal) {
            
            // Converts first temperature to Kelvin (default)
            var Kelvin = new Temperature((temp.value - ((TemperatureUnit)temp.scale).offset) * temp.scale.ratio, goal);

            // If kelvin is goal, then return kelvin
            if (goal.name == TemperatureUnit.Kelvin.name)
                return Kelvin;

            // Else convert the temperature to the goal TemperatureUnit (TemperatureScale)
            return new Temperature(Kelvin.value * (Kelvin.scale.ratio / goal.ratio) + goal.offset, goal);
        }

    }
}
