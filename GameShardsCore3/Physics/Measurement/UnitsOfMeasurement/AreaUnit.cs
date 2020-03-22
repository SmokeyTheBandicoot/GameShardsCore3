using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class AreaUnit : UnitOfMeasure {
        public AreaUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public AreaUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static AreaUnit SquareMeter {
            get {
                return new AreaUnit("SquareMeter", 1, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Meter, 2 } });
            }
        }

        public static AreaUnit SquareCentimeter {
            get {
                return new AreaUnit("SquareCentimeter", 10000, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Centimeter, 2 } });
            }
        }

        public static AreaUnit SquareMile {
            get {
                return new AreaUnit("SquareMile", 0.0000003861021585424, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Mile, 2 } });
            }
        }

        public static AreaUnit SquareYard {
            get {
                return new AreaUnit("SquareYard", 1.195990046301, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Yard, 2 } });
            }
        }

        public static AreaUnit SquareFoot {
            get {
                return new AreaUnit("SquareFoot", 10.76391041671, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Foot, 2 } });
            }
        }

        public static AreaUnit SquareInch {
            get {
                return new AreaUnit("SquareInch", 1550.003100006, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Inch, 2 } });
            }
        }

        public static AreaUnit CircularInch {
            get {
                return new AreaUnit("CircularInch", 1973.52524139, "cinch^2");
            }
        }

        public static AreaUnit Acre {
            get {
                return new AreaUnit("Acre", 0.0002471053814672, "acre");
            }
        }

        public static AreaUnit Hectare {
            get {
                return new AreaUnit("Hectare", 0.0001, "hectare");
            }
        }

        public static AreaUnit Are {
            get {
                return new AreaUnit("Are", 0.01, "are");
            }
        }

        public static AreaUnit Barn {
            get {
                return new AreaUnit("Barn", 1.0E+28, "bn");
            }
        }

        public static AreaUnit CricketPitch {
            get {
                return new AreaUnit("CricketPitch", 1 / (3.05 * 20.12), "CP");
            }
        }

        public static AreaUnit Dunam {
            get {
                return new AreaUnit("Dunam", 0.001, "dn");
            }
        }

        public static AreaUnit FootballField {
            get {
                return new AreaUnit("FootballField", 1 / (double)7140, "FF");
            }
        }

        public static AreaUnit FootballPitch {
            get {
                return new AreaUnit("FootballPitch", 1 / (91.4 * 46), "FP");
            }
        }

        public static AreaUnit Ping {
            get {
                return new AreaUnit("Ping", 3.30579, "ping");
            }
        }

        public static AreaUnit PlanckArea {
            get {
                return new AreaUnit("PlanckArea", 2.6121E-70, "Ap");
            }
        }

        public static AreaUnit Section {
            get {
                return new AreaUnit("Section", 0.0000003861021585424, "section");
            }
        }

        public static AreaUnit SurveyTownship {
            get {
                return new AreaUnit("SurveyTownship", 0.00000001072505995951, "ST");
            }
        }

        public static AreaUnit Rood {
            get {
                return new AreaUnit("Rood", 0.0009884215258687, "Rood");
            }
        }

        public static AreaUnit SquareChain {
            get {
                return new AreaUnit("SquareChain", 0.002471053814672, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Chain, 2 } });
            }
        }

        public static AreaUnit SquareRod {
            get {
                return new AreaUnit("SquareRod", 0.03953686103475, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Rod, 2 } });
            }
        }

        public static AreaUnit SquarePerch {
            get {
                return new AreaUnit("SquarePerch", 0.03953686103475, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Perch, 2 } });
            }
        }

        public static AreaUnit SquarePole {
            get {
                return new AreaUnit("SquarePole", 0.03953686103475, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Pole, 2 } });
            }
        }

        public static AreaUnit SquareMil {
            get {
                return new AreaUnit("SquareMil", 1550003100.006, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Mil, 2 } });
            }
        }

        public static AreaUnit CircularMil {
            get {
                return new AreaUnit("CircularMil", 1973525241.39, "circular mil");
            }
        }

        public static AreaUnit Homestead {
            get {
                return new AreaUnit("Homestead", 0.00000154440863417, "homestead");
            }
        }

        public static AreaUnit Sabin {
            get {
                return new AreaUnit("Sabin", 10.76391041671, "sabin");
            }
        }

        public static AreaUnit Arpent {
            get {
                return new AreaUnit("Arpent", 0.00029250542597, "arpent");
            }
        }

        public static AreaUnit Cuerda {
            get {
                return new AreaUnit("Cuerda", 0.0002544273135354, "cuerda");
            }
        }

        public static AreaUnit VarasCastellanasCuad {
            get {
                return new AreaUnit("VarasCastellanasCuad", 1.431153638637, "vca");
            }
        }

        public static AreaUnit VarasConuquerasCuad {
            get {
                return new AreaUnit("VarasConuquerasCuad", 0.1590170709596, "vco");
            }
        }

        public static AreaUnit ElectronCrossSection {
            get {
                return new AreaUnit("ElectronCrossSection", 1.503202964749E+28, "ecs");
            }
        }

        public static AreaUnit Desyatina {
            get {
                return new AreaUnit("Desyatina", 0.00009152982957145, "desyatina");
            }
        }

        public static AreaUnit SquareVersta {
            get {
                return new AreaUnit("SquareVersta", 0.000000878734622144, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Versta, 2 } });
            }
        }

        public static AreaUnit SquareArshin {
            get {
                return new AreaUnit("SquareArshin", 0.000000878734622144, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Arshin, 2 } });
            }
        }

        public static AreaUnit SquareSazhen {
            get {
                return new AreaUnit("SquareSazhen", 0.000000878734622144, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Sazhen,  2 } });
            }
        }

        public static AreaUnit SquareDiuym {
            get {
                return new AreaUnit("SquareDiuym", 0.000000878734622144, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Diuym, 2 } });
            }
        }

        public static AreaUnit SquareLiniya {
            get {
                return new AreaUnit("SquareLiniya", 0.000000878734622144, new Dictionary<UnitOfMeasure, int> { { LengthUnit.Liniya, 2 } });
            }
        }
    }
}
