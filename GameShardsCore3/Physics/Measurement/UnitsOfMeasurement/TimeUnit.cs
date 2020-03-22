using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    /// <summary>
    /// Time Unit class
    /// </summary>
    public class TimeUnit : UnitOfMeasure {
        public TimeUnit(string name, double ratio, string symbol) : base(name: name, ratio: ratio, symbol: symbol) {
        }

        public TimeUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(name: name, ratio: ratio, dimension: dimension) {
        }

        public static TimeUnit Second {
            get {
                return new TimeUnit("Second", 1, "s");
            }
        }

        public static TimeUnit SyderealSecond {
            get {
                return new TimeUnit("SyderealSecond", 1.002737915528, "Ss");
            }
        }

        public static TimeUnit Minute {
            get {
                return new TimeUnit("Minute", 1 / (double)60, "min");
            }
        }

        public static TimeUnit SyderealMinute {
            get {
                return new TimeUnit("SyderealMinute", 0.01671229859214, "Smin");
            }
        }

        public static TimeUnit Hour {
            get {
                return new TimeUnit("Hour", 1 / (double)3600, "h");
            }
        }

        public static TimeUnit SyderealHour {
            get {
                return new TimeUnit("SyderealHour", 0.000278538309869, "Sh");
            }
        }

        public static TimeUnit Day {
            get {
                return new TimeUnit("Day", 1 / (double)86400, "d");
            }
        }

        public static TimeUnit SyderealDay {
            get {
                return new TimeUnit("SyderealDay", 0.00001160576291121, "Sd");
            }
        }

        public static TimeUnit Week {
            get {
                return new TimeUnit("Week", 1 / (double)604800, "Week");
            }
        }

        public static TimeUnit Month {
            get {
                return new TimeUnit("Month", 1 / (double)2628000, "Month");
            }
        }

        public static TimeUnit DraconicMonth {
            get {
                return new TimeUnit("DraconicMonth", 0.0000004253263450786, "DMonth");
            }
        }

        public static TimeUnit AnomalisticMonth {
            get {
                return new TimeUnit("AnomalisticMonth", 0.0000004200422098736, "AMonth");
            }
        }

        public static TimeUnit SyderealMonth {
            get {
                return new TimeUnit("SyderealMonth", 1 / (double)2628000, "SMonth");
            }
        }

        public static TimeUnit SynodicMonth {
            get {
                return new TimeUnit("SynodicMonth", 0.0000003919349445685, "SynMonth");
            }
        }

        public static TimeUnit Year {
            get {
                return new TimeUnit("Year", 1 / (double)31536000, "Year");
            }
        }

        public static TimeUnit AnomalisticYear {
            get {
                return new TimeUnit("AnomalisticYear", 0.000000031687251843159997, "AYear");
            }
        }

        public static TimeUnit DraconicYear {
            get {
                return new TimeUnit("DraconicYear", 0.00000003339123980222, "DYear");
            }
        }

        public static TimeUnit JulianYear {
            get {
                return new TimeUnit("JulianYear", 1 / (double)31557600, "JYear");
            }
        }

        public static TimeUnit LeapYear {
            get {
                return new TimeUnit("LeapYear", 1 / (double)31622400, "LeapYear");
            }
        }

        public static TimeUnit TropicalYear {
            get {
                return new TimeUnit("TropicalYear", 1 / (double)31556930, "TYear");
            }
        }

        public static TimeUnit SiderealYear {
            get {
                return new TimeUnit("SiderealYear", 0.00000003168753601134, "SYear");
            }
        }

        public static TimeUnit GregorianYear {
            get {
                return new TimeUnit("GregorianYear", 0.0000000316887385068, "GYear");
            }
        }

        public static TimeUnit Decade {
            get {
                return new TimeUnit("Decade", 1 / (double)315360000, "Decade");
            }
        }

        public static TimeUnit Century {
            get {
                return new TimeUnit("Century", 1 / (double)3153600000, "Century");
            }
        }

        public static TimeUnit Millennium {
            get {
                return new TimeUnit("Millennium", 1 / (double)31536000000, "Millennium");
            }
        }

        public static TimeUnit Centisecond {
            get {
                return new TimeUnit("Centisecond", 100, "cs");
            }
        }

        public static TimeUnit Millisecond {
            get {
                return new TimeUnit("Millisecond", 1000, "ms");
            }
        }

        public static TimeUnit Microsecond {
            get {
                return new TimeUnit("Microsecond", 1000000.0, "μs");
            }
        }


        public static TimeUnit Nanosecond {
            get {
                return new TimeUnit("Millisecond", 1000000000, "ns");
            }
        }

        public static TimeUnit Shake {
            get {
                return new TimeUnit("Shake", 100000000, "shake");
            }
        }

        public static TimeUnit PlanckTime {
            get {
                return new TimeUnit("PlanckTime", 1.855094832448E+43, "Tp");
            }
        }

        public static TimeUnit Fortnight {
            get {
                return new TimeUnit("Fortnight", 0.0000008267195767196, "fortnight");
            }
        }
    }
}
