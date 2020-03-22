using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class DataStorageUnit : UnitOfMeasure {

        public DataStorageUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public DataStorageUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }
        public static DataStorageUnit Bit {
            get {
                return new DataStorageUnit("Bit", 1, "bit");
            }
        }

        public static DataStorageUnit Nibble {
            get {
                return new DataStorageUnit("Nibble", 0.25, "nibble");
            }
        }

        public static DataStorageUnit Byte_ {
            get {
                return new DataStorageUnit("Byte", 0.125, "byte");
            }
        }

        public static DataStorageUnit Character {
            get {
                return new DataStorageUnit("Character", 0.125, "char");
            }
        }

        public static DataStorageUnit Word {
            get {
                return new DataStorageUnit("Word", 0.0625, "word");
            }
        }

        public static DataStorageUnit MAPMWord {
            get {
                return new DataStorageUnit("MAPMWord", 0.03125, "MAPMword");
            }
        }

        public static DataStorageUnit Block {
            get {
                return new DataStorageUnit("Block", 0.000244140625, "block");
            }
        }

        public static DataStorageUnit Kibibit {
            get {
                return new DataStorageUnit("Kibibit", 0.0009765625, "Kibit");
            }
        }

        public static DataStorageUnit FloppyDisk3p5DD {
            get {
                return new DataStorageUnit("FloppyDisk3p5DD", 0.0000001715072883737, "FloppyDisk3p5DD");
            }
        }

        public static DataStorageUnit FloppyDisk3p5HD {
            get {
                return new DataStorageUnit("FloppyDisk3p5HD", 0.00000008575364418686, "FloppyDisk3p5HD");
            }
        }

        public static DataStorageUnit FloppyDisk3p5ED {
            get {
                return new DataStorageUnit("FloppyDisk3p5ED", 0.00000004287682209343, "FloppyDisk3p5ED");
            }
        }

        public static DataStorageUnit FloppyDisk5p25DD {
            get {
                return new DataStorageUnit("FloppyDisk5p25DD", 0.0000003430145767475, "FloppyDisk5p25DD");
            }
        }

        public static DataStorageUnit FloppyDisk5p25HD {
            get {
                return new DataStorageUnit("FloppyDisk5p25HD", 0.0000001029694749051, "FloppyDisk5p25HD");
            }
        }

        public static DataStorageUnit Zip100 {
            get {
                return new DataStorageUnit("Zip100", 0.000000001244624813924, "Zip100");
            }
        }

        public static DataStorageUnit Zip250 {
            get {
                return new DataStorageUnit("Zip250", 0.0000000004978499255694, "Zip250");
            }
        }

        public static DataStorageUnit Jaz1GB {
            get {
                return new DataStorageUnit("Jaz1GB", 0.0000000001164153218269, "Jaz1GB");
            }
        }

        public static DataStorageUnit Jaz2GB {
            get {
                return new DataStorageUnit("Jaz2GB", 0.00000000005820766091347, "Jaz2GB");
            }
        }

        public static DataStorageUnit CD74Minutes {
            get {
                return new DataStorageUnit("CD74Minutes", 0.0000000001835378840047, "CD74Minutes");
            }
        }

        public static DataStorageUnit CD80Minutes {
            get {
                return new DataStorageUnit("CD80Minutes", 0.0000000001697725428352, "CD80Minutes");
            }
        }

        public static DataStorageUnit DVD1Layer1Side {
            get {
                return new DataStorageUnit("DVD1Layer1Side", 0.00000000002476921740999, "DVD1Layer1Side");
            }
        }

        public static DataStorageUnit DVD2Layer1Side {
            get {
                return new DataStorageUnit("DVD2Layer1Side", 0.00000000001369592021493, "DVD2Layer1Side");
            }
        }

        public static DataStorageUnit DVD1Layer2Side {
            get {
                return new DataStorageUnit("DVD1Layer2Side", 0.00000000001238460870499, "DVD1Layer2Side");
            }
        }

        public static DataStorageUnit DVD2Layer2Side {
            get {
                return new DataStorageUnit("DVD2Layer2Side", 0.000000000006847960107467, "DVD2Layer2Side");
            }
        }

        public static DataStorageUnit BluRayDiskSingleLayer {
            get {
                return new DataStorageUnit("BluRayDiskSingleLayer", 0.000000000004656612873077, "BluRayDiskSingleLayer");
            }
        }

        public static DataStorageUnit BluRayDiskDoubleLayer {
            get {
                return new DataStorageUnit("BluRayDiskDoubleLayer", 0.000000000002328306436539, "BluRayDiskDoubleLayer");
            }
        }
    }
}
