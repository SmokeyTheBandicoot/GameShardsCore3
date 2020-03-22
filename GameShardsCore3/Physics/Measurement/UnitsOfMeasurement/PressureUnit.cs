using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class PressureUnit : UnitOfMeasure {
        public PressureUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public PressureUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static PressureUnit Pascal {
            get {
                return new PressureUnit("Pascal", 1, "pa");
            }
        }

        public static PressureUnit Bar {
            get {
                return new PressureUnit("Bar", 0.00001, "bar");
            }
        }

        public static PressureUnit StandardAtmosphere {
            get {
                return new PressureUnit("Atmosphere", 0.00000986923266716, "atm");
            }
        }

        public static PressureUnit TechnicalAtmosphere {
            get {
                return new PressureUnit("TechnicalAtmosphere", 0.00001019716212978, "at");
            }
        }

        public static PressureUnit PoundsPerSquareInch {
            get {
                return new PressureUnit("PSI", 0.00014503773773, "PSI");
            }
        }

        public static PressureUnit Torr {
            get {
                return new PressureUnit("Torr", 0.00750062, "Torr");
            }
        }

        public static PressureUnit NewtonPerSqMeter {
            get {
                return new PressureUnit("NewtonPerSquareMeter", 0.00750062, new Dictionary<UnitOfMeasure, int> { {ForceUnit.Newton, 1 } , { LengthUnit.Meter, -2} });
            }
        }

        public static PressureUnit DynePerSqCentimeter {
            get {
                return new PressureUnit("DynePerSquareCentimeter", 10, new Dictionary<UnitOfMeasure, int> { { ForceUnit.Dyne, 1 }, { LengthUnit.Centimeter, -2 } });
            }
        }

        public static PressureUnit PoundalPerSqFoot {
            get {
                return new PressureUnit("PoundalPerSquareFoot", 0.6719689751395, new Dictionary<UnitOfMeasure, int> { { ForceUnit.Poundal, 1 }, { LengthUnit.Foot, -2 } });
            }
        }

        public static PressureUnit KilogramForcePerSqMeter {
            get {
                return new PressureUnit("KilogramForcePerSquareMeter", 0.1019716212978, new Dictionary<UnitOfMeasure, int> { { ForceUnit.KiloGramForce, 1 }, { LengthUnit.Meter, -2 } });
            }
        }

        public static PressureUnit PoundForcePerSqFoot {
            get {
                return new PressureUnit("PoundForcePerSquareFoot", 0.02088543423312, new Dictionary<UnitOfMeasure, int> { { ForceUnit.PoundForce, 1 }, { LengthUnit.Foot, -2 } });
            }
        }

        public static PressureUnit PoundForcePerSqInch {
            get {
                return new PressureUnit("PoundForcePerSquareInch", 0.00014503773773, new Dictionary<UnitOfMeasure, int> { { ForceUnit.PoundForce, 1 }, { LengthUnit.Inch, -2 } });
            }
        }

        public static PressureUnit MillimetersOfMercury0Celsius {
            get {
                return new PressureUnit("MillimetersOfMercury", 0.007500637554192, "mmHg");
            }
        }

        public static PressureUnit MillimetersOfWater4Celsius {
            get {
                return new PressureUnit("MillimetersOfWater", 0.1019744288922, "mmH2O");
            }
        }

        public static PressureUnit SthenePerSqMeter {
            get {
                return new PressureUnit("SthenePerSqMeter", 0.001, new Dictionary<UnitOfMeasure, int> { { ForceUnit.Sthene, 1 }, { LengthUnit.Meter, -2 } });
            }
        }

        public static PressureUnit Piéze {
            get {
                return new PressureUnit("Piéze", 0.001, "pièze");
            }
        }

        public static PressureUnit Barye {
            get {
                return new PressureUnit("Barye", 10, "Ba");
            }
        }

        public static PressureUnit PlanckPressure {
            get {
                return new PressureUnit("PlanckPressure", 2.158386735418E-114, "Pp");
            }
        }

        public static PressureUnit MeterSeaWater {
            get {
                return new PressureUnit("MeterSeaWater", 0.0001, "msw");
            }
        }

        public static PressureUnit FootSeaWater {
            get {
                return new PressureUnit("FootSeaWater", 0.0003263381732743, "fsw");
            }
        }

        public static PressureUnit MeterWater4C {
            get {
                return new PressureUnit("MeterSeaWater4C", 0.0001019744288922, "mH2O");
            }
        }
    }
}
