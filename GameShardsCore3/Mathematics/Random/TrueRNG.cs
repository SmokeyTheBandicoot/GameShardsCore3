using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using static GameShardsCore3.Core.LibLanguage.LibLanguageManager;

namespace GameShardsCore3.Mathematics.Random {

    /// <summary>
    /// Uses System.Security.Cryptography RNG to generate true random numbers and uses them with different distributions
    /// </summary>
    public sealed class TrueRNG {

        static RNGCryptoServiceProvider RNG = new RNGCryptoServiceProvider();

        /// <summary>
        /// Generates a random number in a Normal Distribution
        /// </summary>
        /// <param name="Mean">Mean of the Normal distribution</param>
        /// <param name="StdDev">Standard Deviation of the distribution (square root of variation)</param>
        /// <returns></returns>
        public static double RandomNormal(double Mean, double StdDev) {

            double u1 = 1.0 - RandomContinuousStandardUniform(); //uniform(0,1] random doubles
            double u2 = 1.0 - RandomContinuousStandardUniform();

            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                         Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            return Mean + StdDev * StdDev * randStdNormal; //random normal(mean,stdDev^2)
        }

        /// <summary>
        /// Generates a random number between 0.0 and 1.0 (included) in a uniform distribution
        /// </summary>
        /// <returns></returns>
        public static double RandomContinuousStandardUniform() {
            byte[] b = BitConverter.GetBytes(0.0);
            RNG.GetBytes(b);
            double d = BitConverter.ToDouble(b, 0);
            return d - Math.Truncate(d);
        }

        /// <summary>
        /// Generates a random number from a continuous uniform distribution, between min and max (included)
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static double RandomContinuousUniform(double min, double max) {
            if (max < min) throw new ArgumentException(LangManager.GetString("exception_argument_max_less_than_min", CurrentCulture));
            if (max == min) return min;
            return RandomContinuousStandardUniform() * (max - min) + min;
        }

        /// <summary>
        /// Generates a uniform discrete random number between min and max (included)
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static long RandomDiscreteUniform(long min, long max) {
            if (max < min) throw new ArgumentException(LangManager.GetString("exception_argument_max_less_than_min", CurrentCulture));
            byte[] b = BitConverter.GetBytes(min);
            long rand = 0;
            do {
                RNG.GetBytes(b);
                rand = BitConverter.ToInt64(b, 0);
            } while (!IsFairValue(rand, max - min));
            return rand;
        }

        //Indicates if there are just X spans in Long.MaxValue. for example, the span for a dice is 6 (sides 1 to 6).
        //If the Long.MaxValue mod 6 is 0, then the value is always fair. if not, some sides have less chance than the others.
        //For example in a byte (255) there are 42 dice spans (6) because 42 * 6 = 252, so byte values from 0 to 251.
        //the last span (252 to 255, which are sides 3,4,5 and 6, have less chance than the other sides to occur.
        //So if the byte value (value) is < 252 (42 * 6) then, the roll is fair, otherwise it's not.
        //Here concept is the same, except it is made for long, which greatly reduces chances of unfair rolls, especially
        //with small spans.
        private static bool IsFairValue(long value, long span) {
            return value < (long.MaxValue / span) * span;
        }
         
    }

}
