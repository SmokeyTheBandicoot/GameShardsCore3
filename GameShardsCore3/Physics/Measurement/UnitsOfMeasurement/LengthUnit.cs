using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class LengthUnit : UnitOfMeasure {
        public LengthUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public LengthUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static LengthUnit Meter {
            get {
                return new LengthUnit("Meter", 1, "m");
            }
        }

        public static LengthUnit Kilometer {
            get {
                return new LengthUnit("Kilometer", 0.001, "km");
            }
        }

        public static LengthUnit Millimeter {
            get {
                return new LengthUnit("Millimeter", 1000, "mm");
            }
        }

        public static LengthUnit Centimeter {
            get {
                return new LengthUnit("Centimeter", 100, "cm");
            }
        }

        public static LengthUnit Mile {
            get {
                return new LengthUnit("Mile", 0.0006213711922373, "mi");
            }
        }

        public static LengthUnit MileStatute {
            get {
                return new LengthUnit("MileStatute", 0.000621369949495, "smi");
            }
        }

        public static LengthUnit Yard {
            get {
                return new LengthUnit("Yard", 1.093613298338, "yd");
            }
        }

        public static LengthUnit Foot {
            get {
                return new LengthUnit("Foot", 3.280839895013, "ft");
            }
        }

        public static LengthUnit Inch {
            get {
                return new LengthUnit("Inch", 39.37007874016, "in");
            }
        }

        public static LengthUnit NauticalMileUK {
            get {
                return new LengthUnit("NauticalMileUK", 0.0005396118248376, "nmiUK");
            }
        }

        public static LengthUnit NauticalMile {
            get {
                return new LengthUnit("NauticalMile", 0.0005399568034556, "nmi");
            }
        }

        public static LengthUnit Parsec {
            get {
                return new LengthUnit("Parsec", 3.240779289666E-17, "pc");
            }
        }

        public static LengthUnit AstronomicalUnit {
            get {
                return new LengthUnit("AstronomicalUnit", 3.240779289666E-17, "AU");
            }
        }

        public static LengthUnit League {
            get {
                return new LengthUnit("League", 0.0002071237307458, "lea");
            }
        }

        public static LengthUnit NauticalLeagueUK {
            get {
                return new LengthUnit("NauticalLeagueUK", 0.0001798706082792, "NLUK");
            }
        }

        public static LengthUnit NauticalLeague {
            get {
                return new LengthUnit("NauticalLeague", 0.0001799856011519, "NL");
            }
        }

        public static LengthUnit StatuteLeague {
            get {
                return new LengthUnit("StatuteLeague", 0.0002071233164983, "slea");
            }
        }

        public static LengthUnit Furlong {
            get {
                return new LengthUnit("Furlong", 0.004970969537899, "fur");
            }
        }

        public static LengthUnit Chain {
            get {
                return new LengthUnit("Chain", 0.04970969537899, "chain");
            }
        }

        public static LengthUnit Rope {
            get {
                return new LengthUnit("Rope", 0.1640419947507, "rope");
            }
        }

        public static LengthUnit Rod {
            get {
                return new LengthUnit("Rod", 0.1988387815159, "rod");
            }
        }

        public static LengthUnit Perch {
            get {
                return new LengthUnit("Perch", 0.1988387815159, "perch");
            }
        }

        public static LengthUnit Pole {
            get {
                return new LengthUnit("Pole", 0.1988387815159, "pole");
            }
        }

        public static LengthUnit Arshin {
            get {
                return new LengthUnit("Arshin", 1.406, "arshin");
            }
        }

        public static LengthUnit Fathom {
            get {
                return new LengthUnit("Fathom", 0.5468066491687, "ftm");
            }
        }

        public static LengthUnit Mil {
            get {
                return new LengthUnit("Mil", 39370.07874016, "mil");
            }
        }

        public static LengthUnit Ell {
            get {
                return new LengthUnit("Ell", 0.8748906386702, "ell");
            }
        }

        public static LengthUnit Link {
            get {
                return new LengthUnit("Link", 4.970969537899, "lnk");
            }
        }

        public static LengthUnit Cubit {
            get {
                return new LengthUnit("Cubit", 2.187226596675, "cubit");
            }
        }

        public static LengthUnit Hand {
            get {
                return new LengthUnit("Hand", 9.842519685039, "h");
            }
        }

        public static LengthUnit Spoon {
            get {
                return new LengthUnit("Spoon", 4.374453193351, "spoon");
            }
        }

        public static LengthUnit Finger {
            get {
                return new LengthUnit("Finger", 8.748906386702, "finger");
            }
        }

        public static LengthUnit Nail {
            get {
                return new LengthUnit("Nail", 17.4978127734, "nail");
            }
        }

        public static LengthUnit BarleyCorn {
            get {
                return new LengthUnit("BarleyCorn", 118.1102362205, "barleycorn");
            }
        }

        public static LengthUnit Angstrom {
            get {
                return new LengthUnit("Angstrom", 10000000000, "A");
            }
        }

        public static LengthUnit AtomicUnitLength {
            get {
                return new LengthUnit("AtomicUnitOfLength", 18897259885.79, "au");
            }
        }

        public static LengthUnit XCopperUnit {
            get {
                return new LengthUnit("XCopperUnit", 9979243174198.0, "xu");
            }
        }

        public static LengthUnit Fermi {
            get {
                return new LengthUnit("Fermi", 1.0E+15, "fm");
            }
        }

        public static LengthUnit Arpent {
            get {
                return new LengthUnit("Arpent", 0.01708770778653, "arpent");
            }
        }

        public static LengthUnit Pica {
            get {
                return new LengthUnit("Pica", 236.2204724409, "pica");
            }
        }

        public static LengthUnit Point {
            get {
                return new LengthUnit("Point", 2834.645669291, "pt");
            }
        }

        public static LengthUnit Twip {
            get {
                return new LengthUnit("Twip", 56692.91338583, "twip"); // Twentieth of a point
            }
        }

        public static LengthUnit Aln {
            get {
                return new LengthUnit("Aln", 1.684131736527, "aln");
            }
        }

        public static LengthUnit Famn {
            get {
                return new LengthUnit("Famn", 0.561377245509, "famn");
            }
        }

        public static LengthUnit Ken {
            get {
                return new LengthUnit("Ken", 0.4720632942465, "ken");
            }
        }

        public static LengthUnit Caliber {
            get {
                return new LengthUnit("Caliber", 3937.007874016, "cl");
            }
        }

        public static LengthUnit RussianArshin {
            get {
                return new LengthUnit("RussianArshin", 1.40607424072, "RUarshin");
            }
        }

        public static LengthUnit RomanActus {
            get {
                return new LengthUnit("RomanActus", 0.02818590975097, "ROMactus");
            }
        }

        public static LengthUnit VaraDeTarea {
            get {
                return new LengthUnit("VaraDeTarea", 0.3991289409992, "VDT");
            }
        }

        public static LengthUnit VaraConuquera {
            get {
                return new LengthUnit("VaraConuquera", 0.3991289409992, "VCQ");
            }
        }

        public static LengthUnit VaraCastellana {
            get {
                return new LengthUnit("VaraCastellana", 1.197386822997, "VCA");
            }
        }

        public static LengthUnit GreekCubit {
            get {
                return new LengthUnit("GreekCubit", 2.160816615815, "GRcubit");
            }
        }

        public static LengthUnit LongReed {
            get {
                return new LengthUnit("LongReed", 0.3124609423822, "long reed");
            }
        }

        public static LengthUnit Reed {
            get {
                return new LengthUnit("Reed", 0.3645377661126, "reed");
            }
        }

        public static LengthUnit LongCubit {
            get {
                return new LengthUnit("LongCubit", 1.874765654293, "long cubit");
            }
        }

        public static LengthUnit HandBreadth {
            get {
                return new LengthUnit("HandBreadth", 13.12335958005, "handbreadth");
            }
        }

        public static LengthUnit EarthsEquatorialRadius {
            get {
                return new LengthUnit("EarthsEquatorialRadius", 0.0000001567850289112, "earths eq. radius");
            }
        }

        public static LengthUnit EarthsPolarRadius {
            get {
                return new LengthUnit("EarthsPolarRadius", 0.0000001573124242049, "earths polar radius");
            }
        }

        public static LengthUnit EarthSunMeanDistance {
            get {
                return new LengthUnit("EarthsSunDistance", 0.00000000000668449197861, "AU");
            }
        }

        public static LengthUnit EarthMoonMeanDistance {
            get {
                return new LengthUnit("EarthMoonMeanDistance", 0.000000002604166, "LD");
            }
        }

        public static LengthUnit FingerBreadth {
            get {
                return new LengthUnit("FingerBreadth", 52.4934383202, "fingerbreadth");
            }
        }

        public static LengthUnit PlanckLength {
            get {
                return new LengthUnit("PlanckLength", 6.187927353733E+34, "ℓP");
            }
        }

        public static LengthUnit ElectronRadius {
            get {
                return new LengthUnit("ElectronRadius", 354869043883300.0, "er");
            }
        }

        public static LengthUnit BohrRadius {
            get {
                return new LengthUnit("BohrRadius", 18897259885.79, "b a.u.");
            }
        }

        public static LengthUnit SunRadius {
            get {
                return new LengthUnit("SunRadius", 0.000000001436781609195, "radofsun");
            }
        }

        public static LengthUnit LightNanosecond {
            get {
                return new LengthUnit("LightNanosecond", 3.335640951982, new Dictionary<UnitOfMeasure, int> { { SpeedUnit.SpeedOfLight, 1 }, { TimeUnit.Nanosecond, 1 } });
            }
        }

        public static LengthUnit LightMicrosecond {
            get {
                return new LengthUnit("LightMicrosecond", 3.335640951982, new Dictionary<UnitOfMeasure, int> { { SpeedUnit.SpeedOfLight, 1 }, { TimeUnit.Microsecond, 1 } });
            }
        }

        public static LengthUnit LightMillisecond {
            get {
                return new LengthUnit("LightMillisecond", 0.000003335640951982, new Dictionary<UnitOfMeasure, int> { { SpeedUnit.SpeedOfLight, 1 }, { TimeUnit.Millisecond, 1 } });
            }
        }

        public static LengthUnit LightSecond {
            get {
                return new LengthUnit("Lightsecond", 0.000000003335640951982, new Dictionary<UnitOfMeasure, int> { { SpeedUnit.SpeedOfLight, 1 }, { TimeUnit.Second, 1 } });
            }
        }

        public static LengthUnit LightMinute {
            get {
                return new LengthUnit("LightMinute", 0.00000000005559401586636, new Dictionary<UnitOfMeasure, int> { { SpeedUnit.SpeedOfLight, 1 }, { TimeUnit.Minute, 1 } });
            }
        }

        public static LengthUnit LightHour {
            get {
                return new LengthUnit("LightHour", 0.000000000000926566931106, new Dictionary<UnitOfMeasure, int> { { SpeedUnit.SpeedOfLight, 1 }, { TimeUnit.Hour, 1 } });
            }
        }

        public static LengthUnit LightDay {
            get {
                return new LengthUnit("LightDay", 0.00000000000003860695546275, new Dictionary<UnitOfMeasure, int> { { SpeedUnit.SpeedOfLight, 1 }, { TimeUnit.Day, 1 } });
            }
        }

        public static LengthUnit LightWeek {
            get {
                return new LengthUnit("LightWeek", 0.000000000000005515279351821, new Dictionary<UnitOfMeasure, int> { { SpeedUnit.SpeedOfLight, 1 }, { TimeUnit.Week, 1 } });
            }
        }

        public static LengthUnit LightMonth {
            get {
                return new LengthUnit("LightMonth", 0.000000000001158208663882, new Dictionary<UnitOfMeasure, int> { { SpeedUnit.SpeedOfLight, 1 }, { TimeUnit.Month, 1 } });
            }
        }

        public static LengthUnit LightYear {
            get {
                return new LengthUnit("LightYear", 0.0000000000000001057000834025, new Dictionary<UnitOfMeasure, int> { { SpeedUnit.SpeedOfLight, 1 }, { TimeUnit.Year, 1 } });
            }
        }

        public static LengthUnit CableLength {
            get {
                return new LengthUnit("CableLength", 0.005399568034557, "cl");
            }
        }

        public static LengthUnit CableLengthImperial {
            get {
                return new LengthUnit("CableLengthImperial", 0.005396118248377, "cli");
            }
        }

        public static LengthUnit RackUnit {
            get {
                return new LengthUnit("RackUnit", 22.49718785152, "RU");
            }
        }

        public static LengthUnit HorizontalPitch {
            get {
                return new LengthUnit("HorizontalPitch", 196.8503937008, "HP");
            }
        }

        public static LengthUnit Cicero {
            get {
                return new LengthUnit("Cicero", 222.2222222222, "cicero");
            }
        }

        public static LengthUnit Pixel17in1280_1024 {
            get {
                return new LengthUnit("Pixel17in1280_1024", 222.2222222222, "pixel");
            }
        }

        public static LengthUnit Liniya {
            get {
                return new LengthUnit("Liniya", 393.7007874016, "line");
            }
        }

        public static LengthUnit Diuym {
            get {
                return new LengthUnit("Diuym", 39.37007874016, "diuym");
            }
        }

        public static LengthUnit Vershok {
            get {
                return new LengthUnit("Vershok", 22.49718785152, "ver");
            }
        }

        public static LengthUnit Pyad {
            get {
                return new LengthUnit("Pyad", 5.62429696288, "pyad");
            }
        }

        public static LengthUnit Fut {
            get {
                return new LengthUnit("Fut", 3.280839895013, "fut");
            }
        }

        public static LengthUnit Sazhen {
            get {
                return new LengthUnit("Sazhen", 0.4686914135733, "fathom");
            }
        }

        public static LengthUnit KosayaSazhen {
            get {
                return new LengthUnit("KosayaSazhen", 0.4032258064516, "kfathom");
            }
        }

        public static LengthUnit Versta {
            get {
                return new LengthUnit("Versta", 0.0009373828271466, "versta");
            }
        }

        public static LengthUnit MezhevayaVersta {
            get {
                return new LengthUnit("MezhevayaVersta", 0.0004686914135733, "mversta");
            }
        }
    }
}

