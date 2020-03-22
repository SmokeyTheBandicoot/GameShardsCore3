using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class EnergyUnit : UnitOfMeasure {
        public EnergyUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public EnergyUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static EnergyUnit Joule {
            get {
                return new EnergyUnit("Joule", 1, "J");
            }
        }

        public static EnergyUnit THCalorie {
            get {
                return new EnergyUnit("THCalorie", 0.239006, "th cal");
            }
        }

        public static EnergyUnit ITCalorie {
            get {
                return new EnergyUnit("ITCalorie", 0.2388458966275, "ITcal");
            }
        }

        public static EnergyUnit NutritionalCalorie {
            get {
                return new EnergyUnit("NutritionalCalorie", 0.0002388458966275, "cal");
            }
        }

        public static EnergyUnit KiloWattHour {
            get {
                return new EnergyUnit("KiloWattHour", 0.0000002777777777778, new Dictionary<UnitOfMeasure, int> { { PowerUnit.KiloWatt, 1 }, { TimeUnit.Hour, 1 } });
            }
        }

        public static EnergyUnit WattHour {
            get {
                return new EnergyUnit("WattHour", 0.000277778, new Dictionary<UnitOfMeasure, int> { { PowerUnit.Watt, 1 }, { TimeUnit.Hour, 1 } });
            }
        }

        public static EnergyUnit ElectronVolt {
            get {
                return new EnergyUnit("ElectronVolt", 6.242E+18, "eV");
            }
        }

        public static EnergyUnit BritishThermalUnit {
            get {
                return new EnergyUnit("BTU", 0.0009478171203133, "BTU");
            }
        }

        public static EnergyUnit ThermUSA {
            get {
                return new EnergyUnit("TUSA", 0.0000000094804, "thm");
            }
        }

        public static EnergyUnit FootPoundForce {
            get {
                return new EnergyUnit("FootPoundForce", 0.7375621493, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Foot, 1 }, { ForceUnit.PoundForce, 1 } });
            }
        }

        public static EnergyUnit BarrelOfOilEquivalent {
            get {
                return new EnergyUnit("BarrelOfOilEquivalent", 0.000000000163456, "BOE");
            }
        }

        public static EnergyUnit Erg {
            get {
                return new EnergyUnit("Erg", 10000000.0, "erg");
            }
        }

        public static EnergyUnit GramsOfTNT {
            get {
                return new EnergyUnit("GramsOfTNT", 0.0002390057361377, "gTNT");
            }
        }

        public static EnergyUnit WattSecond {
            get {
                return new EnergyUnit("WattSecond", 1, new Dictionary<UnitOfMeasure, int> { { PowerUnit.Watt, 1 }, { TimeUnit.Second, 1 } });
            }
        }

        public static EnergyUnit NewtonMeter {
            get {
                return new EnergyUnit("NewtonMeter", 1, new Dictionary<UnitOfMeasure, int> { { ForceUnit.Newton, 1 }, { LengthUnit.Meter, 1 } });
            }
        }

        public static EnergyUnit HorsepowerHour {
            get {
                return new EnergyUnit("HorsePowerHour", 0.0000003725061361111, new Dictionary<UnitOfMeasure, int> { { PowerUnit.HorsePower, 1 }, { TimeUnit.Hour, 1 } });
            }
        }

        public static EnergyUnit MetricHorsepowerHour {
            get {
                return new EnergyUnit("MetricHorsePowerHour", 0.0000003776726714733, new Dictionary<UnitOfMeasure, int> { { PowerUnit.MetricHorsePower, 1 }, { TimeUnit.Hour, 1 } });
            }
        }

        public static EnergyUnit BritishThermalUnitTH {
            get {
                return new EnergyUnit("BritishThermalUnitTH", 0.0009484516527, "BTU (th)");
            }
        }

        public static EnergyUnit TonHourRefrigeration {
            get {
                return new EnergyUnit("TonHourRefrigeration", 0.00000007898476002611, "THR");
            }
        }

        public static EnergyUnit TonneOfOilEquivalent {
            get {
                return new EnergyUnit("TonneofOilEquivalent", 0.00000000002388458966275, "TOE");
            }
        }

        public static EnergyUnit Ton {
            get {
                return new EnergyUnit("TonneofOilEquivalent", 0.0000000002390057361377, "ton");
            }
        }// Explosives (Megaton, Gigaton, etc)

        public static EnergyUnit DyneCentimeter {
            get {
                return new EnergyUnit("DyneCentimeter", 10000000, new Dictionary<UnitOfMeasure, int> { { ForceUnit.Dyne, 1 }, { LengthUnit.Centimeter, 1 } });
            }
        }

        public static EnergyUnit GramForceMeter {
            get {
                return new EnergyUnit("GramForceMeter", 101.9716213009, new Dictionary<UnitOfMeasure, int> { { ForceUnit.GramForce, 1 }, { LengthUnit.Meter, 1 } });
            }
        }
        
        public static EnergyUnit InchPoundForce {
            get {
                return new EnergyUnit("InchPoundForce", 8.8507457916, new Dictionary<UnitOfMeasure, int> { { ForceUnit.PoundForce, 1 }, { LengthUnit.Inch, 1 } });
            }
        }

        public static EnergyUnit OunceForceInch {
            get {
                return new EnergyUnit("OunceForceInch", 141.6119326656, new Dictionary<UnitOfMeasure, int> { { ForceUnit.OunceForce, 1 }, { LengthUnit.Inch, 1 } });
            }
        }

        public static EnergyUnit PoundalFoot {
            get {
                return new EnergyUnit("PoundalFoot", 23.7303604571, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Foot, 1 }, { MassUnit.Pound, 1 }, { TimeUnit.Second, 1 } });
            }
        }

        public static EnergyUnit HartreeEnergy {
            get {
                return new EnergyUnit("HartreeEnergy", 2.293710448691E+17, "Ha");
            }
        }

        public static EnergyUnit CelsiusHeatUnit {
            get {
                return new EnergyUnit("CelsiusHeatUnit", 0.00052656506684073173, "CHU");
            }
        }


        public static EnergyUnit PlanckEnergy {
            get {
                return new EnergyUnit("PlanckEnergy", 0.0000000005112213077041, "Ep");
            }
        }
    }
}
