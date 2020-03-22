using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class CurrencyUnit : UnitOfMeasure {
        public CurrencyUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public CurrencyUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static CurrencyUnit Euro {
            get {
                return new CurrencyUnit("Euro", 1, "€");
            }
        }

        public static CurrencyUnit USDollar {
            get {
                return new CurrencyUnit("USDollar", 1.176332196212, "US$");
            }
        }

        public static CurrencyUnit CanadianDollar {
            get {
                return new CurrencyUnit("CanadianDollar", 1.479943536055, "C$");
            }
        }

        public static CurrencyUnit BritishPound {
            get {
                return new CurrencyUnit("BritishPound", 0.9137748500176, "£");
            }
        }

        public static CurrencyUnit JapaneseYen {
            get {
                return new CurrencyUnit("JapaneseYen", 128.452064463, "¥");
            }
        }

        public static CurrencyUnit SwissFranc {
            get {
                return new CurrencyUnit("SwissFranc", 1.135042936125, "SFr");
            }
        }

        public static CurrencyUnit AlgerianDinar {
            get {
                return new CurrencyUnit("AlgerianDinar", 129.5165274674, "DA");
            }
        }

        public static CurrencyUnit ArgentinePeso {
            get {
                return new CurrencyUnit("ArgentinePeso", 20.37077990825, "ARS$");
            }
        }

        public static CurrencyUnit AustralianDollar {
            get {
                return new CurrencyUnit("AustralianDollar", 1.482884366545, "A$");
            }
        }

        public static CurrencyUnit BahamianDollar {
            get {
                return new CurrencyUnit("BahamianDollar", 1.176332196212, "B$");
            }
        }

        public static CurrencyUnit BarbadianDollar {
            get {
                return new CurrencyUnit("BarbadianDollar", 2.352664392424, "Bds$");
            }
        }

        public static CurrencyUnit BermudianDollar {
            get {
                return new CurrencyUnit("BermudianDollar", 1.176332196212, "BD$");
            }
        }

        public static CurrencyUnit BrazilianReal {
            get {
                return new CurrencyUnit("BrazilianReal", 3.700505822844, "R$");
            }
        }

        public static CurrencyUnit BulgarianLev {
            get {
                return new CurrencyUnit("BulgarianLev", 1.95965180567, "Лв");
            }
        }

        public static CurrencyUnit ChileanPeso {
            get {
                return new CurrencyUnit("ChileanPeso", 760.169274203, "CLP$");
            }
        }

        public static CurrencyUnit ChineseYuan {
            get {
                return new CurrencyUnit("ChineseYuan", 7.846723914834, "CNY¥");
            }
        }

        public static CurrencyUnit CzechKoruna {
            get {
                return new CurrencyUnit("CzechKoruna", 26.05364074815, "Kc");
            }
        }

        public static CurrencyUnit DanishKroner {
            get {
                return new CurrencyUnit("DanishKroner", 7.529820021174, "kr");
            }
        }

        public static CurrencyUnit EgyptianPound {
            get {
                return new CurrencyUnit("EgyptianPound", 21.14833548994, "E£");
            }
        }

        public static CurrencyUnit FijianDollar {
            get {
                return new CurrencyUnit("FijianDollar", 2.374779437713, "FJ$");
            }
        }

        public static CurrencyUnit HongKongDollar {
            get {
                return new CurrencyUnit("HongKongDollar", 9.202917303847, "HK$");
            }
        }

        public static CurrencyUnit HungarianForint {
            get {
                return new CurrencyUnit("HungarianForint", 303.8963651335, "Ft");
            }
        }

        public static CurrencyUnit IcelandicKróna {
            get {
                return new CurrencyUnit("IcelandicKróna", 126.4158334314, "ISKkr");
            }
        }

        public static CurrencyUnit IndianRupee {
            get {
                return new CurrencyUnit("IndianRupee", 75.477237972, "₹");
            }
        }

        public static CurrencyUnit IndonesianRupiah {
            get {
                return new CurrencyUnit("IndonesianRupiah", 15718.9705917, "Rp");
            }
        }

        public static CurrencyUnit IsraeliNewShekel {
            get {
                return new CurrencyUnit("IsraeliNewShekel", 4.258322550288, "₪");
            }
        }

        public static CurrencyUnit JamaicanDollar {
            get {
                return new CurrencyUnit("JamaicanDollar", 149.6118103752, "J$");
            }
        }

        public static CurrencyUnit JordanianDinar {
            get {
                return new CurrencyUnit("JordanianDinar", 0.8309610634043, "JOD");
            }
        }

        public static CurrencyUnit LatvianLats {
            get {
                return new CurrencyUnit("LatvianLats", 0.761792730267, "Ls");
            }
        }

        public static CurrencyUnit LebanesePound {
            get {
                return new CurrencyUnit("LebanesePound", 1772.909069521, "L£");
            }
        }

        public static CurrencyUnit LithuanianLitas {
            get {
                return new CurrencyUnit("LithuanianLitas", 3.742853781908, "Lt");
            }
        }

        public static CurrencyUnit MalaysianRinggit {
            get {
                return new CurrencyUnit("MalaysianRinggit", 5.049523585461, "MYR");
            }
        }

        public static CurrencyUnit MexicanPeso {
            get {
                return new CurrencyUnit("MexicanPeso", 20.82378543701, "MXN$");
            }
        }

        public static CurrencyUnit NewZelandDollar {
            get {
                return new CurrencyUnit("NewZelandDollar", 1.608987177979, "NZ$");
            }
        }

        public static CurrencyUnit NorwayKrone {
            get {
                return new CurrencyUnit("NorwayKrone", 9.301729208328, "NOKkr");
            }
        }

        public static CurrencyUnit PakistaniRupee {
            get {
                return new CurrencyUnit("PakistaniRupee", 124.1550405835, "Rs");
            }
        }

        public static CurrencyUnit PhilippinePeso {
            get {
                return new CurrencyUnit("PhilippinePeso", 60.52287966122, "₱");
            }
        }

        public static CurrencyUnit PolishZloty {
            get {
                return new CurrencyUnit("PolishZloty", 4.283378426068, "zl");
            }
        }

        public static CurrencyUnit RomanianLeu {
            get {
                return new CurrencyUnit("RomanianLeu", 4.598753087872, "RON");
            }
        }

        public static CurrencyUnit RussianRuble {
            get {
                return new CurrencyUnit("RussianRuble", 69.135513469, "py6");
            }
        }

        public static CurrencyUnit SaudiRiyal {
            get {
                return new CurrencyUnit("SaudiRiyal", 4.413833666627, "ر.س"); // Thanks god that Visual Studio 2015 supports unicode
            }
        }

        public static CurrencyUnit SingaporeDollar {
            get {
                return new CurrencyUnit("SingaporeDollar", 1.608163745442, "S$");
            }
        }

        public static CurrencyUnit SouthAfricanRand {
            get {
                return new CurrencyUnit("SouthAfricanRand", 15.49935301729, "R");
            }
        }

        public static CurrencyUnit SouthKoreanWon {
            get {
                return new CurrencyUnit("SouthKoreanWon", 1342.004352429, "?");
            }
        }

        public static CurrencyUnit SwedishKronor {
            get {
                return new CurrencyUnit("SwedishKronor", 9.548288436655, "SEKkr");
            }
        }

        public static CurrencyUnit NewTaiwanDollar {
            get {
                return new CurrencyUnit("NewTaiwanDollar", 35.6900364663, "NT$");
            }
        }

        public static CurrencyUnit ThaiBaht {
            get {
                return new CurrencyUnit("ThaiBaht", 39.07293259617, "฿");
            }
        }

        public static CurrencyUnit TurkishLira {
            get {
                return new CurrencyUnit("TurkishLira", 4.140924597106, "TRY");
            }
        }

        public static CurrencyUnit UkranianHryvnia {
            get {
                return new CurrencyUnit("UkranianHryvnia", 30.01117515586, "₴");
            }
        }

        public static CurrencyUnit ItalianLira {
            get {
                return new CurrencyUnit("ItalianLira", 1936.27, "₤");
            }
        }
    }
}
