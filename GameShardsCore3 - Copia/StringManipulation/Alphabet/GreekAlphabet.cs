using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShardsCore3.StringManipulation.Alphabet;
using GameShardsCore3.Attributes;
using static GameShardsCore3.Core.LibLanguage.LibLanguageManager;

namespace GameShardsCore3.StringManipulation.Alphabet {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 0)]
    public sealed class GreekAlphabet : Alphabet{

        public static char Alpha(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[0];
            else return GreekAphabet.Chars[0];
        }

        public static char Beta(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[1];
            else return GreekAphabet.Chars[1];
        }

        public static char Gamma(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[2];
            else return GreekAphabet.Chars[2];
        }

        public static char Delta(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[3];
            else return GreekAphabet.Chars[3];
        }

        public static char Epsilon(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[4];
            else return GreekAphabet.Chars[4];
        }

        public static char Zeta(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[5];
            else return GreekAphabet.Chars[5];
        }

        public static char Eta(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[6];
            else return GreekAphabet.Chars[6];
        }

        public static char Theta(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[7];
            else return GreekAphabet.Chars[7];
        }

        public static char Iota(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[8];
            else return GreekAphabet.Chars[8];
        }

        public static char Kappa(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[9];
            else return GreekAphabet.Chars[9];
        }

        public static char Lambda(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[10];
            else return GreekAphabet.Chars[10];
        }

        public static char Mu(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[11];
            else return GreekAphabet.Chars[11];
        }

        public static char Nu(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[12];
            else return GreekAphabet.Chars[12];
        }

        public static char Xi(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[13];
            else return GreekAphabet.Chars[13];
        }

        public static char Omicron(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[14];
            else return GreekAphabet.Chars[14];
        }

        public static char Pi(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[15];
            else return GreekAphabet.Chars[15];
        }
        
        public static char Rho(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[16];
            else return GreekAphabet.Chars[16];
        }

        public static char Sigma(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[17];
            else return GreekAphabet.Chars[17];
        }

        public static char Tau(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[18];
            else return GreekAphabet.Chars[18];
        }

        public static char Upsilon(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[19];
            else return GreekAphabet.Chars[19];
        }

        public static char Phi(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[20];
            else return GreekAphabet.Chars[20];
        }

        public static char Chi(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[21];
            else return GreekAphabet.Chars[21];
        }

        public static char Psi(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[22];
            else return GreekAphabet.Chars[22];
        }

        public static char Omega(bool capital = false) {
            if (capital) return GreekAlphabetCapitals.Chars[23];
            else return GreekAphabet.Chars[23];
        }

        /// <summary>
        /// Returns the char of the corresponding letter, using it's full name or letter.
        /// Valid values: A, ALPHA, B, BETA, C, GAMMA, D, DELTA, E, EPSILON, Z, ZETA,
        /// H, ETA, TH, THETA, I, IOTA, K, KAPPA, L, LAMBDA, M, MU, MI, N, NU, NI, KS, XI,
        /// O, OMICRON, P, PI, R, RHO, S, SIGMA, T, TAU, Y, UPSILON, F, PHI, X, CHI, Y, PSI, W, OMEGA
        /// Case unsensitive
        /// </summary>
        /// <param name="LetterName"></param>
        /// <returns></returns>
        public static char GetCharFromName(string LetterName) {
            switch (LetterName.ToUpper()) {
                case string n when n.Equals("A") || n.Equals("ALPHA"):
                    return Alpha(false);
                case string n when n.Equals("B") || n.Equals("BETA"):
                    return Beta(false);
                case string n when n.Equals("C") || n.Equals("GAMMA"):
                    return Alpha(false);
                case string n when n.Equals("D") || n.Equals("DELTA"):
                    return Delta(false);
                case string n when n.Equals("E") || n.Equals("EPSILON"):
                    return Epsilon(false);
                case string n when n.Equals("Z") || n.Equals("ZETA"):
                    return Zeta(false);
                case string n when n.Equals("H") || n.Equals("ETA"):
                    return Eta(false);
                case string n when n.Equals("TH") || n.Equals("THETA"):
                    return Theta(false);
                case string n when n.Equals("I") || n.Equals("IOTA"):
                    return Iota(false);
                case string n when n.Equals("K") || n.Equals("KAPPA"):
                    return Kappa(false);
                case string n when n.Equals("L") || n.Equals("LAMBDA"):
                    return Lambda(false);
                case string n when n.Equals("M") || n.Equals("MU") || n.Equals("MI"):
                    return Mu(false);
                case string n when n.Equals("N") || n.Equals("Nu") || n.Equals("NI"):
                    return Nu(false);
                case string n when n.Equals("KS") || n.Equals("XI"):
                    return Xi(false);
                case string n when n.Equals("O") || n.Equals("OMICRON"):
                    return Omicron(false);
                case string n when n.Equals("P") || n.Equals("PI"):
                    return Pi(false);
                case string n when n.Equals("R") || n.Equals("RHO"):
                    return Rho(false);
                case string n when n.Equals("S") || n.Equals("SIGMA"):
                    return Sigma(false);
                case string n when n.Equals("T") || n.Equals("TAU"):
                    return Tau(false);
                case string n when n.Equals("F") || n.Equals("PHI"):
                    return Phi(false);
                case string n when n.Equals("X") || n.Equals("CHI"):
                    return Chi(false);
                case string n when n.Equals("Y") || n.Equals("UPSILON"):
                    return Upsilon(false);
                case string n when n.Equals("W") || n.Equals("OMEGA"):
                    return Omega(false);
                default:
                    throw new ArgumentException(LangManager.GetString("exception_char_not_recognized", CurrentCulture));
            }
        }

    }
}
