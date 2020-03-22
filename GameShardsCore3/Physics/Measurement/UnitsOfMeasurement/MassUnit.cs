using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class MassUnit : UnitOfMeasure{
        public MassUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public MassUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static MassUnit Kilogram {
            get {
                return new MassUnit("Kilogram", 1, "Kg");
            }
        }

        public static MassUnit Ton {
            get {
                return new MassUnit("Ton", 0.001, "ton");
            }
        }

        public static MassUnit TonUS {
            get {
                return new MassUnit("TonUS", 34.28571036735, "tonUS");
            }
        }

        public static MassUnit TonUK {
            get {
                return new MassUnit("TonUK", 30.61224489796, "tonUK");
            }
        }

        public static MassUnit Gram {
            get {
                return new MassUnit("Gram", 1000, "g");
            }
        }

        public static MassUnit LongTon {
            get {
                return new MassUnit("LongTon", 0.0009842065276111, "Long ton");
            }
        }

        public static MassUnit ShortTon {
            get {
                return new MassUnit("ShortTon", 0.001102311310924, "Short ton");
            }
        }

        public static MassUnit StoneUS {
            get {
                return new MassUnit("StoneUS", 0.1763698097479, "stUS");
            }
        }

        public static MassUnit Stone {
            get {
                return new MassUnit("Stone", 0.1574730444178, "st");
            }
        }

        public static MassUnit Pound {
            get {
                return new MassUnit("Pound", 2.204622621849, "lb");
            }
        }

        public static MassUnit Ounce {
            get {
                return new MassUnit("Ounce", 35.274, "oz");
            }
        }

        public static MassUnit AtomicMassUnit {
            get {
                return new MassUnit("AtomicMassUnit", 6.02217364335E+26, "u");
            }
        }

        public static MassUnit KilogramForceSecond2PerMeter {
            get {
                return new MassUnit("KilogramForceSecond2PerMeter", 0.1019716212978, new Dictionary<UnitOfMeasure, int> { {ForceUnit.KiloGramForce, 1 }, { TimeUnit.Second, 2 }, {LengthUnit.Meter, -1 } });
            }
        }

        public static MassUnit Slug {
            get {
                return new MassUnit("Slug", 0.0685217658568, "slug");
            }
        }

        public static MassUnit PoundForceSecond2PerFoot {
            get {
                return new MassUnit("PoundForceSecond2PerFoot", 0.06852176585679, new Dictionary<UnitOfMeasure, int> { { ForceUnit.PoundForce, 1 }, { TimeUnit.Second, 2 }, { LengthUnit.Foot, -1 } });
            }
        }

        public static MassUnit TroyPound {
            get {
                return new MassUnit("TroyPound", 2.679228880719, "tlbf");
            }
        }

        public static MassUnit TroyOunce {
            get {
                return new MassUnit("TroyOunce", 32.15074656863, "toz");
            }
        }

        public static MassUnit MetricOunce {
            get {
                return new MassUnit("MetricOunce", 40, "moz");
            }
        }

        public static MassUnit HundredWeightUS {
            get {
                return new MassUnit("HundredWeightUS", 0.02204622621849, "cwtUS");
            }
        }

        public static MassUnit HundredWeight {
            get {
                return new MassUnit("HundredWeightUK", 0.01968413055222, "cwtUK");
            }
        }

        public static MassUnit QuarterUS {
            get {
                return new MassUnit("QuarterUS", 0.08818490487395, "qUS");
            }
        }

        public static MassUnit Quarter {
            get {
                return new MassUnit("QuarterUK", 0.07873652220888, "qUK");
            }
        }

        public static MassUnit PennyWeight {
            get {
                return new MassUnit("PennyWeight", 643.0149313708, "pwt");
            }
        }

        public static MassUnit ApothecaryScruple {
            get {
                return new MassUnit("ApothecaryScruple", 771.617917645, "s.ap");
            }
        }

        public static MassUnit Carat {
            get {
                return new MassUnit("Carat", 5000, "ct");
            }
        }

        public static MassUnit Grain {
            get {
                return new MassUnit("Grain", 15432.3583529, "gr");
            }
        }

        public static MassUnit Gamma {
            get {
                return new MassUnit("Gamma", 1000000000, "gr");
            }
        }

        public static MassUnit Talent {
            get {
                return new MassUnit("Talent", 0.02923976608187, "talent");
            }
        }

        public static MassUnit Mina {
            get {
                return new MassUnit("Mina", 1.754385964912, "mina");
            }
        }

        public static MassUnit Shekel {
            get {
                return new MassUnit("Shekel", 87.71929824561, "shekel");
            }
        }

        public static MassUnit Bekan {
            get {
                return new MassUnit("Bekan", 175.4385964912, "bekan");
            }
        }

        public static MassUnit Gerah {
            get {
                return new MassUnit("Gerah", 1754.385964912, "gerah");
            }
        }

        public static MassUnit TalentGK {
            get {
                return new MassUnit("TalentGK", 0.04901960784314, "gktalent");
            }
        }

        public static MassUnit MinaGK {
            get {
                return new MassUnit("MinaGK", 2.941176470588, "gkmina");
            }
        }

        public static MassUnit TetraDrachma {
            get {
                return new MassUnit("TetraDrachma", 73.52941176471, "tetradrachma");
            }
        }

        public static MassUnit DiDrachma {
            get {
                return new MassUnit("DiDrachma", 147.0588235294, "didrachma");
            }
        }

        public static MassUnit Drachma {
            get {
                return new MassUnit("Drachma", 294.1176470588, "drachma");
            }
        }

        public static MassUnit Denarius {
            get {
                return new MassUnit("Denarius", 259.7402597403, "denarius");
            }
        }

        public static MassUnit Assarion {
            get {
                return new MassUnit("Assarion", 4155.844155844, "assarion");
            }
        }

        public static MassUnit Quadrans {
            get {
                return new MassUnit("Quadrans", 16623.37662338, "quadrans");
            }
        }

        public static MassUnit Lepton {
            get {
                return new MassUnit("Lepton", 33246.75324675, "lepton");
            }
        }

        public static MassUnit PlanckMass {
            get {
                return new MassUnit("PlanckMass", 45940892.44778, "mp");
            }
        }

        public static MassUnit ElectronRestMass {
            get {
                return new MassUnit("ElectronRestMass", 1.097768382881E+30, "me");
            }
        }

        public static MassUnit MuonMass {
            get {
                return new MassUnit("MuonMass", 5.309172492731E+27, "mmu");
            }
        }

        public static MassUnit ProtonMass {
            get {
                return new MassUnit("ProtonMass", 5.978633201945E+26, "mpr");
            }
        }

        public static MassUnit NeutronMass {
            get {
                return new MassUnit("NeutronMass", 5.97040375333E+26, "mne");
            }
        }

        public static MassUnit DeuteronMass {
            get {
                return new MassUnit("DeuteronMass", 2.990800894608E+26, "mdt");
            }
        }

        public static MassUnit MassOfEarth {
            get {
                return new MassUnit("MassOfEarth", 1.673360107095E-25, "M⊕");
            }
        }

        public static MassUnit MassOfSun {
            get {
                return new MassUnit("MassOfSun", 5.0E-31, "Mʘ");
            }
        }

        public static MassUnit Berkovets {
            get {
                return new MassUnit("Berkovets", 0.006104821096875, "berk");
            }
        }

        public static MassUnit Pood {
            get {
                return new MassUnit("Pood", 0.06104821096875, "pood");
            }
        }

        public static MassUnit Funt {
            get {
                return new MassUnit("Funt", 2.44192843875, "funt");
            }
        }

        public static MassUnit Lot {
            get {
                return new MassUnit("Lot", 78.14171004, "lot");
            }
        }

        public static MassUnit Zolotnik {
            get {
                return new MassUnit("Zolotnik", 234.42513012, "zlot");
            }
        }

        public static MassUnit Dolya {
            get {
                return new MassUnit("Dolya", 22504.81249152, "dolya");
            }
        }

        public static MassUnit FrenchQuintal {
            get {
                return new MassUnit("FrenchQuintal", 0.02042900919305, "fq");
            }
        }

        public static MassUnit Livre {
            get {
                return new MassUnit("Livre", 2.042900919305, "lv");
            }
        }
    }
}
