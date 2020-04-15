using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Attributes;
using GameShardsCore3.ExtensionMethods.Arrays;

namespace GameShardsCore3.StringManipulation.Alphabet {

    /// <summary>
    /// Class which represents a set of symbols
    /// </summary>
    public class Alphabet : IEnumerable<string> {

        public string Name { get; set; }

        public string[] Chars;

        public Alphabet(string Name, string[] Chars = null) {
            if (Chars == null) this.Chars = new string[] { };
            this.Name = Name;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder(" Symbols: ");
            foreach (string c in this.Chars)
                sb.Append(c).Append("; ");
            return base.ToString() + "; Name: " + Name + sb.ToString(); ;
        }

        public void AddSymbol(string symbol) {
            Chars.Append(symbol);
        }

        /// <summary>
        /// Removes a symbol from the alphabet and returns it.
        /// Returns null if the symbol has not been found
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public string RemoveSymbol(string symbol) {
            if (!Chars.Contains(symbol))
                throw new ArgumentException("The alphabet does not contain such symbol");
            int index = Chars.IndexOf(symbol);
            if (index != -1) {
                Chars.RemoveAt(index);
                return symbol;
            }
            return null;
        }

        public void ConcatenateAlphabet(Alphabet other) {
            Chars.AddRange(other.Chars);
            
        }

        public IEnumerator<string> GetEnumerator() {
            foreach (string s in Chars)
                yield return s;
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return Chars.GetEnumerator();
        }

        /// <summary>
        /// 0 and 1
        /// </summary>
        public static CharAlphabet Binary {
            get {
                char[] c = { '0', '1' };
                return new CharAlphabet("Binary", c);
            }
        }

        /// <summary>
        /// Adenine, Cytosine, Guanine, Thymine
        /// </summary>
        public static CharAlphabet DNA {
            get {
                char[] c = { 'A', 'C', 'G', 'T' };
                return new CharAlphabet("DNA", c);
            }
        }

        /// <summary>
        /// Adenine, Cytosine, Guanine, Uracil
        /// </summary>
        public static CharAlphabet RNA {
            get {
                char[] c = { 'A', 'C', 'G', 'U' };
                return new CharAlphabet("RNA", c);
            }
        }

        /// <summary>
        /// Adenine, Cytosine, Guanine, Thymine, Uracil
        /// </summary>
        public static CharAlphabet DNA_RNA {
            get {
                char[] c = { 'A', 'C', 'G', 'T', 'U' };
                return new CharAlphabet("DNA & RNA", c);
            }
        }

        /// <summary>
        /// 0 to 7
        /// </summary>
        public static CharAlphabet Octal {
            get {
                char[] c = { '0', '1', '2', '3', '4', '5', '6', '7' };
                return new CharAlphabet("Octal", c);
            }
        }

        /// <summary>
        /// 0 to 9
        /// </summary>
        public static CharAlphabet Numerical {
            get {
                char[] c = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                return new CharAlphabet("Numbers", c);
            }
        }

        /// <summary>
        /// 0 to F
        /// </summary>
        public static CharAlphabet Hexadecimal {
            get {
                char[] c = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
                return new CharAlphabet("Hexadecimal", c);
            }
        }

        /// <summary>
        /// Roman numbers
        /// </summary>
        public static CharAlphabet Roman {
            get {
                char[] c = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
                return new CharAlphabet("Roman", c);
            }
        }

        /// <summary>
        /// Upper and lower case roman numbers (lower case for 1..1000, upper case for 1000...1000000)
        /// </summary>
        public static CharAlphabet RomanExtended {
            get {
                char[] c = { 'i', 'v', 'x', 'l', 'c', 'd', 'm', 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
                return new CharAlphabet("Roman Extended", c);
            }
        }

        /// <summary>
        /// Chars that cannot be used in Windows path names
        /// </summary>
        public static CharAlphabet WindowsReserverChars {
            get {
                char[] c = { '<', '>', ':', '"', '/', '\\', '|', '?', '*' };
                return new CharAlphabet("Windows Reserved Chars", c);
            }
        }

        /// <summary>
        /// Alphabets
        /// </summary>
        public static CharAlphabet Alphabetical {
            get {
                char[] c = { 'A', 'B', 'C', 'D', 'D', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
                return new CharAlphabet("Alphabetical", c);
            }
        }

        /// <summary>
        /// Alphabet (Upper case) and numbers
        /// </summary>
        public static CharAlphabet AlphaNumeric {
            get {
                char[] c = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                    'A', 'B', 'C', 'D', 'D', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
                return new CharAlphabet("Alphanumeric", c);
            }
        }

        /// <summary>
        /// yocto, zepto, atto, femto, pico, nano, micro, milli, none, kilo, Mega, Giga, Tera, Peta, Exa, Zetta, Yotta
        /// </summary>
        public static CharAlphabet SIMagnitudePrefixes {
            get {
                char[] c = {'y', 'z', 'a', 'f', 'p', 'n', 'µ', 'm', ' ', 'k', 'M', 'G', 'T', 'P', 'E', 'Z', 'Y'};
                return new CharAlphabet("International System Magnitude Prefixes", c);
            }
        }

        /// <summary>
        /// thousand, million, milliard, billion, billiard, trillion, trilliard, quadrillion, quadrilliard
        /// </summary>
        public static CharAlphabet EuropeanMagnitudePrefixes {
            get {
                char[] c = {'k', 'm', 'M', 'b', 'B', 't', 'T', 'q', 'Q'};
                return new CharAlphabet("European Magnitude Prefixes", c);
            }
        }

        /// <summary>
        /// Thousand, Million, Billion, Trillion, quadrillion, Quintillion, sestillion, Septillion
        /// </summary>
        public static CharAlphabet USMagnitudePrefixes {
            get {
                char[] c = { 'k', 'M', 'B', 'T', 'q', 'Q', 's', 'S'};
                return new CharAlphabet("US Magnitude Prefixes", c);
            }
        }

        /// <summary>
        /// Greek letters
        /// </summary>
        public static CharAlphabet GreekAphabet {
            get {
                char[] c = { 'α', 'β', 'γ', 'δ', 'ε', 'ζ', 'η', 'θ', 'ι', 'κ', 'λ', 'μ', 'ν', 'ξ', 'ο', 'π', 'ρ', 'σ', 'τ', 'υ', 'φ', 'χ', 'ψ', 'ω', 'ς' };
                return new CharAlphabet("Greek lower case", c);
            }
        }

        [WIP()]
        public static CharAlphabet GreekAlphabetCapitals {
            get {
                char[] c = {'Α', 'Β', 'Γ', 'Δ', 'Ε', 'Ζ', 'Η', 'Θ', 'Ι', 'Κ', 'Λ', 'Μ', 'Ν', 'Ξ', 'Ο', 'Π', 'Ρ', 'Σ', 'Τ', 'Υ', 'Φ', 'Χ', 'Ψ', 'Ω'};
                return new CharAlphabet("Greek upper case", c);
            }
        }
    }
}
