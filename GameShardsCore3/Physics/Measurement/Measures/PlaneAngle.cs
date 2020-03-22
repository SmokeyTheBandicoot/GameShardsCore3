using GameShardsCore3.Physics.Measurement.UnitsOfMeasurement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.Measures {
    public class PlaneAngle : Measure {
        public PlaneAngle(double v, PlaneAngleUnit u) : base(value: v, scale: u) { }


        /// <summary>
        /// Returns null angle in the specified unit
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static PlaneAngle getNullAngle(PlaneAngleUnit unit) {
            return new PlaneAngle(0, unit);
        }

        /// <summary>
        /// returns right angle in the specified unit (quarter of circle)
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static PlaneAngle GetRightAngle(PlaneAngleUnit unit) {
            return UnitConverter.ConvertMeasure(new PlaneAngle(90, PlaneAngleUnit.Degree), unit);
        }

        /// <summary>
        /// returns straight angle in the specified unit (half circle)
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static PlaneAngle GetStraightAngle(PlaneAngleUnit unit) {
            return UnitConverter.ConvertMeasure(new PlaneAngle(180, PlaneAngleUnit.Degree), unit);
        }

        /// <summary>
        /// returns full angle in the specified unit (full circle)
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public static PlaneAngle GetFullAngle(PlaneAngleUnit unit) {
            return UnitConverter.ConvertMeasure(new PlaneAngle(360, PlaneAngleUnit.Degree), unit);
        }

        /// <summary>
        /// Returns if the angle is Null
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static bool IsNull(PlaneAngle angle) {
            return angle.value == 0;
        }


        /// <summary>
        /// Returns if the angle is Acute
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static bool IsAcute(PlaneAngle angle) {
            double val = UnitConverter.ConvertMeasure(angle, PlaneAngleUnit.Degree).value % 360;
            return val > 0 & val < 90;
        }

        /// <summary>
        /// Returns if the angle is Right
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static bool IsRight(PlaneAngle angle) {
            return (UnitConverter.ConvertMeasure(angle, PlaneAngleUnit.Degree).value % 360) == 90;
        }

        /// <summary>
        /// Returns if the angle is obtuse (Greater than Right angle but smaller than Straight)
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static bool IsObtuse(PlaneAngle angle) {
            double val = UnitConverter.ConvertMeasure(angle, PlaneAngleUnit.Degree).value % 360;
            return val > 90 & val < 180;
        }

        /// <summary>
        /// Returns if the angle is Straight
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static bool IsStraight(PlaneAngle angle) {
            return UnitConverter.ConvertMeasure(angle, PlaneAngleUnit.Degree).value % 360 == 180;
        }

        /// <summary>
        /// Returns if the angle is obtuse (Greater than Right angle but smaller than Straight)
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static bool IsReflex(PlaneAngle angle) {
            double val = UnitConverter.ConvertMeasure(angle, PlaneAngleUnit.Degree).value % 360;
            return val > 180 & val < 360;
        }

        /// <summary>
        /// Returns if the angle is Full angle
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static bool IsFullAngle(PlaneAngle angle) {
            return UnitConverter.ConvertMeasure(angle, PlaneAngleUnit.Degree).value % 360 == 0 && !(angle.value == 0);
        }

        /// <summary>
        /// Returns if the angle is Greater than Full angle
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static bool IsMoreThanFullAngle(PlaneAngle angle) {
            return UnitConverter.ConvertMeasure(angle, PlaneAngleUnit.Degree).value > 360;
        }
    }
}
