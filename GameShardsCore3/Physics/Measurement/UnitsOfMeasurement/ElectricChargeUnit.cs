using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class ElectricChargeUnit : UnitOfMeasure {
        public ElectricChargeUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public ElectricChargeUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static ElectricChargeUnit Coulomb {
            get {
                return new ElectricChargeUnit("Coulomb", 1, "C");
            }
        }

        public static ElectricChargeUnit MilliAmperesHour {
            get {
                return new ElectricChargeUnit("MilliAmpereHour", 1 / (double)3600, new Dictionary<UnitOfMeasure, int> { { ElectricCurrentUnit.MilliAmpere, 1 }, { TimeUnit.Hour, 1 } });
            }
        }

        public static ElectricChargeUnit AmperesHour {
            get {
                return new ElectricChargeUnit("AmpereHour", 1 / (double)3600, new Dictionary<UnitOfMeasure, int> { {ElectricCurrentUnit.Ampere, 1 }, { TimeUnit.Hour, 1 } });
            }
        }

        public static ElectricChargeUnit AmperesMinute {
            get {
                return new ElectricChargeUnit("AmperesMinute", 1 / (double)60, new Dictionary<UnitOfMeasure, int> { { ElectricCurrentUnit.Ampere, 1 }, { TimeUnit.Minute, 1 } });
            }
        }

        public static ElectricChargeUnit AmpereSecond {
            get {
                return new ElectricChargeUnit("AmpereSecond", 1, new Dictionary<UnitOfMeasure, int> { { ElectricCurrentUnit.Ampere, 1 }, { TimeUnit.Second, 1 } });
            }
        }


        public static ElectricChargeUnit Faraday {
            get {
                return new ElectricChargeUnit("Faraday", 96485.3, "Fd");
            }
        }

        public static ElectricChargeUnit AbCoulomb {
            get {
                return new ElectricChargeUnit("AbCoulomb", 0.1, "abC");
            }
        }

        public static ElectricChargeUnit EMUofCharge {
            get {
                return new ElectricChargeUnit("EMUofCharge", 0.1, "EMUofCharge");
            }
        }

        public static ElectricChargeUnit StatCoulomb {
            get {
                return new ElectricChargeUnit("StatCoulomb", 2997924580, "stC");
            }
        }

        public static ElectricChargeUnit ESUofCharge {
            get {
                return new ElectricChargeUnit("ESUofCharge", 2997924580, "ESUofCharge");
            }
        }

        public static ElectricChargeUnit Franklin {
            get {
                return new ElectricChargeUnit("Franklin", 2997924580, "Franklin");
            }
        }

        public static ElectricChargeUnit ElementaryCharge {
            get {
                return new ElectricChargeUnit("ElementaryCharge", 6.241506363094E+18, "e");
            }
        }

    }
}
