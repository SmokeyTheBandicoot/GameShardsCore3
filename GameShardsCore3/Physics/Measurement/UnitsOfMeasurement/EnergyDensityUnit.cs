using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class EnergyDensityUnit : UnitOfMeasure {
        public EnergyDensityUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public EnergyDensityUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static EnergyDensityUnit JoulePerCubicMeter {
            get {
                return new EnergyDensityUnit("JoulePerCubicMeter", 1, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.Joule, 1 }, { LengthUnit.Meter, -3 } });
            }
        }

        public static EnergyDensityUnit JoulePerCubicLiter {
            get {
                return new EnergyDensityUnit("JoulePerCubicLiter", 0.001, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.Joule, 1 }, { VolumeUnit.Liter, -1 } });
            }
        }

        public static EnergyDensityUnit ITCaloriePerCubicMeter {
            get {
                return new EnergyDensityUnit("ITCaloriePerCubicMeter", 0.2388458966, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.ITCalorie, 1 }, { LengthUnit.Meter, -3 } });
            }
        }

        public static EnergyDensityUnit ThermPerCubicFoot {
            get {
                return new EnergyDensityUnit("ThermPerCubicFoot", 0.0000000002683919173, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.ThermUSA, 1 }, { LengthUnit.Foot, -3 } });
            }
        }

        public static EnergyDensityUnit ThermPerUSGallon {
            get {
                return new EnergyDensityUnit("ThermPerUSGallon", 0.0000000000358873, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.ThermUSA, 1 }, { VolumeUnit.USGallon, -1 } });
            }
        }

        public static EnergyDensityUnit ITBTUPerCubicFoot {
            get {
                return new EnergyDensityUnit("ITBTUPerCubicFoot", 0.0000268391919932, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.BritishThermalUnit, 1 }, { LengthUnit.Foot, -3 } });
            }
        }

        public static EnergyDensityUnit THBTUPerCubicFoot {
            get {
                return new EnergyDensityUnit("THBTUPerCubicFoot", 0.0000268571532115, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.BritishThermalUnitTH, 1 }, { LengthUnit.Foot, -3 } });
            }
        }

        public static EnergyDensityUnit CHUPerCubicFoot {
            get {
                return new EnergyDensityUnit("CHUPerCubicFoot", 0.00001491066207, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.CelsiusHeatUnit, 1 }, { LengthUnit.Foot, -3 } });
            }
        }

        public static EnergyDensityUnit CubicMeterPerJoule {
            get {
                return new EnergyDensityUnit("CubicMeterPerJoule", 1, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.Joule, -1 }, { LengthUnit.Meter, 3 } });
            }
        }

        public static EnergyDensityUnit LiterPerJoule {
            get {
                return new EnergyDensityUnit("LiterPerJoule", 1000, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.Joule, -1 }, { VolumeUnit.Liter, 1 } });
            }
        }

        public static EnergyDensityUnit USGallonPerHorsepowerHour {
            get {
                return new EnergyDensityUnit("USGallonPerHorsepowerHour", 709175035.869, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.HorsepowerHour, -1 }, { VolumeUnit.USGallon, 1 } });
            }
        }

        public static EnergyDensityUnit USGallonPerMetricHorsepowerHour {
            get {
                return new EnergyDensityUnit("USGallonPerMetricHorsepowerHour", 699473571.46, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.MetricHorsepowerHour, -1 }, { VolumeUnit.USGallon, 1 } });
            }
        }
    }
}
