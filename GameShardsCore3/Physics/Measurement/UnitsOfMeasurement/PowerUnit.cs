using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class PowerUnit : UnitOfMeasure {
        public PowerUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public PowerUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }


        public static PowerUnit Watt {
            get {
                return new PowerUnit("Watt", 1, "W");
            }
        }

        public static PowerUnit KiloWatt {
            get {
                return new PowerUnit("KiloWatt", 0.001, "kW");
            }
        }

        public static PowerUnit HorsePower {
            get {
                return new PowerUnit("HorsePower", 0.001341022089595, "HP");
            }
        }

        public static PowerUnit MetricHorsePower {
            get {
                return new PowerUnit("MetricHorsePower", 0.001359621617304, "HP");
            }
        }

        public static PowerUnit BoilerHorsePower {
            get {
                return new PowerUnit("BoilerHorsePower", 0.0001019419950048, "bHP");
            }
        }

        public static PowerUnit ElectricHorsePower {
            get {
                return new PowerUnit("ElectricHorsePower", 0.001340482573727, "eHP");
            }
        }

        public static PowerUnit WaterHorsePower {
            get {
                return new PowerUnit("WaterHorsePower", 0.001340482573727, "wHP");
            }
        }

        public static PowerUnit Pfedestarke {
            get {
                return new PowerUnit("Pfedestarke", 0.001359621617304, "ps");
            }
        }

        public static PowerUnit BTUPerHour {
            get {
                return new PowerUnit("BTUPerHour", 3.412141633128,  new Dictionary<UnitOfMeasure, int> { { EnergyUnit.BritishThermalUnit, 1 }, { TimeUnit.Hour, -1 } });
            }
        }

        public static PowerUnit BTUPerMinute {
            get {
                return new PowerUnit("BTUPerMinute", 0.0568690272188, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.BritishThermalUnit, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static PowerUnit BTUPerSecond {
            get {
                return new PowerUnit("BTUPerSecond", 0.0009478171203133, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.BritishThermalUnit, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static PowerUnit ThermochemicalBTUPerHour {
            get {
                return new PowerUnit("ThermochemicalBTUPerHour", 3.41442594972, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.BritishThermalUnitTH, 1 }, { TimeUnit.Hour, -1 } });
            }
        }

        public static PowerUnit ThermochemicalBTUPerMinute {
            get {
                return new PowerUnit("ThermochemicalBTUPerMinute", 0.056907099162, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.BritishThermalUnitTH, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static PowerUnit ThermochemicalBTUPerSecond {
            get {
                return new PowerUnit("ThermochemicalBTUPerSecond", 0.0009484516527, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.BritishThermalUnitTH, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static PowerUnit TonOfRefrigeration {
            get {
                return new PowerUnit("TonOfRefrigeration", 0.000284345136094, "tor");
            }
        }

        public static PowerUnit CaloriePerHour {
            get {
                return new PowerUnit("CaloriePerHour", 859.845227859, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.ITCalorie, 1 }, { TimeUnit.Hour, -1 } });
            }
        }

        public static PowerUnit CaloriePerMinute {
            get {
                return new PowerUnit("CaloriePerMinute", 14.33075379765, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.ITCalorie, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static PowerUnit CaloriePerSecond {
            get {
                return new PowerUnit("CaloriePerSecond", 0.2388458966275, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.ITCalorie, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static PowerUnit ThermoCaloriePerHour {
            get {
                return new PowerUnit("ThermoCaloriePerHour", 860.4206500956, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.THCalorie, 1 }, { TimeUnit.Hour, -1 } });
            }
        }

        public static PowerUnit ThermoCaloriePerMinute {
            get {
                return new PowerUnit("ThermoCaloriePerMinute", 14.34034416826, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.THCalorie, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static PowerUnit ThermoCaloriePerSecond {
            get {
                return new PowerUnit("ThermoCaloriePerSecond", 0.2390057361377, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.THCalorie, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static PowerUnit FootPoundForcePerHour {
            get {
                return new PowerUnit("FootPoundForcePerHour", 2655.223737402, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.FootPoundForce, 1 }, { TimeUnit.Hour, -1 } });
            }
        }

        public static PowerUnit FootPoundForcePerMinute {
            get {
                return new PowerUnit("FootPoundForcePerMinute", 44.2537289567, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.FootPoundForce, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static PowerUnit FootPoundForcePerSecond {
            get {
                return new PowerUnit("FootPoundForcePerSecond", 0.7375621492783, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.FootPoundForce, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static PowerUnit ErgPerSecond {
            get {
                return new PowerUnit("ErgPerSecond", 10000000, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.Erg, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static PowerUnit VoltAmpere {
            get {
                return new PowerUnit("VoltAmpere", 1, new Dictionary<UnitOfMeasure, int> { { ElectricVoltageUnit.Volt, 1 }, { ElectricCurrentUnit.Ampere, 1 } });
            }
        }

        public static PowerUnit NewtonMeterPerSecond {
            get {
                return new PowerUnit("NewtonMeterPerSecond", 1, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.NewtonMeter, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static PowerUnit JoulePerSecond {
            get {
                return new PowerUnit("JoulePerSecond", 1, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.Joule, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static PowerUnit JoulePerMinute {
            get {
                return new PowerUnit("JoulePerSecond", 60, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.Joule, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static PowerUnit JoulePerHour {
            get {
                return new PowerUnit("JoulePerHour", 3600, new Dictionary<UnitOfMeasure, int> { { EnergyUnit.Joule, 1 }, { TimeUnit.Hour, -1 } });
            }
        }

        public static PowerUnit PlanckPower {
            get {
                return new PowerUnit("PlanckPower", 2.756104081515E-53, "Wp");
            }
        }
    }
}
