using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.Attributes;

    namespace GameShardsCore3.StringManipulation.Alphabet {

    public abstract class Alphabet {

        internal string _name;

        public string name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        public override string ToString() {
            return base.ToString() + "; Name: " + _name;
        }

        /// <summary>
        /// 0 and 1
        /// </summary>
        public static CharAlphabet Binary {
            get {
                char[] c = { '0', '1' };
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// Adenine, Cytosine, Guanine, Thymine
        /// </summary>
        public static CharAlphabet DNA {
            get {
                char[] c = { 'A', 'C', 'G', 'T' };
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// Adenine, Cytosine, Guanine, Uracil
        /// </summary>
        public static CharAlphabet RNA {
            get {
                char[] c = { 'A', 'C', 'G', 'U' };
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// Adenine, Cytosine, Guanine, Thymine, Uracil
        /// </summary>
        public static CharAlphabet DNA_RNA {
            get {
                char[] c = { 'A', 'C', 'G', 'T', 'U' };
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// 0 to 7
        /// </summary>
        public static CharAlphabet Octal {
            get {
                char[] c = { '0', '1', '2', '3', '4', '5', '6', '7' };
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// 0 to 9
        /// </summary>
        public static CharAlphabet Numerical {
            get {
                char[] c = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// 0 to F
        /// </summary>
        public static CharAlphabet Hexadecimal {
            get {
                char[] c = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// Roman numbers
        /// </summary>
        public static CharAlphabet Roman {
            get {
                char[] c = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// Upper and lower case roman numbers (lower case for 1..1000, upper case for 1000...1000000)
        /// </summary>
        public static CharAlphabet RomanExtended {
            get {
                char[] c = { 'i', 'v', 'x', 'l', 'c', 'd', 'm', 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// Chars that cannot be used in Windows path names
        /// </summary>
        public static CharAlphabet ReserverChars {
            get {
                char[] c = { '<', '>', ':', '"', '/', '\\', '|', '?', '*' };
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// Alphabets
        /// </summary>
        public static CharAlphabet Alpha {
            get {
                char[] c = { 'A', 'B', 'C', 'D', 'D', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
                return new CharAlphabet(c);
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
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// yocto, zepto, atto, femto, pico, nano, micro, milli, none, kilo, Mega, Giga, Tera, Peta, Exa, Zetta, Yotta
        /// </summary>
        public static CharAlphabet SIMagnitudePrefixes {
            get {
                char[] c = {'y', 'z', 'a', 'f', 'p', 'n', 'µ', 'm', ' ', 'k', 'M', 'G', 'T', 'P', 'E', 'Z', 'Y'};
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// thousand, million, milliard, billion, billiard, trillion, trilliard, quadrillion, quadrilliard
        /// </summary>
        public static CharAlphabet EuropeanMagnitudePrefixes {
            get {
                char[] c = {'k', 'm', 'M', 'b', 'B', 't', 'T', 'q', 'Q'};
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// Thousand, Million, Billion, Trillion, quadrillion, Quintillion, sestillion, Septillion
        /// </summary>
        public static CharAlphabet EnglishMagnitudePrefixes {
            get {
                char[] c = { 'k', 'M', 'B', 'T', 'q', 'Q', 's', 'S'};
                return new CharAlphabet(c);
            }
        }

        /// <summary>
        /// Greek letters
        /// </summary>
        public static CharAlphabet GreekLettersLower {
            get {
                char[] c = { 'α', 'β', 'γ', 'δ', 'ε', 'ζ', 'η', 'θ', 'ι', 'κ', 'λ', 'μ', 'ν', 'ξ', 'ο', 'π', 'ρ', 'σ', 'τ', 'υ', 'φ', 'χ', 'ψ', 'ω', 'ς' };
                return new CharAlphabet(c);
            }
            /*Public Shared ReadOnly Property CapitalGreekAlphabet As CharAlphabet
                Get
                    Return New CharAlphabet({ CChar("Α"), CChar("Β"), CChar("Γ"), CChar("Δ"), CChar("Ε"), CChar("Ζ"), CChar("Η"), CChar("Θ"), CChar("Ι"), CChar("Κ"), CChar("Λ"), CChar("Μ"), CChar("Ν"), CChar("Ξ"), CChar("Ο"), CChar("Π"), CChar("Ρ"), CChar("Σ"), CChar("Τ"), CChar("Υ"), CChar("Φ"), CChar("Χ"), CChar("Ψ"), CChar("Ω")}.ToList)
            */
        }

        [WIP()]
        public static CharAlphabet GreekLettersUpper {
            get {
                char[] c = { };
                return null;
            }
        }
    }
}
