using GameShardsCore3.Physics.Measurement.UnitsOfMeasurement;
using GameShardsCore3.Physics.Measurement.Measures;
using GameShardsCore3.Physics.Measurement;

namespace GameShardsCore3.Physics {
    public static class PhysicConstants {

        // Acceleration
        public static Acceleration GRAVITY_ACCELERATION => new Acceleration(9.80665, AccelerationUnit.MeterPerSquareSecond);

        // Electric Charge
        public static ElectricCharge ChargeOfProton => new ElectricCharge(1.60217733E-19, ElectricChargeUnit.Coulomb);
        public static ElectricCharge ChargeOfElectron => new ElectricCharge(-1.60217733E-19, ElectricChargeUnit.Coulomb);

        // Mass
        public static Mass MassOfElectron => new Mass(9.1093897E-31, MassUnit.Kilogram);
        public static Mass MassOfProton => new Mass(1.6726231E-27, MassUnit.Kilogram);
        public static Mass MassOfNeutron => new Mass(1.67749286E-27, MassUnit.Kilogram);
        public static Mass AtomicMassUnit => new Mass(1.6605402E-27, MassUnit.Kilogram);

        // Pressure
        public static Pressure StandardAtmosphere => new Pressure(101325, PressureUnit.Pascal);

        // Pure numbers
        public static double AvogadrosNumber = 6.0221E+23;
        public static double ElementaryChargesInACoulomb = 6.25E+18;

        // Speeds
        public static Speed SpeedOfLight => new Speed(299792458, SpeedUnit.MeterPerSecond);
        public static Speed SpeedOfSoundInAir => new Speed(343, SpeedUnit.MeterPerSecond);
    }
}
