using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.Physics.Measurement.UnitsOfMeasurement {
    public class DataTransferUnit : UnitOfMeasure {

        public DataTransferUnit(string name, double ratio, string symbol) : base(ratio: ratio, name: name, symbol: symbol) {
        }

        public DataTransferUnit(string name, double ratio, Dictionary<UnitOfMeasure, int> dimension) : base(ratio: ratio, name: name, dimension: dimension) {
        }

        public static DataTransferUnit BitsPerSecond {
            get {
                return new DataTransferUnit("BitsPerSeconds", 1, new Dictionary<UnitOfMeasure, int> { { DataStorageUnit.Bit, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static DataTransferUnit BytesPerSecond {
            get {
                return new DataTransferUnit("BytesPerSeconds", 1 / (double)8, new Dictionary<UnitOfMeasure, int> { { DataStorageUnit.Byte_, 1 }, { TimeUnit.Second, -1 } });
            }
        }

        public static DataTransferUnit Ethernet {
            get {
                return new DataTransferUnit("Ethernet", 0.0000001, "10BASE-T Ethernet");
            }
        }

        public static DataTransferUnit EthernetFast {
            get {
                return new DataTransferUnit("EthernetFast", 0.00000001, "100BASE-T Ethernet");
            }
        }

        public static DataTransferUnit EthernetGigabit {
            get {
                return new DataTransferUnit("EthernetGigabit", 0.000000001, "1000BASE-T Ethernet");
            }
        }

        public static DataTransferUnit OC1 {
            get {
                return new DataTransferUnit("OC1", 0.00000001929012345679, "OC1");
            }
        }

        public static DataTransferUnit OC3 {
            get {
                return new DataTransferUnit("OC3", 0.000000006430041152263, "OC3");
            }
        }

        public static DataTransferUnit OC12 {
            get {
                return new DataTransferUnit("OC12", 0.000000001607510288066, "OC12");
            }
        }

        public static DataTransferUnit OC24 {
            get {
                return new DataTransferUnit("OC24", 0.0000000008037551440329, "OC24");
            }
        }

        public static DataTransferUnit OC48 {
            get {
                return new DataTransferUnit("OC48", 0.0000000004018775720165, "OC48");
            }
        }

        public static DataTransferUnit OC192 {
            get {
                return new DataTransferUnit("OC192", 0.0000000001004693930041, "OC192");
            }
        }

        public static DataTransferUnit OC768 {
            get {
                return new DataTransferUnit("OC768", 0.00000000002511734825103, "OC768");
            }
        }

        public static DataTransferUnit ISDNSingle {
            get {
                return new DataTransferUnit("ISDNSingle", 0.000015625, "ISDNs");
            }
        }

        public static DataTransferUnit ISDNDual {
            get {
                return new DataTransferUnit("ISDNDual", 0.0000078125, "ISDNd");
            }
        }

        public static DataTransferUnit Modem110 {
            get {
                return new DataTransferUnit("Modem110", 0.009090909090909, "Modem110");
            }
        }

        public static DataTransferUnit Modem300 {
            get {
                return new DataTransferUnit("Modem300", 0.003333333333333, "Modem300");
            }
        }

        public static DataTransferUnit Modem1200 {
            get {
                return new DataTransferUnit("Modem1200", 0.0008333333333332, "Modem1200");
            }
        }

        public static DataTransferUnit Modem2400 {
            get {
                return new DataTransferUnit("Modem2400", 0.0004166666666667, "Modem2400");
            }
        }

        public static DataTransferUnit Modem9600 {
            get {
                return new DataTransferUnit("Modem9600", 0.0001041666666667, "Modem9600");
            }
        }

        public static DataTransferUnit Modem14p4k {
            get {
                return new DataTransferUnit("Modem14p4k", 0.00006944444444444, "Modem14p4k");
            }
        }

        public static DataTransferUnit Modem28p8k {
            get {
                return new DataTransferUnit("Modem28p8k", 0.00003472222222222, "Modem28p8k");
            }
        }

        public static DataTransferUnit Modem33p6k {
            get {
                return new DataTransferUnit("Modem33p6k", 0.0000297619047619, "Modem33p6k");
            }
        }

        public static DataTransferUnit Modem56k {
            get {
                return new DataTransferUnit("Modem56k", 0.00001785714285714, "Modem56k");
            }
        }

        public static DataTransferUnit SCSIAsync {
            get {
                return new DataTransferUnit("SCSIAsync", 0.00000008333333333332, "SCSIAsync");
            }
        }

        public static DataTransferUnit SCSISync {
            get {
                return new DataTransferUnit("SCSISync", 0.000000025, "SCSISync");
            }
        }

        public static DataTransferUnit SCSIFast {
            get {
                return new DataTransferUnit("SCSIFast", 0.0000000125, "SCSIFast");
            }
        }

        public static DataTransferUnit SCSIFastUltra {
            get {
                return new DataTransferUnit("SCSIFastUltra", 0.00000000625, "SCSIFastUltra");
            }
        }

        public static DataTransferUnit SCSIFastWide {
            get {
                return new DataTransferUnit("SCSIFastWide", 0.00000000625, "SCSIFastWide");
            }
        }

        public static DataTransferUnit SCSIFastUltraWide {
            get {
                return new DataTransferUnit("SCSIFastUltraWide", 0.000000003125, "SCSIFastUltraWide");
            }
        }

        public static DataTransferUnit SCSIFastUltra2 {
            get {
                return new DataTransferUnit("SCSIFastUltra2", 0.0000000015625, "SCSIFastUltra2");
            }
        }

        public static DataTransferUnit SCSIFastUltra3 {
            get {
                return new DataTransferUnit("SCSIFastUltra3", 0.00000000078125, "SCSIFastUltra3");
            }
        }

        public static DataTransferUnit SCSILVDUltra80 {
            get {
                return new DataTransferUnit("SCSILVDUltra80", 0.0000000015625, "SCSILVDUltra80");
            }
        }

        public static DataTransferUnit SCSILVDUltra160 {
            get {
                return new DataTransferUnit("SCSILVDUltra160", 0.00000000078125, "SCSILVDUltra160");
            }
        }

        public static DataTransferUnit IDEPIOMode0 {
            get {
                return new DataTransferUnit("IDEPIOMode0", 0.00000003787878787879, "IDEPIOMode0");
            }
        }

        public static DataTransferUnit IDEPIOMode1 {
            get {
                return new DataTransferUnit("IDEPIOMode1", 0.00000002403846153846, "IDEPIOMode1");
            }
        }

        public static DataTransferUnit IDEPIOMode2 {
            get {
                return new DataTransferUnit("IDEPIOMode2", 0.00000001506024096385, "IDEPIOMode2");
            }
        }

        public static DataTransferUnit IDEPIOMode3 {
            get {
                return new DataTransferUnit("IDEPIOMode3", 0.00000001126126126126, "IDEPIOMode3");
            }
        }

        public static DataTransferUnit IDEPIOMode4 {
            get {
                return new DataTransferUnit("IDEPIOMode4", 0.000000007530120481927, "IDEPIOMode4");
            }
        }

        public static DataTransferUnit IDEDMAMode0 {
            get {
                return new DataTransferUnit("IDEDMAMode0", 0.0000000297619047619, "IDEDMAMode0");
            }
        }

        public static DataTransferUnit IDEDMAMode1 {
            get {
                return new DataTransferUnit("IDEDMAMode1", 0.0000000093984962406, "IDEDMAMode1");
            }
        }

        public static DataTransferUnit IDEDMAMode2 {
            get {
                return new DataTransferUnit("IDEDMAMode2", 0.000000007530120481926, "IDEDMAMode2");
            }
        }

        public static DataTransferUnit IDEUDMAMode0 {
            get {
                return new DataTransferUnit("IDEUDMAMode0", 0.000000007530120481928, "IDEUDMAMode0");
            }
        }

        public static DataTransferUnit IDEUDMAMode1 {
            get {
                return new DataTransferUnit("IDEUDMAMode1", 0.000000005, "IDEUDMAMode1");
            }
        }

        public static DataTransferUnit IDEUDMAMode2 {
            get {
                return new DataTransferUnit("IDEUDMAMode2", 0.000000003787878787879, "IDEUDMAMode2");
            }
        }

        public static DataTransferUnit IDEUDMAMode3 {
            get {
                return new DataTransferUnit("IDEUDMAMode3", 0.0000000025, "IDEUDMAMode3");
            }
        }

        public static DataTransferUnit IDEUDMAMode4 {
            get {
                return new DataTransferUnit("IDEUDMAMode4", 0.000000001893939393939, "IDEUDMAMode4");
            }
        }

        public static DataTransferUnit IDEUDMA33 {
            get {
                return new DataTransferUnit("IDEUDMA33", 0.000000003787878787879, "IDEUDMA33");
            }
        }

        public static DataTransferUnit IDEUDMA66 {
            get {
                return new DataTransferUnit("IDEUDMA66", 0.000000001893939393939, "IDEUDMA66");
            }
        }

        public static DataTransferUnit USB1pX {
            get {
                return new DataTransferUnit("USB1pX", 0.00000008333333333332, "USB1.X");
            }
        }

        public static DataTransferUnit FireWire400IEEE1394_1995 {
            get {
                return new DataTransferUnit("FireWire400IEEE1394_1995", 0.0000000025, "FireWire400");
            }
        }

        public static DataTransferUnit T0Payload {
            get {
                return new DataTransferUnit("T0Payload", 0.00001785714285714, "T0Payload");
            }
        }

        public static DataTransferUnit T0B8ZSPayload {
            get {
                return new DataTransferUnit("T0B8ZSPayload", 0.000015625, "T0B8ZSPayload");
            }
        }

        public static DataTransferUnit T1Signal {
            get {
                return new DataTransferUnit("T1Signal", 0.0000006476683937824, "T1Signal");
            }
        }

        public static DataTransferUnit T1Payload {
            get {
                return new DataTransferUnit("T1Payload", 0.0000007440476190476, "T1Payload");
            }
        }

        public static DataTransferUnit T1ZPayload {
            get {
                return new DataTransferUnit("T1ZPayload", 0.0000006476683937824, "T1ZPayload");
            }
        }

        public static DataTransferUnit T1CSignal {
            get {
                return new DataTransferUnit("T1CSignal", 0.0000003172588832487, "T1CSignal");
            }
        }

        public static DataTransferUnit T1CPayload {
            get {
                return new DataTransferUnit("T1CPayload", 0.0000003720238095238, "T1CPayload");
            }
        }

        public static DataTransferUnit T2Signal {
            get {
                return new DataTransferUnit("T2Signal", 0.0000001584283903676, "T2Signal");
            }
        }

        public static DataTransferUnit T3Signal {
            get {
                return new DataTransferUnit("T3Signal", 0.00000002235336194564, "T3Signal");
            }
        }

        public static DataTransferUnit T3Payload {
            get {
                return new DataTransferUnit("T3Payload", 0.0000000265731292517, "T3Payload");
            }
        }

        public static DataTransferUnit T3ZPayload {
            get {
                return new DataTransferUnit("T3ZPayload", 0.00000002325148809524, "T3ZPayload");
            }
        }

        public static DataTransferUnit T4Signal {
            get {
                return new DataTransferUnit("T4Signal", 0.000000003647292250233, "T4Signal");
            }
        }

        public static DataTransferUnit VirtualTributary1Signal {
            get {
                return new DataTransferUnit("VirtualTributary1Signal", 0.0000005787037037037, "VirtualTributary1Signal");
            }
        }

        public static DataTransferUnit VirtualTributary1Payload {
            get {
                return new DataTransferUnit("VirtualTributary1Payload", 0.0000006476683937824, "VirtualTributary1Payload");
            }
        }

        public static DataTransferUnit VirtualTributary2Signal {
            get {
                return new DataTransferUnit("VirtualTributary2Signal", 0.0000004340277777778, "VirtualTributary2Signal");
            }
        }

        public static DataTransferUnit VirtualTributary2Payload {
            get {
                return new DataTransferUnit("VirtualTributary2Payload", 0.00000048828125, "VirtualTributary2Payload");
            }
        }

        public static DataTransferUnit VirtualTributary6Paylaod {
            get {
                return new DataTransferUnit("VirtualTributary6Paylaod", 0.0000001666666666667, "VirtualTributary6Paylaod");
            }
        }

        public static DataTransferUnit VirtualTributary6Signal {
            get {
                return new DataTransferUnit("VirtualTributary6Signal", 0.0000001584283903676, "VirtualTributary6Signal");
            }
        }

        public static DataTransferUnit STS1Signal {
            get {
                return new DataTransferUnit("STS1Signal", 0.00000001929012345679, "STS1Signal");
            }
        }

        public static DataTransferUnit STS1Payload {
            get {
                return new DataTransferUnit("STS1Payload", 0.00000002020202020202, "STS1Payload");
            }
        }

        public static DataTransferUnit STS3Signal {
            get {
                return new DataTransferUnit("STS3Signal", 0.000000006430041152263, "STS3Signal");
            }
        }

        public static DataTransferUnit STS3Payload {
            get {
                return new DataTransferUnit("STS3Payload", 0.000000006651766709237, "STS3Payload");
            }
        }

        public static DataTransferUnit STS3cSignal {
            get {
                return new DataTransferUnit("STS3cSignal", 0.000000006430041152263, "STS3cSignal");
            }
        }

        public static DataTransferUnit STS3cPayload {
            get {
                return new DataTransferUnit("STS3cPayload", 0.000000006651766709237, "STS3cPayload");
            }
        }

        public static DataTransferUnit STS12Signal {
            get {
                return new DataTransferUnit("STS12Signal", 0.000000001607510288066, "STS12Signal");
            }
        }

        public static DataTransferUnit STS24Signal {
            get {
                return new DataTransferUnit("STS24Signal", 0.0000000008037551440329, "STS24Signal");
            }
        }

        public static DataTransferUnit STS48Signal {
            get {
                return new DataTransferUnit("STS48Signal", 0.0000000004018775720165, "STS48Signal");
            }
        }

        public static DataTransferUnit STS192Signal {
            get {
                return new DataTransferUnit("STS192Signal", 0.0000000001004693930041, "STS192Signal");
            }
        }

        public static DataTransferUnit STM1Signal {
            get {
                return new DataTransferUnit("STM1Signal", 0.000000006430041152263, "STM1Signal");
            }
        }

        public static DataTransferUnit STM4Signal {
            get {
                return new DataTransferUnit("STM4Signal", 0.000000001607510288066, "STM4Signal");
            }
        }

        public static DataTransferUnit STM16Signal {
            get {
                return new DataTransferUnit("STM16Signal", 0.0000000004018775720165, "STM16Signal");
            }
        }

        public static DataTransferUnit STM64Signal {
            get {
                return new DataTransferUnit("STM64Signal", 0.0000000001004693930041, "STM64Signal");
            }
        }

        public static DataTransferUnit USB2pX {
            get {
                return new DataTransferUnit("USB2pX", 0.000000003571428571428, "USB2.X");
            }
        }

        public static DataTransferUnit USB3p0 {
            get {
                return new DataTransferUnit("USB3p0", 0.0000000002, "USB3.0");
            }
        }

        public static DataTransferUnit USB3p1 {
            get {
                return new DataTransferUnit("USB3p1", 0.0000000001, "USB3.1");
            }
        }

        public static DataTransferUnit FireWire800IEEE1394b_2002 {
            get {
                return new DataTransferUnit("FireWire800IEEE1394b_2002", 0.0000000001, "FireWire800");
            }
        }

        public static DataTransferUnit FireWireS1600_S3200IEEE1394_2008 {
            get {
                return new DataTransferUnit("FireWireS1600_S3200IEEE1394_2008", 0.0000000001, "FireWireS1600_S3200");
            }
        }
    }
}
