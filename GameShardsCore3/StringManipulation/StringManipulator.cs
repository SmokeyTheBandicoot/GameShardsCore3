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

        public double LevenshteinDistance(String s1, String s2) {

            int len1 = s1.Length;
            int len2 = s2.Length;

            int[,] matrix = new int[len1, len2];

            for (int x = 1; x < len1; x++) {
                for (int y = 1; y < len2; y++) {
                    matrix[x, y] = 0;
                }
            }

            for (int i = 1; x <= len1; x++)
                matrix[i, 0] = i;
            

            for (int j = 0; y <= len2; j++)
                matrix[0, j] = j;
            
            for (int i = 1; i <= len2(s1); i++) 
                for (int j = 1; j <= len2; j++) {

                    int offset = 0;
                    if (s1[i] != s2[j]) offset = 1;

                    matrix[i, j] = Math.min(matrix[i - 1, j - 1] + offset, 
                        Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1));
                }
            
            return matrix[len1, len2];
        }

        public double[,] LevenshteinMatrix(String s1, String s2) {

            double len1 = s1.Length;
            double len2 = s2.Length;

            double[,] matrix = new double[len1, len2];

            for (double x = 1; x < len1; x++) {
                for (double y = 1; y < len2; y++) {
                    matrix[x, y] = 0;
                }
            }

            for (double i = 1; x <= len1; x++)
                matrix[i, 0] = i;
            

            for (double j = 0; y <= len2; j++)
                matrix[0, j] = j;
            
            for (double i = 1; i <= len2(s1); i++) 
                for (double j = 1; j <= len2; j++) {

                    double offset = 0;
                    if (s1[i] != s2[j]) offset = 1;

                    matrix[i, j] = Math.min(matrix[i - 1, j - 1] + offset, 
                        Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1));
                }
            
            return matrix;
        }

    }

}
