using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class PlaneAngleUnit : UnitOfMeasure {
        public PlaneAngleUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public PlaneAngleUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static PlaneAngleUnit Degree {
            get {
                return new PlaneAngleUnit("Degree", 1, "°");
            }
        }

        public static PlaneAngleUnit Radiant {
            get {
                return new PlaneAngleUnit("Radiant", Math.PI / 180, "rad");
            }
        }

        public static PlaneAngleUnit CentesimalDegree {
            get {
                return new PlaneAngleUnit("CentesimalDegree", 1.1111111111111112, "grad");
            }
        }

        public static PlaneAngleUnit ArcMinute {
            get {
                return new PlaneAngleUnit("ArcMinute", 60, "'");
            }
        }

        public static PlaneAngleUnit ArcSecond {
            get {
                return new PlaneAngleUnit("ArcSecond", 3600, "\"");
            }
        }

        public static PlaneAngleUnit Revolution {
            get {
                return new PlaneAngleUnit("Revolution", 1 / (double)360, "rev");
            }
        }

        public static PlaneAngleUnit Circle {
            get {
                return new PlaneAngleUnit("Circle", 1 / (double)360, "circle");
            }
        }

        public static PlaneAngleUnit Grad {
            get {
                return new PlaneAngleUnit("Grad", 1.111111111111, "grad"); // Same as centesimal degrees
            }
        }

        public static PlaneAngleUnit Gon {
            get {
                return new PlaneAngleUnit("Gon", 1.111111111111, "gon"); // Same as centesimal degrees
            }
        }

        public static PlaneAngleUnit Sign {
            get {
                return new PlaneAngleUnit("Sign", 0.03333333333333, "sign");
            }
        }

        public static PlaneAngleUnit Mil {
            get {
                return new PlaneAngleUnit("Mil", 17.77777777778, "mil");
            }
        }

        public static PlaneAngleUnit Turn {
            get {
                return new PlaneAngleUnit("Turn", 1 / (double)360, "turn");
            }
        }

        public static PlaneAngleUnit Quadran {
            get {
                return new PlaneAngleUnit("Quadran", 0.01111111111111, "quad");
            }
        }

        public static PlaneAngleUnit RightAngle {
            get {
                return new PlaneAngleUnit("RightAngle", 0.01111111111111, "rightangle");
            }
        }

        public static PlaneAngleUnit Sextant {
            get {
                return new PlaneAngleUnit("Sextant", 0.01666666666667, "sextant");
            }
        }
    }
}
