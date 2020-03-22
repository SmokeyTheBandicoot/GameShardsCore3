using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class AngularVelocityUnit : UnitOfMeasure {

        public AngularVelocityUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public AngularVelocityUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static AngularVelocityUnit RadiantPerSecond {
            get {
                return new AngularVelocityUnit("RadiantPerSecond", 1, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Radiant, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static AngularVelocityUnit RadiantPerDay {
            get {
                return new AngularVelocityUnit("RadiantPerDay", 86400, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Radiant, 1 }, { TimeUnit.Day, -1 } });
            }
        }

        public static AngularVelocityUnit RadiantPerHour {
            get {
                return new AngularVelocityUnit("RadiantPerHour", 3600, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Radiant, 1 }, { TimeUnit.Day, -1 } });
            }
        }

        public static AngularVelocityUnit RadiantPerMinute {
            get {
                return new AngularVelocityUnit("RadiantPerMinute", 60, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Radiant, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static AngularVelocityUnit RadiantPerWeek {
            get {
                return new AngularVelocityUnit("RadiantPerWeek", 12342.85714286, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Radiant, 1 }, { TimeUnit.Week, -1 } });
            }
        }

        public static AngularVelocityUnit RadiantPerMonth {
            get {
                return new AngularVelocityUnit("RadiantPerMonth", 2880, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Radiant, 1 }, { TimeUnit.Month, -1 } });
            }
        }

        public static AngularVelocityUnit RadiantPerYear {
            get {
                return new AngularVelocityUnit("RadiantPerYear", 236.7123287671, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Radiant, 1 }, { TimeUnit.Year, -1 } });
            }
        }

        public static AngularVelocityUnit DegreePerDay {
            get {
                return new AngularVelocityUnit("DegreePerDay", 4950355.34993, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Degree, 1 }, { TimeUnit.Day, -1 } });
            }
        }

        public static AngularVelocityUnit DegreePerHour {
            get {
                return new AngularVelocityUnit("DegreePerHour", 206264.8062471, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Degree, 1 }, { TimeUnit.Hour, -1 } });
            }
        }

        public static AngularVelocityUnit DegreePerMinute {
            get {
                return new AngularVelocityUnit("DegreePerMinute", 3437.746770785, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Degree, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static AngularVelocityUnit DegreePerSecond {
            get {
                return new AngularVelocityUnit("DegreePerSecond", 57.29577951308, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Degree, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static AngularVelocityUnit DegreePerWeek {
            get {
                return new AngularVelocityUnit("DegreePerWeek", 707193.6214186, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Degree, 1 }, { TimeUnit.Week, -1 } });
            }
        }

        public static AngularVelocityUnit DegreePerMonth {
            get {
                return new AngularVelocityUnit("DegreePerMonth", 165011.8449977, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Degree, 1 }, { TimeUnit.Month, -1 } });
            }
        }

        public static AngularVelocityUnit DegreePerYear {
            get {
                return new AngularVelocityUnit("DegreePerYear", 13562.61739707, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Degree, 1 }, { TimeUnit.Year, -1 } });
            }
        }

        public static AngularVelocityUnit RevolutionPerDay {
            get {
                return new AngularVelocityUnit("RevolutionPerDay", 13750.98708314, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Revolution, 1 }, { TimeUnit.Day, -1 } });
            }
        }

        public static AngularVelocityUnit RevolutionPerHour {
            get {
                return new AngularVelocityUnit("RevolutionPerHour", 572.9577951308, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Revolution, 1 }, { TimeUnit.Hour, -1 } });
            }
        }

        public static AngularVelocityUnit RevolutionPerMinute {
            get {
                return new AngularVelocityUnit("RevolutionPerMinute", 9.549296585514, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Revolution, 1 }, { TimeUnit.Minute, -1 } });
            }
        }

        public static AngularVelocityUnit RevolutionPerSecond {
            get {
                return new AngularVelocityUnit("RevolutionPerSecond", 0.1591549430919, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Revolution, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static AngularVelocityUnit RevolutionPerWeek {
            get {
                return new AngularVelocityUnit("RevolutionPerWeek", 1964.426726163, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Revolution, 1 }, { TimeUnit.Week, -1 } });
            }
        }

        public static AngularVelocityUnit RevolutionPerMonth {
            get {
                return new AngularVelocityUnit("RevolutionPerMonth", 458.3662361047, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Revolution, 1 }, { TimeUnit.Month, -1 } });
            }
        }

        public static AngularVelocityUnit RevolutionPerYear {
            get {
                return new AngularVelocityUnit("RevolutionPerYear", 37.67393721408, new Dictionary<UnitOfMeasure, int> { { PlaneAngleUnit.Revolution, 1 }, { TimeUnit.Year, -1 } });
            }
        }
    }
}
