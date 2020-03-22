using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class VolumeUnit : UnitOfMeasure {
        public VolumeUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public VolumeUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static VolumeUnit Liter {
            get {
                return new VolumeUnit("Liter", 1, "l");
            }
        }

        public static VolumeUnit USDryBarrel {
            get {
                return new VolumeUnit("USDryBarrel", 0.008648489807853, "UDbbl");
            }
        }

        public static VolumeUnit USDryPint {
            get {
                return new VolumeUnit("USDryPint", 1.816165968398, "UDpt");
            }
        }

        public static VolumeUnit USDryQuart {
            get {
                return new VolumeUnit("USDryQuart", 0.9080829841988, "UDqt");
            }
        }

        public static VolumeUnit USPeck {
            get {
                return new VolumeUnit("USPeck", 0.1135103730248, "USpk");
            }
        }

        public static VolumeUnit UKPeck {
            get {
                return new VolumeUnit("UKPeck", 0.1099846241495, "UKpk");
            }
        }

        public static VolumeUnit USBushel {
            get {
                return new VolumeUnit("USBushel", 0.02837759325621, "USbu");
            }
        }

        public static VolumeUnit UKBushel {
            get {
                return new VolumeUnit("UKBushel", 0.02749615603739, "UKbu");
            }
        }

        public static VolumeUnit Cor {
            get {
                return new VolumeUnit("Cor", 0.004545454766699, "cor");
            }
        }

        public static VolumeUnit Homer {
            get {
                return new VolumeUnit("Homer", 0.004545454766699, "homer");
            }
        }

        public static VolumeUnit Ephah {
            get {
                return new VolumeUnit("Ephah", 0.04545454766699, "ephah");
            }
        }

        public static VolumeUnit Seah {
            get {
                return new VolumeUnit("Seah", 0.136363643001, "seah");
            }
        }

        public static VolumeUnit Omer {
            get {
                return new VolumeUnit("Omer", 0.4545454766699, "omer");
            }
        }

        public static VolumeUnit Cab {
            get {
                return new VolumeUnit("Cab", 0.8181818580058, "cab");
            }
        }

        public static VolumeUnit Log {
            get {
                return new VolumeUnit("Log", 3.272727432023, "log");
            }
        }

        public static VolumeUnit CubicMeter {
            get {
                return new VolumeUnit("CubicMeter", 0.001, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 3 } });
            }
        }

        public static VolumeUnit USGallon {
            get {
                return new VolumeUnit("USGallon", 0.264172, "USgal");
            }
        }

        public static VolumeUnit USCup {
            get {
                return new VolumeUnit("USCup", 4.16667, "UScup");
            }
        }

        public static VolumeUnit MetricCup {
            get {
                return new VolumeUnit("MetricCup", 4000, "cup");
            }
        }

        public static VolumeUnit USFluidOunce {
            get {
                return new VolumeUnit("USFluidOunce", 33.814, "foz");
            }
        }

        public static VolumeUnit USTablespoon {
            get {
                return new VolumeUnit("USTablespoon", 67.628, "UStablespoon");
            }
        }

        public static VolumeUnit MetricTablespoon {
            get {
                return new VolumeUnit("MetricTablespoon", 66666.666666666672, "tablespoon");
            }
        }

        public static VolumeUnit USTeaSpoon {
            get {
                return new VolumeUnit("USTeaSpoon", 202.884, "USteaspoon");
            }
        }

        public static VolumeUnit MetricTeaSpoon {
            get {
                return new VolumeUnit("MetricTeaSpoon", 200000, "teaspoon");
            }
        }

        public static VolumeUnit ImperialGallon {
            get {
                return new VolumeUnit("ImperialGallon", 0.219969, "igal");
            }
        }

        public static VolumeUnit ImperialQuarter {
            get {
                return new VolumeUnit("ImperialQuarter", 0.879877, "iquarter");
            }
        }

        public static VolumeUnit ImperialPint {
            get {
                return new VolumeUnit("ImperialPint", 1.75975, "ipint");
            }
        }

        public static VolumeUnit ImperialCup {
            get {
                return new VolumeUnit("ImperialCup", 3.51951, "icup");
            }
        }

        public static VolumeUnit ImperialFluidOunce {
            get {
                return new VolumeUnit("ImperialFluidOunce", 35.1951, "ifoz");
            }
        }

        public static VolumeUnit ImperialSpoon {
            get {
                return new VolumeUnit("ImperialSpoon", 56.3121, "ispoon");
            }
        }

        public static VolumeUnit ImperialTeaSpoon {
            get {
                return new VolumeUnit("ImperialTeaSpoon", 168.936, "itspoon");
            }
        }

        public static VolumeUnit USBeerBarrel {
            get {
                return new VolumeUnit("USBeerBarrel", 0.000000810714, "USbeerbbl");
            }
        }

        public static VolumeUnit Firkins {
            get {
                return new VolumeUnit("Firkins", 0.0244410174933, "firkins");
            }
        }

        public static VolumeUnit Hogshead {
            get {
                return new VolumeUnit("Hogshead", 0.0041932071625644194, "hogshead");
            }
        }
        public static VolumeUnit KilderKins {
            get {
                return new VolumeUnit("KilderKins", 0.012220513794393765, "kilderkins");
            }
        }

        public static VolumeUnit BoardFoot {
            get {
                return new VolumeUnit("BoardFoot", 0.4237759988558048, "board ft");
            }
        }

        public static VolumeUnit CubicKilometer {
            get {
                return new VolumeUnit("CubicKilometer", 0.000000000001, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Kilometer, 3} } );
            }
        }

        public static VolumeUnit CubicMillimeter {
            get {
                return new VolumeUnit("CubicMillimeter", 1000000, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Millimeter, 3 } });
            }
        }

        public static VolumeUnit USDrams {
            get {
                return new VolumeUnit("USDrams", 270.51218127021269, "USD");
            }
        }

        public static VolumeUnit USFullKegs {
            get {
                return new VolumeUnit("USFullKegs", 0.008516799072835703, "USfullkegs");
            }
        }

        public static VolumeUnit Gills {
            get {
                return new VolumeUnit("Gills", 8.4535069820980073, "gills");
            }
        }

        public static VolumeUnit GrossRegisterTonne {
            get {
                return new VolumeUnit("GrossRegisterTonne", 0.00035314666721488673, "GRT");
            }
        }

        public static VolumeUnit ImperialDessertpoons {
            get {
                return new VolumeUnit("ImperialDessertpoons", 84.468156414431292, "idspoon");
            }
        }

        public static VolumeUnit USMinims {
            get {
                return new VolumeUnit("USMinims", 16230.736145849396, "USminims");
            }
        }

        public static VolumeUnit ImperialMinims {
            get {
                return new VolumeUnit("ImperialMinims", 16893.638269158771, "iminims");
            }
        }

        public static VolumeUnit Puncheons {
            get {
                return new VolumeUnit("Puncheons", 0.002, "puncheons");
            }
        }

        public static VolumeUnit RegisterTonne {
            get {
                return new VolumeUnit("RegisterTonne", 0.002, "registertonne");
            }
        }

        public static VolumeUnit Shots {
            get {
                return new VolumeUnit("Shots", 22.542681808055782, "shots");
            }
        }

        public static VolumeUnit Drop {
            get {
                return new VolumeUnit("Drop", 20000000, "drop");
            }
        }

        public static VolumeUnit CubicMile {
            get {
                return new VolumeUnit("CubicMile", 0.0000000002399127585789, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Mile, 3 } });
            }
        }

        public static VolumeUnit CubicYard {
            get {
                return new VolumeUnit("CubicYard", 1.307950619314, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Yard, 3 } });
            }
        }

        public static VolumeUnit CubicFoot {
            get {
                return new VolumeUnit("CubicFoot", 35.31466672149, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Foot, 3 } });
            }
        }

        public static VolumeUnit CubicInch {
            get {
                return new VolumeUnit("CubicInch", 61023.74409473, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Inch, 3 } });
            }
        }

        public static VolumeUnit AcreInch {
            get {
                return new VolumeUnit("AcreInch", 0.000009728558325479, new Dictionary<UnitOfMeasure, int> { { AreaUnit.Acre, 2 }, {LengthUnit.Inch, 1 } });
            }
        }

        public static VolumeUnit AcreFoot {
            get {
                return new VolumeUnit("AcreFoot", 8.107131937899e-7, new Dictionary<UnitOfMeasure, int> { { AreaUnit.Acre, 2 }, { LengthUnit.Foot, 1 } });
            }
        }

        public static VolumeUnit Stere {
            get {
                return new VolumeUnit("Stere", 1, "stere");
            }
        }

        public static VolumeUnit Cord {
            get {
                return new VolumeUnit("Cord", 0.2758958337616, "cord");
            }
        }

        public static VolumeUnit Tun {
            get {
                return new VolumeUnit("Tun", 1.048301795072, "tun");
            }
        }

        public static VolumeUnit Bath {
            get {
                return new VolumeUnit("Bath", 45.45454545455, "bath");
            }
        }

        public static VolumeUnit Taza {
            get {
                return new VolumeUnit("Taza", 4226.75283773, "taza");
            }
        }

        public static VolumeUnit EarthVolume {
            get {
                return new VolumeUnit("EarthVolume", 9.233610341644E-22, "V⊕");
            }
        }

        public static VolumeUnit PlanckVolume {
            get {
                return new VolumeUnit("PlanckVolume", 2.368714025156E+104, "Vp");
            }
        }

        public static VolumeUnit CubicAstronomicalUnit {
            get {
                return new VolumeUnit("CubicAstronomicalUnit", 2.986921186124E-34, new Dictionary<UnitOfMeasure, int> { { LengthUnit.AstronomicalUnit, 3 } });
            }
        }

        public static VolumeUnit CubicParsec {
            get {
                return new VolumeUnit("CubicParsec", 3.403675970048E-50, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Parsec, 3 } });
            }
        }

        public static VolumeUnit Bochka {
            get {
                return new VolumeUnit("Bochka", 2.032617824757, "bochka");
            }
        }

        public static VolumeUnit Vedro {
            get {
                return new VolumeUnit("Vedro", 81.3047129903, "vedro");
            }
        }

        public static VolumeUnit Shtoff {
            get {
                return new VolumeUnit("Shtoff", 813.047129903, "shtoff");
            }
        }

        public static VolumeUnit Chetvert {
            get {
                return new VolumeUnit("Chetvert", 325.2188519612, "chetvert");
            }
        }

        public static VolumeUnit WineBottle {
            get {
                return new VolumeUnit("WineBottle", 1300.875407845, "winebottle");
            }
        }

        public static VolumeUnit VodkaBottle {
            get {
                return new VolumeUnit("VodkaBottle", 1626.094259806, "vodkabottle");
            }
        }

        public static VolumeUnit Stakan {
            get {
                return new VolumeUnit("Stakan", 3658.712084563, "stakan");
            }
        }

        public static VolumeUnit Charka {
            get {
                return new VolumeUnit("Charka", 8130.47129903, "charka");
            }
        }

        public static VolumeUnit Shkalik {
            get {
                return new VolumeUnit("Shkalik", 16260.94259806, "shkalik");
            }
        }
    }
}