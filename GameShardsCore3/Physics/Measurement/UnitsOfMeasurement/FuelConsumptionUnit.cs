using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class FuelConsumptionUnit : UnitOfMeasure {

        public FuelConsumptionUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public FuelConsumptionUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }
        public static FuelConsumptionUnit MeterPerLiter {
            get {
                return new FuelConsumptionUnit("MeterPerLiter", 1, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 1 }, { VolumeUnit.Liter, -1 } });
            }
        }

        public static FuelConsumptionUnit MilePerLiter {
            get {
                return new FuelConsumptionUnit("MilePerLiter", 0.0006213711922373, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Mile, 1 }, { VolumeUnit.Liter, -1 } });
            }
        }

        public static FuelConsumptionUnit NauticalMilePerLiter {
            get {
                return new FuelConsumptionUnit("NauticalMilePerLiter", 0.0005395940750326, new Dictionary<UnitOfMeasure, int> { { LengthUnit.NauticalMile, 1 }, { VolumeUnit.Liter, -1 } });
            }
        }

        public static FuelConsumptionUnit NauticalMilePerGallon {
            get {
                return new FuelConsumptionUnit("NauticalMilePerGallon", 0.002042585769811, new Dictionary<UnitOfMeasure, int> { { LengthUnit.NauticalMile, 1 }, { VolumeUnit.USGallon, -1 } });
            }
        }

        public static FuelConsumptionUnit MeterPerGallon {
            get {
                return new FuelConsumptionUnit("MeterPerGallon", 3.7854117834, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 1 }, { VolumeUnit.USGallon, -1 } });
            }
        }

        public static FuelConsumptionUnit MilePerGallon {
            get {
                return new FuelConsumptionUnit("MilePerGallon", 3.7854117834, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Mile, 1 }, { VolumeUnit.USGallon, -1 } });
            }
        }

        public static FuelConsumptionUnit MeterPerCubicMeter {
            get {
                return new FuelConsumptionUnit("MeterPerCubicMeter", 1000, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 1 }, { LengthUnit.Meter, -3 } });
            }
        }

        public static FuelConsumptionUnit MeterPerCubicYard {
            get {
                return new FuelConsumptionUnit("MeterPerCubicYard", 764.5548581678, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 1 }, { LengthUnit.Yard, -3 } });
            }
        }

        public static FuelConsumptionUnit MeterPerCubicFoot {
            get {
                return new FuelConsumptionUnit("MeterPerCubicFoot", 28.31684659319, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 1 }, { LengthUnit.Foot, -3 } });
            }
        }

        public static FuelConsumptionUnit MeterPerCubicInch {
            get {
                return new FuelConsumptionUnit("MeterPerCubicInch", 0.01638706400127, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 1 }, { LengthUnit.Inch, -3 } });
            }
        }

        public static FuelConsumptionUnit MeterPerQuart {
            get {
                return new FuelConsumptionUnit("MeterPerQuart", 0.9463529463874, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 1 }, { VolumeUnit.USDryQuart, -1 } });
            }
        }

        public static FuelConsumptionUnit MeterPerPint {
            get {
                return new FuelConsumptionUnit("MeterPerPint", 0.4731764729698, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 1 }, { VolumeUnit.USDryPint, -1 } });
            }
        }

        public static FuelConsumptionUnit MeterPerCup {
            get {
                return new FuelConsumptionUnit("MeterPerPint", 0.2365882364849, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 1 }, { VolumeUnit.USCup, -1 } });
            }
        }

        public static FuelConsumptionUnit MeterPerFluidOunce {
            get {
                return new FuelConsumptionUnit("MeterPerFluidOunce", 0.02957352956411, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 1 }, { VolumeUnit.USFluidOunce, -1 } });
            }
        }

        public static FuelConsumptionUnit LiterPerMeter {
            get {
                return new FuelConsumptionUnit("LiterPerMeter", 1, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, -1 }, { VolumeUnit.Liter, 1 } });
            }
        }

        public static FuelConsumptionUnit GallonPerMile {
            get {
                return new FuelConsumptionUnit("GallonPerMile", 425.1437074976, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Mile, -1 }, { VolumeUnit.USGallon, 1 } });
            }
        }
    }
}
