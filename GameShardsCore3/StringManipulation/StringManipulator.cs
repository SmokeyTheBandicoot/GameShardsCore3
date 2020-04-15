using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.StringManipulation {

    public static class StringManipulator {

        /// <summary>
        /// Returns if the string is palindrome
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string str) {
            for (int i = 0; i < (str.Length + str.Length % 2) / 2; i++) {
                if (str[i] != str[str.Length - i]) return false;
            } return true;
        }

        /// <summary>
        /// Reverses a string returning another string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Reverse(string str) {
            string res = "";
            for (int x = str.Length - 1; x >= 0; x--) {
                res += str[x];
            }
            return res;
        }

        /// <summary>
        /// Returns bigger number the more different the strings are
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static double LevenshteinDistance(String s1, String s2) {

            int len1 = s1.Length;
            int len2 = s2.Length;

            int[,] matrix = new int[len1, len2];

            for (int x = 1; x < len1; x++) {
                for (int y = 1; y < len2; y++) {
                    matrix[x, y] = 0;
                }
            }

            for (int i = 1; i <= len1; i++)
                matrix[i, 0] = i;
            

            for (int j = 0; j <= len2; j++)
                matrix[0, j] = j;
            
            for (int i = 1; i <= len2; i++) 
                for (int j = 1; j <= len2; j++) {

                    int offset = 0;
                    if (s1[i] != s2[j]) offset = 1;

                    matrix[i, j] = Math.Min(matrix[i - 1, j - 1] + offset, 
                        Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1));
                }
            
            return matrix[len1, len2];
        }

        /// <summary>
        /// Returns the matrix for Lvenshtein distance
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static double[,] LevenshteinMatrix(String s1, String s2) {

            double len1 = s1.Length;
            double len2 = s2.Length;

            double[,] matrix = new double[(int)len1, (int)len2];

            for (double x = 1; x < len1; x++) {
                for (double y = 1; y < len2; y++) {
                    matrix[(int)x, (int)y] = 0;
                }
            }

            for (double i = 1; i <= len1; i++)
                matrix[(int)i, 0] = i;
            

            for (double j = 0; j <= len2; j++)
                matrix[0, (int)j] = j;
            
            for (double i = 1; i <= len2; i++) 
                for (double j = 1; j <= len2; j++) {

                    double offset = 0;
                    if (s1[(int)i] != s2[(int)j]) offset = 1;

                    matrix[(int)i, (int)j] = Math.Min(matrix[(int)i - 1, (int)j - 1] + offset, 
                        Math.Min(matrix[(int)i - 1, (int)j] + 1, matrix[(int)i, (int)j - 1] + 1));
                }
            
            return matrix;
        }

        public static string GetSmallestFollowingSubstring(string expression, string start, string end, ref bool foundEnd, bool allowOverlap = true, bool includeExtremes = true, bool endOfStringAsEnd = false) {

            bool startFound = false;
            foundEnd = false;

            // Length checks
            if (allowOverlap)
                if (expression.Length < start.Length) return null;
                if (expression.Length < end.Length) return null;
            else
                if (expression.Length < start.Length + end.Length) return null;

            for (int x = 0; x <= expression.Length - start.Length; x++) {

                if (expression.Substring(x, start.Length).Equals(start)) {
                    startFound = true;
                }

                if (startFound)
                    // Here x is where the start has been found
                    if (allowOverlap) {

                        // To solve the problem when end.Length is less than start.Length
                        int shift = 0;
                        shift = start.Length - end.Length;
                        if (shift < 0) shift = 0;

                        for (int y = x + shift; y <= expression.Length - (end.Length - 1); y++) {
                            if (expression.Substring(y, end.Length).Equals(end)) {
                                // Here end has been found. Return the substring
                                foundEnd = true;
                                return expression.Substring(x, y - x + 1);
                            }
                        }
                    } else {

                        // If overlap is not allowed, then there is no problem since the shift is always start.Length

                        for (int y = x + start.Length; y <= expression.Length - end.Length; y++) {
                            if (expression.Substring(y, end.Length).Equals(end)) {
                                foundEnd = true;
                                return expression.Substring(x, y - x + 1);
                            }
                        }
                    }
            }

            return null;

        }
        
        /*
        public static Dictionary<(int, int), string> GetSubstrings(string expression, string start, string end, bool allowOverlap = true) {

        }*/
    }

}
