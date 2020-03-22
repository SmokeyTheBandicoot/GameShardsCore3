using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class DynamicViscosityUnit : UnitOfMeasure {

        public DynamicViscosityUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public DynamicViscosityUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static DynamicViscosityUnit PascalSecond {
            get {
                return new DynamicViscosityUnit("PascalSecond", 1, new Dictionary<UnitOfMeasure, int> { { PressureUnit.Pascal, 1 }, { TimeUnit.Second, 1 } });
            }
        }


        public static DynamicViscosityUnit KilogramForceSecondPerSquaredMeter {
            get {
                return new DynamicViscosityUnit("KilogramForceSecondPerSquaredMeter", 0.1019716212978, new Dictionary<UnitOfMeasure, int> { { ForceUnit.KiloGramForce, 1 }, { TimeUnit.Second, 1 }, {LengthUnit.Meter, -2 } });
            }
        }


        public static DynamicViscosityUnit NewtonSecondPerSquaredMeter {
            get {
                return new DynamicViscosityUnit("NewtonSecondPerSquaredMeter", 1, new Dictionary<UnitOfMeasure, int> { { ForceUnit.Newton, 1 }, { TimeUnit.Second, 1 }, { LengthUnit.Meter, -2 } });
            }
        }


        public static DynamicViscosityUnit DyneSecondPerSquaredCentimeter {
            get {
                return new DynamicViscosityUnit("DyneSecondPerSquaredCentimeter", 10, new Dictionary<UnitOfMeasure, int> { { ForceUnit.Dyne, 1 }, { TimeUnit.Second, 1 }, { LengthUnit.Centimeter, -2 } });
            }
        }


        public static DynamicViscosityUnit Poise {
            get {
                return new DynamicViscosityUnit("Poise", 10, "P");
            }
        }


        public static DynamicViscosityUnit PoundForceSecondPerSquareInch {
            get {
                return new DynamicViscosityUnit("PoundForceSecondPerSquareInch", 0.0001450377377302, new Dictionary<UnitOfMeasure, int> { { ForceUnit.PoundForce, 1 }, { TimeUnit.Second, 1 }, { LengthUnit.Inch, -2 } });
            }
        }


        public static DynamicViscosityUnit PoundForceSecondPerSquareFoot {
            get {
                return new DynamicViscosityUnit("PoundForceSecondPerSquareFoot", 0.0208854342332, new Dictionary<UnitOfMeasure, int> { { ForceUnit.PoundForce, 1 }, { TimeUnit.Second, 1 }, { LengthUnit.Foot, -2 } });
            }
        }


        public static DynamicViscosityUnit PoundalSecondPerSquareFoot {
            get {
                return new DynamicViscosityUnit("PoundalSecondPerSquareFoot", 0.67196897514, new Dictionary<UnitOfMeasure, int> { { ForceUnit.Poundal, 1 }, { TimeUnit.Second, 1 }, { LengthUnit.Foot, -2 } });
            }
        }


        public static DynamicViscosityUnit GramPerCentimeterPerSecond {
            get {
                return new DynamicViscosityUnit("GramPerCentimeterSecond", 10, new Dictionary<UnitOfMeasure, int> { { MassUnit.Gram, 1 }, { TimeUnit.Second, -1 }, { LengthUnit.Centimeter, -1 } });
            }
        }


        public static DynamicViscosityUnit SlugPerFootSecond {
            get {
                return new DynamicViscosityUnit("SlugPerFootSecond", 0.0208854342332, new Dictionary<UnitOfMeasure, int> { { MassUnit.Slug, 1 }, { TimeUnit.Second, -1 }, { LengthUnit.Foot, -1 } });
            }
        }


        public static DynamicViscosityUnit PoundPerFootSecond {
            get {
                return new DynamicViscosityUnit("PoundPerFootSecond", 0.67196897514, new Dictionary<UnitOfMeasure, int> { { MassUnit.Pound, 1 }, { TimeUnit.Second, -1 }, { LengthUnit.Foot, -1 } });
            }
        }


        public static DynamicViscosityUnit PoundPerFootHour {
            get {
                return new DynamicViscosityUnit("PoundPerFootHour", 2419.088310502, new Dictionary<UnitOfMeasure, int> { { MassUnit.Pound, 1 }, { TimeUnit.Hour, -1 }, { LengthUnit.Foot, -1 } });
            }
        }


        public static DynamicViscosityUnit Reyn {
            get {
                return new DynamicViscosityUnit("Reyn", 0.0001451378809869, "reyn");
            }
        }
    }
}
