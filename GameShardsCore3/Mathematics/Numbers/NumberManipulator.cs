using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Attributes;
using GameShardsCore3.ExtensionMethods.Arrays;
using GameShardsCore3.StringManipulation;
using GameShardsCore3.StringManipulation.DigitShortener;
using static GameShardsCore3.Core.LibLanguage.LibLanguageManager;


namespace GameShardsCore3.Mathematics.Numbers {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 1, 0)]
    public static class NumberManipulator {

        /// <summary>
        /// Shortens a number into it's exponential form. For example 1024 --> 1.024E3
        /// </summary>
        /// <param name="Num">Number to convert</param>
        /// <param name="Mantissa">Reference parameter to get the resulting mantissa</param>
        /// <param name="Exponent">Reference parameter to get the resulting exponent</param>
        /// <param name="Decimals">Number of decimals</param>
        /// <param name="ExponentialTreeshold">Treeshold after which the number should be shortened to exp notation. For example if treeshold is 5678, then 5677 is left as it is, 5678 will be shortened in 5.678E3</param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        [Version(1, 0, 0, 'b')]
        public static string ToExpNotation(double Num, ref double Mantissa, ref int Exponent, ushort Decimals = 1, uint ExponentialTreeshold = 1000, DigitShortener.ExponentialMode Mode = DigitShortener.ExponentialMode.OneToTen) {

            Exponent = 0;
            if (Num < ExponentialTreeshold) return Num.ToString();

            //Mode: OneToTen
            if (Mode == DigitShortener.ExponentialMode.OneToTen) {
                if (ExponentialTreeshold < 1) throw new ArgumentException(LangManager.GetString("exception_treeshold_not_valid_mode", CurrentCulture));

                while (Math.Abs(Num) >= 10) {
                    Num /= 10;
                    Exponent++;
                }

                while (Math.Abs(Num) <= 1) {
                    Num *= 10;
                    Exponent--;
                }

                //Mode: ZeroToOne
            } else {

                while (Math.Abs(Num) >= 1) {
                    Num /= 10;
                    Exponent++;
                }

                while (Math.Abs(Num) < 0.1) {
                    Num *= 10;
                    Exponent--;
                }
            }

            Mantissa = Math.Round(Num, (int)Decimals);
            return Mantissa.ToString() + "E" + Exponent.ToString();

        }

        /// <summary>
        /// Returns all the perfect numbers which are less then Double.MaxValue()
        /// </summary>
        public static readonly double[] PerfectNumbersInDouble = { 6, 28, 496, 8128, 33550336, 8589869056, 137438691328, 2305843008139952128 };

        /// <summary>
        /// Splits a real number into its integer part and decimal part
        /// </summary>
        /// <param name="number">number to split</param>
        /// <param name="decimals">result passed by reference</param>
        /// <returns></returns>
        public static double SplitIntegerDecimals(double number, ref double decimals) {
            double integer = Math.Truncate(number);
            decimals = number - integer;
            return integer;
        }

        /// <summary>
        /// Executes a division and returns both quotient and remainder
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <param name="remainder"></param>
        /// <returns></returns>
        public static double SplitQuotientRemainder(double dividend, double divisor, ref double remainder) {
            remainder = dividend % divisor;
            return Math.Truncate(dividend / divisor);
        }

        /// <summary>
        /// Returns true if the number is prime
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime(long n) {
            for (int x = 2; x < (long)(Math.Sqrt(n) + 1); x++)
                if (n % x == 0) return false;
            return true;
        }

        /// <summary>
        /// Actually, since there are less than 50 perfect numbers with less than 25 million digits, 
        /// then it's actually faster(to code and in regards to this function's performance) to give a 
        /// list of perfect numbers representable in a double variable
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool IsPerfect(double d) {
            return PerfectNumbersInDouble.Contains(d);
        }

        /// <summary>
        /// Returns true if the number is palindrome
        /// </summary>
        /// <example>
        /// 121 IS palindrome
        /// 5665 IS palindrome
        /// 10,01 IS palindrome
        /// 121,3 IS NOT palindrome
        /// </example>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool IsPalindrome(double d) {
            return StringManipulator.IsPalindrome(d.ToString());
        }

        /// <summary>
        /// Returns the element which has the most occurrences in a collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="occurrences"></param>
        /// <returns></returns>
        public static T Majority<T>(IEnumerable<T> collection, ref int occurrences) {
            if (collection.Count() == 0) {
                occurrences = 0;
                return default(T);
            }

            Dictionary<T, int> val = new Dictionary<T, int>();
            T Majority = default(T);
            foreach (T elem in collection) {
                val[elem]++;
                if (occurrences < val[elem]) {
                    occurrences = val[elem];
                    Majority = elem;
                }
            }

            return Majority;
        }

        /// <summary>
        /// Returns the element which has the least occurrences in a collection which contains it at
        /// least once. Also returns how many times it occurs in the collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="occurrences"></param>
        /// <returns></returns>
        public static T Minority<T>(IEnumerable<T> collection, ref int occurrences) {
            if (collection.Count() == 0) {
                occurrences = 0;
                return default(T);
            }

            Dictionary<T, int> val = new Dictionary<T, int>();
            T Minority = default(T);

            foreach (T elem in collection) {
                val[elem]++;
            }

            foreach (T elem in val.Keys) {
                if (val[elem] < occurrences) {
                    occurrences = val[elem];
                    Minority = elem;
                }
            }

            return Minority;

        }

        /// <summary>
        /// Returns the max common divisor between two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static long MaxCommonDivisor(long a, long b) {
            if (a < b) return MaxCommonDivisor(b, a);
            if (a % b == 0) return a;
            else return MaxCommonDivisor(b, a % b);
        }

        /// <summary>
        /// Returns the max common divisor in an array of numbers
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static long MaxCommonDivisor(long[] arr) {
            if (arr.Length == 2) return MaxCommonDivisor(arr[0], arr[1]);
            return MaxCommonDivisor(MaxCommonDivisor(arr.RemoveAt(arr.Length - 1)), arr[arr.Length - 1]);
        }




    }

}
