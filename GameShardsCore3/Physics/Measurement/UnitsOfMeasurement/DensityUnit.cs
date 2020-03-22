using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class DensityUnit : UnitOfMeasure {

        public DensityUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public DensityUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }
        public static DensityUnit KilogramPerCubicMeter {
            get {
                return new DensityUnit("KilogramPerCubicMeter", 1, new Dictionary<UnitOfMeasure, int> { {MassUnit.Kilogram, 1 }, { LengthUnit.Meter, -3 } });
            }
        }

        public static DensityUnit GramPerLiter {
            get {
                return new DensityUnit("GramPerLiter", 1, new Dictionary<UnitOfMeasure, int> { { MassUnit.Gram, 1 }, { VolumeUnit.Liter, -1 } });
            }
        }

        public static DensityUnit PoundPerCubicInch {
            get {
                return new DensityUnit("PoundPerCubicInch", 0.0000361272920001, new Dictionary<UnitOfMeasure, int> { { MassUnit.Pound, 1 }, { LengthUnit.Inch, -3 } });
            }
        }

        public static DensityUnit PoundPerCubicFoot {
            get {
                return new DensityUnit("PoundPerCubicFoot", 0.06242796057617, new Dictionary<UnitOfMeasure, int> { { MassUnit.Pound, 1 }, { LengthUnit.Foot, -3 } });
            }
        }

        public static DensityUnit PoundPerCubicYard {
            get {
                return new DensityUnit("PoundPerCubicYard", 1.685554935556, new Dictionary<UnitOfMeasure, int> { { MassUnit.Pound, 1 }, { LengthUnit.Yard, -3 } });
            }
        }

        public static DensityUnit PoundPerUSGallon {
            get {
                return new DensityUnit("PoundPerUSGallon", 0.008345404452031, new Dictionary<UnitOfMeasure, int> { { MassUnit.Pound, 1 }, { VolumeUnit.USGallon, -1 } });
            }
        }

        public static DensityUnit OuncePerCubicInch {
            get {
                return new DensityUnit("OuncePerCubicInch", 0.0005780366720016, new Dictionary<UnitOfMeasure, int> { { MassUnit.Ounce, 1 }, { LengthUnit.Inch, -3 } });
            }
        }

        public static DensityUnit OuncePerCubicFoot {
            get {
                return new DensityUnit("OuncePerCubicFoot", 0.9988473692188, new Dictionary<UnitOfMeasure, int> { { MassUnit.Ounce, 1 }, { LengthUnit.Foot, -3 } });
            }
        }

        public static DensityUnit OuncePerUSGallon {
            get {
                return new DensityUnit("OuncePerUSGallon", 0.1335264712325, new Dictionary<UnitOfMeasure, int> { { MassUnit.Ounce, 1 }, { VolumeUnit.USGallon, -1 } });
            }
        }

        public static DensityUnit GrainPerUSGallon {
            get {
                return new DensityUnit("GrainPerUSGallon", 58.41783116414, new Dictionary<UnitOfMeasure, int> { { MassUnit.Grain, 1 }, { VolumeUnit.USGallon, -1 } });
            }
        }

        public static DensityUnit GrainPerCubicFoot {
            get {
                return new DensityUnit("GrainPerCubicFoot", 436.995724033, new Dictionary<UnitOfMeasure, int> { { MassUnit.Grain, 1 }, { LengthUnit.Foot, -3 } });
            }
        }

        public static DensityUnit ShortTonPerCubicYard {
            get {
                return new DensityUnit("ShortTonPerCubicYard", 0.0008427774677783, new Dictionary<UnitOfMeasure, int> { { MassUnit.ShortTon, 1 }, { LengthUnit.Yard, -3 } });
            }
        }

        public static DensityUnit LongTonPerCubicYard {
            get {
                return new DensityUnit("LongTonPerCubicYard", 0.0007524798819446, new Dictionary<UnitOfMeasure, int> { { MassUnit.LongTon, 1 }, { LengthUnit.Yard, -3 } });
            }
        }

        public static DensityUnit SlugPerCubicFoot {
            get {
                return new DensityUnit("SlugPerCubicFoot", 0.00194032033198, new Dictionary<UnitOfMeasure, int> { { MassUnit.Slug, 1 }, { LengthUnit.Foot, -3 } });
            }
        }

        public static DensityUnit SlugPerCubicInch {
            get {
                return new DensityUnit("SlugPerCubicInch", 0.000001122870562488, new Dictionary<UnitOfMeasure, int> { { MassUnit.Slug, 1 }, { LengthUnit.Inch, -3 } });
            }
        }

        public static DensityUnit SlugPerCubicYard {
            get {
                return new DensityUnit("SlugPerCubicYard", 0.0523844582068, new Dictionary<UnitOfMeasure, int> { { MassUnit.Slug, 1 }, { LengthUnit.Yard, -3 } });
            }
        }

        public static DensityUnit PlanckDensity {
            get {
                return new DensityUnit("PlanckDensity", 1.939864209505E-97, "dp");
            }
        }

        public static DensityUnit EarthMeanDensity {
            get {
                return new DensityUnit("EarthMeanDensity", 0.0001812250815513, "d⊕");
            }
        }
    }
}
